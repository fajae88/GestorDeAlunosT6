﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeAlunoT6
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void listarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaDeEstudantes formListaDeEstudantes = new FormListaDeEstudantes();
            formListaDeEstudantes.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudante inserirEstudante = new FormInserirEstudante();
            inserirEstudante.Show();
        }
    }
}
