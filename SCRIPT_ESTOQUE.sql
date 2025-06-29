CREATE DATABASE IF NOT EXISTS Estoque;
USE Estoque;

CREATE TABLE IF NOT EXISTS mercadorias (
    ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Quantidade int(30) NOT NULL,
    Itens_caixa int NOT NULL,
    estoque_minimo int NOT NULL,
    estoque_maximo int NOT NULL,
    Volumes float(6,2) NOT NULL,
    Peso_liquido float(6,2) NOT NULL,
    Peso_bruto float(6,2) NOT NULL,
    Largura float(6,2) NOT NULL,
    Altura float(6,2) NOT NULL,
    Profundidade float(6,2) NOT NULL,
    Preco_venda float(6,2) NOT NULL,
    codigo varchar(30) NOT NULL,
    Formato varchar(30) NOT NULL,
    Condicao varchar(30) NOT NULL,
    Tipo varchar(30) NOT NULL,
    Situacao varchar(30) NOT NULL,
    Marca varchar(50) NOT NULL,
    Producao varchar(30) NOT NULL,
    Data_validade varchar(30) NOT NULL,
    Frete_gratis varchar(10) NOT NULL,
    Unidade_Medida varchar(30) NOT NULL,
    Variacao_Atributo varchar(30) NOT NULL,
    Variacao_Opcao varchar(30) NOT NULL,
    GTIN varchar(30) NOT NULL,
    Departamento varchar(30) NOT NULL,
    Crossdocking varchar(30) NOT NULL,
    Localizacao varchar(30) NOT NULL,
    UNIQUE KEY unique_codigo (codigo)
) DEFAULT CHARSET=utf8;

create table funcionarios (
	Codigo_ID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	Nome varchar (50) NOT NULL,
	login varchar (50) NOT NULL,
	Senha varchar (10) NOT NULL
) default charset = utf8;
select * from mercadorias;

CREATE TABLE IF NOT EXISTS estoque (
    codigo_mercadoria INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    quantidade_atual INT NOT NULL DEFAULT 0,
    data_ultima_atualizacao DATETIME NOT NULL,
    FOREIGN KEY (codigo_mercadoria) REFERENCES mercadorias(Id)
) DEFAULT CHARSET = utf8;


CREATE TABLE IF NOT EXISTS movimentos_estoque (
    id_movimento INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    codigo_mercadoria VARCHAR(30) NOT NULL,
    tipo_movimento ENUM('ENTRADA', 'SAIDA') NOT NULL,
    quantidade INT(10) NOT NULL, 
    preco_unitario_movimento DECIMAL(8, 2) NOT NULL,
    data_hora_movimento DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    observacoes VARCHAR(255),
    FOREIGN KEY (codigo_mercadoria) REFERENCES mercadorias(codigo)
) DEFAULT CHARSET = utf8;

DELIMITER $$

CREATE TRIGGER after_insert_movimento_estoque
AFTER INSERT ON movimentos_estoque
FOR EACH ROW
BEGIN
 
    IF NOT EXISTS (SELECT 1 FROM estoque WHERE codigo_mercadoria = NEW.codigo_mercadoria) 
    THEN
   
        INSERT INTO estoque (codigo_mercadoria, quantidade_atual, data_ultima_atualizacao)
        VALUES (NEW.codigo_mercadoria, 0, NOW()); 
    END IF;

  
    IF NEW.tipo_movimento = 'ENTRADA' THEN
        UPDATE estoque
        SET
            quantidade_atual = quantidade_atual + NEW.quantidade,
            data_ultima_atualizacao = NOW()
        WHERE
            codigo_mercadoria = NEW.codigo_mercadoria;
		ELSEIF NEW.tipo_movimento = 'SAIDA' THEN
      
        IF (SELECT quantidade_atual FROM estoque WHERE codigo_mercadoria = NEW.codigo_mercadoria) >= NEW.quantidade THEN
            UPDATE estoque
            SET
                quantidade_atual = quantidade_atual - NEW.quantidade,
                data_ultima_atualizacao = NOW()
            WHERE
                codigo_mercadoria = NEW.codigo_mercadoria;
        ELSE
            
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Erro: Quantidade de saída excede o estoque disponível!';
			END IF;
			END IF;
END$$

DELIMITER ;


DELIMITER $$

CREATE TRIGGER after_update_movimento_estoque
AFTER UPDATE ON movimentos_estoque
FOR EACH ROW
BEGIN

