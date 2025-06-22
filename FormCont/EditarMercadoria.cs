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
        public EditarMercadoria(string codigo, string tipo, string formato, string precovenda,
                                string unidade, string condicao, string situacao, string marca, string producao,
                                string datavalidade, string fretegratis, string volumes, string pesoliquido,
                                string pesoBruto, string largura, string altura, string profundidade, string itensCaixa,
                                string unidadeMedida, string varAtributo, string varOpcao, string GtinEan, string departamento,
                                string estoqueMinimo, string estoqueMaximo, string crossdocking, string localizacao)
        {
            InitializeComponent();
            this.FormClosing += EditarMercadoria_FormClosing;

            // Configurações visuais para parecer uma janela modal limpa
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            // Preenchimento dos campos
            txtcodigo.Text = codigo;
            txttipo.Text = tipo;
            txtformato.Text = formato;
            txtprecovenda.Text = precovenda;
            txtunidade.Text = unidade;
            txtcondicao.Text = condicao;
            txtsituacao.Text = situacao;
            txtmarca.Text = marca;
            txtproducao.Text = producao;
            txtdatavalidade.Text = datavalidade;
            txtfretegratis.Text = fretegratis;
            txtvolumes.Text = volumes;
            txtpesoLiquido.Text = pesoliquido;
            txtpesoBruto.Text = pesoBruto;
            txtlargura.Text = largura;
            txtaltura.Text = altura;
            txtprofundidade.Text = profundidade;
            txtitensCaixa.Text = itensCaixa;
            txtunidadeMedida.Text = unidadeMedida;
            txtvarAtributo.Text = varAtributo;
            txtvarOpcao.Text = varOpcao;
            txtGtinEan.Text = GtinEan;
            txtdepartamento.Text = departamento;
            txtestoqueMinimo.Text = estoqueMinimo;
            txtestoqueMaximo.Text = estoqueMaximo;
            txtcrossdocking.Text = crossdocking;
            txtlocalizacao.Text = localizacao;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btSalvarAltr_Click(object sender, EventArgs e)
        {
            try
            {
                Mercadoria attMerc = new Mercadoria();

                attMerc.Codigo = txtcodigo.Text;
                attMerc.Tipo = txttipo.Text;
                attMerc.Formato = txtformato.Text;

                attMerc.Quantidade = int.Parse(txtunidade.Text);
                attMerc.Condicao = txtcondicao.Text;
                attMerc.Situacao = txtsituacao.Text;
                attMerc.Marca = txtmarca.Text;
                attMerc.Producao = txtproducao.Text;
                attMerc.Data_Validade = txtdatavalidade.Text;
                attMerc.Frete_Gratis = txtfretegratis.Text;
                attMerc.Volumes = float.Parse(txtvolumes.Text);
                attMerc.Peso_Liquido = float.Parse(txtpesoLiquido.Text);
                attMerc.Peso_Bruto = float.Parse(txtpesoBruto.Text);
                attMerc.Largura = float.Parse(txtlargura.Text);
                attMerc.Altura = float.Parse(txtaltura.Text);
                attMerc.Profundidade = float.Parse(txtprofundidade.Text);
                attMerc.Itens_Caixa = int.Parse(txtitensCaixa.Text);
                attMerc.Unidade_Medida = txtunidadeMedida.Text;
                attMerc.Variacao_Atributo = txtvarAtributo.Text;
                attMerc.Variacao_Opcao = txtvarOpcao.Text;
                attMerc.GTIN = txtGtinEan.Text;
                attMerc.Departamento = txtdepartamento.Text;
                attMerc.Estoque_Minimo = int.Parse(txtestoqueMinimo.Text);
                attMerc.Estoque_Maximo = int.Parse(txtestoqueMaximo.Text);
                attMerc.Crossdocking = txtcrossdocking.Text;
                attMerc.Localizacao = txtlocalizacao.Text;

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

    }

}