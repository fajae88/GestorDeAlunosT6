using System;
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
    public partial class FormEstatistica : Form
    {
        public FormEstatistica()
        {
            InitializeComponent();
        }

        Color corPainelTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;


        private void FormEstatistica_Load(object sender, EventArgs e)
        {
            corPainelTotal = panelTotalDeAlunos.BackColor;
            corPainelMeninos = panelMeninos.BackColor;
            corPainelMeninas = panelMeninas.BackColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTotalDeAlunos_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalDeAlunos_MouseEnter(object sender, EventArgs e)
        {
            panelTotalDeAlunos.BackColor = Color.Black;
            labelTotalDeAlunos.ForeColor = corPainelTotal;
        }

        private void labelTotalDeAlunos_MouseLeave(object sender, EventArgs e)
        {
            panelTotalDeAlunos.BackColor = corPainelTotal;
            labelTotalDeAlunos.ForeColor = Color.Black;
        }

        private void labelMeninos_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Black;
            labelMeninos.ForeColor = corPainelMeninos;
        }

        private void labelMeninos_MouseLeave(object sender, EventArgs e)
        {
            panelMeninos.BackColor = corPainelMeninos;
            labelMeninos.ForeColor = Color.Black;
        }

        private void labelMeninas_MouseEnter(object sender, EventArgs e)
        {
            panelMeninas.BackColor = Color.Black;
            labelMeninas.ForeColor = corPainelMeninas;
        }

        private void labelMeninas_MouseLeave(object sender, EventArgs e)
        {
            panelMeninas.BackColor = corPainelMeninas;
            labelMeninas.ForeColor = Color.Black;
        }
    }
}
