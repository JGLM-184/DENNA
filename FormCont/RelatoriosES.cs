using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FormCont
{
    public partial class RelatoriosES : Form
    {

        public RelatoriosES()
        {
            InitializeComponent();
            rdbMes.Checked = false;
            rdbPeriodo.Checked = false;
            toolTip1.SetToolTip(btLimpar, "Limpar listagem");


        }

        private void btGerarRelatorio_Click_1(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoBusca.Text.Trim(); // pode estar vazio
                Mercadoria relatorio = new Mercadoria();
                DataTable dataTable = null;

                // 1. Se o radiobutton do mês atual estiver marcado
                if (rdbMes.Checked)
                {
                    DateTime primeiroDiaMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    DateTime ultimoDiaMes = primeiroDiaMes.AddMonths(1).AddDays(-1);

                    dataTable = relatorio.relatorioPorPeriodo(codigo, primeiroDiaMes, ultimoDiaMes);
                }
                // 2. Se o radiobutton de período personalizado estiver marcado
                else if (rdbPeriodo.Checked)
                {
                    DateTime dataInicio = dtInicio.Value.Date;
                    DateTime dataFim = dtFinal.Value.Date;

                    if (dataInicio > dataFim)
                    {
                        MessageBox.Show("Data de início não pode ser maior que a data de fim.");
                        return;
                    }

                    dataTable = relatorio.relatorioPorPeriodo(codigo, dataInicio, dataFim);
                }
                // 3. Nenhum radiobutton marcado
                else
                {
                    if (!string.IsNullOrEmpty(codigo))
                    {
                        dataTable = relatorio.relatorioPorCodigo(codigo); // só o código
                    }
                    else
                    {
                        dataTable = relatorio.relatorioES(); // tudo
                    }
                }

                // Exibe os dados no DataGridView
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    tabelaRelatorio.DataSource = dataTable;
                    tabelaRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    tabelaRelatorio.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

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


        private void btDesmarcar_Click(object sender, EventArgs e)
        {
            rdbMes.Checked = false;
            rdbPeriodo.Checked = false;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tabelaRelatorio.DataSource = null;
            tabelaRelatorio.Rows.Clear();
            txtCodigoBusca.Clear();
            rdbMes.Checked = false;
            rdbPeriodo.Checked = false;
        }
    }
}
