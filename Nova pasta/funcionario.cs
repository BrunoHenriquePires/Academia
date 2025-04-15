using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace academia
{
    internal class funcionario
    {
        private string nome;
        private string senha;
        private string profissao;
        private string email;
        private string telefone;
        private float salario;
 
 
 
 
        public string Nome
        {
            get { return nome; }
            set { nome =  value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }



        //método de cadastro de funcionarios

        public bool cadastrofun()
        {
            try
            {

               
                    //conexão ao banco chamando a classe "conexaoBanco" e chamando a conexao do banco o "ConexaoBanco 
                    MySqlConnection MysqlConexao = new MySqlConnection(conexaoBanco.ConexaoBanco);
                    MysqlConexao.Open();

                    string insert = $"insert into funcionario (nome, senha,email,cargo,telefone,salario) values ('{Nome}', '{Senha}', '{Email}', '{Profissao}', '{Telefone}','{Salario}')";

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
