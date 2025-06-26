using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            MysqlConexaoBanco.Open();

            //Inicializando o forms, com a combobox ja tendo
            //todos os formatos preenchidos, sem repetir.

            //COMANDO PARA PESQUISAR TODOS OS FORMATOS E NAO REPETIR
            string query = "SELECT DISTINCT Formato FROM mercadorias";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, MysqlConexaoBanco))
                {
                    
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            cmbForma.Items.Add(reader["Formato"].ToString());
                            //reader["coluna_especificada_da_tabela"]
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar conteudo da Combobox " + ex);
            }
            finally
            {
                MysqlConexaoBanco.Close();
            }

            dateMov.Text = DateTime.Now.ToString();
        } 
               
        private void btRegistrarEntrada_Click(object sender, EventArgs e)
        {
            if (tabela.SelectedRows.Count == 1)
            {
                try
                {

                    var row = tabela.SelectedRows[0];
                    string codigo = row.Cells["ID"].Value.ToString();

                    using (MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.conexaoBd))
                    {
                        MysqlConexaoBanco.Open();

                        string insert = @"INSERT INTO movimentos_estoque 
                            (codigo_mercadoria , tipo_movimento, quantidade, 
                                preco_unitario_movimento , data_hora_movimento , observacoes) 
                            VALUES 
                            (@Codigo_mercadoria , @Tipo_movimento , @Quantidade ,
                             @Preco_unitario_movimento , @Data_hora_movimento , @Obs)";

                        using (MySqlCommand comandoSql = new MySqlCommand(insert, MysqlConexaoBanco))
                        {

                            comandoSql.Parameters.AddWithValue("@Codigo_mercadoria", tabela.SelectedCells[0].Value.ToString());

                            if (rdEntrada.Checked)
                            {
                                comandoSql.Parameters.AddWithValue("@Tipo_movimento", rdEntrada.Text.ToString());
                            }
                            else
                                comandoSql.Parameters.AddWithValue("@Tipo_movimento", rdSaida.Text.ToString());

                            comandoSql.Parameters.AddWithValue("@Quantidade", quantMov.Text.ToString());
                            comandoSql.Parameters.AddWithValue("@Preco_unitario_movimento", Double.Parse(precUnimov.Text.ToString()));
                            comandoSql.Parameters.AddWithValue("@Data_hora_movimento", DateTime.Now);
                            comandoSql.Parameters.AddWithValue("@Obs", obsMov.Text.ToString());


                            comandoSql.ExecuteNonQuery();
                            MessageBox.Show("Registro de Movimento realizado com Sucesso."); //Possivel label ?
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Registrar Movimento: " + ex.Message);
                }
                finally
                {
                    MysqlConexaoBanco.Close();
                }
            }
        }

        private void btDesmarcar_Click(object sender, EventArgs e)
        {
            dateMov.Text = DateTime.Now.ToString();

        }

        private void btPesquisar_Click_1(object sender, EventArgs e)
        {
            string buscaCod = txt1.Text.Trim();
            string buscaTip = txt2.Text.Trim();
            string buscaMarc = txt3.Text.Trim();
            string buscaForma = cmbForma.Text.Trim();

            Mercadoria buscarReg = new Mercadoria();

            try
            {
                buscarReg.PesquisaReg(MysqlConexaoBanco, tabela, buscaCod, buscaTip, buscaMarc, buscaForma);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro " + ex);
            }
        }
    }
 }