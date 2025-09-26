namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMostrar = new TextBox();
            btnImportar = new Button();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // txtMostrar
            // 
            txtMostrar.Location = new Point(12, 12);
            txtMostrar.Multiline = true;
            txtMostrar.Name = "txtMostrar";
            txtMostrar.Size = new Size(349, 291);
            txtMostrar.TabIndex = 0;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(367, 12);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(98, 68);
            btnImportar.TabIndex = 1;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += Listar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(367, 86);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(98, 68);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(txtMostrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMostrar;
        private Button btnImportar;
        private Button btnExportar;
    }
}
