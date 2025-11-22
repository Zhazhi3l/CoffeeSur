namespace CoffeeSur
{
    partial class ProductoCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblPrecio = new Label();
            lblNombre = new Label();
            picImagen = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(picImagen);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 157);
            panel1.TabIndex = 0;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Dock = DockStyle.Top;
            lblPrecio.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(0, 117);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(51, 17);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "\"$0.00\"";
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Dock = DockStyle.Top;
            lblNombre.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(0, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "\"Nombre\"";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picImagen
            // 
            picImagen.Dock = DockStyle.Top;
            picImagen.Location = new Point(0, 0);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(155, 100);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // ProductoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ProductoCard";
            Size = new Size(157, 157);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPrecio;
        private Label lblNombre;
        private PictureBox picImagen;
    }
}
