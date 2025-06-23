using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCont
{
    public partial class CadastroMerc : Form
    {

        public CadastroMerc()
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
        }




        private void btsalvarMercadoria_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!txtCodigo.Text.Equals("") &&!txtNome.Text.Equals("") && !txtFormato.Text.Equals("") && !txtTipo.Text.Equals("") &&
                    !txtPrecoVenda.Text.Equals("") && !txtQuantidade.Text.Equals("") && !txtCondicao.Text.Equals("") &&
                    !txtSituacao.Text.Equals("") && !txtMarca.Text.Equals("") && !txtProducao.Text.Equals("") &&
                    !txtDataValidade.Text.Equals("") && !txtFreteGratis.Text.Equals("") && !txtVolume.Text.Equals("") &&
                    !txtPesoLiquido.Text.Equals("") && !txtPesoBruto.Text.Equals("") && !txtLargura.Text.Equals("") &&
                    !txtAltura.Text.Equals("") && !txtProfundidade.Text.Equals("") && !txtItensCaixa.Text.Equals("") &&
                    !txtUnidadeMedida.Text.Equals("") && !txtVarAtributo.Text.Equals("") && !txtVarOpcao.Text.Equals("") &&
                    !txtGtin.Text.Equals("") && !txtDepartamento.Text.Equals("") &&
                    !txtEstoqueMinimo.Text.Equals("") && !txtEstoqueMaximo.Text.Equals("") && !txtCrossdocking.Text.Equals("") &&
                    !txtLocalizacao.Text.Equals(""))
                {
                Mercadoria cadastrarMerc = new Mercadoria();
                    cadastrarMerc.Codigo = txtCodigo.Text;
                    cadastrarMerc.Nome = txtNome.Text;
                    cadastrarMerc.Formato = txtFormato.Text;
                    cadastrarMerc.Tipo = txtTipo.Text;
                    cadastrarMerc.Preco_Venda = txtPrecoVenda.Text;
                    cadastrarMerc.Quantidade = int.Parse(txtQuantidade.Text);
                    cadastrarMerc.Condicao = txtCondicao.Text;
                    cadastrarMerc.Situacao = txtSituacao.Text;
                    cadastrarMerc.Marca = txtMarca.Text;
                    cadastrarMerc.Producao = txtProducao.Text;
                    cadastrarMerc.Data_Validade = txtDataValidade.Text;
                    cadastrarMerc.Frete_Gratis = txtFreteGratis.Text;
                    cadastrarMerc.Volumes = float.Parse(txtVolume.Text);
                    cadastrarMerc.Peso_Liquido = float.Parse(txtPesoLiquido.Text);
                    cadastrarMerc.Peso_Bruto = float.Parse(txtPesoBruto.Text);
                    cadastrarMerc.Largura = float.Parse(txtLargura.Text);
                    cadastrarMerc.Altura = float.Parse(txtAltura.Text);
                    cadastrarMerc.Profundidade = float.Parse(txtProfundidade.Text);
                    cadastrarMerc.Itens_Caixa = int.Parse(txtItensCaixa.Text);
                    cadastrarMerc.Unidade_Medida = txtUnidadeMedida.Text;
                    cadastrarMerc.Variacao_Atributo = txtVarAtributo.Text;
                    cadastrarMerc.Variacao_Opcao = txtVarOpcao.Text;
                    cadastrarMerc.GTIN = txtGtin.Text;
                    cadastrarMerc.Departamento = txtDepartamento.Text;
                    cadastrarMerc.Estoque_Minimo = int.Parse(txtEstoqueMinimo.Text);
                    cadastrarMerc.Estoque_Maximo = int.Parse(txtEstoqueMaximo.Text);
                    cadastrarMerc.Crossdocking = txtCrossdocking.Text;
                    cadastrarMerc.Localizacao = txtLocalizacao.Text;

                    if (cadastrarMerc.cadastrarMercadoria())
                    {
                        MessageBox.Show($"Mercadoria cadastrada com sucesso!");

                        txtCodigo.Clear();
                        txtNome.Clear();
                        txtFormato.SelectedIndex = -1;
                        txtTipo.Clear();
                        txtPrecoVenda.Clear();
                        txtQuantidade.Clear();
                        txtCondicao.SelectedIndex = -1;
                        txtSituacao.SelectedIndex = -1;
                        txtMarca.Clear();
                        txtProducao.Clear();
                        txtDataValidade.Clear();
                        txtFreteGratis.SelectedIndex = -1;
                        txtVolume.Clear();
                        txtPesoLiquido.Clear();
                        txtPesoBruto.Clear();
                        txtLargura.Clear();
                        txtAltura.Clear();
                        txtProfundidade.Clear();
                        txtItensCaixa.Clear();
                        txtUnidadeMedida.SelectedIndex = -1;
                        txtVarAtributo.Clear();
                        txtVarOpcao.Clear();
                        txtGtin.Clear();
                        txtDepartamento.SelectedIndex = -1;
                        txtEstoqueMinimo.Clear();
                        txtEstoqueMaximo.Clear();
                        txtCrossdocking.Clear();
                        txtLocalizacao.Clear();
                    }
                    else
                    {
                        MessageBox.Show($"Não foi possível cadastrar a mercadoria.");
                    }
                }
               else
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar mercadoria: " + ex.Message);
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
                e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Impede mais de uma vírgula ou ponto
            if ((e.KeyChar == ',' || e.KeyChar == '.') &&
                (txt.Text.Contains(",") || txt.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        



    }

}

