﻿namespace VetSystem
{
    partial class Consulta
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
            dgv_Consultas = new DataGridView();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            lblProcure = new Label();
            lblReceituario = new Label();
            lblDesc = new Label();
            txtReceituario = new TextBox();
            txtDesc = new TextBox();
            btnNovo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Consultas).BeginInit();
            SuspendLayout();
            // 
            // dgv_Consultas
            // 
            dgv_Consultas.ColumnHeadersHeight = 29;
            dgv_Consultas.Location = new Point(61, 100);
            dgv_Consultas.Name = "dgv_Consultas";
            dgv_Consultas.RowHeadersWidth = 51;
            dgv_Consultas.Size = new Size(871, 120);
            dgv_Consultas.TabIndex = 26;
            dgv_Consultas.CellContentClick += dgv_Consultas_CellContentClick;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(412, 67);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(125, 27);
            txtPesquisar.TabIndex = 28;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(64, 67);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(341, 20);
            lblPesquisar.TabIndex = 27;
            lblPesquisar.Text = "Pesquise pelo nome do animal e data da consulta:";
            // 
            // lblProcure
            // 
            lblProcure.AutoSize = true;
            lblProcure.Location = new Point(61, 28);
            lblProcure.Name = "lblProcure";
            lblProcure.Size = new Size(400, 20);
            lblProcure.TabIndex = 29;
            lblProcure.Text = "Consulte as consultas agendadas e registre as informações!";
            // 
            // lblReceituario
            // 
            lblReceituario.AutoSize = true;
            lblReceituario.Location = new Point(64, 259);
            lblReceituario.Name = "lblReceituario";
            lblReceituario.Size = new Size(102, 20);
            lblReceituario.TabIndex = 30;
            lblReceituario.Text = "RECEITUARIO:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(374, 263);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(192, 20);
            lblDesc.TabIndex = 31;
            lblDesc.Text = "DESCRIÇÃO DA CONSULTA:";
            // 
            // txtReceituario
            // 
            txtReceituario.Location = new Point(172, 256);
            txtReceituario.Multiline = true;
            txtReceituario.Name = "txtReceituario";
            txtReceituario.Size = new Size(177, 242);
            txtReceituario.TabIndex = 32;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(572, 256);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(360, 242);
            txtDesc.TabIndex = 33;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(838, 523);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 36;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 564);
            Controls.Add(btnNovo);
            Controls.Add(txtDesc);
            Controls.Add(txtReceituario);
            Controls.Add(lblDesc);
            Controls.Add(lblReceituario);
            Controls.Add(lblProcure);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(dgv_Consultas);
            Name = "Consulta";
            Text = "Consulta";
            Load += Consulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Consultas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Consultas;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private Label lblProcure;
        private Label lblReceituario;
        private Label lblDesc;
        private TextBox txtReceituario;
        private TextBox txtDesc;
        private Button btnNovo;
    }
}