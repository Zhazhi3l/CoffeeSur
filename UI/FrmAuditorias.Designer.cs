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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuditorias));
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
            label1.Location = new Point(600, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 37);
            label1.TabIndex = 0;
            label1.Text = "Auditorías";
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.BurlyWood;
            btnUsuarios.Font = new Font("Footlight MT Light", 14.25F);
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(93, 103);
            btnUsuarios.Margin = new Padding(4, 3, 4, 3);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(241, 67);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.BurlyWood;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(593, 103);
            btnProductos.Margin = new Padding(4, 3, 4, 3);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(241, 67);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.BurlyWood;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(1107, 103);
            btnVentas.Margin = new Padding(4, 3, 4, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(241, 67);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleRight;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // dgvAuditorias
            // 
            dgvAuditorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditorias.Location = new Point(14, 213);
            dgvAuditorias.Margin = new Padding(4, 3, 4, 3);
            dgvAuditorias.Name = "dgvAuditorias";
            dgvAuditorias.RowHeadersWidth = 51;
            dgvAuditorias.Size = new Size(1381, 395);
            dgvAuditorias.TabIndex = 4;
            // 
            // FrmAuditorias
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1370, 675);
            Controls.Add(dgvAuditorias);
            Controls.Add(btnVentas);
            Controls.Add(btnProductos);
            Controls.Add(btnUsuarios);
            Controls.Add(label1);
            Font = new Font("Footlight MT Light", 14.25F);
            Margin = new Padding(4, 3, 4, 3);
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