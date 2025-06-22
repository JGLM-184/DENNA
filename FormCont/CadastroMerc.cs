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
        }


        private void btsalvarMercadoria_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!txtcodigo.Text.Equals("") && !txtformato.Text.Equals("") && !txttipo.Text.Equals("") &&
                    !txtprecovenda.Text.Equals("") && !txtunidade.Text.Equals("") && !txtcondicao.Text.Equals("") &&
                    !txtsituacao.Text.Equals("") && !txtmarca.Text.Equals("") && !txtproducao.Text.Equals("") &&
                    !txtdatavalidade.Text.Equals("") && !txtfretegratis.Text.Equals("") && !txtvolumes.Text.Equals("") &&
                    !txtpesoLiquido.Text.Equals("") && !txtpesoBruto.Text.Equals("") && !txtlargura.Text.Equals("") &&
                    !txtaltura.Text.Equals("") && !txtprofundidade.Text.Equals("") && !txtitensCaixa.Text.Equals("") &&
                    !txtunidadeMedida.Text.Equals("") && !txtvarAtributo.Text.Equals("") && !txtvarOpcao.Text.Equals("") &&
                    !txtGtinEan.Text.Equals("") && !txtdepartamento.Text.Equals("") &&
                    !txtestoqueMinimo.Text.Equals("") && !txtestoqueMaximo.Text.Equals("") && !txtcrossdocking.Text.Equals("") &&
                    !txtlocalizacao.Text.Equals(""))
                {
                Mercadoria cadastrarMerc = new Mercadoria();
                    cadastrarMerc.Codigo = txtcodigo.Text;
                    cadastrarMerc.Formato = txtformato.Text;
                    cadastrarMerc.Tipo = txttipo.Text;
                    cadastrarMerc.Preco_Venda = txtprecovenda.Text;
                    cadastrarMerc.Quantidade = int.Parse(txtunidade.Text);
                    cadastrarMerc.Condicao = txtcondicao.Text;
                    cadastrarMerc.Situacao = txtsituacao.Text;
                    cadastrarMerc.Marca = txtmarca.Text;
                    cadastrarMerc.Producao = txtproducao.Text;
                    cadastrarMerc.Data_Validade = txtdatavalidade.Text;
                    cadastrarMerc.Frete_Gratis = txtfretegratis.Text;
                    cadastrarMerc.Volumes = float.Parse(txtvolumes.Text);
                    cadastrarMerc.Peso_Liquido = float.Parse(txtpesoLiquido.Text);
                    cadastrarMerc.Peso_Bruto = float.Parse(txtpesoBruto.Text);
                    cadastrarMerc.Largura = float.Parse(txtlargura.Text);
                    cadastrarMerc.Altura = float.Parse(txtaltura.Text);
                    cadastrarMerc.Profundidade = float.Parse(txtprofundidade.Text);
                    cadastrarMerc.Itens_Caixa = int.Parse(txtitensCaixa.Text);
                    cadastrarMerc.Unidade_Medida = txtunidadeMedida.Text;
                    cadastrarMerc.Variacao_Atributo = txtvarAtributo.Text;
                    cadastrarMerc.Variacao_Opcao = txtvarOpcao.Text;
                    cadastrarMerc.GTIN = txtGtinEan.Text;
                    cadastrarMerc.Departamento = txtdepartamento.Text;
                    cadastrarMerc.Estoque_Minimo = int.Parse(txtestoqueMinimo.Text);
                    cadastrarMerc.Estoque_Maximo = int.Parse(txtestoqueMaximo.Text);
                    cadastrarMerc.Crossdocking = txtcrossdocking.Text;
                    cadastrarMerc.Localizacao = txtlocalizacao.Text;

                    if (cadastrarMerc.cadastrarMercadoria())
                    {
                        MessageBox.Show($"Mercadoria cadastrada com sucesso!");

                        txtcodigo.Clear();
                        txtformato.SelectedIndex = -1;
                        txttipo.Clear();
                        txtprecovenda.Clear();
                        txtunidade.Clear();
                        txtcondicao.SelectedIndex = -1;
                        txtsituacao.SelectedIndex = -1;
                        txtmarca.Clear();
                        txtproducao.SelectedIndex = -1;
                        txtdatavalidade.Clear();
                        txtfretegratis.SelectedIndex = -1;
                        txtvolumes.SelectedIndex = -1;
                        txtpesoLiquido.Clear();
                        txtpesoBruto.Clear();
                        txtlargura.Clear();
                        txtaltura.Clear();
                        txtprofundidade.Clear();
                        txtitensCaixa.Clear();
                        txtunidadeMedida.SelectedIndex = -1;
                        txtvarAtributo.Clear();
                        txtvarOpcao.Clear();
                        txtGtinEan.Clear();
                        txtdepartamento.SelectedIndex = -1;
                        txtestoqueMinimo.Clear();
                        txtestoqueMaximo.Clear();
                        txtcrossdocking.Clear();
                        txtlocalizacao.Clear();
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

        private void btsalvarMercadoria_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }

}

