namespace VetSystem
{
    partial class Agendar
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
            btnConsulta = new Button();
            btnExame = new Button();
            label1 = new Label();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            dgv_Animais = new DataGridView();
            dtpData = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_Animais).BeginInit();
            SuspendLayout();
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(42, 354);
            btnConsulta.Margin = new Padding(3, 2, 3, 2);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(158, 22);
            btnConsulta.TabIndex = 0;
            btnConsulta.Text = "AGENDAR CONSULTA";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnExame
            // 
            btnExame.Location = new Point(220, 354);
            btnExame.Margin = new Padding(3, 2, 3, 2);
            btnExame.Name = "btnExame";
            btnExame.Size = new Size(126, 22);
            btnExame.TabIndex = 1;
            btnExame.Text = "AGENDAR EXAME";
            btnExame.UseVisualStyleBackColor = true;
            btnExame.Click += btnExame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(167, 22);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Escolha a data!";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(258, 86);
            txtPesquisar.Margin = new Padding(3, 2, 3, 2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(124, 23);
            txtPesquisar.TabIndex = 25;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.BackColor = Color.Transparent;
            lblPesquisar.Location = new Point(10, 94);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(242, 15);
            lblPesquisar.TabIndex = 24;
            lblPesquisar.Text = "Pesquise os animais cadastrados e selecione:";
            // 
            // dgv_Animais
            // 
            dgv_Animais.ColumnHeadersHeight = 29;
            dgv_Animais.Location = new Point(10, 124);
            dgv_Animais.Margin = new Padding(3, 2, 3, 2);
            dgv_Animais.Name = "dgv_Animais";
            dgv_Animais.RowHeadersWidth = 51;
            dgv_Animais.Size = new Size(395, 198);
            dgv_Animais.TabIndex = 39;
            dgv_Animais.CellContentClick += dgv_Animais_CellContentClick;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(60, 52);
            dtpData.Margin = new Padding(3, 2, 3, 2);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(286, 23);
            dtpData.TabIndex = 41;
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // Agendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(434, 411);
            Controls.Add(dtpData);
            Controls.Add(dgv_Animais);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(label1);
            Controls.Add(btnExame);
            Controls.Add(btnConsulta);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Agendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendar";
            Load += Agendar_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Animais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsulta;
        private Button btnExame;
        private Label label1;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private DataGridView dgv_Animais;
        private DateTimePicker dtpData;
    }
}