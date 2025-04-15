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
    public partial class pagamentocs : UserControl
    {
        public pagamentocs()
        {
            InitializeComponent();

            lstContatos.View = View.Details;
            lstContatos.LabelEdit = true;
            lstContatos.AllowColumnReorder = true;
            lstContatos.FullRowSelect = true;
            lstContatos.GridLines = true;

            lstContatos.Columns.Add("ID Pagamento", 50, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Id Aluno", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Valor", 150, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Data de Pagamento", 100, HorizontalAlignment.Left);
            lstContatos.Columns.Add("Forma de Pagamento", 100, HorizontalAlignment.Left);

        }

        void MostraContatos()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco.ConexaoBanco);
            try
            {
                var sql = "SELECT * FROM pagamento";
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                conexao.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                lstContatos.Items.Clear();

                while (reader.Read())
                {
                    var item = new ListViewItem(reader["idPagamento"].ToString());
                    item.SubItems.Add(reader["idAluno"].ToString());
                    item.SubItems.Add(reader["valor"].ToString());
                    item.SubItems.Add(reader["dataPagamento"].ToString());
                    item.SubItems.Add(reader["FormaPagamento"].ToString());
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
        void BuscarContatos()
        {

            MySqlConnection conexao = new MySqlConnection(conexaoBanco.ConexaoBanco);
            try
            {
                //q serve para gurdar o txt do procurar 
                var q = "'%" + txtProcura.Text + "%'";

                // sql é o comando que será execultado
                var sql = "SELECT * FROM pagamento WHERE idAluno LIKE " + q;

                //criação do comando
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //conexao aberta
                conexao.Open();

                //execussão do comando
                MySqlDataReader reader = comando.ExecuteReader();
                lstContatos.Items.Clear();
                while (reader.Read())
                {

                    var item = new ListViewItem(reader["idPagamento"].ToString());
                    item.SubItems.Add(reader["idAluno"].ToString());
                    item.SubItems.Add(reader["valor"].ToString());
                    item.SubItems.Add(reader["dataPagamento"].ToString());
                    item.SubItems.Add(reader["FormaPagamento"].ToString());
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


        private void pagamentocs_Load(object sender, EventArgs e)
        {
            MostraContatos();
        }

        private void BotaoProcura_Click(object sender, EventArgs e)
        {
            BuscarContatos();
        }
    }
}
