namespace Trabajos_Practicos
{
    partial class FormularioMenu
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
            this.BPractico1 = new System.Windows.Forms.Button();
            this.BPractico2 = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BPractico4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BPractico1
            // 
            this.BPractico1.BackColor = System.Drawing.Color.Gray;
            this.BPractico1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BPractico1.Location = new System.Drawing.Point(55, 12);
            this.BPractico1.Name = "BPractico1";
            this.BPractico1.Size = new System.Drawing.Size(112, 33);
            this.BPractico1.TabIndex = 0;
            this.BPractico1.Text = "Practico 1";
            this.BPractico1.UseVisualStyleBackColor = false;
            this.BPractico1.Click += new System.EventHandler(this.BPractico1_Click);
            // 
            // BPractico2
            // 
            this.BPractico2.BackColor = System.Drawing.Color.Gray;
            this.BPractico2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BPractico2.Location = new System.Drawing.Point(55, 51);
            this.BPractico2.Name = "BPractico2";
            this.BPractico2.Size = new System.Drawing.Size(112, 30);
            this.BPractico2.TabIndex = 1;
            this.BPractico2.Text = "Practico 2/3";
            this.BPractico2.UseVisualStyleBackColor = false;
            this.BPractico2.Click += new System.EventHandler(this.BPractico2_Click);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Maroon;
            this.BSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BSalir.Location = new System.Drawing.Point(147, 176);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(75, 23);
            this.BSalir.TabIndex = 2;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BPractico4
            // 
            this.BPractico4.BackColor = System.Drawing.Color.Gray;
            this.BPractico4.ForeColor = System.Drawing.Color.White;
            this.BPractico4.Location = new System.Drawing.Point(55, 87);
            this.BPractico4.Name = "BPractico4";
            this.BPractico4.Size = new System.Drawing.Size(112, 29);
            this.BPractico4.TabIndex = 3;
            this.BPractico4.Text = "Practico 4";
            this.BPractico4.UseVisualStyleBackColor = false;
            this.BPractico4.Click += new System.EventHandler(this.BPractico4_Click);
            // 
            // FormularioMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.BPractico4);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BPractico2);
            this.Controls.Add(this.BPractico1);
            this.Name = "FormularioMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Practicos";
            this.Load += new System.EventHandler(this.FormularioMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BPractico1;
        private System.Windows.Forms.Button BPractico2;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BPractico4;
    }
}