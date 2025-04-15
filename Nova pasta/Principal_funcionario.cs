using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace academia
{
    public partial class Principal_funcionario : Form
    {
        public Principal_funcionario()
        {
            InitializeComponent();

            contador = 1;
            PanelMenu.Visible = false;
            entrada1.BringToFront();
        }
        int contador;

        private void Principal_funcionario_Load(object sender, EventArgs e)
        {

        }


        private void PanelSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelSair_MouseHover(object sender, EventArgs e)
        {
            PanelSair.BackColor = Color.LightGreen;
        }

        private void PanelSair_MouseLeave(object sender, EventArgs e)
        {
            PanelSair.BackColor = Color.Gainsboro;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            PanelSair.BackColor = Color.LightGreen;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            PanelSair.BackColor = Color.Gainsboro;
        }

        private void panel11_MouseHover(object sender, EventArgs e)
        {
            PanelSair.BackColor = Color.LightGreen;
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            PanelSair.BackColor = Color.Gainsboro;
        }

        private void IconMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IconMenu_Click(object sender, EventArgs e)
        {
            if (contador % 2 == 0)
            {
                PanelMenu.Visible = false;
                contador++;
            }
            else
            {
                PanelMenu.Visible = true;
                contador++;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            entrada1.BringToFront();
        }

        private void foraPagamento_MouseHover(object sender, EventArgs e)
        {
            foraPagamento.BackColor = Color.LightGreen;
        }

        private void foraPagamento_MouseLeave(object sender, EventArgs e)
        {
            foraPagamento.BackColor = Color.Gainsboro;
        }

        private void textPagamento_MouseHover(object sender, EventArgs e)
        {
            foraPagamento.BackColor = Color.LightGreen;
        }

        private void textPagamento_MouseLeave(object sender, EventArgs e)
        {
            foraPagamento.BackColor = Color.Gainsboro;
        }

        private void iconPagamento_MouseHover(object sender, EventArgs e)
        {
            foraPagamento.BackColor = Color.LightGreen;
        }

        private void iconPagamento_MouseLeave(object sender, EventArgs e)
        {
            foraPagamento.BackColor = Color.Gainsboro;
        }

        private void ForaHome_MouseHover(object sender, EventArgs e)
        {
            ForaHome.BackColor = Color.LightGreen;
        }

        private void ForaHome_MouseLeave(object sender, EventArgs e)
        {
            ForaHome.BackColor = Color.Gainsboro;
        }

        private void textHome_MouseHover(object sender, EventArgs e)
        {
            ForaHome.BackColor = Color.LightGreen;
        }

        private void textHome_MouseLeave(object sender, EventArgs e)
        {
            ForaHome.BackColor = Color.Gainsboro;
        }

        private void iconHome_MouseHover(object sender, EventArgs e)
        {
            ForaHome.BackColor = Color.LightGreen;
        }

        private void iconHome_MouseLeave(object sender, EventArgs e)
        {
            ForaHome.BackColor = Color.Gainsboro;
        }

        private void BotaoProcura_Click(object sender, EventArgs e)
        {

        }

        private void ForaHome_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void iconHome_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void foraPagamento_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textPagamento_Click(object sender, EventArgs e)
        {
            pagamentocs1.BringToFront();
        }

        private void iconPagamento_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void foraPagamento_Click(object sender, EventArgs e)
        {
            pagamentocs1.BringToFront();
        }

        private void iconHome_Click(object sender, EventArgs e)
        {
            pagamentocs1.BringToFront();
        }

        private void ForaHome_Click(object sender, EventArgs e)
        {
            entrada1.BringToFront();
        }
    }
}

