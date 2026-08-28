using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajos_Practicos.Practico4
{
    public partial class FormularioGrid : Form
    {
        public FormularioGrid()
        {
            InitializeComponent();
        }

        private void RBHombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Length > 0)
            {
                int posicion = TxtNombre.SelectionStart;
                TxtNombre.Text = char.ToUpper(TxtNombre.Text[0]) + TxtNombre.Text.Substring(1).ToLower();
                TxtNombre.SelectionStart = posicion;
            }
        }

        private void LSaldo_Click(object sender, EventArgs e)
        {

        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos Imagenes|*.jpg;*.bmp;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaOriginal = openFileDialog1.FileName;
                PictureBox1.Image = Image.FromFile(rutaOriginal);

                string nombreArchivo = System.IO.Path.GetFileName(rutaOriginal);
                string carpetaFotos = System.IO.Path.Combine(Application.StartupPath, "Fotos");
                string destino = System.IO.Path.Combine(carpetaFotos, nombreArchivo);

                System.IO.File.Copy(rutaOriginal, destino, true);

                TxtFoto.Text = destino;
            }
        }

        private void FormularioGrid_Load(object sender, EventArgs e)
        {
            string carpetaFotos = System.IO.Path.Combine(Application.StartupPath, "Fotos");
            if (!System.IO.Directory.Exists(carpetaFotos))
            {
                System.IO.Directory.CreateDirectory(carpetaFotos);
            }

            ConfigurarColumnasGrid();
        }

        private void ConfigurarColumnasGrid()
        {
            DDatos.Columns.Add("Apellido", "Apellido");
            DDatos.Columns.Add("Nombre", "Nombre");
            DDatos.Columns.Add("FechaNacimiento", "Fecha Nacimiento");
            DDatos.Columns.Add("Sexo", "Sexo");

            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.Name = "Eliminar";
            colEliminar.HeaderText = "Eliminar";
            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            DDatos.Columns.Add(colEliminar);

            DDatos.Columns.Add("Saldo", "Saldo");
            DDatos.Columns.Add("Ruta", "Ruta");

            // Punto 6: fuente distinta para Nombre y Apellido
            DDatos.Columns["Nombre"].DefaultCellStyle.Font = new Font("Segoe Script", 10, FontStyle.Italic);
            DDatos.Columns["Apellido"].DefaultCellStyle.Font = new Font("Segoe Script", 10, FontStyle.Italic);
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            if (TxtApellido.Text.Length > 0)
            {
                int posicion = TxtApellido.SelectionStart;
                TxtApellido.Text = char.ToUpper(TxtApellido.Text[0]) + TxtApellido.Text.Substring(1).ToLower();
                TxtApellido.SelectionStart = posicion;
            }
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "" || TxtApellido.Text == "" || TxtSaldo.Text == "")
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sexo = RBHombre.Checked ? "Hombre" : "Mujer";
            decimal saldo = Convert.ToDecimal(TxtSaldo.Text);

            int indiceFila = DDatos.Rows.Add(
                TxtApellido.Text,
                TxtNombre.Text,
                DTNacimiento.Text,
                sexo,
                "Eliminar",
                saldo,
                TxtFoto.Text
            );

            if (saldo < 50)
            {
                DDatos.Rows[indiceFila].DefaultCellStyle.BackColor = Color.Red;
            }

            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtSaldo.Clear();
            TxtFoto.Clear();
            PictureBox1.Image = null;
        }

        private void DDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DDatos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar este registro?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    DDatos.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void DDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string sexoFila = DDatos.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();

                if (sexoFila == "Hombre")
                {
                    RBHombre.Checked = true;
                }
                else
                {
                    RBMujer.Checked = true;
                }
            }
        }

        private void FormularioGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormularioMenu menu = new FormularioMenu();
            menu.Show();
        }

        private void TxtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
