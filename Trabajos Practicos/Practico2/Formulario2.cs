using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajos_Practicos.Practico2
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            LModificar.Text = TApellido.Text + " " + TNombre.Text;

            if (TDni.Text == "" || TApellido.Text == "" || TNombre.Text == "")
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult ask;

                ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Insercion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El Cliente: " + TNombre.Text + " " + TApellido.Text + " se insertó correctamente",
                        "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask;

            ask = MessageBox.Show("Esta apunto de eliminar el Cliente: " + TNombre.Text + " " + TApellido.Text,
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show("El Cliente: " + TNombre.Text + " " + TApellido.Text + " se eliminó correctamente",
                    "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();
                LModificar.Text = "Modificar";
            }
        }

        private void Formulario2_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormularioMenu menu = new FormularioMenu();
            menu.Show();
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                PictureBox1.Image = Properties.Resources.varon;
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {
                PictureBox1.Image = Properties.Resources.mujer;
            }
        }
    }
}
