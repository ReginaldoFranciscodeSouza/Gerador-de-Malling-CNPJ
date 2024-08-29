namespace Gerador_de_Malling_CNPJ
{
    partial class Tela_Inicial
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
            this.btn_consulta_simples = new System.Windows.Forms.Button();
            this.btn_consulta_lote = new System.Windows.Forms.Button();
            this.Btn_Criar_malling = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_consulta_simples
            // 
            this.btn_consulta_simples.Location = new System.Drawing.Point(81, 222);
            this.btn_consulta_simples.Name = "btn_consulta_simples";
            this.btn_consulta_simples.Size = new System.Drawing.Size(127, 67);
            this.btn_consulta_simples.TabIndex = 0;
            this.btn_consulta_simples.Text = "Consulta Simples";
            this.btn_consulta_simples.UseVisualStyleBackColor = true;
            this.btn_consulta_simples.Click += new System.EventHandler(this.btn_consulta_simples_Click);
            // 
            // btn_consulta_lote
            // 
            this.btn_consulta_lote.Location = new System.Drawing.Point(282, 222);
            this.btn_consulta_lote.Name = "btn_consulta_lote";
            this.btn_consulta_lote.Size = new System.Drawing.Size(127, 67);
            this.btn_consulta_lote.TabIndex = 1;
            this.btn_consulta_lote.Text = "Consulta em lote";
            this.btn_consulta_lote.UseVisualStyleBackColor = true;
            // 
            // Btn_Criar_malling
            // 
            this.Btn_Criar_malling.Location = new System.Drawing.Point(471, 222);
            this.Btn_Criar_malling.Name = "Btn_Criar_malling";
            this.Btn_Criar_malling.Size = new System.Drawing.Size(127, 67);
            this.Btn_Criar_malling.TabIndex = 2;
            this.Btn_Criar_malling.Text = "Criar Malling";
            this.Btn_Criar_malling.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem vindo !!!! Click na Ação";
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Criar_malling);
            this.Controls.Add(this.btn_consulta_lote);
            this.Controls.Add(this.btn_consulta_simples);
            this.Name = "Tela_Inicial";
            this.Text = "Tela_Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_consulta_simples;
        private System.Windows.Forms.Button btn_consulta_lote;
        private System.Windows.Forms.Button Btn_Criar_malling;
        private System.Windows.Forms.Label label1;
    }
}