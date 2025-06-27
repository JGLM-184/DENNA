using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using Newtonsoft.Json;

namespace FormCont
{
    public partial class GerenciarUsuarios : Form
    {
        public GerenciarUsuarios()
        {
            InitializeComponent();
        }
        private string usuarioSelecionadoUID = null;

        private async void GerenciarUsuarios_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string token = Sessao.IdToken;
                var response = await client.GetAsync($"https://console.firebase.google.com/project/software-denna/database/software-denna-default-rtdb/data/~2F{token}");
                var json = await response.Content.ReadAsStringAsync();

                var dados = JsonConvert.DeserializeObject<Dictionary<string, Usuario>>(json);

                var lista = dados.Select(kv => new
                {
                    UID = kv.Key,
                    Nome = kv.Value.nome,
                    Email = kv.Value.email,
                    Admin = kv.Value.isAdmin
                }).ToList();

                dgvUsuarios.DataSource = lista;
            }
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                usuarioSelecionadoUID = dgvUsuarios.CurrentRow.Cells["UID"].Value.ToString();
                txtNomeGerir.Text = dgvUsuarios.CurrentRow.Cells["Nome"].Value.ToString();
                txtEmailGerir.Text = dgvUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                chkAdminGerir.Checked = (bool)dgvUsuarios.CurrentRow.Cells["Admin"].Value;
                txtSenhaGerir.Enabled = false; // E-mail não pode ser editado
            }
        }

        private async Task AtualizarGrid()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync($"https://SEU_PROJETO.firebaseio.com/usuarios.json?auth={Sessao.IdToken}");
                var json = await response.Content.ReadAsStringAsync();

                var dados = JsonConvert.DeserializeObject<Dictionary<string, Usuario>>(json);
                var lista = dados.Select(kv => new
                {
                    UID = kv.Key,
                    Nome = kv.Value.nome,
                    Email = kv.Value.email,
                    Admin = kv.Value.isAdmin
                }).ToList();

                dgvUsuarios.DataSource = lista;
            }
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para excluir.");
                return;
            }

            string uid = dgvUsuarios.CurrentRow.Cells["UID"].Value.ToString();

            var confirm = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            using (HttpClient client = new HttpClient())
            {
                string url = $"https://console.firebase.google.com/project/software-denna/database/software-denna-default-rtdb/data/~2F{uid}.json?auth={Sessao.IdToken}";
                var response = await client.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuário excluído com sucesso!");
                    await AtualizarGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir usuário.");
                }
            }
        }
    }
}
