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
    public partial class FormListaDeEstudantes : Form
    {
        public FormListaDeEstudantes()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormListaDeEstudantes_Load(object sender, EventArgs e)
        {
            // Preencha a tabela com as informações do banco de dados:
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            dataGridViewListaDeEstudantes.ReadOnly = true;
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            dataGridViewListaDeEstudantes.RowTemplate.Height = 80;
            dataGridViewListaDeEstudantes.DataSource = estudante.getEstudantes(comando);
            colunaDeFotos = (DataGridViewImageColumn) dataGridViewListaDeEstudantes.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewListaDeEstudantes.AllowUserToAddRows = false;  

        }

        private void dataGridViewListaDeEstudantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridViewListaDeEstudantes_DoubleClick(object sender, EventArgs e)
        {
            FormAtualizarApagarAlunos formAtualizarApagarAlunos = new FormAtualizarApagarAlunos();
            formAtualizarApagarAlunos.textBoxID.Text = dataGridViewListaDeEstudantes.CurrentRow.Cells[0].Value.ToString();
            formAtualizarApagarAlunos.textBoxNome.Text = dataGridViewListaDeEstudantes.CurrentRow.Cells[1].Value.ToString();
            formAtualizarApagarAlunos.textBoxSobrenome.Text = dataGridViewListaDeEstudantes.CurrentRow.Cells[2].Value.ToString();
            formAtualizarApagarAlunos.dateTimeNascimento.Value = (DateTime) dataGridViewListaDeEstudantes.CurrentRow.Cells[3].Value;
            if (dataGridViewListaDeEstudantes.CurrentRow.Cells[4].Value.ToString() == "Feminino")
            {
                formAtualizarApagarAlunos.radioButtonFeminino.Checked = true;
            }
            else
            {
                formAtualizarApagarAlunos.radioButtonMasculino.Checked = true;
            }
            formAtualizarApagarAlunos.textBoxTelefone.Text = dataGridViewListaDeEstudantes.CurrentRow.Cells[5].Value.ToString();
            formAtualizarApagarAlunos.textBoxEndereço.Text = dataGridViewListaDeEstudantes.CurrentRow.Cells[6].Value.ToString();

            byte[] imagem;
            imagem = (byte[])dataGridViewListaDeEstudantes.CurrentRow.Cells[7].Value;
            MemoryStream foto = new MemoryStream(imagem);
            formAtualizarApagarAlunos.pictureBoxFoto.Image = 
                Image.FromStream(foto);

            formAtualizarApagarAlunos.Show();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            // Preencha a tabela com as informações do banco de dados:
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            dataGridViewListaDeEstudantes.ReadOnly = true;
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            dataGridViewListaDeEstudantes.RowTemplate.Height = 80;
            dataGridViewListaDeEstudantes.DataSource = estudante.getEstudantes(comando);
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListaDeEstudantes.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewListaDeEstudantes.AllowUserToAddRows = false;
        }
    }
}
