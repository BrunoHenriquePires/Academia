namespace academia
{
    partial class Principal_funcionario
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.IconMenu = new System.Windows.Forms.Panel();
            this.PanelIconMenu = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ForaHome = new System.Windows.Forms.Panel();
            this.textHome = new System.Windows.Forms.Label();
            this.iconHome = new System.Windows.Forms.Panel();
            this.foraPagamento = new System.Windows.Forms.Panel();
            this.textPagamento = new System.Windows.Forms.Label();
            this.iconPagamento = new System.Windows.Forms.Panel();
            this.PanelSair = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pagamentocs1 = new academia.pagamentocs();
            this.entrada1 = new academia.Entrada();
            this.panel2.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.ForaHome.SuspendLayout();
            this.foraPagamento.SuspendLayout();
            this.PanelSair.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.IconMenu);
            this.panel2.Controls.Add(this.PanelIconMenu);
            this.panel2.Location = new System.Drawing.Point(-67, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 80);
            this.panel2.TabIndex = 2;
            // 
            // IconMenu
            // 
            this.IconMenu.BackgroundImage = global::academia.Properties.Resources.menu;
            this.IconMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMenu.Location = new System.Drawing.Point(95, 13);
            this.IconMenu.Name = "IconMenu";
            this.IconMenu.Size = new System.Drawing.Size(50, 46);
            this.IconMenu.TabIndex = 1;
            this.IconMenu.Click += new System.EventHandler(this.IconMenu_Click);
            this.IconMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.IconMenu_Paint);
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
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelMenu.Controls.Add(this.ForaHome);
            this.PanelMenu.Controls.Add(this.foraPagamento);
            this.PanelMenu.Controls.Add(this.PanelSair);
            this.PanelMenu.Location = new System.Drawing.Point(0, 77);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(275, 623);
            this.PanelMenu.TabIndex = 3;
            // 
            // ForaHome
            // 
            this.ForaHome.Controls.Add(this.textHome);
            this.ForaHome.Controls.Add(this.iconHome);
            this.ForaHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForaHome.Location = new System.Drawing.Point(3, 8);
            this.ForaHome.Name = "ForaHome";
            this.ForaHome.Size = new System.Drawing.Size(263, 73);
            this.ForaHome.TabIndex = 5;
            this.ForaHome.Click += new System.EventHandler(this.ForaHome_Click);
            this.ForaHome.Paint += new System.Windows.Forms.PaintEventHandler(this.ForaHome_Paint);
            this.ForaHome.MouseLeave += new System.EventHandler(this.ForaHome_MouseLeave);
            this.ForaHome.MouseHover += new System.EventHandler(this.ForaHome_MouseHover);
            // 
            // textHome
            // 
            this.textHome.AutoSize = true;
            this.textHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHome.Location = new System.Drawing.Point(89, 25);
            this.textHome.Name = "textHome";
            this.textHome.Size = new System.Drawing.Size(80, 29);
            this.textHome.TabIndex = 2;
            this.textHome.Text = "CASA";
            this.textHome.Click += new System.EventHandler(this.label2_Click);
            this.textHome.MouseLeave += new System.EventHandler(this.textHome_MouseLeave);
            this.textHome.MouseHover += new System.EventHandler(this.textHome_MouseHover);
            // 
            // iconHome
            // 
            this.iconHome.BackgroundImage = global::academia.Properties.Resources.home;
            this.iconHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconHome.Location = new System.Drawing.Point(13, 15);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(73, 47);
            this.iconHome.TabIndex = 0;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            this.iconHome.Paint += new System.Windows.Forms.PaintEventHandler(this.iconHome_Paint);
            this.iconHome.MouseLeave += new System.EventHandler(this.iconHome_MouseLeave);
            this.iconHome.MouseHover += new System.EventHandler(this.iconHome_MouseHover);
            // 
            // foraPagamento
            // 
            this.foraPagamento.Controls.Add(this.textPagamento);
            this.foraPagamento.Controls.Add(this.iconPagamento);
            this.foraPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foraPagamento.Location = new System.Drawing.Point(3, 87);
            this.foraPagamento.Name = "foraPagamento";
            this.foraPagamento.Size = new System.Drawing.Size(263, 73);
            this.foraPagamento.TabIndex = 4;
            this.foraPagamento.Click += new System.EventHandler(this.foraPagamento_Click);
            this.foraPagamento.Paint += new System.Windows.Forms.PaintEventHandler(this.foraPagamento_Paint);
            this.foraPagamento.MouseLeave += new System.EventHandler(this.foraPagamento_MouseLeave);
            this.foraPagamento.MouseHover += new System.EventHandler(this.foraPagamento_MouseHover);
            // 
            // textPagamento
            // 
            this.textPagamento.AutoSize = true;
            this.textPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPagamento.Location = new System.Drawing.Point(89, 25);
            this.textPagamento.Name = "textPagamento";
            this.textPagamento.Size = new System.Drawing.Size(165, 25);
            this.textPagamento.TabIndex = 2;
            this.textPagamento.Text = "PAGAMENTOS";
            this.textPagamento.Click += new System.EventHandler(this.textPagamento_Click);
            this.textPagamento.MouseLeave += new System.EventHandler(this.textPagamento_MouseLeave);
            this.textPagamento.MouseHover += new System.EventHandler(this.textPagamento_MouseHover);
            // 
            // iconPagamento
            // 
            this.iconPagamento.BackgroundImage = global::academia.Properties.Resources.Pagamento;
            this.iconPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPagamento.Location = new System.Drawing.Point(13, 15);
            this.iconPagamento.Name = "iconPagamento";
            this.iconPagamento.Size = new System.Drawing.Size(73, 47);
            this.iconPagamento.TabIndex = 0;
            this.iconPagamento.Paint += new System.Windows.Forms.PaintEventHandler(this.iconPagamento_Paint);
            this.iconPagamento.MouseLeave += new System.EventHandler(this.iconPagamento_MouseLeave);
            this.iconPagamento.MouseHover += new System.EventHandler(this.iconPagamento_MouseHover);
            // 
            // PanelSair
            // 
            this.PanelSair.Controls.Add(this.label3);
            this.PanelSair.Controls.Add(this.panel11);
            this.PanelSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelSair.Location = new System.Drawing.Point(3, 166);
            this.PanelSair.Name = "PanelSair";
            this.PanelSair.Size = new System.Drawing.Size(263, 73);
            this.PanelSair.TabIndex = 3;
            this.PanelSair.Click += new System.EventHandler(this.PanelSair_Click);
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
            // pagamentocs1
            // 
            this.pagamentocs1.Location = new System.Drawing.Point(382, 100);
            this.pagamentocs1.Name = "pagamentocs1";
            this.pagamentocs1.Size = new System.Drawing.Size(694, 600);
            this.pagamentocs1.TabIndex = 4;
            // 
            // entrada1
            // 
            this.entrada1.Location = new System.Drawing.Point(354, 85);
            this.entrada1.Name = "entrada1";
            this.entrada1.Size = new System.Drawing.Size(722, 615);
            this.entrada1.TabIndex = 5;
            // 
            // Principal_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 697);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.entrada1);
            this.Controls.Add(this.pagamentocs1);
            this.Name = "Principal_funcionario";
            this.Text = "Principal_funcionario";
            this.Load += new System.EventHandler(this.Principal_funcionario_Load);
            this.panel2.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.ForaHome.ResumeLayout(false);
            this.ForaHome.PerformLayout();
            this.foraPagamento.ResumeLayout(false);
            this.foraPagamento.PerformLayout();
            this.PanelSair.ResumeLayout(false);
            this.PanelSair.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelIconMenu;
        private System.Windows.Forms.Panel IconMenu;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel foraPagamento;
        private System.Windows.Forms.Label textPagamento;
        private System.Windows.Forms.Panel iconPagamento;
        private System.Windows.Forms.Panel ForaHome;
        private System.Windows.Forms.Label textHome;
        private System.Windows.Forms.Panel iconHome;
        private pagamentocs pagamentocs1;
        private Entrada entrada1;
    }
}