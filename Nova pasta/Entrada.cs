using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace academia
{
    public partial class Entrada : UserControl
    {
        public Entrada()
        {
            InitializeComponent();


            lstContatos.View = View.Details;
            lstContatos.LabelEdit = true;
            lstContatos.AllowColumnReorder = true;
            lstContatos.FullRowSelect = true;
            lstContatos.GridLines = true;

            lstContatos.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Plano", 100, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Data de Nascimento", 100, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Telefone", 100, HorizontalAlignment.Left);

            MostraContatos();

          
        }

        void MostraContatos()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco.ConexaoBanco);
            try
            {
                var sql = "SELECT idAluno, nome, email, idPlano, dataNascimento, telefone FROM aluno";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                lstContatos.Items.Clear();

                while (reader.Read())
                {
                    var item = new ListViewItem(reader["idAluno"].ToString());
                    item.SubItems.Add(reader["nome"].ToString());
                    item.SubItems.Add(reader["email"].ToString());
                    item.SubItems.Add(reader["idPlano"].ToString());
                    item.SubItems.Add(reader["dataNascimento"].ToString());
                    item.SubItems.Add(reader["telefone"].ToString());
                    lstContatos.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        void CriandoPagamento()
        {
            MySqlConnection teste = new MySqlConnection(conexaoBanco.ConexaoBanco);
            teste.Open();
            try
            {
                string q = txtID.Text;

                if (radioBronze.Checked)
                {
                    string insert = $"INSERT INTO pagamento (idAluno, valor, dataPagamento, formaPagamento) VALUES ({q}, 119.90, CURDATE(), 'Dinheiro vivo')";

                    MySqlCommand comandosql = teste.CreateCommand();
                    comandosql.CommandText = insert;

                    comandosql.ExecuteNonQuery();

                    MessageBox.Show("Pagamento realizado com Sucesso!");
                }
                else
                {
                    string insert = $"INSERT INTO pagamento (idAluno, valor, dataPagamento, formaPagamento) VALUES ({q}, 89.90, CURDATE(), 'Dinheiro vivo')";

                    MySqlCommand comandosql = teste.CreateCommand();
                    comandosql.CommandText = insert;

                    comandosql.ExecuteNonQuery();

                    MessageBox.Show("Pagamento realizado com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar o pagamento: " + ex.Message);
            }
            finally
            {
                teste.Close();
            }
        }

        void AdicionaPlano()
        {

            MySqlConnection conexao = new MySqlConnection(conexaoBanco.ConexaoBanco);
            try
            {
                if (radioBronze.Checked)
                {

                    //q server para guarda o id
                    var q = txtID.Text;

                    //comando que vai ser executado no Mysql
                    var sql = "UPDATE aluno SET idPlano = 1 WHERE idAluno = " + q;

                    //criação do comando 
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    //abrir conexão
                    conexao.Open();

                    //execussão do comando
                    comando.ExecuteNonQuery();


                }
                else
                {
                    //q server para guarda o id
                    var q = txtID.Text;

                    //comando que vai ser executado no Mysql
                    var sql = "UPDATE aluno SET idPlano = 2 WHERE idAluno = " + q;

                    //criação do comando
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    //abrir conexão
                    conexao.Open();

                    //execussão do comando
                    comando.ExecuteNonQuery();

                }


            }
            catch
            {

            }
            finally
            {
                conexao.Close();
            }

        }

        void BuscarContatoos()
        {

            MySqlConnection conexao = new MySqlConnection(conexaoBanco.ConexaoBanco);
            try
            {
                //q serve para gurdar o txt do procurar 
                var q = "'%" + txtProcurar.Text + "%'";

                // sql é o comando que será execultado
                var sql = "SELECT idAluno, nome, email, idPlano, dataNascimento, telefone FROM aluno WHERE nome LIKE " + q + "OR email LIKE " + q;

                //criação do comando
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //conexao aberta
                conexao.Open();

                //execussão do comando
                MySqlDataReader reader = comando.ExecuteReader();
                lstContatos.Items.Clear();
                while (reader.Read())
                {

                    var item = new ListViewItem(reader["idAluno"].ToString());
                    item.SubItems.Add(reader["nome"].ToString());
                    item.SubItems.Add(reader["email"].ToString());
                    item.SubItems.Add(reader["idPlano"].ToString());
                    item.SubItems.Add(reader["dataNascimento"].ToString());
                    item.SubItems.Add(reader["telefone"].ToString());
                    lstContatos.Items.Add(item);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }


        private void botaoPlano_Click(object sender, EventArgs e)
        {
            AdicionaPlano();
            MostraContatos();
            CriandoPagamento();
        }

        private void BotaoProcura_Click(object sender, EventArgs e)
        {
            BuscarContatoos();
        }

        private void Entrada_Load(object sender, EventArgs e)
        {

        }
    }
}
