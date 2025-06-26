using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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

                    tabelaCurvaABC.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
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

            chartReal.Series.Clear();
            chartReal.Titles.Clear();
            chartReal.ChartAreas.Clear();
        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            if (tabelaCurvaABC.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar.");
                return;
            }

            // Nome do arquivo com data
            string nomeArquivo = $"CurvaABC_{DateTime.Now:yyyy-MM-dd}.pdf";

            SaveFileDialog salvar = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Salvar Relatório Curva ABC em PDF",
                FileName = nomeArquivo
            };

            if (salvar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(salvar.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    using (Document doc = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f))
                    {
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        // Fontes
                        var fonteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
                        var fonteCabecalho = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                        var fonteCelula = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.NORMAL);

                        // Título
                        Paragraph titulo = new Paragraph("Relatório Curva ABC", fonteTitulo);
                        titulo.Alignment = Element.ALIGN_CENTER;
                        titulo.SpacingAfter = 20f;
                        doc.Add(titulo);

                        // --- Tabela ---
                        PdfPTable tabelaPDF = new PdfPTable(tabelaCurvaABC.Columns.Count);
                        tabelaPDF.WidthPercentage = 100;

                        // Cabeçalhos
                        foreach (DataGridViewColumn col in tabelaCurvaABC.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, fonteCabecalho));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            tabelaPDF.AddCell(cell);
                        }

                        // Dados
                        foreach (DataGridViewRow row in tabelaCurvaABC.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    tabelaPDF.AddCell(new Phrase(cell.Value?.ToString() ?? "", fonteCelula));
                                }
                            }
                        }

                        doc.Add(tabelaPDF);

                        // Espaço entre tabela e gráficos
                        doc.Add(new Paragraph("\n"));

                        // --- Gráficos lado a lado ---

                        // Salva os gráficos como imagens temporárias
                        System.Drawing.Bitmap bmpIdeal = new System.Drawing.Bitmap(chartIdeal.Width, chartIdeal.Height);
                        chartIdeal.DrawToBitmap(bmpIdeal, new System.Drawing.Rectangle(0, 0, chartIdeal.Width, chartIdeal.Height));
                        string imgPathIdeal = System.IO.Path.GetTempFileName();
                        bmpIdeal.Save(imgPathIdeal, System.Drawing.Imaging.ImageFormat.Png);

                        System.Drawing.Bitmap bmpReal = new System.Drawing.Bitmap(chartReal.Width, chartReal.Height);
                        chartReal.DrawToBitmap(bmpReal, new System.Drawing.Rectangle(0, 0, chartReal.Width, chartReal.Height));
                        string imgPathReal = System.IO.Path.GetTempFileName();
                        bmpReal.Save(imgPathReal, System.Drawing.Imaging.ImageFormat.Png);

                        // Cria tabela com 2 colunas para colocar os gráficos lado a lado
                        PdfPTable tabelaGraficos = new PdfPTable(2);
                        tabelaGraficos.WidthPercentage = 100;
                        tabelaGraficos.DefaultCell.Border = PdfPCell.NO_BORDER;
                        tabelaGraficos.SetWidths(new float[] { 50f, 50f });

                        // Imagem gráfico Ideal
                        iTextSharp.text.Image imgIdeal = iTextSharp.text.Image.GetInstance(imgPathIdeal);
                        imgIdeal.ScaleToFit((doc.PageSize.Width - doc.LeftMargin - doc.RightMargin) / 2 - 10, doc.PageSize.Height / 2);
                        imgIdeal.Alignment = Element.ALIGN_CENTER;

                        PdfPCell cellIdeal = new PdfPCell(imgIdeal);
                        cellIdeal.Border = PdfPCell.NO_BORDER;
                        cellIdeal.HorizontalAlignment = Element.ALIGN_CENTER;
                        tabelaGraficos.AddCell(cellIdeal);

                        // Imagem gráfico Real
                        iTextSharp.text.Image imgReal = iTextSharp.text.Image.GetInstance(imgPathReal);
                        imgReal.ScaleToFit((doc.PageSize.Width - doc.LeftMargin - doc.RightMargin) / 2 - 10, doc.PageSize.Height / 2);
                        imgReal.Alignment = Element.ALIGN_CENTER;

                        PdfPCell cellReal = new PdfPCell(imgReal);
                        cellReal.Border = PdfPCell.NO_BORDER;
                        cellReal.HorizontalAlignment = Element.ALIGN_CENTER;
                        tabelaGraficos.AddCell(cellReal);

                        // Adiciona a tabela com gráficos ao documento
                        doc.Add(tabelaGraficos);

                        // Fecha documento
                        doc.Close();

                        // Apaga arquivos temporários
                        if (System.IO.File.Exists(imgPathIdeal)) System.IO.File.Delete(imgPathIdeal);
                        if (System.IO.File.Exists(imgPathReal)) System.IO.File.Delete(imgPathReal);

                        MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
