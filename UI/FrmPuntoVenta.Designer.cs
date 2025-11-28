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
            pnlLineaVenta.SuspendLayout();
            pnlInfoVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDetalle).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLineaVenta
            // 
            pnlLineaVenta.BackColor = Color.Moccasin;
            pnlLineaVenta.Controls.Add(pnlInfoVenta);
            pnlLineaVenta.Controls.Add(dgvVenta);
            pnlLineaVenta.Controls.Add(lblLineaVenta);
            pnlLineaVenta.Dock = DockStyle.Left;
            pnlLineaVenta.Location = new Point(0, 0);
            pnlLineaVenta.Name = "pnlLineaVenta";
            pnlLineaVenta.Size = new Size(323, 461);
            pnlLineaVenta.TabIndex = 0;
            // 
            // pnlInfoVenta
            // 
            pnlInfoVenta.BackColor = Color.PaleGoldenrod;
            pnlInfoVenta.Controls.Add(lblFecha);
            pnlInfoVenta.Controls.Add(lblHora);
            pnlInfoVenta.Controls.Add(lblUsuario);
            pnlInfoVenta.Dock = DockStyle.Top;
            pnlInfoVenta.Location = new Point(0, 0);
            pnlInfoVenta.Name = "pnlInfoVenta";
            pnlInfoVenta.Size = new Size(323, 53);
            pnlInfoVenta.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(214, 16);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "label1";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(120, 16);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(38, 15);
            lblHora.TabIndex = 1;
            lblHora.Text = "label1";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(3, 16);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "label1";
            // 
            // dgvVenta
            // 
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Columns.AddRange(new DataGridViewColumn[] { Cantidad, Producto, Precio, Descuento });
            dgvVenta.Dock = DockStyle.Bottom;
            dgvVenta.Location = new Point(0, 207);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersWidth = 51;
            dgvVenta.Size = new Size(323, 254);
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
            lblLineaVenta.Location = new Point(3, 56);
            lblLineaVenta.Name = "lblLineaVenta";
            lblLineaVenta.Size = new Size(137, 24);
            lblLineaVenta.TabIndex = 0;
            lblLineaVenta.Text = "Linea de Venta";
            // 
            // flpProductos
            // 
            flpProductos.AutoScroll = true;
            flpProductos.AutoSize = true;
            flpProductos.BackColor = Color.AntiqueWhite;
            flpProductos.Dock = DockStyle.Fill;
            flpProductos.Location = new Point(323, 0);
            flpProductos.Name = "flpProductos";
            flpProductos.Size = new Size(561, 461);
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
            pnlDetalle.Location = new Point(684, 0);
            pnlDetalle.Name = "pnlDetalle";
            pnlDetalle.Size = new Size(200, 461);
            pnlDetalle.TabIndex = 2;
            // 
            // lblDetalleId
            // 
            lblDetalleId.AutoSize = true;
            lblDetalleId.Location = new Point(43, 112);
            lblDetalleId.Name = "lblDetalleId";
            lblDetalleId.Size = new Size(0, 15);
            lblDetalleId.TabIndex = 5;
            lblDetalleId.Visible = false;
            // 
            // btnMenos
            // 
            btnMenos.AutoSize = true;
            btnMenos.BackColor = Color.PaleGoldenrod;
            btnMenos.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnMenos.Image = (Image)resources.GetObject("btnMenos.Image");
            btnMenos.Location = new Point(107, 213);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(58, 47);
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
            btnMas.Location = new Point(34, 207);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(52, 47);
            btnMas.TabIndex = 3;
            btnMas.TextAlign = ContentAlignment.MiddleRight;
            btnMas.UseVisualStyleBackColor = false;
            btnMas.Click += btnMas_Click;
            // 
            // lblDetallePrecio
            // 
            lblDetallePrecio.AutoSize = true;
            lblDetallePrecio.Location = new Point(43, 161);
            lblDetallePrecio.Name = "lblDetallePrecio";
            lblDetallePrecio.Size = new Size(73, 15);
            lblDetallePrecio.TabIndex = 2;
            lblDetallePrecio.Text = "Precio: $0.00";
            // 
            // lblDetalleNombre
            // 
            lblDetalleNombre.AutoSize = true;
            lblDetalleNombre.Location = new Point(43, 136);
            lblDetalleNombre.Name = "lblDetalleNombre";
            lblDetalleNombre.Size = new Size(122, 15);
            lblDetalleNombre.TabIndex = 1;
            lblDetalleNombre.Text = "Nombre del producto";
            // 
            // picDetalle
            // 
            picDetalle.BackgroundImageLayout = ImageLayout.Zoom;
            picDetalle.Location = new Point(43, 19);
            picDetalle.Name = "picDetalle";
            picDetalle.Size = new Size(122, 90);
            picDetalle.SizeMode = PictureBoxSizeMode.Zoom;
            picDetalle.TabIndex = 0;
            picDetalle.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnCobrar);
            panel1.Controls.Add(lblTotal);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(323, 361);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 100);
            panel1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.BackColor = Color.PaleGoldenrod;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 14.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(154, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 47);
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
            btnCobrar.Location = new Point(26, 41);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(108, 47);
            btnCobrar.TabIndex = 4;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.MiddleRight;
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(63, 19);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "label1";
            // 
            // FrmPuntoVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(panel1);
            Controls.Add(pnlDetalle);
            Controls.Add(flpProductos);
            Controls.Add(pnlLineaVenta);
            Name = "FrmPuntoVenta";
            Text = "FrmPuntoVenta";
            pnlLineaVenta.ResumeLayout(false);
            pnlLineaVenta.PerformLayout();
            pnlInfoVenta.ResumeLayout(false);
            pnlInfoVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            pnlDetalle.ResumeLayout(false);
            pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDetalle).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}