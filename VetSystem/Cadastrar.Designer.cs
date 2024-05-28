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
            lblNome.Location = new Point(233, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "NOME";
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.Location = new Point(238, 63);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(47, 20);
            lblRaca.TabIndex = 1;
            lblRaca.Text = "RAÇA";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(238, 115);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(44, 20);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "PESO";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(240, 157);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(45, 20);
            lblSexo.TabIndex = 3;
            lblSexo.Text = "SEXO";
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.Location = new Point(546, 23);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(54, 20);
            lblTutor.TabIndex = 4;
            lblTutor.Text = "TUTOR";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(546, 68);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(77, 20);
            lblTelefone.TabIndex = 5;
            lblTelefone.Text = "TELEFONE";
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(231, 209);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(62, 20);
            lblEspecie.TabIndex = 6;
            lblEspecie.Text = "ESPECIE";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(549, 108);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "EMAIL";
            // 
            // picImage
            // 
            picImage.Location = new Point(68, 38);
            picImage.Name = "picImage";
            picImage.Size = new Size(124, 156);
            picImage.TabIndex = 8;
            picImage.TabStop = false;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(68, 200);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(124, 29);
            btnImage.TabIndex = 9;
            btnImage.Text = "carregar..";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(307, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 10;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(307, 154);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(125, 27);
            txtSexo.TabIndex = 11;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(307, 108);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 27);
            txtPeso.TabIndex = 12;
            // 
            // txtRaca
            // 
            txtRaca.Location = new Point(307, 56);
            txtRaca.Name = "txtRaca";
            txtRaca.Size = new Size(125, 27);
            txtRaca.TabIndex = 13;
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(307, 206);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(125, 27);
            txtEspecie.TabIndex = 14;
            // 
            // txtTutor
            // 
            txtTutor.Location = new Point(638, 16);
            txtTutor.Name = "txtTutor";
            txtTutor.Size = new Size(125, 27);
            txtTutor.TabIndex = 15;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(638, 63);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(125, 27);
            txtTelefone.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(638, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 17;
            // 
            // dgv_Animais
            // 
            dgv_Animais.ColumnHeadersHeight = 29;
            dgv_Animais.Location = new Point(43, 309);
            dgv_Animais.Name = "dgv_Animais";
            dgv_Animais.RowHeadersWidth = 51;
            dgv_Animais.Size = new Size(636, 222);
            dgv_Animais.TabIndex = 25;
            dgv_Animais.CellContentClick += dgv_Animais_CellContentClick;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(726, 359);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 19;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(726, 410);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(94, 29);
            btnAlterar.TabIndex = 20;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(726, 460);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(43, 268);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(73, 20);
            lblPesquisar.TabIndex = 22;
            lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(122, 265);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(125, 27);
            txtPesquisar.TabIndex = 23;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // txtCodPet
            // 
            txtCodPet.Location = new Point(13, 11);
            txtCodPet.Name = "txtCodPet";
            txtCodPet.ReadOnly = true;
            txtCodPet.Size = new Size(37, 27);
            txtCodPet.TabIndex = 24;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 543);
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
            Name = "Cadastrar";
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