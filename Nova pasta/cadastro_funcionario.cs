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

namespace academia
{
    public partial class cadastro_funcionario : Form
    {
        public cadastro_funcionario()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // if para saber se os campos estão vazios
                if (txtNome.Text != ("") && txtSenha.Text != ("") && txtEmail.Text != ("") && txtSalario.Text !=("")
                    && txtTelefone.Text !=(""))
                {

                    //if para saber se email é válido
                    if (validacaoEmail(txtEmail.Text))
                    {
                        //objeto do tipo  funcionario
                        funcionario cadastrofun = new funcionario();
                        cadastrofun.Nome = txtNome.Text;
                        cadastrofun.Senha = txtSenha.Text;
                        cadastrofun.Email = txtEmail.Text;
                        cadastrofun.Salario = float.Parse(txtSalario.Text);
                        cadastrofun.Telefone = txtTelefone.Text;

                        //if para saber qual profissão a pessoa escolheu
                        if (radioPersonal.Checked) cadastrofun.Profissao = "Personal";
                        else cadastrofun.Profissao = "Recepcionista";


                        if (cadastrofun.cadastrofun())
                        {
                            //Da clear em tudo, não precisa, mas, deixa ai
                            txtNome.Clear();
                            txtSenha.Clear();

                            txtNome.Focus();

                            //Depois tenho que mandar ele para a página principal
                            //mandando ele para a página principal
                            var principal = new Principal_funcionario();
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
                        txtTelefone.Clear();
                    }
                



                }
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                    txtNome.Clear();
                    txtSenha.Clear();
                    txtNome.Focus();
                    txtEmail.Clear();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no  cadastro" + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cadastro_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void cadastro_funcionario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cadastro_funcionario_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
