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
            btnCobrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(372, 52);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Fecha Fin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Footlight MT Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(197, 9);
            label3.Name = "label3";
            label3.Size = new Size(317, 25);
            label3.TabIndex = 3;
            label3.Text = "Reporte de venta por producto";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(127, 49);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(466, 50);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(216, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 150);
            dataGridView1.TabIndex = 6;
            // 
            // btnCobrar
            // 
            btnCobrar.AutoSize = true;
            btnCobrar.BackColor = Color.DeepSkyBlue;
            btnCobrar.FlatStyle = FlatStyle.Popup;
            btnCobrar.Font = new Font("Footlight MT Light", 14.25F);
            btnCobrar.Image = (Image)resources.GetObject("btnCobrar.Image");
            btnCobrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCobrar.Location = new Point(220, 89);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(325, 46);
            btnCobrar.TabIndex = 7;
            btnCobrar.Text = "Consultar";
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // FrmReportePorPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(734, 311);
            Controls.Add(btnCobrar);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmReportePorPeriodo";
            Text = "FrmReportePorPeriodo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Button btnCobrar;
    }
}