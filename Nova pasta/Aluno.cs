using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace academia
{
    internal class Aluno
    {
        private string nome;
        private string senha;
        private string email;
        private string nacimento;
        private int telefone;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Nacimento
        {
            get { return nacimento; }
            set { nacimento = value; }
        }
        public int Telefone
        {
            get { return telefone; }
            set {  telefone = value; }
        }



        //método de cadastro de funcionarios

        public bool cadastroaluno()
        {
            try
            {
                //conexão ao banco chamando a classe "conexaoBanco" e chamando a conexao do banco o "ConexaoBanco 
                MySqlConnection MysqlConexao = new MySqlConnection(conexaoBanco.ConexaoBanco);
                MysqlConexao.Open();

                string insert = $"insert into aluno (nome, senha,email,dataNascimento, telefone) values ('{Nome}', '{Senha}', '{Email}','{Nacimento}','{Telefone}')";

                //criação da variavel de comando do sql
                MySqlCommand comandosql = MysqlConexao.CreateCommand();
                comandosql.CommandText = insert;

                comandosql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //erro do try
                MessageBox.Show("Erro no banco de dados" + ex.Message);
                return false;
            }
        }
    }
}
