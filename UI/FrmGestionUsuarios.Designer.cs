namespace CoffeeSur.UI
{
    partial class FrmGestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionUsuarios));
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(115, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(353, 150);
            dataGridView1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.BackColor = Color.PaleGoldenrod;
            btnAgregar.Font = new Font("Footlight MT Light", 14.25F);
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(22, 58);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(125, 47);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = true;
            btnModificar.BackColor = Color.PaleGoldenrod;
            btnModificar.Font = new Font("Footlight MT Light", 14.25F);
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(215, 58);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(125, 47);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.BackColor = Color.PaleGoldenrod;
            btnEliminar.Font = new Font("Footlight MT Light", 14.25F);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(417, 58);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 47);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // FrmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(584, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Name = "FrmGestionUsuarios";
            Text = "FrmGestionUsuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}