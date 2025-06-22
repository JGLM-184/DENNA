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
    public partial class RelatoriosES : Form
    {

        public RelatoriosES()
        {
            InitializeComponent();
           
        }     

        private void btGerarRelatorio_Click_1(object sender, EventArgs e)
        {
            try
            {
                Mercadoria relatorio = new Mercadoria();

                DataTable dataTable = relatorio.relatorioES();
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    tabelaRelatorio.DataSource = dataTable;
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RelatoriosES_Load(object sender, EventArgs e)
        {

        }
    }
}
