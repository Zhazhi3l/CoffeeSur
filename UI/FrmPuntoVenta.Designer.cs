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
            dgvVenta = new DataGridView();
            Cantidad = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            lblLineaVenta = new Label();
            flpProductos = new FlowLayoutPanel();
            pnlDetalle = new Panel();
            button1 = new Button();
            btnMas = new Button();
            lblDetallePrecio = new Label();
            lblDetalleNombre = new Label();
            picDetalle = new PictureBox();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnCobrar = new Button();
            lblTotal = new Label();
            pnlInfoVenta = new Panel();
            lblFecha = new Label();
            lblHora = new Label();
            lblUsuario = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            pnlLineaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDetalle).BeginInit();
            panel1.SuspendLayout();
            pnlInfoVenta.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLineaVenta
            // 
            pnlLineaVenta.BackColor = Color.Moccasin;
            pnlLineaVenta.Controls.Add(dgvVenta);
            pnlLineaVenta.Controls.Add(lblLineaVenta);
            pnlLineaVenta.Dock = DockStyle.Left;
            pnlLineaVenta.Location = new Point(0, 0);
            pnlLineaVenta.Name = "pnlLineaVenta";
            pnlLineaVenta.Size = new Size(246, 461);
            pnlLineaVenta.TabIndex = 0;
            // 
            // dgvVenta
            // 
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Columns.AddRange(new DataGridViewColumn[] { Cantidad, Producto, Precio, Descuento });
            dgvVenta.Dock = DockStyle.Bottom;
            dgvVenta.Location = new Point(0, 207);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.Size = new Size(246, 254);
            dgvVenta.TabIndex = 1;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            // 
            // lblLineaVenta
            // 
            lblLineaVenta.AutoSize = true;
            lblLineaVenta.Dock = DockStyle.Top;
            lblLineaVenta.Font = new Font("Footlight MT Light", 14.25F);
            lblLineaVenta.Location = new Point(0, 0);
            lblLineaVenta.Name = "lblLineaVenta";
            lblLineaVenta.Size = new Size(125, 20);
            lblLineaVenta.TabIndex = 0;
            lblLineaVenta.Text = "Linea de Venta";
            // 
            // flpProductos
            // 
            flpProductos.AutoScroll = true;
            flpProductos.AutoSize = true;
            flpProductos.BackColor = Color.AntiqueWhite;
            flpProductos.Dock = DockStyle.Fill;
            flpProductos.Location = new Point(246, 0);
            flpProductos.Name = "flpProductos";
            flpProductos.Size = new Size(638, 461);
            flpProductos.TabIndex = 1;
            flpProductos.Paint += flpProductos_Paint;
            // 
            // pnlDetalle
            // 
            pnlDetalle.BackColor = Color.Wheat;
            pnlDetalle.Controls.Add(button1);
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
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.PaleGoldenrod;
            button1.Font = new Font("Footlight MT Light", 14.25F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(107, 213);
            button1.Name = "button1";
            button1.Size = new Size(58, 47);
            button1.TabIndex = 4;
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnMas
            // 
            btnMas.AutoSize = true;
            btnMas.BackColor = Color.PaleGoldenrod;
            btnMas.Font = new Font("Footlight MT Light", 14.25F);
            btnMas.Image = (Image)resources.GetObject("btnMas.Image");
            btnMas.Location = new Point(30, 213);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(52, 47);
            btnMas.TabIndex = 3;
            btnMas.TextAlign = ContentAlignment.MiddleRight;
            btnMas.UseVisualStyleBackColor = false;
            // 
            // lblDetallePrecio
            // 
            lblDetallePrecio.AutoSize = true;
            lblDetallePrecio.Location = new Point(69, 181);
            lblDetallePrecio.Name = "lblDetallePrecio";
            lblDetallePrecio.Size = new Size(38, 15);
            lblDetallePrecio.TabIndex = 2;
            lblDetallePrecio.Text = "label1";
            // 
            // lblDetalleNombre
            // 
            lblDetalleNombre.AutoSize = true;
            lblDetalleNombre.Location = new Point(65, 141);
            lblDetalleNombre.Name = "lblDetalleNombre";
            lblDetalleNombre.Size = new Size(38, 15);
            lblDetalleNombre.TabIndex = 1;
            lblDetalleNombre.Text = "label1";
            // 
            // picDetalle
            // 
            picDetalle.Location = new Point(65, 59);
            picDetalle.Name = "picDetalle";
            picDetalle.Size = new Size(100, 50);
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
            panel1.Location = new Point(246, 361);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 100);
            panel1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.BackColor = Color.PaleGoldenrod;
            btnCancelar.Font = new Font("Footlight MT Light", 14.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(154, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 47);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCobrar
            // 
            btnCobrar.AutoSize = true;
            btnCobrar.BackColor = Color.PaleGoldenrod;
            btnCobrar.Font = new Font("Footlight MT Light", 14.25F);
            btnCobrar.Image = (Image)resources.GetObject("btnCobrar.Image");
            btnCobrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCobrar.Location = new Point(26, 41);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(108, 47);
            btnCobrar.TabIndex = 4;
            btnCobrar.Text = "Cobrar";
            btnCobrar.TextAlign = ContentAlignment.MiddleRight;
            btnCobrar.UseVisualStyleBackColor = false;
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
            // pnlInfoVenta
            // 
            pnlInfoVenta.BackColor = Color.PaleGoldenrod;
            pnlInfoVenta.Controls.Add(lblFecha);
            pnlInfoVenta.Controls.Add(lblHora);
            pnlInfoVenta.Controls.Add(lblUsuario);
            pnlInfoVenta.Dock = DockStyle.Top;
            pnlInfoVenta.Location = new Point(246, 0);
            pnlInfoVenta.Name = "pnlInfoVenta";
            pnlInfoVenta.Size = new Size(438, 53);
            pnlInfoVenta.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(305, 19);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "label1";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(154, 15);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(38, 15);
            lblHora.TabIndex = 1;
            lblHora.Text = "label1";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(23, 15);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "label1";
            // 
            // FrmPuntoVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(pnlInfoVenta);
            Controls.Add(panel1);
            Controls.Add(pnlDetalle);
            Controls.Add(flpProductos);
            Controls.Add(pnlLineaVenta);
            Name = "FrmPuntoVenta";
            Text = "FrmPuntoVenta";
            pnlLineaVenta.ResumeLayout(false);
            pnlLineaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            pnlDetalle.ResumeLayout(false);
            pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDetalle).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlInfoVenta.ResumeLayout(false);
            pnlInfoVenta.PerformLayout();
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
        private Button button1;
        private Panel panel1;
        private Label lblTotal;
        private Button btnCancelar;
        private Button btnCobrar;
        private Panel pnlInfoVenta;
        private Label lblUsuario;
        private Label lblFecha;
        private Label lblHora;
        private System.Windows.Forms.Timer Timer;
    }
}