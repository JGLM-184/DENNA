using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCont
{
    static class ConexaoBanco
    {
        //4 variáveis declaradaas passando as informações do banco de dados
        private const string servidor = "localhost";
        private const string bancoDados = "estoque";
        private const string usuario = "root";
        private const string senha = "1234";
        private const string port = "3306";

        //declarando variavel conexaoBd para fazer a conexão do banco de dados
        static public string conexaoBd = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}; port={port};";

    }
}
