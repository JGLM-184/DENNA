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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace FormCont
{
    public partial class RelatoriosES : Form
    {

        public RelatoriosES()
        {
            InitializeComponent();
            rdbMes.Checked = false;
            rdbPeriodo.Checked = false;
            toolTip1.SetToolTip(btnLimpar, "Limpar");


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
tabelaRelatorio.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

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


        private void btExportar_Click(object sender, EventArgs e)
        {
            if (tabelaRelatorio.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para exportar.");
                return;
            }

            // Gera nome automático com data atual
            string nomeArquivo = $"RelatorioES_{DateTime.Now:yyyy-MM-dd}.pdf";

            SaveFileDialog salvar = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Salvar Relatório em PDF",
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

                        // Fonte para o título e cabeçalho
                        var fonteTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
                        var fonteCabecalho = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                        var fonteCelula = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.NORMAL);

                        // Título centralizado
                        Paragraph titulo = new Paragraph("Relatório de Entrada e Saída", fonteTitulo);
                        titulo.Alignment = Element.ALIGN_CENTER;
                        titulo.SpacingAfter = 20f;
                        doc.Add(titulo);

                        // Tabela PDF
                        PdfPTable tabelaPDF = new PdfPTable(tabelaRelatorio.Columns.Count);
                        tabelaPDF.WidthPercentage = 100;

                        // Cabeçalhos
                        foreach (DataGridViewColumn col in tabelaRelatorio.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, fonteCabecalho));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            tabelaPDF.AddCell(cell);
                        }

                        // Dados
                        foreach (DataGridViewRow row in tabelaRelatorio.Rows)
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
                        doc.Close();
                    }

                    MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tabelaRelatorio.DataSource = null;
            tabelaRelatorio.Rows.Clear();
            txtCodigoBusca.Clear();
            rdbMes.Checked = false;
            rdbPeriodo.Checked = false;
        }
    }
}
