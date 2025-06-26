using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCont
{
    internal class Mercadoria
    {

        //Atributos
        private int quantidade, itens_caixa, estoque_minimo, estoque_maximo;

        private float volumes, peso_liquido, peso_bruto, largura, altura, profundidade, preco_venda;

        private string codigo, nome, formato, condicao, tipo, situacao, marca, producao,
            data_validade, frete_gratis, unidade_medida, variacao_atributo, variacao_opcao, gtin,
            departamento, crossdocking, localizacao;


        //Métodos de acesso Get e Set
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public int Itens_Caixa
        {
            get { return itens_caixa; }
            set { itens_caixa = value; }
        }
        public float Volumes
        {
            get { return volumes; }
            set { volumes = value; }
        }

        public float Peso_Liquido
        {
            get { return peso_liquido; }
            set { peso_liquido = value; }
        }

        public float Peso_Bruto
        {
            get { return peso_bruto; }
            set { peso_bruto = value; }
        }

        public float Largura
        {
            get { return largura; }
            set { largura = value; }
        }

        public float Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public float Profundidade
        {
            get { return profundidade; }
            set { profundidade = value; }
        }

        public int Estoque_Minimo
        {
            get { return estoque_minimo; }
            set { estoque_minimo = value; }
        }

        public int Estoque_Maximo
        {
            get { return estoque_maximo; }
            set { estoque_maximo = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Formato
        {
            get { return formato; }
            set { formato = value; }
        }

        public string Condicao
        {
            get { return condicao; }
            set { condicao = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public float Preco_Venda
        {
            get { return preco_venda; }
            set { preco_venda = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Producao
        {
            get { return producao; }
            set { producao = value; }
        }

        public string Data_Validade
        {
            get { return data_validade; }
            set { data_validade = value; }
        }

        public string Frete_Gratis
        {
            get { return frete_gratis; }
            set { frete_gratis = value; }
        }

        public string Unidade_Medida
        {
            get { return unidade_medida; }
            set { unidade_medida = value; }
        }

        public string Variacao_Atributo
        {
            get { return variacao_atributo; }
            set { variacao_atributo = value; }
        }

        public string Variacao_Opcao
        {
            get { return variacao_opcao; }
            set { variacao_opcao = value; }
        }

        public string GTIN
        {
            get { return gtin; }
            set { gtin = value; }
        }

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public string Crossdocking
        {
            get { return crossdocking; }
            set { crossdocking = value; }
        }

        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        //Método para cadastrar mercadoria nova no estoque
        public bool cadastrarMercadoria()
        {
            try
            {
                using (MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoBd))
                {
                    MysqlConexaoBanco.Open();

                    string insert = @"INSERT INTO mercadorias 
                            (Quantidade, Nome, Itens_caixa, estoque_minimo, estoque_maximo, Volumes, Peso_liquido, Peso_bruto,
                            Largura, Altura, Profundidade, Preco_venda, codigo, Formato, Condicao, Tipo, Situacao, Marca,
                            Producao, Data_validade, Frete_gratis, Unidade_Medida, Variacao_Atributo, Variacao_Opcao, GTIN, 
                            Departamento, Crossdocking, Localizacao) 
                            VALUES 
                            (@Quantidade, @Nome, @Itens_Caixa, @Estoque_Minimo, @Estoque_Maximo, @Volumes, @Peso_Liquido, 
                            @Peso_Bruto, @Largura, @Altura, @Profundidade, @Preco_Venda, @Codigo, @Formato, @Condicao, 
                            @Tipo, @Situacao, @Marca, @Producao, @Data_Validade, @Frete_Gratis, @Unidade_Medida, 
                            @Variacao_Atributo, @Variacao_Opcao, @GTIN, @Departamento, @Crossdocking, @Localizacao)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, MysqlConexaoBanco))
                    {
                        comandoSql.Parameters.AddWithValue("@Quantidade", Quantidade);
                        comandoSql.Parameters.AddWithValue("@Nome", Nome);
                        comandoSql.Parameters.AddWithValue("@Itens_Caixa", Itens_Caixa);
                        comandoSql.Parameters.AddWithValue("@Estoque_Minimo", Estoque_Minimo);
                        comandoSql.Parameters.AddWithValue("@Estoque_Maximo", Estoque_Maximo);
                        comandoSql.Parameters.AddWithValue("@Volumes", Volumes);
                        comandoSql.Parameters.AddWithValue("@Peso_Liquido", Peso_Liquido);
                        comandoSql.Parameters.AddWithValue("@Peso_Bruto", Peso_Bruto);
                        comandoSql.Parameters.AddWithValue("@Largura", Largura);
                        comandoSql.Parameters.AddWithValue("@Altura", Altura);
                        comandoSql.Parameters.AddWithValue("@Profundidade", Profundidade);
                        comandoSql.Parameters.AddWithValue("@Preco_Venda", Preco_Venda);
                        comandoSql.Parameters.AddWithValue("@Codigo", Codigo);
                        comandoSql.Parameters.AddWithValue("@Formato", Formato);
                        comandoSql.Parameters.AddWithValue("@Condicao", Condicao);
                        comandoSql.Parameters.AddWithValue("@Tipo", Tipo);
                        comandoSql.Parameters.AddWithValue("@Situacao", Situacao);
                        comandoSql.Parameters.AddWithValue("@Marca", Marca);
                        comandoSql.Parameters.AddWithValue("@Producao", Producao);
                        comandoSql.Parameters.AddWithValue("@Data_Validade", Data_Validade);
                        comandoSql.Parameters.AddWithValue("@Frete_Gratis", Frete_Gratis);
                        comandoSql.Parameters.AddWithValue("@Unidade_Medida", Unidade_Medida);
                        comandoSql.Parameters.AddWithValue("@Variacao_Atributo", Variacao_Atributo);
                        comandoSql.Parameters.AddWithValue("@Variacao_Opcao", Variacao_Opcao);
                        comandoSql.Parameters.AddWithValue("@GTIN", GTIN);
                        comandoSql.Parameters.AddWithValue("@Departamento", Departamento);
                        comandoSql.Parameters.AddWithValue("@Crossdocking", Crossdocking);
                        comandoSql.Parameters.AddWithValue("@Localizacao", Localizacao);

                        comandoSql.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar mercadoria - método 'cadastrarMercadoria': " + ex.Message);
                return false;
            }
        }


        //Método para pesquisar uma mercadoria no estoque e retornar na tabela (datatable)
        public DataTable localizarMercadorias(string codigo)
        {
            try
            {
                using (MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoBd))
                {
                    MySqlConexaoBanco.Open();

                    string select = @"SELECT 
                                            codigo AS 'Código',
                                            Nome AS 'Nome',
                                            Tipo AS 'Tipo',
                                            Quantidade AS 'Quantidade',
                                            Condicao AS 'Condição',
                                            Preco_venda AS 'Preço de Venda',
                                            Formato AS 'Formato',
                                            Marca AS 'Marca',
                                            Producao AS 'Produção',
                                            Data_validade AS 'Validade',
                                            Frete_gratis AS 'Frete Grátis',
                                            Unidade_Medida AS 'Unidade Medida',
                                            Volumes AS 'Volumes',
                                            Peso_liquido AS 'Peso Líquido',
                                            Peso_bruto AS 'Peso Bruto',
                                            Largura AS 'Largura',
                                            Altura AS 'Altura',
                                            Profundidade AS 'Profundidade',
                                            Itens_caixa AS 'Itens por Caixa',
                                            Variacao_Atributo AS 'Var. Atributo',
                                            Variacao_Opcao AS 'Var. Opção',
                                            Situacao AS 'Situação',
                                            estoque_minimo AS 'Estoque Mínimo',
                                            estoque_maximo AS 'Estoque Máximo',
                                            Localizacao AS 'Localização',
                                            GTIN AS 'GTIN',
                                            Departamento AS 'Departamento',
                                            Crossdocking AS 'Crossdocking'
                                        FROM mercadorias WHERE codigo = @Codigo";

                    MySqlCommand comandoSql = new MySqlCommand(select, MySqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@Codigo", codigo);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comandoSql);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados: " + ex.Message);
                return null;
            }
        }

        public DataTable listarMercadorias()    
        {
            try
            {
                using (MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoBd))
                {
                    MySqlConexaoBanco.Open();

                    string select = @"SELECT 
                                            codigo AS 'Código',
                                            Nome AS 'Nome',
                                            Tipo AS 'Tipo',
                                            Quantidade AS 'Quantidade',
                                            Condicao AS 'Condição',
                                            Preco_venda AS 'Preço de Venda',
                                            Formato AS 'Formato',
                                            Marca AS 'Marca',
                                            Producao AS 'Produção',
                                            Data_validade AS 'Validade',
                                            Frete_gratis AS 'Frete Grátis',
                                            Unidade_Medida AS 'Unidade Medida',
                                            Volumes AS 'Volumes',
                                            Peso_liquido AS 'Peso Líquido',
                                            Peso_bruto AS 'Peso Bruto',
                                            Largura AS 'Largura',
                                            Altura AS 'Altura',
                                            Profundidade AS 'Profundidade',
                                            Itens_caixa AS 'Itens por Caixa',
                                            Variacao_Atributo AS 'Var. Atributo',
                                            Variacao_Opcao AS 'Var. Opção',
                                            Situacao AS 'Situação',
                                            estoque_minimo AS 'Estoque Mínimo',
                                            estoque_maximo AS 'Estoque Máximo',
                                            Localizacao AS 'Localização',
                                            GTIN AS 'GTIN',
                                            Departamento AS 'Departamento',
                                            Crossdocking AS 'Crossdocking'
                                        FROM mercadorias";

                    MySqlCommand comandoSql = new MySqlCommand(select, MySqlConexaoBanco);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comandoSql);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados: " + ex.Message);
                return null;
            }
        }

        //Método para alterar dados de uma mercadoria já cadastrada no estoque
        public bool atualizarMercadoria()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConexaoBanco.conexaoBd))
                {
                    conn.Open();

                    string update = @"UPDATE mercadorias SET 
                Quantidade = @Quantidade,
                Nome = @Nome,
                Formato = @Formato,
                Condicao = @Condicao,
                Tipo = @Tipo,
                Situacao = @Situacao,
                Preco_venda = @Preco_Venda,
                Marca = @Marca,
                Producao = @Producao,
                Data_validade = @Data_Validade,
                Frete_gratis = @Frete_Gratis,
                Volumes = @Volumes,
                Peso_liquido = @Peso_Liquido,
                Peso_bruto = @Peso_Bruto,
                Largura = @Largura,
                Altura = @Altura,
                Profundidade = @Profundidade,
                Itens_caixa = @Itens_Caixa,
                Unidade_Medida = @Unidade_Medida,
                Variacao_Atributo = @Variacao_Atributo,
                Variacao_Opcao = @Variacao_Opcao,
                GTIN = @GTIN,
                Departamento = @Departamento,
                estoque_minimo = @Estoque_Minimo,
                estoque_maximo = @Estoque_Maximo,
                Crossdocking = @Crossdocking,
                Localizacao = @Localizacao
            WHERE codigo = @Codigo;";

                    using (MySqlCommand cmd = new MySqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", Codigo);
                        cmd.Parameters.AddWithValue("@Nome", Nome);
                        cmd.Parameters.AddWithValue("@Quantidade", Quantidade);
                        cmd.Parameters.AddWithValue("@Formato", Formato);
                        cmd.Parameters.AddWithValue("@Condicao", Condicao);
                        cmd.Parameters.AddWithValue("@Tipo", Tipo);
                        cmd.Parameters.AddWithValue("@Situacao", Situacao);
                        cmd.Parameters.AddWithValue("@Preco_Venda", Preco_Venda);
                        cmd.Parameters.AddWithValue("@Marca", Marca);
                        cmd.Parameters.AddWithValue("@Producao", Producao);
                        cmd.Parameters.AddWithValue("@Data_Validade", Data_Validade);
                        cmd.Parameters.AddWithValue("@Frete_Gratis", Frete_Gratis);
                        cmd.Parameters.AddWithValue("@Volumes", Volumes);
                        cmd.Parameters.AddWithValue("@Peso_Liquido", Peso_Liquido);
                        cmd.Parameters.AddWithValue("@Peso_Bruto", Peso_Bruto);
                        cmd.Parameters.AddWithValue("@Largura", Largura);
                        cmd.Parameters.AddWithValue("@Altura", Altura);
                        cmd.Parameters.AddWithValue("@Profundidade", Profundidade);
                        cmd.Parameters.AddWithValue("@Itens_Caixa", Itens_Caixa);
                        cmd.Parameters.AddWithValue("@Unidade_Medida", Unidade_Medida);
                        cmd.Parameters.AddWithValue("@Variacao_Atributo", Variacao_Atributo);
                        cmd.Parameters.AddWithValue("@Variacao_Opcao", Variacao_Opcao);
                        cmd.Parameters.AddWithValue("@GTIN", GTIN);
                        cmd.Parameters.AddWithValue("@Departamento", Departamento);
                        cmd.Parameters.AddWithValue("@Estoque_Minimo", Estoque_Minimo);
                        cmd.Parameters.AddWithValue("@Estoque_Maximo", Estoque_Maximo);
                        cmd.Parameters.AddWithValue("@Crossdocking", Crossdocking);
                        cmd.Parameters.AddWithValue("@Localizacao", Localizacao);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        // Verifica se algum registro foi alterado
                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar mercadoria: " + ex.Message);
                return false;
            }
        }


        //Método para deletar uma mercadoria do estoque
        public bool deletarMercadoria()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoBd);
                MysqlConexaoBanco.Open();

                string delete = $"delete from mercadorias where codigo = '{Codigo}';";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;
                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar mercadoria - método 'deletarrMercadoria': " + ex.Message);
                return false;
            }
        }

        //Método para exibir o relatório de movimentação (entrada e saída) das mercadorias
        public DataTable relatorioES()
        {
            try
            {
                using (MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoBd))
                {
                    MySqlConexaoBanco.Open();

                    string select = @"
                                    SELECT
                                        me.codigo_mercadoria AS 'Código',
                                        m.Nome AS 'Nome da Mercadoria',
                                        me.tipo_movimento AS 'Movimento',
                                        me.quantidade AS 'Quantidade',
                                        me.preco_unitario_movimento AS 'Preço unitário',
                                        me.data_hora_movimento AS 'Data e Hora',
                                        me.observacoes AS 'Observações'
                                    FROM movimentos_estoque me
                                    JOIN mercadorias m ON m.codigo = me.codigo_mercadoria
                                    ORDER BY me.data_hora_movimento DESC";

                    MySqlCommand comandoSql = new MySqlCommand(select, MySqlConexaoBanco);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comandoSql);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados: " + ex.Message);
                return null;
            }
        }


        //Método para exibir o relatório de movimentação (entrada e saída) das mercadorias
        //através de código na barra de busca
        public DataTable relatorioPorCodigo(string codigoMercadoria)
        {
            try
            {
                using (MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoBd))
                {
                    MySqlConexaoBanco.Open();

                    string select = @"SELECT
                                    me.codigo_mercadoria AS 'Código',
                                    m.Nome AS 'Nome',
                                    me.tipo_movimento AS 'Movimento',
                                    me.quantidade AS 'Quantidade',
                                    me.preco_unitario_movimento AS 'Preço unitário',
                                    me.data_hora_movimento AS 'Data e Hora',
                                    me.observacoes AS 'Observações'
                                FROM movimentos_estoque me
                                JOIN mercadorias m ON me.codigo_mercadoria = m.codigo
                                WHERE (@codigo = '' OR me.codigo_mercadoria = @codigo)";

                    MySqlCommand comandoSql = new MySqlCommand(select, MySqlConexaoBanco);
                    comandoSql.Parameters.AddWithValue("@codigo", codigoMercadoria);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comandoSql);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados: " + ex.Message);
                return null;
            }
        }


        public DataTable relatorioPorPeriodo(string codigo, DateTime dataInicio, DateTime dataFim)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConexaoBanco.conexaoBd))
                {
                    conn.Open();

                    string sql = @"
                SELECT 
                    me.codigo_mercadoria AS 'Código',
                    m.Nome AS 'Nome',
                    me.tipo_movimento AS 'Movimento', 
                    me.quantidade AS 'Quantidade',
                    me.preco_unitario_movimento AS 'Preço unitário',
                    me.data_hora_movimento AS 'Data e Hora',
                    me.observacoes AS 'Observações'
                FROM movimentos_estoque me
                JOIN mercadorias m ON me.codigo_mercadoria = m.codigo
                WHERE me.data_hora_movimento BETWEEN @DataInicio AND @DataFim";

                    if (!string.IsNullOrEmpty(codigo))
                    {
                        sql += " AND me.codigo_mercadoria = @Codigo ";
                    }

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@DataInicio", dataInicio);
                    cmd.Parameters.AddWithValue("@DataFim", dataFim);

                    if (!string.IsNullOrEmpty(codigo))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", codigo);
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório por período: " + ex.Message);
                return null;
            }
        }


        public DataGridView PesquisaReg(MySqlConnection MysqlConexaoBD, DataGridView tabela1, string cod, string tipo, string marca, string combo)
        {

            DataTable tabelaShow = new DataTable();

            MysqlConexaoBD.Open();

            try
            {
                // Constrói a base da consulta
                string sql = "SELECT ID , Tipo , Marca , Formato FROM mercadorias WHERE 1=1";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = MysqlConexaoBD;

                if (!string.IsNullOrWhiteSpace(cod))
                {
                    sql += " AND codigo LIKE @cod";
                    cmd.Parameters.AddWithValue("@cod", "%" + cod + "%");
                }

                if (!string.IsNullOrWhiteSpace(marca))
                {
                    sql += " AND Marca LIKE @marca";
                    cmd.Parameters.AddWithValue("@marca", "%" + marca + "%");
                }

                if (!string.IsNullOrWhiteSpace(tipo))
                {
                    sql += " AND Tipo LIKE @tipo";
                    cmd.Parameters.AddWithValue("@tipo", "%" + tipo + "%");
                }

                if (!string.IsNullOrWhiteSpace(combo))
                {
                    sql += " AND Formato LIKE @combo";
                    cmd.Parameters.AddWithValue("@combo", "%" + combo + "%");
                }

                // Se nenhum campo foi preenchido
                if (cmd.Parameters.Count == 0)
                {
                    sql = "SELECT ID , Tipo , Marca , Formato FROM mercadorias";
                }

                // Atribui a SQL final
                cmd.CommandText = sql;

                // Executa
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabelaShow);
                tabela1.DataSource = tabelaShow;
                return tabela1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a busca: " + ex.Message);
                return null;
            }
            finally
            {
                MysqlConexaoBD.Close();
            }
        }
    }
}