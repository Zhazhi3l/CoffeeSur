namespace CoffeeSur.UI
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button3 = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            cboRol = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 93);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 217);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 179);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "Usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 138);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 5;
            label6.Text = "Apellidos:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.ForeColor = Color.DarkGoldenrod;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(103, 322);
            button1.Name = "button1";
            button1.Size = new Size(82, 63);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.ForeColor = Color.DarkGoldenrod;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(259, 322);
            button3.Name = "button3";
            button3.Size = new Size(69, 63);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Khaki;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(134, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(267, 28);
            txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.Khaki;
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Yu Gothic", 9.75F);
            txtApellido.Location = new Point(134, 130);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(263, 28);
            txtApellido.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Footlight MT Light", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(134, 35);
            label2.Name = "label2";
            label2.Size = new Size(223, 29);
            label2.TabIndex = 14;
            label2.Text = "Gestión de Usuario";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Khaki;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Yu Gothic", 9.75F);
            txtUsername.Location = new Point(134, 171);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(263, 28);
            txtUsername.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Khaki;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Yu Gothic", 9.75F);
            txtPassword.Location = new Point(134, 217);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(263, 28);
            txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Footlight MT Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 265);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 17;
            label3.Text = "Rol:";
            // 
            // cboRol
            // 
            cboRol.BackColor = Color.Khaki;
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.Font = new Font("Yu Gothic", 9.75F);
            cboRol.FormattingEnabled = true;
            cboRol.Items.AddRange(new object[] { "Admin", "Empleado" });
            cboRol.Location = new Point(134, 262);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(263, 25);
            cboRol.TabIndex = 18;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(513, 394);
            Controls.Add(cboRol);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private ComboBox cboRol;
    }
}