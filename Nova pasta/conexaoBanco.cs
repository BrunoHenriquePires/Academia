using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academia
{
    static class conexaoBanco
    {
        //começando a conexão do banco

        private const string servidor = "localhost";
        private const string bancoDados = "academia";
        private const string usuario = "root";
        private const string senha = "Bruno";

        //declara a conexão ao banco 

        static public string ConexaoBanco = $"server={servidor}; user id={usuario}; database={bancoDados}; password={senha}";

    }
}
