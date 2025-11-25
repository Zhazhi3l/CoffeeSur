namespace CoffeeSur.UI
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            btnGestionUsuarios = new Button();
            btnGestionProductos = new Button();
            btnGestionVentas = new Button();
            lblUsuario = new Label();
            btnReportePorPedido = new Button();
            btnReporteComparatibo = new Button();
            SuspendLayout();
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.AutoSize = true;
            btnGestionUsuarios.BackColor = Color.PaleGoldenrod;
            btnGestionUsuarios.Font = new Font("Footlight MT Light", 14.25F);
            btnGestionUsuarios.Image = (Image)resources.GetObject("btnGestionUsuarios.Image");
            btnGestionUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionUsuarios.Location = new Point(31, 48);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(219, 47);
            btnGestionUsuarios.TabIndex = 0;
            btnGestionUsuarios.Text = "Gestión de Usuarios";
            btnGestionUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnGestionUsuarios.UseVisualStyleBackColor = false;
            btnGestionUsuarios.Click += btnGestionUsuarios_Click;
            // 
            // btnGestionProductos
            // 
            btnGestionProductos.AutoSize = true;
            btnGestionProductos.BackColor = Color.PaleGoldenrod;
            btnGestionProductos.Font = new Font("Footlight MT Light", 14.25F);
            btnGestionProductos.Image = (Image)resources.GetObject("btnGestionProductos.Image");
            btnGestionProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionProductos.Location = new Point(278, 48);
            btnGestionProductos.Name = "btnGestionProductos";
            btnGestionProductos.Size = new Size(219, 47);
            btnGestionProductos.TabIndex = 1;
            btnGestionProductos.Text = "Gestión de Productos";
            btnGestionProductos.TextAlign = ContentAlignment.MiddleRight;
            btnGestionProductos.UseVisualStyleBackColor = false;
            btnGestionProductos.Click += btnGestionProductos_Click;
            // 
            // btnGestionVentas
            // 
            btnGestionVentas.AutoSize = true;
            btnGestionVentas.BackColor = Color.PaleGoldenrod;
            btnGestionVentas.Font = new Font("Footlight MT Light", 14.25F);
            btnGestionVentas.Image = (Image)resources.GetObject("btnGestionVentas.Image");
            btnGestionVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestionVentas.Location = new Point(31, 125);
            btnGestionVentas.Name = "btnGestionVentas";
            btnGestionVentas.Size = new Size(219, 47);
            btnGestionVentas.TabIndex = 2;
            btnGestionVentas.Text = "Gestión de Ventas";
            btnGestionVentas.TextAlign = ContentAlignment.MiddleRight;
            btnGestionVentas.UseVisualStyleBackColor = false;
            btnGestionVentas.Click += btnGestionVentas_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Footlight MT Light", 14.25F);
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(57, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "label1";
            // 
            // btnReportePorPedido
            // 
            btnReportePorPedido.AutoSize = true;
            btnReportePorPedido.BackColor = Color.PaleGoldenrod;
            btnReportePorPedido.Font = new Font("Footlight MT Light", 14.25F);
            btnReportePorPedido.Image = (Image)resources.GetObject("btnReportePorPedido.Image");
            btnReportePorPedido.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportePorPedido.Location = new Point(278, 125);
            btnReportePorPedido.Name = "btnReportePorPedido";
            btnReportePorPedido.Size = new Size(219, 47);
            btnReportePorPedido.TabIndex = 4;
            btnReportePorPedido.Text = "Reporte por pediodo";
            btnReportePorPedido.TextAlign = ContentAlignment.MiddleRight;
            btnReportePorPedido.UseVisualStyleBackColor = false;
            btnReportePorPedido.Click += btnReportePorPedido_Click;
            // 
            // btnReporteComparatibo
            // 
            btnReporteComparatibo.AutoSize = true;
            btnReporteComparatibo.BackColor = Color.PaleGoldenrod;
            btnReporteComparatibo.Font = new Font("Footlight MT Light", 14.25F);
            btnReporteComparatibo.Image = (Image)resources.GetObject("btnReporteComparatibo.Image");
            btnReporteComparatibo.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporteComparatibo.Location = new Point(130, 203);
            btnReporteComparatibo.Name = "btnReporteComparatibo";
            btnReporteComparatibo.Size = new Size(219, 47);
            btnReporteComparatibo.TabIndex = 5;
            btnReporteComparatibo.Text = "Reporte comparativo";
            btnReporteComparatibo.TextAlign = ContentAlignment.MiddleRight;
            btnReporteComparatibo.UseVisualStyleBackColor = false;
            btnReporteComparatibo.Click += btnReporteComparativo_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(520, 303);
            Controls.Add(btnReporteComparatibo);
            Controls.Add(btnReportePorPedido);
            Controls.Add(lblUsuario);
            Controls.Add(btnGestionVentas);
            Controls.Add(btnGestionProductos);
            Controls.Add(btnGestionUsuarios);
            Name = "FrmMenu";
            Text = "FrmMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGestionUsuarios;
        private Button btnGestionProductos;
        private Button btnGestionVentas;
        private Label lblUsuario;
        private Button btnReportePorPedido;
        private Button btnReporteComparatibo;
    }
}