namespace CoffeeSur.UI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            txtClave = new TextBox();
            textBox1 = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.Silver;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(94, 67);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(267, 28);
            txtClave.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(122, 114);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(239, 28);
            textBox1.TabIndex = 32;
            // 
            // btnIngresar
            // 
            btnIngresar.AutoSize = true;
            btnIngresar.BackColor = Color.Gainsboro;
            btnIngresar.Font = new Font("Footlight MT Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Image = (Image)resources.GetObject("btnIngresar.Image");
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(94, 178);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(112, 47);
            btnIngresar.TabIndex = 33;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextAlign = ContentAlignment.MiddleRight;
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(403, 261);
            Controls.Add(btnIngresar);
            Controls.Add(textBox1);
            Controls.Add(txtClave);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtClave;
        private TextBox textBox1;
        private Button btnIngresar;
    }
}