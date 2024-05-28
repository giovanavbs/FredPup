namespace VetSystem
{
    partial class Inicio
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
            btnNovo = new Button();
            btnConsulta = new Button();
            btnExame = new Button();
            lblInicio1 = new Label();
            lblInicio2 = new Label();
            btnAgendar = new Button();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(19, 89);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(113, 79);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "CADASTRAR NOVO ANIMAL";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(169, 180);
            btnConsulta.Margin = new Padding(3, 2, 3, 2);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(107, 77);
            btnConsulta.TabIndex = 1;
            btnConsulta.Text = "REGISTRAR INFORMAÇÕES DE CONSULTA";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnExame
            // 
            btnExame.Location = new Point(19, 180);
            btnExame.Margin = new Padding(3, 2, 3, 2);
            btnExame.Name = "btnExame";
            btnExame.Size = new Size(113, 77);
            btnExame.TabIndex = 2;
            btnExame.Text = "REGISTRAR INFORMAÇÕES DE EXAME";
            btnExame.UseVisualStyleBackColor = true;
            btnExame.Click += btnExame_Click;
            // 
            // lblInicio1
            // 
            lblInicio1.AutoSize = true;
            lblInicio1.Location = new Point(9, 9);
            lblInicio1.Name = "lblInicio1";
            lblInicio1.Size = new Size(130, 15);
            lblInicio1.TabIndex = 3;
            lblInicio1.Text = "Bem-Vindo ao Sistema!";
            // 
            // lblInicio2
            // 
            lblInicio2.AutoSize = true;
            lblInicio2.Location = new Point(70, 56);
            lblInicio2.Name = "lblInicio2";
            lblInicio2.Size = new Size(165, 15);
            lblInicio2.TabIndex = 4;
            lblInicio2.Text = "Qual operação deseja realizar?";
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(169, 89);
            btnAgendar.Margin = new Padding(3, 2, 3, 2);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(107, 79);
            btnAgendar.TabIndex = 5;
            btnAgendar.Text = "AGENDAR NOVA CONSULTA OU EXAME";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 301);
            Controls.Add(btnAgendar);
            Controls.Add(lblInicio2);
            Controls.Add(lblInicio1);
            Controls.Add(btnExame);
            Controls.Add(btnConsulta);
            Controls.Add(btnNovo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inicio";
            Text = "inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovo;
        private Button btnConsulta;
        private Button btnExame;
        private Label lblInicio1;
        private Label lblInicio2;
        private Button btnAgendar;
    }
}