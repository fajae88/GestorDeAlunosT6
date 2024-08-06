namespace GestorDeAlunoT6
{
    partial class FormInserirEstudante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInserirEstudante));
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.Nome = new System.Windows.Forms.Label();
            this.Sobrenome = new System.Windows.Forms.Label();
            this.Nascimento = new System.Windows.Forms.Label();
            this.Genero = new System.Windows.Forms.Label();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.radioButtonPrefiroNaoDizer = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEndereço = new System.Windows.Forms.TextBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(120, 21);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(143, 20);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.Text = "Maria";
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(120, 45);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(143, 20);
            this.textBoxSobrenome.TabIndex = 1;
            this.textBoxSobrenome.Text = "Silva";
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.Location = new System.Drawing.Point(120, 71);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(143, 20);
            this.dateTimeNascimento.TabIndex = 3;
            this.dateTimeNascimento.Value = new System.DateTime(2000, 2, 1, 0, 0, 0, 0);
            this.dateTimeNascimento.ValueChanged += new System.EventHandler(this.dateTimeNascimento_ValueChanged);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(10, 20);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(49, 18);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sobrenome
            // 
            this.Sobrenome.AutoSize = true;
            this.Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sobrenome.Location = new System.Drawing.Point(10, 47);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(86, 18);
            this.Sobrenome.TabIndex = 5;
            this.Sobrenome.Text = "Sobrenome";
            this.Sobrenome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Nascimento
            // 
            this.Nascimento.AutoSize = true;
            this.Nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nascimento.Location = new System.Drawing.Point(10, 73);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(88, 18);
            this.Nascimento.TabIndex = 6;
            this.Nascimento.Text = "Nascimento";
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.Location = new System.Drawing.Point(10, 147);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(58, 18);
            this.Genero.TabIndex = 7;
            this.Genero.Text = "Gênero";
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.radioButtonPrefiroNaoDizer);
            this.groupBoxGenero.Controls.Add(this.radioButtonMasculino);
            this.groupBoxGenero.Controls.Add(this.radioButtonFeminino);
            this.groupBoxGenero.Location = new System.Drawing.Point(74, 113);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(175, 81);
            this.groupBoxGenero.TabIndex = 8;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonPrefiroNaoDizer
            // 
            this.radioButtonPrefiroNaoDizer.AutoSize = true;
            this.radioButtonPrefiroNaoDizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPrefiroNaoDizer.Location = new System.Drawing.Point(3, 59);
            this.radioButtonPrefiroNaoDizer.Name = "radioButtonPrefiroNaoDizer";
            this.radioButtonPrefiroNaoDizer.Size = new System.Drawing.Size(115, 19);
            this.radioButtonPrefiroNaoDizer.TabIndex = 2;
            this.radioButtonPrefiroNaoDizer.TabStop = true;
            this.radioButtonPrefiroNaoDizer.Text = "Prefiro não dizer";
            this.radioButtonPrefiroNaoDizer.UseVisualStyleBackColor = true;
            this.radioButtonPrefiroNaoDizer.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMasculino.Location = new System.Drawing.Point(3, 34);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(82, 19);
            this.radioButtonMasculino.TabIndex = 1;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            this.radioButtonMasculino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Checked = true;
            this.radioButtonFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFeminino.Location = new System.Drawing.Point(3, 9);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(77, 19);
            this.radioButtonFeminino.TabIndex = 0;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            this.radioButtonFeminino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Telefone";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(120, 209);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(143, 20);
            this.textBoxTelefone.TabIndex = 10;
            this.textBoxTelefone.Text = "11987654321";
            this.textBoxTelefone.TextChanged += new System.EventHandler(this.textBoxTelefone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Endereço";
            // 
            // textBoxEndereço
            // 
            this.textBoxEndereço.Location = new System.Drawing.Point(120, 235);
            this.textBoxEndereço.Multiline = true;
            this.textBoxEndereço.Name = "textBoxEndereço";
            this.textBoxEndereço.Size = new System.Drawing.Size(143, 37);
            this.textBoxEndereço.TabIndex = 12;
            this.textBoxEndereço.Text = "Rua Alameda";
            this.textBoxEndereço.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.Image")));
            this.pictureBoxFoto.Location = new System.Drawing.Point(110, 288);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(64, 68);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 13;
            this.pictureBoxFoto.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("PanRoman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.Location = new System.Drawing.Point(15, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Font = new System.Drawing.Font("PanRoman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Location = new System.Drawing.Point(101, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Enviar Foto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.LightCyan;
            this.buttonCancelar.Font = new System.Drawing.Font("PanRoman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonCancelar.Location = new System.Drawing.Point(180, 411);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(83, 27);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormInserirEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.textBoxEndereço);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxGenero);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.Nascimento);
            this.Controls.Add(this.Sobrenome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.dateTimeNascimento);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormInserirEstudante";
            this.Text = "FormInserirEstudante";
            this.Load += new System.EventHandler(this.FormInserirEstudante_Load);
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Sobrenome;
        private System.Windows.Forms.Label Nascimento;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.GroupBox groupBoxGenero;
        private System.Windows.Forms.RadioButton radioButtonPrefiroNaoDizer;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEndereço;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonCancelar;
    }
}