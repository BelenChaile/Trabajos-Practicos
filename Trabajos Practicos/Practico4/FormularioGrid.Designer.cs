namespace Trabajos_Practicos.Practico4
{
    partial class FormularioGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioGrid));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LSaldo = new System.Windows.Forms.Label();
            this.LSexo = new System.Windows.Forms.Label();
            this.LFechaNacimiento = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.TxtFoto = new System.Windows.Forms.TextBox();
            this.BFoto = new System.Windows.Forms.Button();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.RBHombre = new System.Windows.Forms.RadioButton();
            this.DTNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.DDatos = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.LSaldo);
            this.panel1.Controls.Add(this.LSexo);
            this.panel1.Controls.Add(this.LFechaNacimiento);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.TxtFoto);
            this.panel1.Controls.Add(this.BFoto);
            this.panel1.Controls.Add(this.TxtSaldo);
            this.panel1.Controls.Add(this.RBMujer);
            this.panel1.Controls.Add(this.RBHombre);
            this.panel1.Controls.Add(this.DTNacimiento);
            this.panel1.Controls.Add(this.TxtApellido);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(142, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 361);
            this.panel1.TabIndex = 0;
            // 
            // LSaldo
            // 
            this.LSaldo.AutoSize = true;
            this.LSaldo.BackColor = System.Drawing.Color.Transparent;
            this.LSaldo.Location = new System.Drawing.Point(8, 242);
            this.LSaldo.Name = "LSaldo";
            this.LSaldo.Size = new System.Drawing.Size(78, 33);
            this.LSaldo.TabIndex = 13;
            this.LSaldo.Text = "Saldo:";
            this.LSaldo.Click += new System.EventHandler(this.LSaldo_Click);
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.BackColor = System.Drawing.Color.Transparent;
            this.LSexo.Location = new System.Drawing.Point(8, 181);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(70, 33);
            this.LSexo.TabIndex = 12;
            this.LSexo.Text = "Sexo:";
            // 
            // LFechaNacimiento
            // 
            this.LFechaNacimiento.AutoSize = true;
            this.LFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.LFechaNacimiento.Location = new System.Drawing.Point(7, 122);
            this.LFechaNacimiento.Name = "LFechaNacimiento";
            this.LFechaNacimiento.Size = new System.Drawing.Size(184, 33);
            this.LFechaNacimiento.TabIndex = 11;
            this.LFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.BackColor = System.Drawing.Color.Transparent;
            this.LApellido.Location = new System.Drawing.Point(6, 59);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(98, 33);
            this.LApellido.TabIndex = 10;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.BackColor = System.Drawing.Color.Transparent;
            this.LNombre.Location = new System.Drawing.Point(8, 12);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(92, 33);
            this.LNombre.TabIndex = 9;
            this.LNombre.Text = "Nombre:";
            // 
            // TxtFoto
            // 
            this.TxtFoto.Location = new System.Drawing.Point(114, 300);
            this.TxtFoto.Name = "TxtFoto";
            this.TxtFoto.Size = new System.Drawing.Size(100, 41);
            this.TxtFoto.TabIndex = 8;
            // 
            // BFoto
            // 
            this.BFoto.ForeColor = System.Drawing.Color.Black;
            this.BFoto.Location = new System.Drawing.Point(11, 308);
            this.BFoto.Name = "BFoto";
            this.BFoto.Size = new System.Drawing.Size(75, 33);
            this.BFoto.TabIndex = 7;
            this.BFoto.Text = "Foto";
            this.BFoto.UseVisualStyleBackColor = true;
            this.BFoto.Click += new System.EventHandler(this.BFoto_Click);
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(114, 234);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(100, 41);
            this.TxtSaldo.TabIndex = 6;
            this.TxtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaldo_KeyPress);
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.BackColor = System.Drawing.Color.Transparent;
            this.RBMujer.Location = new System.Drawing.Point(197, 177);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(88, 37);
            this.RBMujer.TabIndex = 5;
            this.RBMujer.TabStop = true;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = false;
            // 
            // RBHombre
            // 
            this.RBHombre.AutoSize = true;
            this.RBHombre.BackColor = System.Drawing.Color.Transparent;
            this.RBHombre.Location = new System.Drawing.Point(84, 177);
            this.RBHombre.Name = "RBHombre";
            this.RBHombre.Size = new System.Drawing.Size(107, 37);
            this.RBHombre.TabIndex = 4;
            this.RBHombre.TabStop = true;
            this.RBHombre.Text = "Hombre";
            this.RBHombre.UseVisualStyleBackColor = false;
            this.RBHombre.CheckedChanged += new System.EventHandler(this.RBHombre_CheckedChanged);
            // 
            // DTNacimiento
            // 
            this.DTNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNacimiento.Location = new System.Drawing.Point(197, 116);
            this.DTNacimiento.Name = "DTNacimiento";
            this.DTNacimiento.Size = new System.Drawing.Size(149, 41);
            this.DTNacimiento.TabIndex = 3;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(131, 59);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 41);
            this.TxtApellido.TabIndex = 2;
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            this.TxtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellido_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(131, 12);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 41);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.Location = new System.Drawing.Point(574, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(203, 203);
            this.PictureBox1.TabIndex = 14;
            this.PictureBox1.TabStop = false;
            // 
            // BGuardar
            // 
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(237, 379);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(96, 47);
            this.BGuardar.TabIndex = 15;
            this.BGuardar.Text = "Agregar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // DDatos
            // 
            this.DDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DDatos.Location = new System.Drawing.Point(12, 436);
            this.DDatos.Name = "DDatos";
            this.DDatos.Size = new System.Drawing.Size(776, 123);
            this.DDatos.TabIndex = 16;
            this.DDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DDatos_CellClick);
            this.DDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DDatos_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormularioGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.DDatos);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormularioGrid";
            this.Text = "Formulario con Grid";
            this.Load += new System.EventHandler(this.FormularioGrid_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.RadioButton RBHombre;
        private System.Windows.Forms.DateTimePicker DTNacimiento;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TxtFoto;
        private System.Windows.Forms.Button BFoto;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.Label LFechaNacimiento;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LSaldo;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.DataGridView DDatos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}