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
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            chkActivo = new CheckBox();
            nudPrecio = new NumericUpDown();
            nudDescuento = new NumericUpDown();
            nudStock = new NumericUpDown();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtClave = new TextBox();
            pbImagen = new PictureBox();
            btnCargarImagen = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Wheat;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(3, 86);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(323, 34);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.Wheat;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel3.SetColumnSpan(txtDescripcion, 2);
            txtDescripcion.Dock = DockStyle.Fill;
            txtDescripcion.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(3, 272);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(671, 185);
            txtDescripcion.TabIndex = 5;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.BackColor = Color.Wheat;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Font = new Font("Microsoft Sans Serif", 10F);
            chkActivo.Location = new Point(341, 148);
            chkActivo.Margin = new Padding(3, 4, 3, 4);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(77, 24);
            chkActivo.TabIndex = 23;
            chkActivo.Text = "Activo";
            chkActivo.TextAlign = ContentAlignment.MiddleCenter;
            chkActivo.UseVisualStyleBackColor = false;
            // 
            // nudPrecio
            // 
            nudPrecio.BackColor = Color.Wheat;
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Font = new Font("Yu Gothic", 9.75F);
            nudPrecio.Location = new Point(3, 210);
            nudPrecio.Margin = new Padding(3, 4, 3, 4);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(179, 34);
            nudPrecio.TabIndex = 3;
            // 
            // nudDescuento
            // 
            nudDescuento.BackColor = Color.Wheat;
            nudDescuento.DecimalPlaces = 2;
            nudDescuento.Font = new Font("Yu Gothic", 9.75F);
            nudDescuento.Location = new Point(341, 210);
            nudDescuento.Margin = new Padding(3, 4, 3, 4);
            nudDescuento.Name = "nudDescuento";
            nudDescuento.Size = new Size(179, 34);
            nudDescuento.TabIndex = 4;
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.Wheat;
            nudStock.Font = new Font("Yu Gothic", 9.75F);
            nudStock.Location = new Point(3, 148);
            nudStock.Margin = new Padding(3, 4, 3, 4);
            nudStock.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(179, 34);
            nudStock.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = Color.Gainsboro;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(3, 465);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(5, 0, 5, 0);
            btnGuardar.Size = new Size(332, 41);
            btnGuardar.TabIndex = 6;
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
            btnCancelar.Location = new Point(341, 465);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(5, 0, 5, 0);
            btnCancelar.Size = new Size(333, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.Wheat;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(3, 24);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(160, 34);
            txtClave.TabIndex = 0;
            // 
            // pbImagen
            // 
            pbImagen.Dock = DockStyle.Fill;
            pbImagen.Location = new Point(3, 4);
            pbImagen.Margin = new Padding(3, 4, 3, 4);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(307, 237);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagen.TabIndex = 31;
            pbImagen.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.AutoSize = true;
            btnCargarImagen.BackColor = Color.Gainsboro;
            btnCargarImagen.Dock = DockStyle.Fill;
            btnCargarImagen.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCargarImagen.Image = (Image)resources.GetObject("btnCargarImagen.Image");
            btnCargarImagen.ImageAlign = ContentAlignment.MiddleLeft;
            btnCargarImagen.Location = new Point(3, 249);
            btnCargarImagen.Margin = new Padding(3, 4, 3, 4);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Padding = new Padding(5, 0, 5, 0);
            btnCargarImagen.Size = new Size(307, 73);
            btnCargarImagen.TabIndex = 0;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.TextAlign = ContentAlignment.MiddleRight;
            btnCargarImagen.UseVisualStyleBackColor = false;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(1120, 687);
            tableLayoutPanel1.TabIndex = 32;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.1818161F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.818182F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(59, 37);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel4.Size = new Size(1002, 612);
            tableLayoutPanel4.TabIndex = 35;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(txtDescripcion, 0, 14);
            tableLayoutPanel3.Controls.Add(label7, 0, 13);
            tableLayoutPanel3.Controls.Add(txtClave, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 2);
            tableLayoutPanel3.Controls.Add(txtNombre, 0, 4);
            tableLayoutPanel3.Controls.Add(label3, 0, 6);
            tableLayoutPanel3.Controls.Add(nudStock, 0, 7);
            tableLayoutPanel3.Controls.Add(label4, 0, 8);
            tableLayoutPanel3.Controls.Add(nudDescuento, 1, 10);
            tableLayoutPanel3.Controls.Add(nudPrecio, 0, 10);
            tableLayoutPanel3.Controls.Add(label5, 1, 8);
            tableLayoutPanel3.Controls.Add(chkActivo, 1, 7);
            tableLayoutPanel3.Controls.Add(label8, 1, 6);
            tableLayoutPanel3.Controls.Add(btnGuardar, 0, 15);
            tableLayoutPanel3.Controls.Add(btnCancelar, 1, 15);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 64);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 16;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(677, 545);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(3, 248);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 34;
            label7.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 29;
            label1.Text = "Clave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 30;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(3, 124);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 31;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(3, 186);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 32;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(341, 186);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 33;
            label5.Text = "Descuento";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(341, 124);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 34;
            label8.Text = "Estado";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pbImagen, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCargarImagen, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(686, 64);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Size = new Size(313, 545);
            tableLayoutPanel2.TabIndex = 33;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 329);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(307, 213);
            tableLayoutPanel5.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(326, 39);
            label6.TabIndex = 35;
            label6.Text = "Gestión de Producto";
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(1120, 687);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProducto";
            Text = "FrmProducto";
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private CheckBox chkActivo;
        private NumericUpDown nudPrecio;
        private NumericUpDown nudDescuento;
        private NumericUpDown nudStock;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtClave;
        private PictureBox pbImagen;
        private Button btnCargarImagen;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label7;
    }
}