﻿namespace GestorDeAlunoT6
{
    partial class FormListaDeEstudantes
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
            this.dataGridViewListaDeEstudantes = new System.Windows.Forms.DataGridView();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeEstudantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaDeEstudantes
            // 
            this.dataGridViewListaDeEstudantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaDeEstudantes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewListaDeEstudantes.Name = "dataGridViewListaDeEstudantes";
            this.dataGridViewListaDeEstudantes.Size = new System.Drawing.Size(776, 346);
            this.dataGridViewListaDeEstudantes.TabIndex = 0;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(264, 384);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(291, 43);
            this.buttonAtualizar.TabIndex = 1;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            // 
            // FormListaDeEstudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.dataGridViewListaDeEstudantes);
            this.Name = "FormListaDeEstudantes";
            this.Text = "FormListaDeEstudantes";
            this.Load += new System.EventHandler(this.FormListaDeEstudantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaDeEstudantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaDeEstudantes;
        private System.Windows.Forms.Button buttonAtualizar;
    }
}