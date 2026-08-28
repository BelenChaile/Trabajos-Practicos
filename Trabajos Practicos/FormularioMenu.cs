using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajos_Practicos.Practico1;
using Trabajos_Practicos.Practico2;
using Trabajos_Practicos.Practico4;

namespace Trabajos_Practicos
{
    public partial class FormularioMenu : Form
    {
        public FormularioMenu()
        {
            InitializeComponent();
        }

        private void BPractico1_Click(object sender, EventArgs e)
        {
            Formulario1 f1 = new Formulario1();
            f1.Show();
            this.Hide();
        }

        private void BPractico2_Click(object sender, EventArgs e)
        {
            Formulario2 f2 = new Formulario2();
            f2.Show();
            this.Hide();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormularioMenu_Load(object sender, EventArgs e)
        {

        }

        private void BPractico4_Click(object sender, EventArgs e)
        {
            FormularioGrid f4 = new FormularioGrid();
            f4.Show();
            this.Hide();
        }
    }
}
