namespace academia
{
    partial class cadastro_funcionario
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
            this.radioRecepcionista = new System.Windows.Forms.RadioButton();
            this.radioPersonal = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrarbotao = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.txtSalario);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTelefone);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.radioRecepcionista);
            this.panel2.Controls.Add(this.radioPersonal);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSenha);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cadastrarbotao);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(85, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 678);
            this.panel2.TabIndex = 2;
            // 
            // radioRecepcionista
            // 
            this.radioRecepcionista.AutoSize = true;
            this.radioRecepcionista.Location = new System.Drawing.Point(185, 457);
            this.radioRecepcionista.Name = "radioRecepcionista";
            this.radioRecepcionista.Size = new System.Drawing.Size(136, 20);
            this.radioRecepcionista.TabIndex = 11;
            this.radioRecepcionista.TabStop = true;
            this.radioRecepcionista.Text = "RECEPCIONISTA";
            this.radioRecepcionista.UseVisualStyleBackColor = true;
            // 
            // radioPersonal
            // 
            this.radioPersonal.AutoSize = true;
            this.radioPersonal.Location = new System.Drawing.Point(62, 458);
            this.radioPersonal.Name = "radioPersonal";
            this.radioPersonal.Size = new System.Drawing.Size(101, 20);
            this.radioPersonal.TabIndex = 10;
            this.radioPersonal.TabStop = true;
            this.radioPersonal.Text = "PERSONAL";
            this.radioPersonal.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F);
            this.txtEmail.Location = new System.Drawing.Point(52, 377);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(436, 36);
            this.txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "EMAIL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "PROFISSÃO:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F);
            this.txtSenha.Location = new System.Drawing.Point(52, 217);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(436, 36);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "SENHA:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadastro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F);
            this.txtNome.Location = new System.Drawing.Point(52, 137);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(436, 36);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME:";
            // 
            // cadastrarbotao
            // 
            this.cadastrarbotao.BackColor = System.Drawing.Color.Transparent;
            this.cadastrarbotao.Location = new System.Drawing.Point(25, 589);
            this.cadastrarbotao.Name = "cadastrarbotao";
            this.cadastrarbotao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cadastrarbotao.Size = new System.Drawing.Size(463, 43);
            this.cadastrarbotao.TabIndex = 0;
            this.cadastrarbotao.Text = "CADASTRAR";
            this.cadastrarbotao.UseVisualStyleBackColor = false;
            this.cadastrarbotao.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 38);
            this.label6.TabIndex = 12;
            this.label6.Text = "TELEFONE:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F);
            this.txtTelefone.Location = new System.Drawing.Point(52, 297);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(436, 36);
            this.txtTelefone.TabIndex = 13;
            this.txtTelefone.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "Salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.1F);
            this.txtSalario.Location = new System.Drawing.Point(47, 522);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(436, 36);
            this.txtSalario.TabIndex = 15;
            // 
            // cadastro_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(725, 749);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "cadastro_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cadastro_funcionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cadastro_funcionario_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cadastro_funcionario_FormClosed);
            this.Load += new System.EventHandler(this.cadastro_funcionario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrarbotao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioRecepcionista;
        private System.Windows.Forms.RadioButton radioPersonal;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label6;
    }
}