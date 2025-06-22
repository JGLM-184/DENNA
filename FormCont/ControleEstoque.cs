using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FormCont.ControleEstoque;
using static FormCont.EditarMercadoria;

namespace FormCont
{

    public partial class ControleEstoque : Form
    {
        private ToolTip toolTip;


        EditarMercadoria editar_merc;
        Mercadoria localizarMerc = new Mercadoria();

        public ControleEstoque()
        {
            InitializeComponent();
            toolTip = new ToolTip();

            // Define textos para diferentes controles
            toolTip.SetToolTip(btBuscarMercFull, "Listar mercadorias");
            toolTip.SetToolTip(btEditar, "Editar mercadoria selecionada");
            toolTip.SetToolTip(btDeletar, "Excluir mercadoria selecionada");
            toolTip.SetToolTip(btBuscarMerc, "Buscar uma mercadoria");
        }

        private void btListarMercFull_Click(object sender, EventArgs e)
        {
            tabelaMercadorias.AutoGenerateColumns = true;

            try
            {
                Mercadoria listarMerc = new Mercadoria();

                DataTable dataTable = listarMerc.listarMercadorias();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    tabelaMercadorias.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados: " + ex.Message);
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (tabelaMercadorias.SelectedRows.Count == 1)
            {
                try
                {
                    var row = tabelaMercadorias.SelectedRows[0];
                    string codigo = row.Cells["Código"].Value.ToString();

                    // Pegando os dados direto da linha
                    string tipo = row.Cells["Tipo"].Value.ToString();
                    string precoVenda = row.Cells["Preço de Venda"].Value.ToString();
                    string formato = row.Cells["Formato"].Value.ToString();
                    string quantidade = row.Cells["Quantidade"].Value.ToString();
                    string condicao = row.Cells["Condição"].Value.ToString();
                    string situacao = row.Cells["Situação"].Value.ToString();
                    string marca = row.Cells["Marca"].Value.ToString();
                    string producao = row.Cells["Produção"].Value.ToString();
                    string validade = row.Cells["Validade"].Value.ToString();
                    string freteGratis = row.Cells["Frete Grátis"].Value.ToString();
                    string volumes = row.Cells["Volumes"].Value.ToString();
                    string pesoLiquido = row.Cells["Peso Líquido"].Value.ToString();
                    string pesoBruto = row.Cells["Peso Bruto"].Value.ToString();
                    string largura = row.Cells["Largura"].Value.ToString();
                    string altura = row.Cells["Altura"].Value.ToString();
                    string profundidade = row.Cells["Profundidade"].Value.ToString();
                    string itensCaixa = row.Cells["Itens por Caixa"].Value.ToString();
                    string unidadeMedida = row.Cells["Unidade Medida"].Value.ToString();
                    string varAtributo = row.Cells["Var. Atributo"].Value.ToString();
                    string varOpcao = row.Cells["Var. Opção"].Value.ToString();
                    string gtin = row.Cells["GTIN"].Value.ToString();
                    string departamento = row.Cells["Departamento"].Value.ToString();
                    string estoqueMinimo = row.Cells["Estoque Mínimo"].Value.ToString();
                    string estoqueMaximo = row.Cells["Estoque Máximo"].Value.ToString();
                    string crossdocking = row.Cells["Crossdocking"].Value.ToString();
                    string localizacao = row.Cells["Localização"].Value.ToString();

                    // Chama o form de edição
                    var formEdicao = new EditarMercadoria(codigo, tipo, formato,precoVenda, quantidade,
                    condicao, situacao, marca, producao,  validade, freteGratis, volumes, pesoLiquido,
                    pesoBruto, largura, altura, profundidade, itensCaixa, unidadeMedida, varAtributo,
                    varOpcao, gtin, departamento, estoqueMinimo, estoqueMaximo, crossdocking, localizacao);

                    formEdicao.StartPosition = FormStartPosition.CenterScreen;
                    formEdicao.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar tela de edição: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma única mercadoria para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void btDeletar_Click_1(object sender, EventArgs e)
        {
            Mercadoria deletar = new Mercadoria();

            if (tabelaMercadorias.SelectedRows.Count > 0 && tabelaMercadorias.SelectedRows.Count < 2)
            {
                deletar.Codigo = Convert.ToString(tabelaMercadorias.SelectedRows[0].Cells["Código"].Value);

                if (deletar.deletarMercadoria())
                {
                    if (MessageBox.Show("Deseja realmente deletar a mercadoria?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Mercadoria excluída!");

                    }
                }

                else
                {
                    MessageBox.Show("Não foi possível excluir a mercadoria");

                }
            }

        }


        private void btBuscarMerc_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = localizarMerc.localizarMercadorias(txtBarraPesquisa.Text.Trim());

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    tabelaMercadorias.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado para o código informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados: " + ex.Message);
            }
        }
    }
}