using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FormCont.ControleEstoque;

namespace FormCont
{
    public partial class EditarMercadoria : Form
    {
        public EditarMercadoria(string codigo, string nome, string tipo, string formato, string precovenda,
                                string unidade, string condicao, string situacao, string marca, string producao,
                                string datavalidade, string fretegratis, string volumes, string pesoliquido,
                                string pesoBruto, string largura, string altura, string profundidade, string itensCaixa,
                                string unidadeMedida, string varAtributo, string varOpcao, string GtinEan, string departamento,
                                string estoqueMinimo, string estoqueMaximo, string crossdocking, string localizacao)
        {
            InitializeComponent();

            //Aplicar método de só números inteiros
            txtCodigo.KeyPress += ApenasNumeros_KeyPress;
            txtQuantidade.KeyPress += ApenasNumeros_KeyPress;
            txtVolume.KeyPress += ApenasNumeros_KeyPress;
            txtGtin.KeyPress += ApenasNumeros_KeyPress;
            txtEstoqueMinimo.KeyPress += ApenasNumeros_KeyPress;
            txtEstoqueMaximo.KeyPress += ApenasNumeros_KeyPress;
            txtItensCaixa.KeyPress += ApenasNumeros_KeyPress;


            //Aplicar método de números decimais
            txtPrecoVenda.KeyPress += ApenasDecimais_KeyPress;
            txtPesoLiquido.KeyPress += ApenasDecimais_KeyPress;
            txtPesoBruto.KeyPress += ApenasDecimais_KeyPress;
            txtAltura.KeyPress += ApenasDecimais_KeyPress;
            txtLargura.KeyPress += ApenasDecimais_KeyPress;
            txtProfundidade.KeyPress += ApenasDecimais_KeyPress;

            this.FormClosing += EditarMercadoria_FormClosing;

            // Configurações visuais para parecer uma janela modal limpa
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            // Preenchimento dos campos
            txtCodigo.Text = codigo;
            txtNome.Text = nome;
            txtTipo.Text = tipo;
            txtFormato.Text = formato;
            txtPrecoVenda.Text = precovenda;
            txtQuantidade.Text = unidade;
            txtCondicao.Text = condicao;
            txtSituacao.Text = situacao;
            txtMarca.Text = marca;
            txtProducao.Text = producao;
            txtDataValidade.Text = datavalidade;
            txtFreteGratis.Text = fretegratis;
            txtVolume.Text = volumes;
            txtPesoLiquido.Text = pesoliquido;
            txtPesoBruto.Text = pesoBruto;
            txtLargura.Text = largura;
            txtAltura.Text = altura;
            txtProfundidade.Text = profundidade;
            txtItensCaixa.Text = itensCaixa;
            txtUnidadeMedida.Text = unidadeMedida;
            txtVarAtributo.Text = varAtributo;
            txtVarOpcao.Text = varOpcao;
            txtGtin.Text = GtinEan;
            txtDepartamento.Text = departamento;
            txtEstoqueMinimo.Text = estoqueMinimo;
            txtEstoqueMaximo.Text = estoqueMaximo;
            txtCrossdocking.Text = crossdocking;
            txtLocalizacao.Text = localizacao;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            
                this.Close();
            
        }

        private void btSalvarAltr_Click(object sender, EventArgs e)
        {
            try
            {
                Mercadoria attMerc = new Mercadoria();

                attMerc.Codigo = txtCodigo.Text;
                attMerc.Tipo = txtTipo.Text;
                attMerc.Formato = txtFormato.Text;
                attMerc.Nome = txtNome.Text;
                attMerc.Quantidade = int.Parse(txtQuantidade.Text);
                attMerc.Condicao = txtCondicao.Text;
                attMerc.Situacao = txtSituacao.Text;
                attMerc.Marca = txtMarca.Text;
                attMerc.Producao = txtProducao.Text;
                attMerc.Data_Validade = txtDataValidade.Text;
                attMerc.Frete_Gratis = txtFreteGratis.Text;
                attMerc.Preco_Venda = float.Parse(txtPrecoVenda.Text);
                attMerc.Volumes = float.Parse(txtVolume.Text);
                attMerc.Peso_Liquido = float.Parse(txtPesoLiquido.Text);
                attMerc.Peso_Bruto = float.Parse(txtPesoBruto.Text);
                attMerc.Largura = float.Parse(txtLargura.Text);
                attMerc.Altura = float.Parse(txtAltura.Text);
                attMerc.Profundidade = float.Parse(txtProfundidade.Text);
                attMerc.Itens_Caixa = int.Parse(txtItensCaixa.Text);
                attMerc.Unidade_Medida = txtUnidadeMedida.Text;
                attMerc.Variacao_Atributo = txtVarAtributo.Text;
                attMerc.Variacao_Opcao = txtVarOpcao.Text;
                attMerc.GTIN = txtGtin.Text;
                attMerc.Departamento = txtDepartamento.Text;
                attMerc.Estoque_Minimo = int.Parse(txtEstoqueMinimo.Text);
                attMerc.Estoque_Maximo = int.Parse(txtEstoqueMaximo.Text);
                attMerc.Crossdocking = txtCrossdocking.Text;
                attMerc.Localizacao = txtLocalizacao.Text;

                if (MessageBox.Show("Deseja realmente salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (attMerc.atualizarMercadoria())
                    {
                        MessageBox.Show("Alterações salvas com sucesso!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração foi feita (verifique se o código existe).");
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar alterações: " + ex.Message);
            }
        }


        private void EditarMercadoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK) // Só pergunta se ainda não salvou
            {
                DialogResult resposta = MessageBox.Show(
                    "Deseja realmente cancelar as alterações?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2
                );

                if (resposta == DialogResult.No)
                {
                    e.Cancel = true; // Impede o fechamento
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }


        //Máscara número inteiro
        private void ApenasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Máscara número decimal
        private void ApenasDecimais_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permitir números, vírgula, ponto e backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Impede mais de uma vírgula ou ponto
            if ((e.KeyChar == ',') &&
                (txt.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }
    }


}