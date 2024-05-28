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
            btnNovo.Location = new Point(667, 415);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(82, 35);
            btnNovo.TabIndex = 46;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(452, 206);
            txtDesc.Margin = new Padding(3, 2, 3, 2);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(297, 182);
            txtDesc.TabIndex = 45;
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(141, 207);
            txtDiagnostico.Margin = new Padding(3, 2, 3, 2);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(155, 182);
            txtDiagnostico.TabIndex = 44;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BackColor = Color.Transparent;
            lblDesc.Location = new Point(312, 213);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(134, 15);
            lblDesc.TabIndex = 43;
            lblDesc.Text = "DESCRIÇÃO DO EXAME:";
            // 
            // lblReceituario
            // 
            lblReceituario.AutoSize = true;
            lblReceituario.BackColor = Color.Transparent;
            lblReceituario.Location = new Point(41, 209);
            lblReceituario.Name = "lblReceituario";
            lblReceituario.Size = new Size(87, 15);
            lblReceituario.TabIndex = 42;
            lblReceituario.Text = "DIAGNOSTICO:";
            // 
            // lblProcure
            // 
            lblProcure.AutoSize = true;
            lblProcure.BackColor = Color.Transparent;
            lblProcure.Location = new Point(43, 17);
            lblProcure.Name = "lblProcure";
            lblProcure.Size = new Size(309, 15);
            lblProcure.TabIndex = 41;
            lblProcure.Text = "Consulte os exames agendadas e registre as informações!";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(350, 41);
            txtPesquisar.Margin = new Padding(3, 2, 3, 2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(110, 23);
            txtPesquisar.TabIndex = 40;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.BackColor = Color.Transparent;
            lblPesquisar.Location = new Point(46, 46);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(269, 15);
            lblPesquisar.TabIndex = 39;
            lblPesquisar.Text = "Pesquise os dados do animal e data para registrar:";
            // 
            // dgv_Exames
            // 
            dgv_Exames.ColumnHeadersHeight = 29;
            dgv_Exames.Location = new Point(43, 71);
            dgv_Exames.Margin = new Padding(3, 2, 3, 2);
            dgv_Exames.Name = "dgv_Exames";
            dgv_Exames.RowHeadersWidth = 51;
            dgv_Exames.Size = new Size(706, 114);
            dgv_Exames.TabIndex = 38;
            dgv_Exames.CellContentClick += dgv_Exames_CellContentClick;
            // 
            // Exame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(784, 461);
            Controls.Add(btnNovo);
            Controls.Add(txtDesc);
            Controls.Add(txtDiagnostico);
            Controls.Add(lblDesc);
            Controls.Add(lblReceituario);
            Controls.Add(lblProcure);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(dgv_Exames);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Exame";
            StartPosition = FormStartPosition.CenterScreen;
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