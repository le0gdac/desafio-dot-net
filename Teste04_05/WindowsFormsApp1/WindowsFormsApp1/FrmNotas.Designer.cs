namespace WindowsFormsApp1
{
    partial class FrmNotas
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
            this.TxtNomeAluno = new System.Windows.Forms.TextBox();
            this.TxtNotaUm = new System.Windows.Forms.TextBox();
            this.TxtNotaDois = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblNomeAluno = new System.Windows.Forms.Label();
            this.LblNotaUm = new System.Windows.Forms.Label();
            this.LblNotaDois = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblSituacao = new System.Windows.Forms.Label();
            this.LblNotaUmObrigatoria = new System.Windows.Forms.Label();
            this.LblNotaDoisObrigatoria = new System.Windows.Forms.Label();
            this.LblNomeObrigatorio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNomeAluno
            // 
            this.TxtNomeAluno.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeAluno.Location = new System.Drawing.Point(33, 100);
            this.TxtNomeAluno.Name = "TxtNomeAluno";
            this.TxtNomeAluno.Size = new System.Drawing.Size(348, 22);
            this.TxtNomeAluno.TabIndex = 0;
            this.TxtNomeAluno.TextChanged += new System.EventHandler(this.TxtNomeAluno_TextChanged);
            this.TxtNomeAluno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNomeAluno_KeyDown);
            // 
            // TxtNotaUm
            // 
            this.TxtNotaUm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNotaUm.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtNotaUm.Location = new System.Drawing.Point(33, 199);
            this.TxtNotaUm.Name = "TxtNotaUm";
            this.TxtNotaUm.Size = new System.Drawing.Size(131, 22);
            this.TxtNotaUm.TabIndex = 1;
            this.TxtNotaUm.TextChanged += new System.EventHandler(this.TxtNotaUm_TextChanged);
            this.TxtNotaUm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNotaUm_KeyPress);
            // 
            // TxtNotaDois
            // 
            this.TxtNotaDois.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNotaDois.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtNotaDois.Location = new System.Drawing.Point(250, 199);
            this.TxtNotaDois.Name = "TxtNotaDois";
            this.TxtNotaDois.Size = new System.Drawing.Size(131, 22);
            this.TxtNotaDois.TabIndex = 2;
            this.TxtNotaDois.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNotaDois_KeyPress);
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnviar.Font = new System.Drawing.Font("Arial", 9F);
            this.BtnEnviar.Location = new System.Drawing.Point(33, 268);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(212, 23);
            this.BtnEnviar.TabIndex = 3;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Arial", 9F);
            this.BtnLimpar.Location = new System.Drawing.Point(260, 268);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnLimpar.Size = new System.Drawing.Size(121, 23);
            this.BtnLimpar.TabIndex = 4;
            this.BtnLimpar.Text = "Limpar Campos";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LblNomeAluno
            // 
            this.LblNomeAluno.AutoSize = true;
            this.LblNomeAluno.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LblNomeAluno.Location = new System.Drawing.Point(40, 81);
            this.LblNomeAluno.Name = "LblNomeAluno";
            this.LblNomeAluno.Size = new System.Drawing.Size(99, 16);
            this.LblNomeAluno.TabIndex = 5;
            this.LblNomeAluno.Text = "Nome do Aluno:";
            this.LblNomeAluno.Click += new System.EventHandler(this.LblNomeAluno_Click);
            // 
            // LblNotaUm
            // 
            this.LblNotaUm.AutoSize = true;
            this.LblNotaUm.Font = new System.Drawing.Font("Arial", 9F);
            this.LblNotaUm.Location = new System.Drawing.Point(40, 181);
            this.LblNotaUm.Name = "LblNotaUm";
            this.LblNotaUm.Size = new System.Drawing.Size(124, 15);
            this.LblNotaUm.TabIndex = 6;
            this.LblNotaUm.Text = "Nota do 1º Semestre:";
            // 
            // LblNotaDois
            // 
            this.LblNotaDois.AutoSize = true;
            this.LblNotaDois.Font = new System.Drawing.Font("Arial", 9F);
            this.LblNotaDois.Location = new System.Drawing.Point(257, 181);
            this.LblNotaDois.Name = "LblNotaDois";
            this.LblNotaDois.Size = new System.Drawing.Size(124, 15);
            this.LblNotaDois.TabIndex = 7;
            this.LblNotaDois.Text = "Nota do 2º Semestre:";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.LblStatus.Location = new System.Drawing.Point(30, 469);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(95, 15);
            this.LblStatus.TabIndex = 8;
            this.LblStatus.Text = "Status do Aluno:";
            // 
            // LblSituacao
            // 
            this.LblSituacao.AutoSize = true;
            this.LblSituacao.Font = new System.Drawing.Font("Arial", 9F);
            this.LblSituacao.Location = new System.Drawing.Point(131, 469);
            this.LblSituacao.Name = "LblSituacao";
            this.LblSituacao.Size = new System.Drawing.Size(0, 15);
            this.LblSituacao.TabIndex = 10;
            // 
            // LblNotaUmObrigatoria
            // 
            this.LblNotaUmObrigatoria.AutoSize = true;
            this.LblNotaUmObrigatoria.Font = new System.Drawing.Font("Arial", 9F);
            this.LblNotaUmObrigatoria.Location = new System.Drawing.Point(30, 224);
            this.LblNotaUmObrigatoria.Name = "LblNotaUmObrigatoria";
            this.LblNotaUmObrigatoria.Size = new System.Drawing.Size(0, 15);
            this.LblNotaUmObrigatoria.TabIndex = 11;
            // 
            // LblNotaDoisObrigatoria
            // 
            this.LblNotaDoisObrigatoria.AutoSize = true;
            this.LblNotaDoisObrigatoria.Font = new System.Drawing.Font("Arial", 9F);
            this.LblNotaDoisObrigatoria.Location = new System.Drawing.Point(247, 224);
            this.LblNotaDoisObrigatoria.Name = "LblNotaDoisObrigatoria";
            this.LblNotaDoisObrigatoria.Size = new System.Drawing.Size(0, 15);
            this.LblNotaDoisObrigatoria.TabIndex = 12;
            // 
            // LblNomeObrigatorio
            // 
            this.LblNomeObrigatorio.AutoSize = true;
            this.LblNomeObrigatorio.Font = new System.Drawing.Font("Arial", 9F);
            this.LblNomeObrigatorio.Location = new System.Drawing.Point(40, 125);
            this.LblNomeObrigatorio.Name = "LblNomeObrigatorio";
            this.LblNomeObrigatorio.Size = new System.Drawing.Size(0, 15);
            this.LblNomeObrigatorio.TabIndex = 13;
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 561);
            this.Controls.Add(this.LblNomeObrigatorio);
            this.Controls.Add(this.LblNotaDoisObrigatoria);
            this.Controls.Add(this.LblNotaUmObrigatoria);
            this.Controls.Add(this.LblSituacao);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblNotaDois);
            this.Controls.Add(this.LblNotaUm);
            this.Controls.Add(this.LblNomeAluno);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtNotaDois);
            this.Controls.Add(this.TxtNotaUm);
            this.Controls.Add(this.TxtNomeAluno);
            this.Name = "FrmNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento de Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNomeAluno;
        private System.Windows.Forms.TextBox TxtNotaUm;
        private System.Windows.Forms.TextBox TxtNotaDois;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblNomeAluno;
        private System.Windows.Forms.Label LblNotaUm;
        private System.Windows.Forms.Label LblNotaDois;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblSituacao;
        private System.Windows.Forms.Label LblNotaUmObrigatoria;
        private System.Windows.Forms.Label LblNotaDoisObrigatoria;
        private System.Windows.Forms.Label LblNomeObrigatorio;
    }
}