namespace GestorDeAlunoT6
{
    partial class FormAtualizarApagarAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtualizarApagarAlunos));
            this.buttonApagar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.textBoxEndereço = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPrefiroNaoDizer = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.Genero = new System.Windows.Forms.Label();
            this.Nascimento = new System.Windows.Forms.Label();
            this.Sobrenome = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApagar
            // 
            this.buttonApagar.BackColor = System.Drawing.Color.LightCyan;
            this.buttonApagar.Font = new System.Drawing.Font("PanRoman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonApagar.Location = new System.Drawing.Point(186, 407);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(83, 27);
            this.buttonApagar.TabIndex = 33;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = false;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Font = new System.Drawing.Font("PanRoman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.Location = new System.Drawing.Point(107, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 31);
            this.button2.TabIndex = 32;
            this.button2.Text = "Enviar Foto";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.LightCyan;
            this.buttonSalvar.Font = new System.Drawing.Font("PanRoman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonSalvar.Location = new System.Drawing.Point(21, 407);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(83, 27);
            this.buttonSalvar.TabIndex = 31;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto.Image")));
            this.pictureBoxFoto.Location = new System.Drawing.Point(116, 284);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(64, 68);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 30;
            this.pictureBoxFoto.TabStop = false;
            // 
            // textBoxEndereço
            // 
            this.textBoxEndereço.Location = new System.Drawing.Point(126, 241);
            this.textBoxEndereço.Multiline = true;
            this.textBoxEndereço.Name = "textBoxEndereço";
            this.textBoxEndereço.Size = new System.Drawing.Size(143, 37);
            this.textBoxEndereço.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Endereço";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(126, 215);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(143, 20);
            this.textBoxTelefone.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Telefone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPrefiroNaoDizer);
            this.groupBox1.Controls.Add(this.radioButtonMasculino);
            this.groupBox1.Controls.Add(this.radioButtonFeminino);
            this.groupBox1.Location = new System.Drawing.Point(80, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 81);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
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
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFeminino.Location = new System.Drawing.Point(3, 9);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(77, 19);
            this.radioButtonFeminino.TabIndex = 0;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.Location = new System.Drawing.Point(16, 155);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(58, 18);
            this.Genero.TabIndex = 24;
            this.Genero.Text = "Gênero";
            // 
            // Nascimento
            // 
            this.Nascimento.AutoSize = true;
            this.Nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nascimento.Location = new System.Drawing.Point(16, 94);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(88, 18);
            this.Nascimento.TabIndex = 23;
            this.Nascimento.Text = "Nascimento";
            // 
            // Sobrenome
            // 
            this.Sobrenome.AutoSize = true;
            this.Sobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sobrenome.Location = new System.Drawing.Point(16, 68);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(86, 18);
            this.Sobrenome.TabIndex = 22;
            this.Sobrenome.Text = "Sobrenome";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(16, 41);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(49, 18);
            this.Nome.TabIndex = 21;
            this.Nome.Text = "Nome";
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.Location = new System.Drawing.Point(126, 92);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(143, 20);
            this.dateTimeNascimento.TabIndex = 20;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(126, 66);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(143, 20);
            this.textBoxSobrenome.TabIndex = 19;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(126, 42);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(143, 20);
            this.textBoxNome.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(126, 12);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(82, 20);
            this.textBoxID.TabIndex = 34;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(215, 11);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(54, 23);
            this.buttonBuscar.TabIndex = 36;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // FormAtualizarApagarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 450);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.textBoxEndereço);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.Nascimento);
            this.Controls.Add(this.Sobrenome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.dateTimeNascimento);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormAtualizarApagarAlunos";
            this.Text = "FormAtualizarApagarAlunos";
            this.Load += new System.EventHandler(this.FormAtualizarApagarAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.Label Nascimento;
        private System.Windows.Forms.Label Sobrenome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBuscar;
        internal System.Windows.Forms.PictureBox pictureBoxFoto;
        internal System.Windows.Forms.TextBox textBoxEndereço;
        internal System.Windows.Forms.TextBox textBoxTelefone;
        internal System.Windows.Forms.RadioButton radioButtonPrefiroNaoDizer;
        internal System.Windows.Forms.RadioButton radioButtonMasculino;
        internal System.Windows.Forms.RadioButton radioButtonFeminino;
        internal System.Windows.Forms.DateTimePicker dateTimeNascimento;
        internal System.Windows.Forms.TextBox textBoxSobrenome;
        internal System.Windows.Forms.TextBox textBoxNome;
        internal System.Windows.Forms.TextBox textBoxID;
    }
}