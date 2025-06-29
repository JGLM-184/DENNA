using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.VisualBasic;

namespace FormCont
{
    public partial class CadastroUsuario : Form
    {
        private const string ApiKey = "AIzaSyA2_x3oCuC5114s757zM_sHFTwF1QUNMpw"; // 🔁 sua API key
        private const string FirebaseBaseUrl = "https://software-denna-default-rtdb.firebaseio.com"; // 🔁 seu banco

        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCadastro.Text.Trim();
            string email = txtEmailCadastro.Text.Trim();
            string senha = txtSenhaCadastro.Text;
            bool isAdmin = chkAdm.Checked;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (isAdmin)
            {
                string senhaMestre = Interaction.InputBox("Digite a senha de administrador:", "Confirmação de administrador", "");

                if (senhaMestre != "agentepet")
                {
                    MessageBox.Show("Senha de administrador incorreta. Cadastro como administrador negado.");
                    return;
                }
            }

            try
            {
                var cadastroResponse = await CadastrarUsuarioAsync(email, senha);
                if (cadastroResponse != null)
                {
                    await SalvarDadosExtras(cadastroResponse.localId, cadastroResponse.idToken, nome, isAdmin);
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário. Tente novamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}");
            }
        }

        public class FirebaseCadastroResponse
        {
            public string idToken { get; set; }
            public string localId { get; set; }
        }

        private async Task<FirebaseCadastroResponse> CadastrarUsuarioAsync(string email, string senha)
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
                    $"https://identitytoolkit.googleapis.com/v1/accounts:signUp?key={ApiKey}", content);

                var json = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<FirebaseCadastroResponse>(json);
                }
                else
                {
                    dynamic erro = JsonConvert.DeserializeObject(json);
                    string mensagemErro = erro?.error?.message ?? "Erro desconhecido.";

                    // Tradução simples das mensagens mais comuns
                    switch (mensagemErro)
                    {
                        case "EMAIL_EXISTS":
                            mensagemErro = "Este e-mail já está cadastrado.";
                            break;
                        case "INVALID_EMAIL":
                            mensagemErro = "E-mail inválido.";
                            break;
                        case "WEAK_PASSWORD : Password should be at least 6 characters":
                        case "WEAK_PASSWORD":
                            mensagemErro = "A senha deve ter pelo menos 6 caracteres.";
                            break;
                        case "OPERATION_NOT_ALLOWED":
                            mensagemErro = "Cadastro por e-mail/senha não está ativado no Firebase.";
                            break;
                    }

                    MessageBox.Show($"Erro ao cadastrar: {mensagemErro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private async Task SalvarDadosExtras(string uid, string token, string nome, bool isAdmin)
        {
            var dados = new
            {
                nome = nome,
                isAdmin = isAdmin
            };

            var content = new StringContent(JsonConvert.SerializeObject(dados), Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                string url = $"{FirebaseBaseUrl}/usuarios/{uid}.json?auth={token}";
                await client.PutAsync(url, content);
            }
        }
    }
}
