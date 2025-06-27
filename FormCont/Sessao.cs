using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCont
{
    public static class Sessao
    {
        public static string IdToken { get; set; }
        public static string Uid { get; set; }
        public static string Nome { get; set; }
        public static bool IsAdmin { get; set; }

        public static void Limpar()
        {
            IdToken = null;
            Uid = null;
            Nome = null;
            IsAdmin = false;
        }
    }
}
