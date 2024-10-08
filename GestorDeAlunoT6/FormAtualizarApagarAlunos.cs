﻿using GestorDeEstudanteT6;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeAlunoT6
{
    public partial class FormAtualizarApagarAlunos : Form
    {

        Estudante estudante = new Estudante();

        public FormAtualizarApagarAlunos()
        {
            InitializeComponent();
        }

        private void FormAtualizarApagarAlunos_Load(object sender, EventArgs e)
        {

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                // Cria um estudante.
                Estudante estudante = new Estudante();
                // Variáveis auxiliares.
                int id = Convert.ToInt32(textBoxID.Text);
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

                    if (estudante.atualizarEstudante(id, nome, sobrenome, nascimento,
                        telefone, genero, endereco, foto))
                    {
                        MessageBox.Show("Dados alterados!", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Dados não alterados!", "Falha!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Campos não preenchidos!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
           
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if (MessageBox.Show("Tem certeza que deseja apagar esse aluno?", "Apagar aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (estudante.apagarEstudante(id))
                    {
                        MessageBox.Show("Estudante removido!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        textBoxID.Text = "";
                        textBoxNome.Text = "";
                        textBoxSobrenome.Text = "";
                        textBoxTelefone.Text = "";
                        textBoxEndereço.Text = "";
                        dateTimeNascimento.Value = DateTime.Now;
                        pictureBoxFoto.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Estudante não removido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog selecionarImagem = new OpenFileDialog();

            selecionarImagem.Filter = "Selecione a foto (*.jpg,*.png,*.gif)|*.jpg;*.png;*.gif";

            if (selecionarImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(selecionarImagem.FileName);
            }
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                MeuBancoDeDados meuBancoDeDados = new MeuBancoDeDados();

                MySqlCommand comando = new MySqlCommand("SELECT `id`, `nome`, `sobrenome`, `genero`, `telefone`, `endereco`, `foto` FROM `estudantes` WHERE `id`=", meuBancoDeDados.getConexao);

                DataTable tabela = estudante.getEstudantes(comando);

                if (tabela.Rows.Count > 0)
                {
                    textBoxNome.Text = tabela.Rows[0]["nome"].ToString();
                    textBoxSobrenome.Text = tabela.Rows[0]["sobrenome"].ToString();
                    textBoxTelefone.Text = tabela.Rows[0]["telefone"].ToString();
                    textBoxEndereço.Text = tabela.Rows[0]["endereco"].ToString();

                    dateTimeNascimento.Value = (DateTime)tabela.Rows[0]["nascimento"];

                    if (tabela.Rows[0]["genero"].ToString() == "Feminino")
                    {
                        radioButtonFeminino.Checked = true;
                    }
                    else
                    {
                        radioButtonMasculino.Checked = true;
                    }

                    byte[] imagem = (byte[])tabela.Rows[0]["foto"];
                    MemoryStream fotoDoAluno = new MemoryStream(imagem);
                    pictureBoxFoto.Image = Image.FromStream(fotoDoAluno);

                }
            } catch
            {
                MessageBox.Show("Insira uma ID válida.", "ID Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
