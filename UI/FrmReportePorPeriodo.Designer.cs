namespace CoffeeSur.UI
{
    partial class FrmReportePorPeriodo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportePorPeriodo));
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			dateTimePicker1 = new DateTimePicker();
			dateTimePicker2 = new DateTimePicker();
			dataGridView1 = new DataGridView();
			btnConsultar = new Button();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel4 = new TableLayoutPanel();
			tableLayoutPanel3 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(149, 79);
			label1.TabIndex = 1;
			label1.Text = "Fecha Inicio:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(447, 0);
			label2.Name = "label2";
			label2.Size = new Size(126, 79);
			label2.TabIndex = 2;
			label2.Text = "Fecha Fin:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Dock = DockStyle.Fill;
			label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(176, 11);
			label3.Name = "label3";
			label3.Size = new Size(513, 51);
			label3.TabIndex = 3;
			label3.Text = "Reporte de venta por producto";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Dock = DockStyle.Fill;
			dateTimePicker1.Location = new Point(158, 4);
			dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(283, 27);
			dateTimePicker1.TabIndex = 4;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Dock = DockStyle.Fill;
			dateTimePicker2.Location = new Point(579, 4);
			dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(284, 27);
			dateTimePicker2.TabIndex = 5;
			// 
			// dataGridView1
			// 
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(112, 274);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(866, 273);
			dataGridView1.TabIndex = 6;
			// 
			// btnConsultar
			// 
			btnConsultar.AutoSize = true;
			btnConsultar.BackColor = Color.DeepSkyBlue;
			btnConsultar.Dock = DockStyle.Fill;
			btnConsultar.FlatStyle = FlatStyle.Popup;
			btnConsultar.Font = new Font("Microsoft Sans Serif", 14.25F);
			btnConsultar.Image = (Image)resources.GetObject("btnConsultar.Image");
			btnConsultar.ImageAlign = ContentAlignment.MiddleLeft;
			btnConsultar.Location = new Point(176, 11);
			btnConsultar.Margin = new Padding(3, 4, 3, 4);
			btnConsultar.Name = "btnConsultar";
			btnConsultar.Size = new Size(513, 55);
			btnConsultar.TabIndex = 7;
			btnConsultar.Text = "Consultar";
			btnConsultar.UseVisualStyleBackColor = false;
			btnConsultar.Click += btnConsultar_Click;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
			tableLayoutPanel1.Controls.Add(dataGridView1, 1, 4);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 6;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle());
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
			tableLayoutPanel1.Size = new Size(1090, 572);
			tableLayoutPanel1.TabIndex = 8;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 3;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel4.Controls.Add(label3, 1, 1);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(112, 23);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 3;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
			tableLayoutPanel4.Size = new Size(866, 74);
			tableLayoutPanel4.TabIndex = 9;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 4;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(label1, 0, 0);
			tableLayoutPanel3.Controls.Add(dateTimePicker1, 1, 0);
			tableLayoutPanel3.Controls.Add(dateTimePicker2, 3, 0);
			tableLayoutPanel3.Controls.Add(label2, 2, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(112, 103);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle());
			tableLayoutPanel3.Size = new Size(866, 79);
			tableLayoutPanel3.TabIndex = 9;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 3;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
			tableLayoutPanel2.Controls.Add(btnConsultar, 1, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(112, 188);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 3;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel2.Size = new Size(866, 79);
			tableLayoutPanel2.TabIndex = 9;
			// 
			// FrmReportePorPeriodo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.PowderBlue;
			ClientSize = new Size(1090, 572);
			Controls.Add(tableLayoutPanel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FrmReportePorPeriodo";
			Text = "FrmReportePorPeriodo";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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

		private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Button btnConsultar;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private TableLayoutPanel tableLayoutPanel4;
	}
}