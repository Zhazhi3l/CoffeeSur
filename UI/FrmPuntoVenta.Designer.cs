namespace CoffeeSur.UI
{
    partial class FrmPuntoVenta
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuntoVenta));
            pnlLineaVenta = new Panel();
            pnlInfoVenta = new Panel();
            lblFecha = new Label();
            lblHora = new Label();
            lblUsuario = new Label();
            dgvVenta = new DataGridView();
            Cantidad = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            lblLineaVenta = new Label();
            flpProductos = new FlowLayoutPanel();
            pnlDetalle = new Panel();
            lblDetalleId = new Label();
            btnMenos = new Button();
            btnMas = new Button();
            lblDetallePrecio = new Label();
            lblDetalleNombre = new Label();
            picDetalle = new PictureBox();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnCobrar = new Button();
            lblTotal = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlLineaVenta.SuspendLayout();
            pnlInfoVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDetalle).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLineaVenta
            // 
            pnlLineaVenta.BackColor = Color.Moccasin;
            pnlLineaVenta.Controls.Add(tableLayoutPanel2);
            pnlLineaVenta.Dock = DockStyle.Left;
            pnlLineaVenta.Location = new Point(0, 0);
            pnlLineaVenta.Margin = new Padding(3, 4, 3, 4);
            pnlLineaVenta.Name = "pnlLineaVenta";
            pnlLineaVenta.Size = new Size(369, 615);
            pnlLineaVenta.TabIndex = 0;
            // 
            // pnlInfoVenta
            // 
            pnlInfoVenta.BackColor = Color.PaleGoldenrod;
            pnlInfoVenta.Controls.Add(lblFecha);
            pnlInfoVenta.Controls.Add(lblHora);
            pnlInfoVenta.Controls.Add(lblUsuario);
            pnlInfoVenta.Dock = DockStyle.Fill;
            pnlInfoVenta.Location = new Point(3, 4);
            pnlInfoVenta.Margin = new Padding(3, 4, 3, 4);
            pnlInfoVenta.Name = "pnlInfoVenta";
            pnlInfoVenta.Size = new Size(363, 71);
            pnlInfoVenta.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(245, 21);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "label1";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(137, 21);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(50, 20);
            lblHora.TabIndex = 1;
            lblHora.Text = "label1";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(3, 21);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "label1";
            // 
            // dgvVenta
            // 
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Columns.AddRange(new DataGridViewColumn[] { Cantidad, Producto, Precio, Descuento });
            dgvVenta.Dock = DockStyle.Fill;
            dgvVenta.Location = new Point(3, 112);
            dgvVenta.Margin = new Padding(3, 4, 3, 4);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersVisible = false;
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.Size = new Size(363, 499);
            dgvVenta.TabIndex = 1;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.MinimumWidth = 6;
            Descuento.Name = "Descuento";
            // 
            // lblLineaVenta
            // 
            lblLineaVenta.AutoSize = true;
            lblLineaVenta.Font = new Font("Microsoft Sans Serif", 14.25F);
            lblLineaVenta.Location = new Point(3, 79);
            lblLineaVenta.Name = "lblLineaVenta";
            lblLineaVenta.Size = new Size(173, 29);
            lblLineaVenta.TabIndex = 0;
            lblLineaVenta.Text = "Linea de Venta";
            // 
            // flpProductos
            // 
            flpProductos.AutoScroll = true;
            flpProductos.AutoSize = true;
            flpProductos.BackColor = Color.AntiqueWhite;
            flpProductos.Dock = DockStyle.Fill;
            flpProductos.Location = new Point(3, 4);
            flpProductos.Margin = new Padding(3, 4, 3, 4);
            flpProductos.Name = "flpProductos";
            flpProductos.Size = new Size(406, 484);
            flpProductos.TabIndex = 1;
            // 
            // pnlDetalle
            // 
            pnlDetalle.BackColor = Color.Wheat;
            pnlDetalle.Controls.Add(lblDetalleId);
            pnlDetalle.Controls.Add(btnMenos);
            pnlDetalle.Controls.Add(btnMas);
            pnlDetalle.Controls.Add(lblDetallePrecio);
            pnlDetalle.Controls.Add(lblDetalleNombre);
            pnlDetalle.Controls.Add(picDetalle);
            pnlDetalle.Dock = DockStyle.Right;
            pnlDetalle.Location = new Point(781, 0);
            pnlDetalle.Margin = new Padding(3, 4, 3, 4);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(229, 615);
            pnlDetalle.TabIndex = 2;
            // 
            // lblDetalleId
            // 
            lblDetalleId.AutoSize = true;
            lblDetalleId.Location = new Point(49, 149);
            lblDetalleId.Name = "lblDetalleId";
            lblDetalleId.Size = new Size(0, 20);
            lblDetalleId.TabIndex = 5;
            lblDetalleId.Visible = false;
            // 
            // btnMenos
            // 
            btnMenos.AutoSize = true;
            btnMenos.BackColor = Color.PaleGoldenrod;
            btnMenos.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnMenos.Image = (Image)resources.GetObject("btnMenos.Image");
            btnMenos.Location = new Point(122, 276);
            btnMenos.Margin = new Padding(3, 4, 3, 4);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(66, 63);
            btnMenos.TabIndex = 4;
            btnMenos.TextAlign = ContentAlignment.MiddleRight;
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.Click += btnMenos_Click;
            // 
            // btnMas
            // 
            btnMas.AutoSize = true;
            btnMas.BackColor = Color.PaleGoldenrod;
            btnMas.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnMas.Image = (Image)resources.GetObject("btnMas.Image");
            btnMas.Location = new Point(39, 276);
            btnMas.Margin = new Padding(3, 4, 3, 4);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(59, 63);
            btnMas.TabIndex = 3;
            btnMas.TextAlign = ContentAlignment.MiddleRight;
            btnMas.UseVisualStyleBackColor = false;
            btnMas.Click += btnMas_Click;
            // 
            // lblDetallePrecio
            // 
            lblDetallePrecio.AutoSize = true;
            lblDetallePrecio.Location = new Point(49, 215);
            lblDetallePrecio.Name = "lblDetallePrecio";
            lblDetallePrecio.Size = new Size(92, 20);
            lblDetallePrecio.TabIndex = 2;
            lblDetallePrecio.Text = "Precio: $0.00";
            // 
            // lblDetalleNombre
            // 
            lblDetalleNombre.AutoSize = true;
            lblDetalleNombre.Location = new Point(49, 181);
            lblDetalleNombre.Name = "lblDetalleNombre";
            lblDetalleNombre.Size = new Size(154, 20);
            lblDetalleNombre.TabIndex = 1;
            lblDetalleNombre.Text = "Nombre del producto";
            // 
            // picDetalle
            // 
            picDetalle.BackgroundImageLayout = ImageLayout.Zoom;
            picDetalle.Location = new Point(49, 25);
            picDetalle.Margin = new Padding(3, 4, 3, 4);
            picDetalle.Name = "picDetalle";
            picDetalle.Size = new Size(139, 120);
            picDetalle.SizeMode = PictureBoxSizeMode.Zoom;
            picDetalle.TabIndex = 0;
            picDetalle.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnCobrar);
            panel1.Controls.Add(lblTotal);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 496);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 115);
            panel1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.BackColor = Color.PaleGoldenrod;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(183, 48);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(5, 0, 5, 0);
            btnCancelar.Size = new Size(161, 63);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCobrar
            // 
            btnCobrar.AutoSize = true;
            btnCobrar.BackColor = Color.PaleGoldenrod;
            btnCobrar.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnCobrar.Image = (Image)resources.GetObject("btnCobrar.Image");
            btnCobrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCobrar.Location = new Point(17, 48);
            btnCobrar.Margin = new Padding(3, 4, 3, 4);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Padding = new Padding(5, 0, 5, 0);
            btnCobrar.Size = new Size(160, 63);
            btnCobrar.TabIndex = 4;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.MiddleRight;
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(75, 24);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 20);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "$0.0";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(flpProductos, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(369, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(412, 615);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 6;
            label1.Text = "Total:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(lblLineaVenta, 0, 1);
            tableLayoutPanel2.Controls.Add(dgvVenta, 0, 2);
            tableLayoutPanel2.Controls.Add(pnlInfoVenta, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(369, 615);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // FrmPuntoVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 615);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlDetalle);
            Controls.Add(pnlLineaVenta);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPuntoVenta";
            Text = "FrmPuntoVenta";
            pnlLineaVenta.ResumeLayout(false);
            pnlInfoVenta.ResumeLayout(false);
            pnlInfoVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            pnlDetalle.ResumeLayout(false);
            pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDetalle).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLineaVenta;
        private Label lblLineaVenta;
        private DataGridView dgvVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Descuento;
        private FlowLayoutPanel flpProductos;
        private Panel pnlDetalle;
        private PictureBox picDetalle;
        private Label lblDetallePrecio;
        private Label lblDetalleNombre;
        private Button btnMas;
        private Button btnMenos;
        private Panel panel1;
        private Label lblTotal;
        private Button btnCancelar;
        private Button btnCobrar;
        private Panel pnlInfoVenta;
        private Label lblUsuario;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer Timer;
        private Label lblDetalleId;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
    }
}