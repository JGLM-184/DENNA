using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormCont
{
    public partial class RegistrarEntrada : Form
    {
        Mercadoria mercadoria = new Mercadoria();
        DataTable dataTable = new DataTable();
        MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoBd);

        public RegistrarEntrada()
        {
            InitializeComponent();

            txt1.KeyPress += ApenasNumeros_KeyPress;
            quantMov.KeyPress += ApenasNumeros_KeyPress;
            precUnimov.KeyPress += ApenasDecimais_KeyPress;

            CarregarComboboxFormato();

            dateMov.Text = DateTime.Now.ToString();
        }

        private void CarregarComboboxFormato()
        {
            try
            {
                MysqlConexaoBanco.Open();

                string query = "SELECT DISTINCT Formato FROM mercadorias";
                using (MySqlCommand command = new MySqlCommand(query, MysqlConexaoBanco))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    cmbForma.Items.Clear();
                    while (reader.Read())
                    {
                        cmbForma.Items.Add(reader["Formato"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar conteúdo da Combobox: " + ex.Message);
            }
            finally
            {
                MysqlConexaoBanco.Close();
            }
        }

        private void btPesquisar_Click_1(object sender, EventArgs e)
        {
            string buscaCod = txt1.Text.Trim();
            string buscaTip = txt2.Text.Trim();
            string buscaMarc = txt3.Text.Trim();
            string buscaForma = cmbForma.Text.Trim();

            try
            {
                mercadoria.PesquisaReg(MysqlConexaoBanco, tabela, buscaCod, buscaTip, buscaMarc, buscaForma);
                tabela.EnableHeadersVisualStyles = false;
                tabela.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                // Oculta a coluna ID após popular o DataGridView
                if (tabela.Columns.Contains("ID"))
                {
                    tabela.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btRegistrarEntrada_Click(object sender, EventArgs e)
        {
            if (tabela.SelectedRows.Count == 1)
            {
                MySqlConnection MysqlConexaoBanco = null;

                try
                {
                    var row = tabela.SelectedRows[0];

                    // Use o nome correto da coluna para pegar o código da mercadoria
                    string codigo = row.Cells["codigo"].Value.ToString();

                    MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoBd);
                    MysqlConexaoBanco.Open();

                    string insert = @"INSERT INTO movimentos_estoque 
                    (codigo_mercadoria, tipo_movimento, quantidade, 
                     preco_unitario_movimento, data_hora_movimento, observacoes) 
                    VALUES 
                    (@Codigo_mercadoria, @Tipo_movimento, @Quantidade,
                     @Preco_unitario_movimento, @Data_hora_movimento, @Obs)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, MysqlConexaoBanco))
                    {
                        comandoSql.Parameters.AddWithValue("@Codigo_mercadoria", codigo);

                        string tipoMovimento = rdEntrada.Checked ? "ENTRADA" : "SAIDA"; // Melhor usar valores fixos
                        comandoSql.Parameters.AddWithValue("@Tipo_movimento", tipoMovimento);

                        comandoSql.Parameters.AddWithValue("@Quantidade", int.Parse(quantMov.Text));
                        comandoSql.Parameters.AddWithValue("@Preco_unitario_movimento", double.Parse(precUnimov.Text));
                        comandoSql.Parameters.AddWithValue("@Data_hora_movimento", DateTime.Now);
                        comandoSql.Parameters.AddWithValue("@Obs", obsMov.Text.Trim());

                        comandoSql.ExecuteNonQuery();

                        MessageBox.Show("Registro de Movimento realizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Registrar Movimento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (MysqlConexaoBanco != null && MysqlConexaoBanco.State == ConnectionState.Open)
                        MysqlConexaoBanco.Close();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha da tabela para registrar a entrada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btDesmarcar_Click(object sender, EventArgs e)
        {
            dateMov.Text = DateTime.Now.ToString();
        }

        //Máscara número inteiro
        private void ApenasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        //Máscara número decimal
        private void ApenasDecimais_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permitir números, vírgula, ponto e backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            // Impede mais de uma vírgula
            if (e.KeyChar == ',' && txt.Text.Contains(","))
                e.Handled = true;
        }
    }
}
