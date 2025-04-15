using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia
{
    public partial class cadastro_cliente : Form
    {
        public cadastro_cliente()
        {
            InitializeComponent();
        }
        public bool validacaoEmail(string email)
        {
            try
            {
                var enderecoEmail = new System.Net.Mail.MailAddress(email);
                return enderecoEmail.Address == email;
            }
            catch
            {

                return false;
            }
        }

        private void cadastrarbotao_Click(object sender, EventArgs e)
        {
            try
            {
                // if para saber se os campos estão vazios
                if (txtNome.Text != ("") && txtSenha.Text != ("") && txtEmail.Text != ("") 
                    && txtNacimento.Text != (""))
                {

                    //if para saber se email é válido
                    if (validacaoEmail(txtEmail.Text))
                    {
                        //objeto do tipo  funcionario
                        Aluno cadastroAluno = new Aluno();
                        cadastroAluno.Nome = txtNome.Text;
                        cadastroAluno.Senha = txtSenha.Text;
                        cadastroAluno.Email = txtEmail.Text;
                        cadastroAluno.Nacimento = txtNacimento.Text;
                        cadastroAluno.Telefone = int.Parse(txtTelefone.Text);
                        



                        if (cadastroAluno.cadastroaluno())
                        {
                            //Da clear em tudo, não precisa, mas, deixa ai
                            txtNome.Clear();
                            txtSenha.Clear();
                            txtNome.Focus();

                            //Depois tenho que mandar ele para a página principal
                            //mandando ele para a página principal
                            var principal = new Principal();
                            principal.Show();
                            this.Visible = false;

                        }
                        else
                        {
                            MessageBox.Show("Erro na hora do cadastro");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Email errado!");
                        txtNome.Clear();
                        txtSenha.Clear();
                        txtNome.Focus();
                        txtEmail.Clear();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Try está errado");
            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