IF OLD.tipo_movimento = 'ENTRADA' THEN
UPDATE estoque
	SET
		quantidade_atual = quantidade_atual - OLD.quantidade,
		data_ultima_atualizacao = NOW()
	WHERE
		codigo_mercadoria = OLD.codigo_mercadoria;
    ELSEIF OLD.tipo_movimento = 'SAIDA' THEN
UPDATE estoque
	SET
	   quantidade_atual = quantidade_atual + OLD.quantidade,
	   data_ultima_atualizacao = NOW()
	WHERE
            codigo_mercadoria = OLD.codigo_mercadoria;
    END IF;

    
    IF NEW.tipo_movimento = 'ENTRADA' THEN
UPDATE estoque
	SET
		quantidade_atual = quantidade_atual + NEW.quantidade,
		data_ultima_atualizacao = NOW()
	WHERE
            codigo_mercadoria = NEW.codigo_mercadoria;
    ELSEIF NEW.tipo_movimento = 'SAIDA' THEN
       
        IF (SELECT quantidade_atual FROM estoque WHERE codigo_mercadoria = NEW.codigo_mercadoria) >= NEW.quantidade THEN
            UPDATE estoque
	SET
                quantidade_atual = quantidade_atual - NEW.quantidade,
                data_ultima_atualizacao = NOW()
WHERE
                codigo_mercadoria = NEW.codigo_mercadoria;
        ELSE
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Erro: Nova quantidade de saída excede o estoque disponível!';
        END IF;
		END IF;
END$$

DELIMITER ;


DELIMITER $$

CREATE TRIGGER after_delete_movimento_estoque
AFTER DELETE ON movimentos_estoque
FOR EACH ROW
BEGIN
   
IF OLD.tipo_movimento = 'ENTRADA' THEN
        UPDATE estoque
SET
		quantidade_atual = quantidade_atual - OLD.quantidade,
		data_ultima_atualizacao = NOW()
WHERE
		codigo_mercadoria = OLD.codigo_mercadoria;
    ELSEIF OLD.tipo_movimento = 'SAIDA' THEN
        UPDATE estoque
SET
		quantidade_atual = quantidade_atual + OLD.quantidade,
		data_ultima_atualizacao = NOW()
WHERE
            codigo_mercadoria = OLD.codigo_mercadoria;
    END IF;
END$$

DELIMITER ;
CREATE OR REPLACE VIEW view_curva_abc AS
SELECT 
    v1.codigo_mercadoria,
    m.Marca,
    m.Tipo,
    ROUND(v1.valor_total, 2) AS valor_total,
    ROUND((v1.valor_total / v2.total_geral) * 100, 2) AS percentual,
    ROUND((
        SELECT SUM(v3.valor_total) / v2.total_geral * 100
        FROM (
            SELECT me.codigo_mercadoria, SUM(me.quantidade * me.preco_unitario_movimento) AS valor_total
            FROM movimentos_estoque me
            WHERE me.tipo_movimento = 'SAIDA'
            GROUP BY me.codigo_mercadoria
        ) v3
        WHERE v3.valor_total >= v1.valor_total
    ), 2) AS percentual_acumulado,
    CASE
        WHEN (
            SELECT SUM(v3.valor_total) / v2.total_geral * 100
            FROM (
                SELECT me.codigo_mercadoria, SUM(me.quantidade * me.preco_unitario_movimento) AS valor_total
                FROM movimentos_estoque me
                WHERE me.tipo_movimento = 'SAIDA'
                GROUP BY me.codigo_mercadoria
            ) v3
            WHERE v3.valor_total >= v1.valor_total
        ) <= 70 THEN 'A'
        WHEN (
            SELECT SUM(v3.valor_total) / v2.total_geral * 100
            FROM (
                SELECT me.codigo_mercadoria, SUM(me.quantidade * me.preco_unitario_movimento) AS valor_total
                FROM movimentos_estoque me
                WHERE me.tipo_movimento = 'SAIDA'
                GROUP BY me.codigo_mercadoria
            ) v3
            WHERE v3.valor_total >= v1.valor_total
        ) <= 90 THEN 'B'
        ELSE 'C'
    END AS classificacao_ABC
FROM (
    SELECT me.codigo_mercadoria, SUM(me.quantidade * me.preco_unitario_movimento) AS valor_total
    FROM movimentos_estoque me
    WHERE me.tipo_movimento = 'SAIDA'
    GROUP BY me.codigo_mercadoria
) v1
JOIN mercadorias m ON m.Codigo = v1.codigo_mercadoria
JOIN (
    SELECT SUM(me.quantidade * me.preco_unitario_movimento) AS total_geral
    FROM movimentos_estoque me
    WHERE me.tipo_movimento = 'SAIDA'
) v2;