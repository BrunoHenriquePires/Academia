namespace academia
{
    partial class pagamentocs
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
            this.lstContatos = new System.Windows.Forms.ListView();
            this.txtProcura = new System.Windows.Forms.TextBox();
            this.btProcura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstContatos
            // 
            this.lstContatos.HideSelection = false;
            this.lstContatos.Location = new System.Drawing.Point(44, 48);
            this.lstContatos.Name = "lstContatos";
            this.lstContatos.Size = new System.Drawing.Size(563, 407);
            this.lstContatos.TabIndex = 5;
            this.lstContatos.UseCompatibleStateImageBehavior = false;
            // 
            // txtProcura
            // 
            this.txtProcura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcura.Location = new System.Drawing.Point(191, 466);
            this.txtProcura.Name = "txtProcura";
            this.txtProcura.Size = new System.Drawing.Size(249, 34);
            this.txtProcura.TabIndex = 8;
            // 
            // btProcura
            // 
            this.btProcura.Location = new System.Drawing.Point(59, 461);
            this.btProcura.Name = "btProcura";
            this.btProcura.Size = new System.Drawing.Size(126, 52);
            this.btProcura.TabIndex = 7;
            this.btProcura.Text = "Procurar";
            this.btProcura.UseVisualStyleBackColor = true;
            this.btProcura.Click += new System.EventHandler(this.BotaoProcura_Click);
            // 
            // pagamentocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtProcura);
            this.Controls.Add(this.btProcura);
            this.Controls.Add(this.lstContatos);
            this.Name = "pagamentocs";
            this.Size = new System.Drawing.Size(671, 584);
            this.Load += new System.EventHandler(this.pagamentocs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstContatos;
        private System.Windows.Forms.TextBox txtProcura;
        private System.Windows.Forms.Button btProcura;
    }
}
