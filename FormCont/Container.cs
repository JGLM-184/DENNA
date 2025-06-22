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
    public partial class Container : Form
    {
        //objetos
        ControleEstoque controle_estoque;
        CadastroMerc cadastro_merc;
        RelatoriosES relatorios;
        

        //altera a cor de fundo do formulário container/menu para a cor branca
        public Container()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }
        }

        //inicializar Cadastro de Mercadorias
        private void bt_cadastro_merc_Click(object sender, EventArgs e)
        {
            if (cadastro_merc == null)
            {
                cadastro_merc = new CadastroMerc();
                cadastro_merc.FormClosed += CadastroMerc_FormClosed;
                cadastro_merc.MdiParent = this;
                cadastro_merc.Dock = DockStyle.Fill;
                cadastro_merc.Show();
            }
            else
            {
                cadastro_merc.Activate();
            }
        }

        private void CadastroMerc_FormClosed(object sender, FormClosedEventArgs e)

        {
            cadastro_merc = null;
        }

        //inicializar formulário de Controle de Estoque
        private void bt_controle_estoque_Click(object sender, EventArgs e)
        {

            if (controle_estoque == null)
            {
                controle_estoque = new ControleEstoque();
                controle_estoque.FormClosed += ControleEstoque_FormClosed;
                controle_estoque.MdiParent = this;
                controle_estoque.Dock = DockStyle.Fill;
                controle_estoque.Show();
            }
            else
            {
                controle_estoque.Activate();
            }
        }

        private void ControleEstoque_FormClosed(object sender, FormClosedEventArgs e)

        {
            controle_estoque = null;
        }

        //inicializar Relatórios
        private void bt_relatorios_Click(object sender, EventArgs e)
        {
            if (relatorios == null)
            {
                relatorios = new RelatoriosES();
                relatorios.FormClosed += Relatorios_FormClosed;
                relatorios.MdiParent = this;
                relatorios.Dock = DockStyle.Fill;
                relatorios.Show();
            }
            else
            {
                relatorios.Activate();
            }
        }
        private void Relatorios_FormClosed(object sender, FormClosedEventArgs e)

        {
            relatorios = null;
        }

        //botão para deslogar e voltar à tela de login
        private void bt_deslogar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário container

        }

        //botão para fechar a aplicação
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bt_deslogar_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_configuracoes_Click(object sender, EventArgs e)
        {

        }
    }
}