namespace academia
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelSair = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelIconMenu = new System.Windows.Forms.Panel();
            this.treino1 = new academia.Treino();
            this.casa1 = new academia.Casa();
            this.PanelMenu.SuspendLayout();
            this.PanelSair.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelMenu.Controls.Add(this.PanelSair);
            this.PanelMenu.Controls.Add(this.panel8);
            this.PanelMenu.Controls.Add(this.panel6);
            this.PanelMenu.Location = new System.Drawing.Point(-1, 64);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(263, 654);
            this.PanelMenu.TabIndex = 0;
            // 
            // PanelSair
            // 
            this.PanelSair.Controls.Add(this.label3);
            this.PanelSair.Controls.Add(this.panel11);
            this.PanelSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSair.Location = new System.Drawing.Point(3, 204);
            this.PanelSair.Name = "PanelSair";
            this.PanelSair.Size = new System.Drawing.Size(260, 73);
            this.PanelSair.TabIndex = 2;
            this.PanelSair.Click += new System.EventHandler(this.PanelSair_click);
            this.PanelSair.MouseLeave += new System.EventHandler(this.PanelSair_MouseLeave);
            this.PanelSair.MouseHover += new System.EventHandler(this.PanelSair_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "SAIR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::academia.Properties.Resources.sair;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel11.Location = new System.Drawing.Point(13, 15);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(73, 47);
            this.panel11.TabIndex = 0;
            this.panel11.Click += new System.EventHandler(this.panel11_Click);
            this.panel11.MouseLeave += new System.EventHandler(this.panel11_MouseLeave);
            this.panel11.MouseHover += new System.EventHandler(this.panel11_MouseHover);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel8.Location = new System.Drawing.Point(3, 114);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(260, 73);
            this.panel8.TabIndex = 1;
            this.panel8.Click += new System.EventHandler(this.panel8_Click);
            this.panel8.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            this.panel8.MouseHover += new System.EventHandler(this.panel8_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "TREINO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::academia.Properties.Resources.treinamento;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Location = new System.Drawing.Point(13, 16);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(73, 47);
            this.panel9.TabIndex = 0;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            this.panel9.MouseLeave += new System.EventHandler(this.panel9_MouseLeave);
            this.panel9.MouseHover += new System.EventHandler(this.panel9_MouseHover);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(0, 18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(263, 73);
            this.panel6.TabIndex = 0;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            this.panel6.MouseLeave += new System.EventHandler(this.panel6_MouseLeave);
            this.panel6.MouseHover += new System.EventHandler(this.panel6_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CASA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::academia.Properties.Resources.home;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(13, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(73, 47);
            this.panel7.TabIndex = 0;
            this.panel7.Click += new System.EventHandler(this.panel7_Click);
            this.panel7.MouseLeave += new System.EventHandler(this.panel7_MouseLeave);
            this.panel7.MouseHover += new System.EventHandler(this.panel7_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.PanelIconMenu);
            this.panel2.Location = new System.Drawing.Point(-1, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 70);
            this.panel2.TabIndex = 1;
            // 
            // PanelIconMenu
            // 
            this.PanelIconMenu.BackgroundImage = global::academia.Properties.Resources.menu;
            this.PanelIconMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelIconMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelIconMenu.Location = new System.Drawing.Point(13, 11);
            this.PanelIconMenu.Name = "PanelIconMenu";
            this.PanelIconMenu.Size = new System.Drawing.Size(50, 46);
            this.PanelIconMenu.TabIndex = 0;
            this.PanelIconMenu.Click += new System.EventHandler(this.PanelIconMenu_Click);
            this.PanelIconMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // treino1
            // 
            this.treino1.Location = new System.Drawing.Point(502, 98);
            this.treino1.Name = "treino1";
            this.treino1.Size = new System.Drawing.Size(628, 600);
            this.treino1.TabIndex = 9;
            // 
            // casa1
            // 
            this.casa1.Location = new System.Drawing.Point(518, 98);
            this.casa1.Name = "casa1";
            this.casa1.Size = new System.Drawing.Size(602, 607);
            this.casa1.TabIndex = 10;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 717);
            this.Controls.Add(this.casa1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.treino1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal_cliente";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelSair.ResumeLayout(false);
            this.PanelSair.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelIconMenu;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel PanelSair;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Treino treino1;
        private Casa casa1;
    }
}