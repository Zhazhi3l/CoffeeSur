namespace CoffeeSur.UI
{
    partial class FrmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            chkActivo = new CheckBox();
            nudPrecio = new NumericUpDown();
            nudDescuento = new NumericUpDown();
            nudStock = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label7 = new Label();
            txtClave = new TextBox();
            pbImagen = new PictureBox();
            btnCargarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 88);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 135);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 268);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 3;
            label3.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 172);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 4;
            label4.Text = "Stock:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 229);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 5;
            label5.Text = "Descuento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(136, 9);
            label6.Name = "label6";
            label6.Size = new Size(235, 29);
            label6.TabIndex = 15;
            label6.Text = "Gestión de Producto";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Wheat;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(136, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 28);
            txtNombre.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.Wheat;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(136, 269);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(293, 66);
            txtDescripcion.TabIndex = 19;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Footlight MT Light", 14.25F);
            chkActivo.Location = new Point(338, 225);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(77, 24);
            chkActivo.TabIndex = 23;
            chkActivo.Text = "Activo";
            chkActivo.TextAlign = ContentAlignment.MiddleCenter;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // nudPrecio
            // 
            nudPrecio.BackColor = Color.Wheat;
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Font = new Font("Yu Gothic", 9.75F);
            nudPrecio.Location = new Point(136, 127);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(157, 28);
            nudPrecio.TabIndex = 24;
            // 
            // nudDescuento
            // 
            nudDescuento.BackColor = Color.Wheat;
            nudDescuento.DecimalPlaces = 2;
            nudDescuento.Font = new Font("Yu Gothic", 9.75F);
            nudDescuento.Location = new Point(136, 221);
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(157, 28);
            nudDescuento.TabIndex = 25;
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.Wheat;
            nudStock.Font = new Font("Yu Gothic", 9.75F);
            nudStock.Location = new Point(136, 173);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(157, 28);
            nudStock.TabIndex = 26;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = Color.Gainsboro;
            btnGuardar.Font = new Font("Footlight MT Light", 14.25F);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(82, 361);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 47);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.Font = new Font("Footlight MT Light", 14.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(275, 361);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 47);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(53, 49);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 29;
            label7.Text = "Clave:";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.Wheat;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(136, 41);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(267, 28);
            txtClave.TabIndex = 30;
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(462, 41);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(134, 84);
            pbImagen.TabIndex = 31;
            pbImagen.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.AutoSize = true;
            btnCargarImagen.BackColor = Color.Gainsboro;
            btnCargarImagen.Font = new Font("Footlight MT Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarImagen.Image = (Image)resources.GetObject("btnCargarImagen.Image");
            btnCargarImagen.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargarImagen.Location = new Point(462, 145);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(155, 47);
            btnCargarImagen.TabIndex = 32;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.TextAlign = ContentAlignment.MiddleRight;
            btnCargarImagen.UseVisualStyleBackColor = false;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(642, 420);
            Controls.Add(btnCargarImagen);
            Controls.Add(pbImagen);
            Controls.Add(txtClave);
            Controls.Add(label7);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(nudStock);
            Controls.Add(nudDescuento);
            Controls.Add(nudPrecio);
            Controls.Add(chkActivo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmProducto";
            Text = "FrmProducto";
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private CheckBox chkActivo;
        private NumericUpDown nudPrecio;
        private NumericUpDown nudDescuento;
        private NumericUpDown nudStock;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label7;
        private TextBox txtClave;
        private PictureBox pbImagen;
        private Button btnCargarImagen;
    }
}