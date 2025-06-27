using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FormCont
{
    public partial class Login : KryptonForm
    {
        private Container container;

        private const string ApiKey = "AIzaSyA2_x3oCuC5114s757zM_sHFTwF1QUNMpw"; // 🔁 Sua API Key do Firebase
        private const string FirebaseBaseUrl = "https://software-denna-default-rtdb.firebaseio.com"; // 🔁 URL do seu Realtime Database

        public Login()
        {
            InitializeComponent();
        }

        public class FirebaseLoginResponse
        {
            public string idToken { get; set; }
            public string localId { get; set; }
            public string email { get; set; }
        }

        private async Task<FirebaseLoginResponse> FazerLoginAsync(string email, string senha)
        {
            var payload = new
            {
                email = email,
                password = senha,
                returnSecureToken = true
            };

            var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsync(
                    $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={ApiKey}", content);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<FirebaseLoginResponse>(json);
                }
                else
                {
                    return null;
                }
            }
        }

        private async Task<bool> VerificarSeAdmin(string uid, string token)
        {
            string url = $"{FirebaseBaseUrl}/usuarios/{uid}/isAdmin.json?auth={token}";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var conteudo = await response.Content.ReadAsStringAsync();
                return conteudo.Contains("true");
            }
        }

        private async Task<string> ObterNomeUsuario(string uid, string token)
        {
            string url = $"{FirebaseBaseUrl}/usuarios/{uid}/nome.json?auth={token}";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                string nome = await response.Content.ReadAsStringAsync();
                return nome.Trim('"'); // remove aspas do JSON
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || email == "Usuário" || senha == "Senha")
            {
                MessageBox.Show("Por favor, preencha o e-mail e a senha corretamente.");
                return;
            }

            try
            {
                var auth = await FazerLoginAsync(email, senha);
                if (auth != null)
                {
                    bool isAdmin = await VerificarSeAdmin(auth.localId, auth.idToken);
                    string nome = await ObterNomeUsuario(auth.localId, auth.idToken);

                    if (isAdmin)
                    {
                        MessageBox.Show($"Bem-vindo, administrador {nome}!");
                    }
                    else
                    {
                        MessageBox.Show($"Bem-vindo(a), {nome}!");
                    }

                    Container container = new Container(nome);

                    // Ao fechar o Container, abrir um novo formulário de login
                    container.FormClosed += (s, args) =>
                    {
                        this.Show(); // Mostra o formulário de login atual, ao invés de fechar
                    };

                    container.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Erro de conexão. Verifique sua internet ou tente novamente mais tarde.");
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("A solicitação demorou muito para responder. Tente novamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}");
            }
        }

        private void linkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroUsuario cadastro = new CadastroUsuario();
            cadastro.FormClosing += (s, args) => this.Show(); // se quiser voltar ao login depois
            cadastro.Show();
            this.Hide();
        }

        private void kryptonTextBox2_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void kryptonTextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.Text = "Senha";
                txtSenha.StateCommon.Content.Color1 = Color.Gray;
            }
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Usuário")
            {
                txtEmail.Text = "";
                txtEmail.StateCommon.Content.Color1 = Color.Black;
            }
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Usuário";
                txtEmail.StateCommon.Content.Color1 = Color.Gray;
            }
        }
    }
}
