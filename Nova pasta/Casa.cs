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
    public partial class Casa : UserControl
    {
        public Casa()
        {
            InitializeComponent();
        }

        void CriandoPagamento(string identificador, int q)
        {
            MySqlConnection teste = new MySqlConnection(conexaoBanco.ConexaoBanco);
            teste.Open();
            try
            {

                if (identificador == "Bronze")
                {
                    string insert = $"INSERT INTO pagamento (idAluno, valor, dataPagamento, formaPagamento) VALUES ({q}, 119.90, CURDATE(), 'PIX')";

                    MySqlCommand comandosql = teste.CreateCommand();
                    comandosql.CommandText = insert;

                    comandosql.ExecuteNonQuery();

                    MessageBox.Show("Pagamento realizado com Sucesso!");
                }
                else
                {
                    string insert = $"INSERT INTO pagamento (idAluno, valor, dataPagamento, formaPagamento) VALUES ({q}, 89.90, CURDATE(), 'PIX')";

                    MySqlCommand comandosql = teste.CreateCommand();
                    comandosql.CommandText = insert;

                    comandosql.ExecuteNonQuery();

                    MessageBox.Show("Pagamento realizado com Sucesso!");
                }
            }
            catch
            {
                MessageBox.Show("Erro ao processar o pagamento: ");
            }
            finally
            {
                teste.Close();
            }
        }

        private void botaoBronze_Click(object sender, EventArgs e)
        {
            try
            {
                int q;

                string plano = "Bronze";

                validacao validacao = new validacao();
                validacao.trocarPlano(plano);
                q = validacao.obterIdAluno();

                CriandoPagamento(plano, q);
            }
            catch 
            {
                MessageBox.Show("Erro no try");
            }
        }
       



        private void botaoOuro_Click(object sender, EventArgs e)
        {
            try
            {
                int q;

                string plano = "Ouro";
                validacao validacao = new validacao();
               q = validacao.obterIdAluno();
                validacao.trocarPlano(plano);
                CriandoPagamento(plano, q);
            }
            catch
            {
                MessageBox.Show("Erro no try");
            }
        }
    }
}
