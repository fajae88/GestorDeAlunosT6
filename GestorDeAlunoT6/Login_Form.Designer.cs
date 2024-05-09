namespace GestorDeAlunoT6
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.Acessar = new System.Windows.Forms.Label();
            this.Usuário = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.LightCyan;
            this.ButtonLogin.Font = new System.Drawing.Font("PanRoman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonLogin.Location = new System.Drawing.Point(33, 384);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(100, 35);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.BackColor = System.Drawing.Color.LightCyan;
            this.ButtonCancelar.Font = new System.Drawing.Font("PanRoman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ButtonCancelar.Location = new System.Drawing.Point(199, 383);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(93, 36);
            this.ButtonCancelar.TabIndex = 1;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = false;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(95, 313);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(202, 20);
            this.textBoxSenha.TabIndex = 4;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(95, 278);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(202, 20);
            this.textBoxUsuario.TabIndex = 5;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // Acessar
            // 
            this.Acessar.AutoSize = true;
            this.Acessar.Font = new System.Drawing.Font("Perpetua Titling MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acessar.Location = new System.Drawing.Point(115, 94);
            this.Acessar.Name = "Acessar";
            this.Acessar.Size = new System.Drawing.Size(89, 21);
            this.Acessar.TabIndex = 6;
            this.Acessar.Text = "Acessar";
            // 
            // Usuário
            // 
            this.Usuário.AutoSize = true;
            this.Usuário.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuário.Location = new System.Drawing.Point(12, 276);
            this.Usuário.Name = "Usuário";
            this.Usuário.Size = new System.Drawing.Size(77, 22);
            this.Usuário.TabIndex = 7;
            this.Usuário.Text = "Usuário:";
            this.Usuário.Click += new System.EventHandler(this.Usuário_Click);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(22, 311);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(67, 22);
            this.Senha.TabIndex = 8;
            this.Senha.Text = "Senha:";
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.Image")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(114, 118);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(90, 96);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsuario.TabIndex = 9;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.pictureBoxUsuario);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuário);
            this.Controls.Add(this.Acessar);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.ButtonLogin);
            this.Name = "Login_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label Acessar;
        private System.Windows.Forms.Label Usuário;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
    }
}

