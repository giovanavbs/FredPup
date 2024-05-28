namespace VetSystem
{
    partial class Exame
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
            txtDesc = new TextBox();
            txtDiagnostico = new TextBox();
            lblDesc = new Label();
            lblReceituario = new Label();
            lblProcure = new Label();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            dgv_Exames = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_Exames).BeginInit();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(826, 519);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 46;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(560, 251);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(360, 242);
            txtDesc.TabIndex = 45;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(167, 251);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(177, 242);
            txtDiagnostico.TabIndex = 44;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(362, 258);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(169, 20);
            lblDesc.TabIndex = 43;
            lblDesc.Text = "DESCRIÇÃO DO EXAME:";
            // 
            // lblReceituario
            // 
            lblReceituario.AutoSize = true;
            lblReceituario.Location = new Point(52, 254);
            lblReceituario.Name = "lblReceituario";
            lblReceituario.Size = new Size(109, 20);
            lblReceituario.TabIndex = 42;
            lblReceituario.Text = "DIAGNOSTICO:";
            // 
            // lblProcure
            // 
            lblProcure.AutoSize = true;
            lblProcure.Location = new Point(49, 23);
            lblProcure.Name = "lblProcure";
            lblProcure.Size = new Size(390, 20);
            lblProcure.TabIndex = 41;
            lblProcure.Text = "Consulte os exames agendadas e registre as informações!";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(400, 55);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(125, 27);
            txtPesquisar.TabIndex = 40;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(52, 62);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(342, 20);
            lblPesquisar.TabIndex = 39;
            lblPesquisar.Text = "Pesquise os dados do animal e data para registrar:";
            // 
            // dgv_Exames
            // 
            dgv_Exames.ColumnHeadersHeight = 29;
            dgv_Exames.Location = new Point(49, 95);
            dgv_Exames.Name = "dgv_Exames";
            dgv_Exames.RowHeadersWidth = 51;
            dgv_Exames.Size = new Size(871, 120);
            dgv_Exames.TabIndex = 38;
            dgv_Exames.CellContentClick += dgv_Exames_CellContentClick;
            // 
            // Exame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 560);
            Controls.Add(btnNovo);
            Controls.Add(txtDesc);
            Controls.Add(txtDiagnostico);
            Controls.Add(lblDesc);
            Controls.Add(lblReceituario);
            Controls.Add(lblProcure);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(dgv_Exames);
            Name = "Exame";
            Text = "Exame";
            Load += Exame_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Exames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNovo;
        private TextBox txtDesc;
        private TextBox txtDiagnostico;
        private Label lblDesc;
        private Label lblReceituario;
        private Label lblProcure;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private DataGridView dgv_Exames;
    }
}