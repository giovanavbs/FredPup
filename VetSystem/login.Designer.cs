namespace VetSystem
{
    partial class Login
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
            txtEmail = new TextBox();
            btnLogar = new Button();
            lblEmail = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 160);
            txtEmail.Margin = new Padding(5, 5, 5, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(132, 27);
            txtEmail.TabIndex = 0;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(89, 294);
            btnLogar.Margin = new Padding(5, 5, 5, 5);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(113, 51);
            btnLogar.TabIndex = 2;
            btnLogar.Text = "LOGIN";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Location = new Point(35, 164);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "EMAIL";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Location = new Point(35, 237);
            lblSenha.Margin = new Padding(5, 0, 5, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(57, 20);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "SENHA";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(117, 230);
            txtSenha.Margin = new Padding(5, 5, 5, 5);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(132, 27);
            txtSenha.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_05_28_at_14_49_10;
            ClientSize = new Size(300, 396);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(btnLogar);
            Controls.Add(txtEmail);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load_2;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
    }
}
