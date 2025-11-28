
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            cmbRol = new ComboBox();
            chkActivo = new CheckBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
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
            // txtUser
            // 
            txtUser.BackColor = Color.Khaki;
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Yu Gothic", 9.75F);
            txtUser.Location = new Point(134, 171);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(263, 28);
            txtUser.TabIndex = 15;
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
            // cmbRol
            // 
            cmbRol.BackColor = Color.Khaki;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Yu Gothic", 9.75F);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(134, 262);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(263, 25);
            cmbRol.TabIndex = 18;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Footlight MT Light", 14.25F);
            chkActivo.Location = new Point(134, 306);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(77, 24);
            chkActivo.TabIndex = 24;
            chkActivo.Text = "Activo";
            chkActivo.TextAlign = ContentAlignment.MiddleCenter;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.AutoSize = true;
            btnAceptar.BackColor = Color.Gainsboro;
            btnAceptar.Font = new Font("Footlight MT Light", 14.25F);
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAceptar.Location = new Point(61, 355);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(118, 47);
            btnAceptar.TabIndex = 28;
            btnAceptar.Text = "Aceptar";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.BackColor = Color.Gainsboro;
            btnCancelar.Font = new Font("Footlight MT Light", 14.25F);
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(214, 355);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 47);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmUsuario
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(513, 430);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(chkActivo);
            Controls.Add(cmbRol);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
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
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label3;
        private ComboBox cmbRol;
        private CheckBox chkActivo;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}