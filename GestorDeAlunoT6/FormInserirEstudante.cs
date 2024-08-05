using GestorDeEstudanteT6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeAlunoT6
{
    public partial class FormInserirEstudante: Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarImagem = new OpenFileDialog();

            selecionarImagem.Filter = "Selecione a foto (*.jpg,*.png,*.gif)|*.jpg;*.png;*.gif";

            if(selecionarImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(selecionarImagem.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

            bool Verificar()
            {
            if (textBoxNome.Text.Trim() == "" ||
                (textBoxSobrenome.Text.Trim() == "") ||
                (textBoxTelefone.Text.Trim() == "") ||
                (textBoxEndereço.Text.Trim() == "") ||
                (pictureBoxFoto.Image == null)) 
                {
                    return false;
                }
                else 
                { 
                    return true;
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria um estudante.
            Estudante estudante = new Estudante();
            // Variáveis auxiliares.
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            DateTime nascimento = dateTimeNascimento.Value;
            string telefone = textBoxTelefone.Text;
            string endereco = textBoxEndereço.Text;
            string genero = "Feminino";

            // Verifica se outro gênero está selecionado.
            if (radioButtonMasculino.Checked)
            {
                genero = "Masculino";
            }

            MemoryStream foto = new MemoryStream();

            // Precisamos verificar se o estudante tem
            // mais de 10 anos e menos de 100.
            int anoDeNascimento = dateTimeNascimento.Value.Year;
            int anoAtual = DateTime.Now.Year;

            if (((anoAtual - anoDeNascimento) < 10) ||
                ((anoAtual - anoDeNascimento) > 100))
            {
                MessageBox.Show("Precisa ter entre 10 e 100 anos.",
                    "Idade Inválida", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (Verificar())
            {
                pictureBoxFoto.Image.Save(foto,
                    pictureBoxFoto.Image.RawFormat);

                if (estudante.inserirEstudantes(nome, sobrenome, nascimento,
                    telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Novo aluno cadastrado!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Aluno não cadastrado!", "Falha!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Campos não preenchidos!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
