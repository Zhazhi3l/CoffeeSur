namespace CoffeeSur.UI
{
    partial class FrmReporteComparativo
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
            tableLayoutPanel5 = new TableLayoutPanel();
            dtpFecha2 = new DateTimePicker();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            dtpFecha1 = new DateTimePicker();
            dgvListaProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnDescartar = new Button();
            btnAnalizar = new Button();
            tbCntrlSeleccionYAnalisis = new TabControl();
            tabPageSelecProductos = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            flpCOntendedorProductos = new FlowLayoutPanel();
            tabPageEstadistica = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            tbCntrlSeleccionYAnalisis.SuspendLayout();
            tabPageSelecProductos.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tabPageEstadistica.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.631579F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 94.73684F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.631579F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(914, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvListaProductos, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel2.Controls.Add(tbCntrlSeleccionYAnalisis, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(27, 33);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(859, 534);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(294, 154);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(dtpFecha2, 0, 1);
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 80);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(288, 71);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // dtpFecha2
            // 
            dtpFecha2.Dock = DockStyle.Fill;
            dtpFecha2.Location = new Point(3, 38);
            dtpFecha2.Name = "dtpFecha2";
            dtpFecha2.Size = new Size(282, 27);
            dtpFecha2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha dos";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(dtpFecha1, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(288, 71);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha uno";
            // 
            // dtpFecha1
            // 
            dtpFecha1.Dock = DockStyle.Fill;
            dtpFecha1.Location = new Point(3, 28);
            dtpFecha1.Name = "dtpFecha1";
            dtpFecha1.Size = new Size(282, 27);
            dtpFecha1.TabIndex = 1;
            // 
            // dgvListaProductos
            // 
            dgvListaProductos.AllowUserToAddRows = false;
            dgvListaProductos.AllowUserToDeleteRows = false;
            dgvListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Clave });
            dgvListaProductos.Dock = DockStyle.Fill;
            dgvListaProductos.Location = new Point(3, 163);
            dgvListaProductos.Name = "dgvListaProductos";
            dgvListaProductos.ReadOnly = true;
            dgvListaProductos.RowHeadersVisible = false;
            dgvListaProductos.RowHeadersWidth = 51;
            tableLayoutPanel2.SetRowSpan(dgvListaProductos, 2);
            dgvListaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaProductos.Size = new Size(294, 314);
            dgvListaProductos.TabIndex = 1;
            // 
            // ID
            // 
            ID.FillWeight = 56.1497345F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.FillWeight = 121.925133F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Clave
            // 
            Clave.FillWeight = 121.925133F;
            Clave.HeaderText = "Clave";
            Clave.MinimumWidth = 6;
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(btnDescartar, 1, 0);
            tableLayoutPanel6.Controls.Add(btnAnalizar, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 483);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(294, 48);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // btnDescartar
            // 
            btnDescartar.Dock = DockStyle.Fill;
            btnDescartar.Location = new Point(150, 3);
            btnDescartar.Name = "btnDescartar";
            btnDescartar.Size = new Size(141, 42);
            btnDescartar.TabIndex = 2;
            btnDescartar.Text = "Descartar";
            btnDescartar.UseVisualStyleBackColor = true;
            btnDescartar.Click += btnDescartar_Click;
            // 
            // btnAnalizar
            // 
            btnAnalizar.Dock = DockStyle.Fill;
            btnAnalizar.Location = new Point(3, 3);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(141, 42);
            btnAnalizar.TabIndex = 1;
            btnAnalizar.Text = "Analizar";
            btnAnalizar.UseVisualStyleBackColor = true;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // tbCntrlSeleccionYAnalisis
            // 
            tbCntrlSeleccionYAnalisis.Controls.Add(tabPageSelecProductos);
            tbCntrlSeleccionYAnalisis.Controls.Add(tabPageEstadistica);
            tbCntrlSeleccionYAnalisis.Dock = DockStyle.Fill;
            tbCntrlSeleccionYAnalisis.Location = new Point(303, 3);
            tbCntrlSeleccionYAnalisis.Name = "tbCntrlSeleccionYAnalisis";
            tableLayoutPanel2.SetRowSpan(tbCntrlSeleccionYAnalisis, 4);
            tbCntrlSeleccionYAnalisis.SelectedIndex = 0;
            tbCntrlSeleccionYAnalisis.Size = new Size(553, 528);
            tbCntrlSeleccionYAnalisis.TabIndex = 3;
            // 
            // tabPageSelecProductos
            // 
            tabPageSelecProductos.Controls.Add(tableLayoutPanel7);
            tabPageSelecProductos.Location = new Point(4, 29);
            tabPageSelecProductos.Name = "tabPageSelecProductos";
            tabPageSelecProductos.Padding = new Padding(3);
            tabPageSelecProductos.Size = new Size(545, 495);
            tabPageSelecProductos.TabIndex = 0;
            tabPageSelecProductos.Text = "Seleccionar productos";
            tabPageSelecProductos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel7.Controls.Add(flpCOntendedorProductos, 1, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel7.Size = new Size(539, 489);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // flpCOntendedorProductos
            // 
            flpCOntendedorProductos.AutoScroll = true;
            flpCOntendedorProductos.Dock = DockStyle.Fill;
            flpCOntendedorProductos.Location = new Point(29, 27);
            flpCOntendedorProductos.Name = "flpCOntendedorProductos";
            flpCOntendedorProductos.Size = new Size(479, 434);
            flpCOntendedorProductos.TabIndex = 0;
            // 
            // tabPageEstadistica
            // 
            tabPageEstadistica.Controls.Add(flowLayoutPanel1);
            tabPageEstadistica.Location = new Point(4, 29);
            tabPageEstadistica.Name = "tabPageEstadistica";
            tabPageEstadistica.Padding = new Padding(3);
            tabPageEstadistica.Size = new Size(545, 495);
            tabPageEstadistica.TabIndex = 1;
            tabPageEstadistica.Text = "Ventana de estadísticas";
            tabPageEstadistica.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(539, 489);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // FrmReporteComparativo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmReporteComparativo";
            Text = "FrmReporteComparativo";
            Load += FrmReporteComparativo_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tbCntrlSeleccionYAnalisis.ResumeLayout(false);
            tabPageSelecProductos.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tabPageEstadistica.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpFecha2;
        private DateTimePicker dtpFecha1;
        private DataGridView dgvListaProductos;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnAnalizar;
        private TabControl tbCntrlSeleccionYAnalisis;
        private TabPage tabPageSelecProductos;
        private TabPage tabPageEstadistica;
        private TableLayoutPanel tableLayoutPanel7;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Clave;
        private Button btnDescartar;
        private FlowLayoutPanel flpCOntendedorProductos;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}