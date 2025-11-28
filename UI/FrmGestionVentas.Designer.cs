namespace CoffeeSur.UI
{
    partial class FrmGestionVentas
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            cmbFiltros = new ComboBox();
            label1 = new Label();
            tabCtrlVentas = new TabControl();
            tabPgVentas = new TabPage();
            dgvTablaVentas = new DataGridView();
            tabPgDetallesVenta = new TabPage();
            dgvDetallesVenta = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabCtrlVentas.SuspendLayout();
            tabPgVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaVentas).BeginInit();
            tabPgDetallesVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.BurlyWood;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tabCtrlVentas, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(43, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Size = new Size(714, 399);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(cmbFiltros, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(708, 53);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // cmbFiltros
            // 
            cmbFiltros.Dock = DockStyle.Fill;
            cmbFiltros.FormattingEnabled = true;
            cmbFiltros.Items.AddRange(new object[] { "Ninguno", "Ventas de hoy" });
            cmbFiltros.Location = new Point(3, 29);
            cmbFiltros.Name = "cmbFiltros";
            cmbFiltros.Size = new Size(348, 28);
            cmbFiltros.TabIndex = 0;
            cmbFiltros.SelectedIndexChanged += cmbFiltros_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Filtros";
            // 
            // tabCtrlVentas
            // 
            tabCtrlVentas.Controls.Add(tabPgVentas);
            tabCtrlVentas.Controls.Add(tabPgDetallesVenta);
            tabCtrlVentas.Dock = DockStyle.Fill;
            tabCtrlVentas.Location = new Point(3, 62);
            tabCtrlVentas.Name = "tabCtrlVentas";
            tabCtrlVentas.SelectedIndex = 0;
            tabCtrlVentas.Size = new Size(708, 334);
            tabCtrlVentas.TabIndex = 2;
            // 
            // tabPgVentas
            // 
            tabPgVentas.Controls.Add(dgvTablaVentas);
            tabPgVentas.Location = new Point(4, 29);
            tabPgVentas.Name = "tabPgVentas";
            tabPgVentas.Padding = new Padding(3);
            tabPgVentas.Size = new Size(700, 301);
            tabPgVentas.TabIndex = 0;
            tabPgVentas.Text = "Ventas";
            tabPgVentas.UseVisualStyleBackColor = true;
            // 
            // dgvTablaVentas
            // 
            dgvTablaVentas.AllowUserToAddRows = false;
            dgvTablaVentas.AllowUserToDeleteRows = false;
            dgvTablaVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTablaVentas.BackgroundColor = Color.Peru;
            dgvTablaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaVentas.Dock = DockStyle.Fill;
            dgvTablaVentas.Location = new Point(3, 3);
            dgvTablaVentas.MultiSelect = false;
            dgvTablaVentas.Name = "dgvTablaVentas";
            dgvTablaVentas.ReadOnly = true;
            dgvTablaVentas.RowHeadersVisible = false;
            dgvTablaVentas.RowHeadersWidth = 51;
            dgvTablaVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTablaVentas.Size = new Size(694, 295);
            dgvTablaVentas.TabIndex = 0;
            dgvTablaVentas.SelectionChanged += dgvTablaVentas_SelectionChanged;
            // 
            // tabPgDetallesVenta
            // 
            tabPgDetallesVenta.Controls.Add(dgvDetallesVenta);
            tabPgDetallesVenta.Location = new Point(4, 29);
            tabPgDetallesVenta.Name = "tabPgDetallesVenta";
            tabPgDetallesVenta.Padding = new Padding(3);
            tabPgDetallesVenta.Size = new Size(700, 301);
            tabPgDetallesVenta.TabIndex = 1;
            tabPgDetallesVenta.Text = "Detalles de Venta";
            tabPgDetallesVenta.UseVisualStyleBackColor = true;
            // 
            // dgvDetallesVenta
            // 
            dgvDetallesVenta.AllowUserToAddRows = false;
            dgvDetallesVenta.AllowUserToDeleteRows = false;
            dgvDetallesVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallesVenta.BackgroundColor = Color.Peru;
            dgvDetallesVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallesVenta.Dock = DockStyle.Fill;
            dgvDetallesVenta.Location = new Point(3, 3);
            dgvDetallesVenta.MultiSelect = false;
            dgvDetallesVenta.Name = "dgvDetallesVenta";
            dgvDetallesVenta.ReadOnly = true;
            dgvDetallesVenta.RowHeadersVisible = false;
            dgvDetallesVenta.RowHeadersWidth = 51;
            dgvDetallesVenta.Size = new Size(694, 295);
            dgvDetallesVenta.TabIndex = 1;
            // 
            // FrmGestionVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmGestionVentas";
            Text = "Gestión de Ventas";
            Load += FrmGestionVentas_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tabCtrlVentas.ResumeLayout(false);
            tabPgVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTablaVentas).EndInit();
            tabPgDetallesVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetallesVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvTablaVentas;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox cmbFiltros;
        private Label label1;
        private TabControl tabCtrlVentas;
        private TabPage tabPgVentas;
        private TabPage tabPgDetallesVenta;
        private DataGridView dgvDetallesVenta;
    }
}