namespace GestorDeAlunoT6
{
    partial class FormEstatistica
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
            this.panelTotalDeAlunos = new System.Windows.Forms.Panel();
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.labelTotalDeAlunos = new System.Windows.Forms.Label();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.panelTotalDeAlunos.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.panelMeninas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotalDeAlunos
            // 
            this.panelTotalDeAlunos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelTotalDeAlunos.Controls.Add(this.labelTotalDeAlunos);
            this.panelTotalDeAlunos.Location = new System.Drawing.Point(12, 12);
            this.panelTotalDeAlunos.Name = "panelTotalDeAlunos";
            this.panelTotalDeAlunos.Size = new System.Drawing.Size(776, 237);
            this.panelTotalDeAlunos.TabIndex = 0;
            this.panelTotalDeAlunos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMeninos.Controls.Add(this.labelMeninos);
            this.panelMeninos.Location = new System.Drawing.Point(12, 255);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(385, 183);
            this.panelMeninos.TabIndex = 1;
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.CadetBlue;
            this.panelMeninas.Controls.Add(this.labelMeninas);
            this.panelMeninas.Location = new System.Drawing.Point(403, 255);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(385, 183);
            this.panelMeninas.TabIndex = 2;
            // 
            // labelTotalDeAlunos
            // 
            this.labelTotalDeAlunos.AutoSize = true;
            this.labelTotalDeAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalDeAlunos.Location = new System.Drawing.Point(297, 108);
            this.labelTotalDeAlunos.Name = "labelTotalDeAlunos";
            this.labelTotalDeAlunos.Size = new System.Drawing.Size(193, 25);
            this.labelTotalDeAlunos.TabIndex = 0;
            this.labelTotalDeAlunos.Text = "Total de Alunos: 999";
            this.labelTotalDeAlunos.Click += new System.EventHandler(this.labelTotalDeAlunos_Click);
            this.labelTotalDeAlunos.MouseEnter += new System.EventHandler(this.labelTotalDeAlunos_MouseEnter);
            this.labelTotalDeAlunos.MouseLeave += new System.EventHandler(this.labelTotalDeAlunos_MouseLeave);
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninos.Location = new System.Drawing.Point(122, 83);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(138, 25);
            this.labelMeninos.TabIndex = 1;
            this.labelMeninos.Text = "Meninos: 50%";
            this.labelMeninos.MouseEnter += new System.EventHandler(this.labelMeninos_MouseEnter);
            this.labelMeninos.MouseLeave += new System.EventHandler(this.labelMeninos_MouseLeave);
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninas.Location = new System.Drawing.Point(115, 83);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(138, 25);
            this.labelMeninas.TabIndex = 2;
            this.labelMeninas.Text = "Meninas: 50%";
            this.labelMeninas.MouseEnter += new System.EventHandler(this.labelMeninas_MouseEnter);
            this.labelMeninas.MouseLeave += new System.EventHandler(this.labelMeninas_MouseLeave);
            // 
            // FormEstatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMeninas);
            this.Controls.Add(this.panelMeninos);
            this.Controls.Add(this.panelTotalDeAlunos);
            this.Name = "FormEstatistica";
            this.Text = "FormEstatistica";
            this.Load += new System.EventHandler(this.FormEstatistica_Load);
            this.panelTotalDeAlunos.ResumeLayout(false);
            this.panelTotalDeAlunos.PerformLayout();
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotalDeAlunos;
        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Label labelTotalDeAlunos;
        private System.Windows.Forms.Label labelMeninos;
        private System.Windows.Forms.Label labelMeninas;
    }
}