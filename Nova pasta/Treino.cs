using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace academia
{
    public partial class Treino : UserControl
    {
        public Treino()
        {
            InitializeComponent();
            
        }

        void CriandoMatricula(string treino, int q)
        {
            using (MySqlConnection conexao = new MySqlConnection(conexaoBanco.ConexaoBanco))
            {
                try
                {
                    conexao.Open();
                    string insert;

                    if (treino == "A")
                        insert = $"INSERT INTO matricula (idAluno, idTreino, dataMatricula) VALUES ({q}, 1, CURDATE())";
                    else if (treino == "B")
                        insert = $"INSERT INTO matricula (idAluno, idTreino, dataMatricula) VALUES ({q}, 2, CURDATE())";
                    else
                        insert = $"INSERT INTO matricula (idAluno, idTreino, dataMatricula) VALUES ({q}, 3, CURDATE())";

                    using (MySqlCommand comandosql = new MySqlCommand(insert, conexao))
                    {
                        comandosql.ExecuteNonQuery();
                        MessageBox.Show("Matrícula Realizada!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar matrícula: {ex.Message}");
                }
            }
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BotaoTreinoA_Click(object sender, EventArgs e)
        {
            validacao validacao = new validacao();
            int q;
            q = validacao.obterIdAluno();
            string treino = "A";
            CriandoMatricula(treino, q);

        }

        private void botaoTreinoB_Click(object sender, EventArgs e)
        {
            validacao validacao = new validacao();
            int q;

            q = validacao.obterIdAluno();
            string treino = "B";
            CriandoMatricula(treino, q);
        }

        private void BotaoTreinoC_Click(object sender, EventArgs e)
        {
            validacao validacao = new validacao();
            int q;

            q = validacao.obterIdAluno();
            string treino = "C";
            CriandoMatricula(treino, q);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
