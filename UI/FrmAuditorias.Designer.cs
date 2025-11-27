namespace CoffeeSur.UI
{
	partial class FrmAuditorias
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
			btnUsuarios = new Button();
			btnProductos = new Button();
			btnVentas = new Button();
			dgvAuditorias = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvAuditorias).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(480, 9);
			label1.Name = "label1";
			label1.Size = new Size(187, 46);
			label1.TabIndex = 0;
			label1.Text = "Auditorías";
			// 
			// btnUsuarios
			// 
			btnUsuarios.Location = new Point(74, 103);
			btnUsuarios.Name = "btnUsuarios";
			btnUsuarios.Size = new Size(193, 66);
			btnUsuarios.TabIndex = 1;
			btnUsuarios.Text = "Usuarios";
			btnUsuarios.UseVisualStyleBackColor = true;
			btnUsuarios.Click += btnUsuarios_Click;
			// 
			// btnProductos
			// 
			btnProductos.Location = new Point(474, 103);
			btnProductos.Name = "btnProductos";
			btnProductos.Size = new Size(193, 66);
			btnProductos.TabIndex = 2;
			btnProductos.Text = "Productos";
			btnProductos.UseVisualStyleBackColor = true;
			btnProductos.Click += btnProductos_Click;
			// 
			// btnVentas
			// 
			btnVentas.Location = new Point(886, 103);
			btnVentas.Name = "btnVentas";
			btnVentas.Size = new Size(193, 66);
			btnVentas.TabIndex = 3;
			btnVentas.Text = "Ventas";
			btnVentas.UseVisualStyleBackColor = true;
			btnVentas.Click += btnVentas_Click;
			// 
			// dgvAuditorias
			// 
			dgvAuditorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvAuditorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvAuditorias.Location = new Point(12, 213);
			dgvAuditorias.Name = "dgvAuditorias";
			dgvAuditorias.RowHeadersWidth = 51;
			dgvAuditorias.Size = new Size(1105, 394);
			dgvAuditorias.TabIndex = 4;
			// 
			// FrmAuditorias
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1129, 675);
			Controls.Add(dgvAuditorias);
			Controls.Add(btnVentas);
			Controls.Add(btnProductos);
			Controls.Add(btnUsuarios);
			Controls.Add(label1);
			Name = "FrmAuditorias";
			Text = "FrmAuditorias";
			((System.ComponentModel.ISupportInitialize)dgvAuditorias).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button btnUsuarios;
		private Button btnProductos;
		private Button btnVentas;
		private DataGridView dgvAuditorias;
	}
}