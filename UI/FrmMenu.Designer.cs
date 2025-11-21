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
            btnGestUsu = new Button();
            btnGestProd = new Button();
            btnGestVent = new Button();
            SuspendLayout();
            // 
            // btnGestUsu
            // 
            btnGestUsu.AutoSize = true;
            btnGestUsu.BackColor = Color.PaleGoldenrod;
            btnGestUsu.Font = new Font("Footlight MT Light", 14.25F);
            btnGestUsu.Image = (Image)resources.GetObject("btnGestUsu.Image");
            btnGestUsu.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestUsu.Location = new Point(181, 45);
            btnGestUsu.Name = "btnGestUsu";
            btnGestUsu.Size = new Size(219, 47);
            btnGestUsu.TabIndex = 0;
            btnGestUsu.Text = "Gestión de Usuarios";
            btnGestUsu.TextAlign = ContentAlignment.MiddleRight;
            btnGestUsu.UseVisualStyleBackColor = false;
            btnGestUsu.Click += btnGestUsu_Click;
            // 
            // btnGestProd
            // 
            btnGestProd.AutoSize = true;
            btnGestProd.BackColor = Color.PaleGoldenrod;
            btnGestProd.Font = new Font("Footlight MT Light", 14.25F);
            btnGestProd.Image = (Image)resources.GetObject("btnGestProd.Image");
            btnGestProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestProd.Location = new Point(181, 115);
            btnGestProd.Name = "btnGestProd";
            btnGestProd.Size = new Size(219, 47);
            btnGestProd.TabIndex = 1;
            btnGestProd.Text = "Gestión de Productos";
            btnGestProd.TextAlign = ContentAlignment.MiddleRight;
            btnGestProd.UseVisualStyleBackColor = false;
            btnGestProd.Click += btnGestProd_Click;
            // 
            // btnGestVent
            // 
            btnGestVent.AutoSize = true;
            btnGestVent.BackColor = Color.PaleGoldenrod;
            btnGestVent.Font = new Font("Footlight MT Light", 14.25F);
            btnGestVent.Image = (Image)resources.GetObject("btnGestVent.Image");
            btnGestVent.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestVent.Location = new Point(181, 189);
            btnGestVent.Name = "btnGestVent";
            btnGestVent.Size = new Size(219, 47);
            btnGestVent.TabIndex = 2;
            btnGestVent.Text = "Gestión de Ventas";
            btnGestVent.TextAlign = ContentAlignment.MiddleRight;
            btnGestVent.UseVisualStyleBackColor = false;
            btnGestVent.Click += btnGestVent_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(584, 450);
            Controls.Add(btnGestVent);
            Controls.Add(btnGestProd);
            Controls.Add(btnGestUsu);
            Name = "FrmMenu";
            Text = "FrmMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGestUsu;
        private Button btnGestProd;
        private Button btnGestVent;
    }
}