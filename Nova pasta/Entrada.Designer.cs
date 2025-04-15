namespace academia
{
    partial class Entrada
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.botaoPlano = new System.Windows.Forms.Button();
            this.radioOuro = new System.Windows.Forms.RadioButton();
            this.radioBronze = new System.Windows.Forms.RadioButton();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.BotaoProcura = new System.Windows.Forms.Button();
            this.lstContatos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(188, 501);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(249, 34);
            this.txtID.TabIndex = 17;
            // 
            // botaoPlano
            // 
            this.botaoPlano.Location = new System.Drawing.Point(56, 497);
            this.botaoPlano.Name = "botaoPlano";
            this.botaoPlano.Size = new System.Drawing.Size(126, 52);
            this.botaoPlano.TabIndex = 16;
            this.botaoPlano.Text = "Adicionar Plano";
            this.botaoPlano.UseVisualStyleBackColor = true;
            this.botaoPlano.Click += new System.EventHandler(this.botaoPlano_Click);
            // 
            // radioOuro
            // 
            this.radioOuro.AutoSize = true;
            this.radioOuro.Location = new System.Drawing.Point(443, 527);
            this.radioOuro.Name = "radioOuro";
            this.radioOuro.Size = new System.Drawing.Size(98, 20);
            this.radioOuro.TabIndex = 15;
            this.radioOuro.TabStop = true;
            this.radioOuro.Text = "Plano  Ouro";
            this.radioOuro.UseVisualStyleBackColor = true;
            // 
            // radioBronze
            // 
            this.radioBronze.AutoSize = true;
            this.radioBronze.Location = new System.Drawing.Point(443, 501);
            this.radioBronze.Name = "radioBronze";
            this.radioBronze.Size = new System.Drawing.Size(108, 20);
            this.radioBronze.TabIndex = 14;
            this.radioBronze.TabStop = true;
            this.radioBronze.Text = "Plano Bronze";
            this.radioBronze.UseVisualStyleBackColor = true;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(188, 559);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(249, 34);
            this.txtProcurar.TabIndex = 13;
            // 
            // BotaoProcura
            // 
            this.BotaoProcura.Location = new System.Drawing.Point(56, 554);
            this.BotaoProcura.Name = "BotaoProcura";
            this.BotaoProcura.Size = new System.Drawing.Size(126, 52);
            this.BotaoProcura.TabIndex = 12;
            this.BotaoProcura.Text = "Procurar";
            this.BotaoProcura.UseVisualStyleBackColor = true;
            this.BotaoProcura.Click += new System.EventHandler(this.BotaoProcura_Click);
            // 
            // lstContatos
            // 
            this.lstContatos.HideSelection = false;
            this.lstContatos.Location = new System.Drawing.Point(30, 84);
            this.lstContatos.Name = "lstContatos";
            this.lstContatos.Size = new System.Drawing.Size(668, 407);
            this.lstContatos.TabIndex = 11;
            this.lstContatos.UseCompatibleStateImageBehavior = false;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.botaoPlano);
            this.Controls.Add(this.radioOuro);
            this.Controls.Add(this.radioBronze);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.BotaoProcura);
            this.Controls.Add(this.lstContatos);
            this.Name = "Entrada";
            this.Size = new System.Drawing.Size(729, 638);
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button botaoPlano;
        private System.Windows.Forms.RadioButton radioOuro;
        private System.Windows.Forms.RadioButton radioBronze;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button BotaoProcura;
        private System.Windows.Forms.ListView lstContatos;
    }
}
