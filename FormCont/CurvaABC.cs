using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormCont
{
    public partial class CurvaABC : Form
    {
        public CurvaABC()
        {
            InitializeComponent();
            this.Load += CurvaABC_Load;
            btGerarCurva.Click += btGerarCurva_Click;
            toolTip1.SetToolTip(btLimpar, "Limpar listagem");

        }

        private void CurvaABC_Load(object sender, EventArgs e)
        {
            GerarGraficoIdeal();
            chartReal.Series.Clear();

        }

        private void CarregarDados()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConexaoBanco.conexaoBd))
                {
                    string query = @"
                                   SELECT 
                                        ID, 
                                        codigo, 
                                        Marca, 
                                        Quantidade, 
                                        Preco_venda, 
                                        (Quantidade * Preco_venda) AS TotalEstoque 
                                    FROM mercadorias
                                    ORDER BY Preco_venda DESC
                                ";


                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    tabelaCurvaABC.DataSource = dt;

                    tabelaCurvaABC.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    tabelaCurvaABC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    tabelaCurvaABC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    tabelaCurvaABC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    GerarGraficoReal(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void GerarGraficoIdeal()
        {
            chartIdeal.Series.Clear();
            chartIdeal.ChartAreas.Clear();

            chartIdeal.ChartAreas.Add("CurvaABC");
            chartIdeal.Series.Add("Ideal");

            chartIdeal.Series["Ideal"].ChartType = SeriesChartType.Column;
            chartIdeal.Series["Ideal"].Points.AddXY("A", 20);
            chartIdeal.Series["Ideal"].Points.AddXY("B", 30);
            chartIdeal.Series["Ideal"].Points.AddXY("C", 50);

            chartIdeal.Series["Ideal"].Color = Color.FromArgb(102, 255, 178); // Verde A
            chartIdeal.Series["Ideal"].Points[1].Color = Color.FromArgb(102, 204, 255); // Azul B
            chartIdeal.Series["Ideal"].Points[2].Color = Color.FromArgb(255, 99, 71); // Coral

            chartIdeal.Titles.Clear();
            chartIdeal.Titles.Add("Curva ABC - Ideal");
        }


        private void GerarGraficoReal(DataTable dt)
        {
            var produtosOrdenados = dt.AsEnumerable()
                .OrderByDescending(row => {
                    decimal temp;
                    return decimal.TryParse(row["TotalEstoque"].ToString(), out temp) ? temp : 0;
                })
                .ToList();

            decimal totalGeral = produtosOrdenados.Sum(row => {
                decimal temp;
                return decimal.TryParse(row["TotalEstoque"].ToString(), out temp) ? temp : 0;
            });

            if (totalGeral == 0) return;

            decimal acumulado = 0;
            int grupoA = 0, grupoB = 0, grupoC = 0;

            // Armazenar os índices para colorir depois
            var grupoARows = new List<int>();
            var grupoBRows = new List<int>();
            var grupoCRows = new List<int>();

            for (int i = 0; i < produtosOrdenados.Count; i++)
            {
                var row = produtosOrdenados[i];
                decimal valor;
                if (!decimal.TryParse(row["TotalEstoque"].ToString(), out valor))
                    continue;

                acumulado += valor;
                decimal percentual = acumulado / totalGeral * 100;

                if (percentual <= 20)
                {
                    grupoARows.Add(i);
                    grupoA++;
                }
                else if (percentual <= 50)
                {
                    grupoBRows.Add(i);
                    grupoB++;
                }
                else
                {
                    grupoCRows.Add(i);
                    grupoC++;
                }
            }

            int totalProdutos = grupoA + grupoB + grupoC;
            if (totalProdutos == 0) return;

            double percA = grupoA * 100.0 / totalProdutos;
            double percB = grupoB * 100.0 / totalProdutos;
            double percC = grupoC * 100.0 / totalProdutos;

            chartReal.Series.Clear();
            chartReal.ChartAreas.Clear();

            chartReal.ChartAreas.Add("CurvaABCReal");
            chartReal.Series.Add("Real");

            chartReal.Series["Real"].ChartType = SeriesChartType.Column;
            chartReal.Series["Real"].Points.AddXY("A", percA);
            chartReal.Series["Real"].Points.AddXY("B", percB);
            chartReal.Series["Real"].Points.AddXY("C", percC);

            chartReal.Series["Real"].Color = Color.FromArgb(102, 255, 178);
            chartReal.Series["Real"].Points[1].Color = Color.FromArgb(102, 204, 255);
            chartReal.Series["Real"].Points[2].Color = Color.FromArgb(255, 99, 71); // Coral

            chartReal.Titles.Clear();
            chartReal.Titles.Add("Curva ABC - Real");

            // 👉 Colorir a tabela
            for (int i = 0; i < tabelaCurvaABC.Rows.Count; i++)
            {
                var gridRow = tabelaCurvaABC.Rows[i];

                if (grupoARows.Contains(i))
                    gridRow.DefaultCellStyle.BackColor = Color.FromArgb(204, 255, 204); // Verde claro
                else if (grupoBRows.Contains(i))
                    gridRow.DefaultCellStyle.BackColor = Color.FromArgb(204, 229, 255); // Azul claro
                else if (grupoCRows.Contains(i))
                    gridRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 204, 204); // Vermelho claro
            }
        }


        private void tabelaCurvaABC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Opcional
        }

        private void btGerarCurva_Click(object sender, EventArgs e)
        {
            CarregarDados();

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tabelaCurvaABC.DataSource = null;
            tabelaCurvaABC.Rows.Clear();
        }
    }
}
