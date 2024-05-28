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
            btnConsulta.Location = new Point(282, 64);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(181, 29);
            btnConsulta.TabIndex = 0;
            btnConsulta.Text = "AGENDAR CONSULTA";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnExame
            // 
            btnExame.Location = new Point(486, 64);
            btnExame.Name = "btnExame";
            btnExame.Size = new Size(144, 29);
            btnExame.TabIndex = 1;
            btnExame.Text = "AGENDAR EXAME";
            btnExame.UseVisualStyleBackColor = true;
            btnExame.Click += btnExame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 20);
            label1.Name = "label1";
            label1.Size = new Size(211, 20);
            label1.TabIndex = 2;
            label1.Text = "Clique no que deseja agendar!";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(322, 118);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(141, 27);
            txtPesquisar.TabIndex = 25;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(12, 125);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(304, 20);
            lblPesquisar.TabIndex = 24;
            lblPesquisar.Text = "Pesquise os animais cadastrados e selecione:";
            // 
            // dgv_Animais
            // 
            dgv_Animais.ColumnHeadersHeight = 29;
            dgv_Animais.Location = new Point(12, 165);
            dgv_Animais.Name = "dgv_Animais";
            dgv_Animais.RowHeadersWidth = 51;
            dgv_Animais.Size = new Size(451, 264);
            dgv_Animais.TabIndex = 39;
            dgv_Animais.CellContentClick += dgv_Animais_CellContentClick;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(584, 274);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(326, 27);
            dtpData.TabIndex = 41;
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // Agendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 552);
            Controls.Add(dtpData);
            Controls.Add(dgv_Animais);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(label1);
            Controls.Add(btnExame);
            Controls.Add(btnConsulta);
            Name = "Agendar";
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