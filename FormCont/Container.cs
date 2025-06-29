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
        CadastroMercadoria cadastro_merc;
        RelatoriosES relatorios;
        CurvaABC curva;
        RegistrarEntrada registrar;



        //altera a cor de fundo do formulário container/menu para a cor branca
        public Container()
        {
            InitializeComponent();

            this.FormClosing += Container_FormClosing;


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
                cadastro_merc = new CadastroMercadoria();
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

        //inicializar Relatório de entrada e saída
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

        //Inicializar relatório de curva ABC
        private void btCurvaABC_Click(object sender, EventArgs e)
        {
            if (curva == null)
            {
                curva = new CurvaABC();
                curva.FormClosed += Curva_FormClosed;
                curva.MdiParent = this;
                curva.Dock = DockStyle.Fill;
                curva.Show();
            }
            else
            {
                curva.Activate();
            }
        }
        private void Curva_FormClosed(object sender, FormClosedEventArgs e)
        {
            curva = null;
        }

        //Inicializar tela de registro de entrada
        private void bt_nt_entrada_Click(object sender, EventArgs e)
        {
            if (registrar == null)
            {
                registrar = new RegistrarEntrada();
                registrar.FormClosed += Registrar_FormClosed;
                registrar.MdiParent = this;
                registrar.Dock = DockStyle.Fill;
                registrar.Show();
            }
            else
            {
                registrar.Activate();
            }
        }
        private void Registrar_FormClosed(object sender, FormClosedEventArgs e)

        {
            registrar = null;
        }

        //Confirmação para fechar
        private void Container_FormClosing(object sender, FormClosingEventArgs e)
        {
            var confirmar = MessageBox.Show(
                "Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }

}