
namespace AnoBissexto
{
    partial class AnoBissexto
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescobrir = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(138, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ano Bissexto";
            // 
            // txtDescobrir
            // 
            this.txtDescobrir.Location = new System.Drawing.Point(145, 241);
            this.txtDescobrir.Name = "txtDescobrir";
            this.txtDescobrir.Size = new System.Drawing.Size(130, 38);
            this.txtDescobrir.TabIndex = 1;
            this.txtDescobrir.Text = "Descobrir";
            this.txtDescobrir.UseVisualStyleBackColor = true;
            this.txtDescobrir.Click += new System.EventHandler(this.txtDescobrir_Click);
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(163, 185);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(102, 26);
            this.txtAno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite aqui o ano desejado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descubra se o Ano é Bissexto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtDescobrir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ano Bissexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtDescobrir;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

