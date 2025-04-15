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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
           PanelMenu.Visible = false;
            //inicia o contador
            contador = 1;
            //Puxar o casa para frente
            casa1.BringToFront();
        }
        //cria o contador
        int contador;
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            casa1.BringToFront();
        }

        private void PanelIconMenu_Click(object sender, EventArgs e)
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

        private void PanelSair_click(object sender, EventArgs e)
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

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            panel8.BackColor = Color.LightGreen;
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.Gainsboro;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            panel8.BackColor = Color.LightGreen;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.Gainsboro;
        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {
            panel8.BackColor = Color.LightGreen;
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.Gainsboro;
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = Color.LightGreen;
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor= Color.Gainsboro;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = Color.LightGreen;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Gainsboro;
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = Color.LightGreen;
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.Gainsboro;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel8_Click(object sender, EventArgs e)
        {

            treino1.BringToFront();
        }

        private void treino1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            treino1.BringToFront();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            treino1.BringToFront();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            casa1.BringToFront();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            casa1.BringToFront();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
          
        }
    }
}
