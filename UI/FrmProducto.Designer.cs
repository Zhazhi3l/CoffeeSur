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
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 117);
            label1.Name = "label1";
            label1.Size = new Size(107, 29);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 180);
            label2.Name = "label2";
            label2.Size = new Size(89, 29);
            label2.TabIndex = 2;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 357);
            label3.Name = "label3";
            label3.Size = new Size(147, 29);
            label3.TabIndex = 3;
            label3.Text = "Descripción:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 229);
            label4.Name = "label4";
            label4.Size = new Size(79, 29);
            label4.TabIndex = 4;
            label4.Text = "Stock:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 305);
            label5.Name = "label5";
            label5.Size = new Size(134, 29);
            label5.TabIndex = 5;
            label5.Text = "Descuento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(155, 12);
            label6.Name = "label6";
            label6.Size = new Size(326, 39);
            label6.TabIndex = 15;
            label6.Text = "Gestión de Producto";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Wheat;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(155, 107);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(305, 34);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.Wheat;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(155, 359);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(335, 87);
            txtDescripcion.TabIndex = 5;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Font = new Font("Microsoft Sans Serif", 14.25F);
            chkActivo.Location = new Point(386, 300);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(99, 33);
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
            nudPrecio.Location = new Point(155, 169);
            nudPrecio.Margin = new Padding(3, 4, 3, 4);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(179, 34);
            nudPrecio.TabIndex = 2;
            // 
            // nudDescuento
            // 
            nudDescuento.BackColor = Color.Wheat;
            nudDescuento.DecimalPlaces = 2;
            nudDescuento.Font = new Font("Yu Gothic", 9.75F);
            nudDescuento.Location = new Point(155, 295);
            nudDescuento.Margin = new Padding(3, 4, 3, 4);
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(179, 34);
            nudDescuento.TabIndex = 4;
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.Wheat;
            nudStock.Font = new Font("Yu Gothic", 9.75F);
            nudStock.Location = new Point(155, 231);
            nudStock.Margin = new Padding(3, 4, 3, 4);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(179, 34);
            nudStock.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = Color.Gainsboro;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(94, 481);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 63);
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
            btnCancelar.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(314, 481);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 63);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(61, 65);
            label7.Name = "label7";
            label7.Size = new Size(80, 29);
            label7.TabIndex = 29;
            label7.Text = "Clave:";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.Wheat;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(155, 55);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(305, 34);
            txtClave.TabIndex = 0;
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(528, 55);
            pbImagen.Margin = new Padding(3, 4, 3, 4);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(153, 112);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 31;
            pbImagen.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.AutoSize = true;
            btnCargarImagen.BackColor = Color.Gainsboro;
            btnCargarImagen.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarImagen.Image = (Image)resources.GetObject("btnCargarImagen.Image");
            btnCargarImagen.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargarImagen.Location = new Point(528, 193);
            btnCargarImagen.Margin = new Padding(3, 4, 3, 4);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(177, 63);
            btnCargarImagen.TabIndex = 6;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.TextAlign = ContentAlignment.MiddleRight;
            btnCargarImagen.UseVisualStyleBackColor = false;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(734, 560);
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
            Margin = new Padding(3, 4, 3, 4);
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