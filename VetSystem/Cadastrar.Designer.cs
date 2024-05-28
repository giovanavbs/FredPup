namespace VetSystem
{
    partial class Cadastrar
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
            lblNome = new Label();
            lblRaca = new Label();
            lblPeso = new Label();
            lblSexo = new Label();
            lblTutor = new Label();
            lblTelefone = new Label();
            lblEspecie = new Label();
            lblEmail = new Label();
            picImage = new PictureBox();
            btnImage = new Button();
            txtNome = new TextBox();
            txtSexo = new TextBox();
            txtPeso = new TextBox();
            txtRaca = new TextBox();
            txtEspecie = new TextBox();
            txtTutor = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            dgv_Animais = new DataGridView();
            btnNovo = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            txtCodPet = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Animais).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Transparent;
            lblNome.Location = new Point(204, 14);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(42, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "NOME";
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.BackColor = Color.Transparent;
            lblRaca.Location = new Point(208, 47);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(38, 15);
            lblRaca.TabIndex = 1;
            lblRaca.Text = "RAÇA";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.BackColor = Color.Transparent;
            lblPeso.Location = new Point(208, 86);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(35, 15);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "PESO";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = Color.Transparent;
            lblSexo.Location = new Point(210, 118);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(35, 15);
            lblSexo.TabIndex = 3;
            lblSexo.Text = "SEXO";
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.BackColor = Color.Transparent;
            lblTutor.Location = new Point(478, 17);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(42, 15);
            lblTutor.TabIndex = 4;
            lblTutor.Text = "TUTOR";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Location = new Point(478, 51);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(61, 15);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "TELEFONE";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.BackColor = Color.Transparent;
            lblEspecie.Location = new Point(202, 157);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(49, 15);
            lblEspecie.TabIndex = 6;
            lblEspecie.Text = "ESPECIE";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Location = new Point(480, 81);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "EMAIL";
            // 
            // picImage
            // 
            picImage.Location = new Point(60, 28);
            picImage.Margin = new Padding(3, 2, 3, 2);
            picImage.Name = "picImage";
            picImage.Size = new Size(108, 117);
            picImage.TabIndex = 8;
            picImage.TabStop = false;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(60, 150);
            btnImage.Margin = new Padding(3, 2, 3, 2);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(108, 27);
            btnImage.TabIndex = 9;
            btnImage.Text = "carregar..";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(269, 9);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(110, 23);
            txtNome.TabIndex = 10;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(269, 116);
            txtSexo.Margin = new Padding(3, 2, 3, 2);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(110, 23);
            txtSexo.TabIndex = 11;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(269, 81);
            txtPeso.Margin = new Padding(3, 2, 3, 2);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(110, 23);
            txtPeso.TabIndex = 12;
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(269, 42);
            txtRaca.Margin = new Padding(3, 2, 3, 2);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(110, 23);
            txtRaca.TabIndex = 13;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(269, 154);
            txtEspecie.Margin = new Padding(3, 2, 3, 2);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(110, 23);
            txtEspecie.TabIndex = 14;
            // 
            // txtTutor
            // 
            txtTutor.Location = new Point(558, 12);
            txtTutor.Margin = new Padding(3, 2, 3, 2);
            txtTutor.Name = "txtTutor";
            txtTutor.Size = new Size(110, 23);
            txtTutor.TabIndex = 15;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(558, 47);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(110, 23);
            txtTelefone.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(558, 81);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 17;
            // 
            // dgv_Animais
            // 
            dgv_Animais.ColumnHeadersHeight = 29;
            dgv_Animais.Location = new Point(38, 238);
            dgv_Animais.Margin = new Padding(3, 2, 3, 2);
            dgv_Animais.Name = "dgv_Animais";
            dgv_Animais.RowHeadersWidth = 51;
            dgv_Animais.Size = new Size(556, 203);
            dgv_Animais.TabIndex = 25;
            dgv_Animais.CellMouseDoubleClick += dgv_Animais_CellMouseDoubleClick;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(647, 288);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(98, 33);
            btnNovo.TabIndex = 19;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(647, 337);
            btnAlterar.Margin = new Padding(3, 2, 3, 2);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(98, 33);
            btnAlterar.TabIndex = 20;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(647, 384);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(98, 33);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.BackColor = Color.Transparent;
            lblPesquisar.Location = new Point(38, 201);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(60, 15);
            lblPesquisar.TabIndex = 22;
            lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(107, 199);
            txtPesquisar.Margin = new Padding(3, 2, 3, 2);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(110, 23);
            txtPesquisar.TabIndex = 23;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // txtCodPet
            // 
            txtCodPet.Location = new Point(-5, 444);
            txtCodPet.Margin = new Padding(3, 2, 3, 2);
            txtCodPet.Name = "txtCodPet";
            txtCodPet.ReadOnly = true;
            txtCodPet.Size = new Size(10, 23);
            txtCodPet.TabIndex = 24;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(784, 461);
            Controls.Add(txtCodPet);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnNovo);
            Controls.Add(dgv_Animais);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtTutor);
            Controls.Add(txtEspecie);
            Controls.Add(txtRaca);
            Controls.Add(txtPeso);
            Controls.Add(txtSexo);
            Controls.Add(txtNome);
            Controls.Add(btnImage);
            Controls.Add(picImage);
            Controls.Add(lblEmail);
            Controls.Add(lblEspecie);
            Controls.Add(lblTelefone);
            Controls.Add(lblTutor);
            Controls.Add(lblSexo);
            Controls.Add(lblPeso);
            Controls.Add(lblRaca);
            Controls.Add(lblNome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            Load += Cadastrar_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Animais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblRaca;
        private Label lblPeso;
        private Label lblSexo;
        private Label lblTutor;
        private Label lblTelefone;
        private Label lblEspecie;
        private Label lblEmail;
        private PictureBox picImage;
        private Button btnImage;
        private TextBox txtNome;
        private TextBox txtSexo;
        private TextBox txtPeso;
        private TextBox txtRaca;
        private TextBox txtEspecie;
        private TextBox txtTutor;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private DataGridView dgv_Animais;
        private Button btnNovo;
        private Button btnAlterar;
        private Button btnExcluir;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private TextBox txtCodPet;
    }
}