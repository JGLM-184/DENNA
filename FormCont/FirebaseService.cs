using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FormCont
{
    internal class FirebaseService
    {
        public async Task<string> ObterNomeUsuario(string uid, string idToken)
        {
            string url = $"https://console.firebase.google.com/project/software-denna/authentication/users{uid}/nome.json?auth={idToken}";

            using (var client = new HttpClient())
            {
                var resposta = await client.GetAsync(url);
                string nome = await resposta.Content.ReadAsStringAsync();
                return nome.Trim('\"');
            }
        }
    }
}
