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
			label1 = new Label();
			label2 = new Label();
			cmbMes1 = new ComboBox();
			cmbMes2 = new ComboBox();
			clbPanes = new CheckedListBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(14, 47);
			label1.Name = "label1";
			label1.Size = new Size(78, 25);
			label1.TabIndex = 2;
			label1.Text = "Mes 1:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(14, 108);
			label2.Name = "label2";
			label2.Size = new Size(78, 25);
			label2.TabIndex = 3;
			label2.Text = "Mes 2:";
			// 
			// cmbMes1
			// 
			cmbMes1.FormattingEnabled = true;
			cmbMes1.Location = new Point(91, 48);
			cmbMes1.Margin = new Padding(3, 4, 3, 4);
			cmbMes1.Name = "cmbMes1";
			cmbMes1.Size = new Size(239, 28);
			cmbMes1.TabIndex = 4;
			cmbMes1.SelectedIndexChanged += cmbMes1_SelectedIndexChanged;
			// 
			// cmbMes2
			// 
			cmbMes2.FormattingEnabled = true;
			cmbMes2.Location = new Point(91, 104);
			cmbMes2.Margin = new Padding(3, 4, 3, 4);
			cmbMes2.Name = "cmbMes2";
			cmbMes2.Size = new Size(239, 28);
			cmbMes2.TabIndex = 5;
			// 
			// clbPanes
			// 
			clbPanes.FormattingEnabled = true;
			clbPanes.Location = new Point(459, 60);
			clbPanes.Margin = new Padding(3, 4, 3, 4);
			clbPanes.Name = "clbPanes";
			clbPanes.Size = new Size(137, 114);
			clbPanes.TabIndex = 6;
			// 
			// FrmReporteComparativo
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(914, 600);
			Controls.Add(clbPanes);
			Controls.Add(cmbMes2);
			Controls.Add(cmbMes1);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "FrmReporteComparativo";
			Text = "FrmReporteComparativo";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private ComboBox cmbMes1;
        private ComboBox cmbMes2;
        private CheckedListBox clbPanes;
    }
}