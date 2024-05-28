using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetSystem
{
    public partial class Cadastrar : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public Cadastrar()
        {
            InitializeComponent();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo nome");
                txtNome.Focus();
            }
            else if (txtRaca.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo raça");
                txtEmail.Focus();
            }
            else if (txtPeso.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Peso");
                txtTelefone.Focus();
            }
            else if (txtSexo.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo sexo");
                txtTelefone.Focus();
            }
            else if (txtEspecie.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo especie");
                txtTelefone.Focus();
            }
            else if (txtTutor.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo tutor");
                txtTelefone.Focus();
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo telefone");
                txtTelefone.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo email");
                txtTelefone.Focus();
            }

            else
            {
                try
                {
                    string sql = "insert into tbAnimal(nome,raca,peso,sexo,especie,tutor,telefone,email,imagem) values(@nome,@raca,@peso,@sexo,@especie,@tutor,@telefone,@email,'" + picImage.Image + "')";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                    cmd.Parameters.Add("@raca", MySqlDbType.VarChar).Value = txtRaca.Text;
                    cmd.Parameters.Add("@peso", MySqlDbType.VarChar).Value = txtPeso.Text;
                    cmd.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = txtSexo.Text;
                    cmd.Parameters.Add("@especie", MySqlDbType.VarChar).Value = txtEspecie.Text;
                    cmd.Parameters.Add("@tutor", MySqlDbType.VarChar).Value = txtTutor.Text;
                    cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = txtTelefone.Text;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados Cadastrados com Sucesso");
                    //limpaCampos();
                    con.DesConnectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
        public void carregarImagem(PictureBox picImage)
        {
            //vai filtrar o tipo de imagem 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Imagem|*.jpg;*.doc;*.xls;*.ppt;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //vai ler o tamanho do arquivo selecionado
                FileInfo file = new FileInfo(openFileDialog1.FileName);


                //testa se tem menos de 1MB (1MB em bytes = 1048576)
                if (file.Length <= 1048576)
                    picImage.ImageLocation = openFileDialog1.FileName;
                else
                    MessageBox.Show("Arquivo Maior que 1MB!");

            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            carregarImagem(picImage);
        }

        private void carregarAnimais()
        {
            try
            {
                con.ConnectarBD();
                txtCodPet.Text = dgv_Animais.SelectedRows[0].Cells[0].Value.ToString();
                txtRaca.Text = dgv_Animais.SelectedRows[0].Cells[1].Value.ToString();
                txtPeso.Text = dgv_Animais.SelectedRows[0].Cells[2].Value.ToString();
                txtSexo.Text = dgv_Animais.SelectedRows[0].Cells[3].Value.ToString();
                txtEspecie.Text = dgv_Animais.SelectedRows[0].Cells[4].Value.ToString();
                txtTutor.Text = dgv_Animais.SelectedRows[0].Cells[5].Value.ToString();
                txtTelefone.Text = dgv_Animais.SelectedRows[0].Cells[6].Value.ToString();
                txtEmail.Text = dgv_Animais.SelectedRows[0].Cells[7].Value.ToString();
                con.DesConnectarBD();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        private void dgv_Animais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarAnimais();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbAnimal";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgv_Animais.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                dgv_Animais.DataSource = null;

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo nome");
                txtNome.Focus();
            }
            else if (txtRaca.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo raça");
                txtEmail.Focus();
            }
            else if (txtPeso.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Peso");
                txtTelefone.Focus();
            }
            else if (txtSexo.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo sexo");
                txtTelefone.Focus();
            }
            else if (txtEspecie.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo especie");
                txtTelefone.Focus();
            }
            else if (txtTutor.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo tutor");
                txtTelefone.Focus();
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo telefone");
                txtTelefone.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo email");
                txtTelefone.Focus();
            }


            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con.ConnectarBD();
                cmd.CommandText = "update tbAnimal set nome=@nome, raca=@raca, peso=@peso, sexo=@sexo, especie=@especie, tutor=@tutor, telefone=@telefone, email=@email where CodPet = " + txtCodPet.Text;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                cmd.Parameters.Add("@raca", MySqlDbType.VarChar).Value = txtRaca.Text;
                cmd.Parameters.Add("@peso", MySqlDbType.VarChar).Value = txtPeso.Text;
                cmd.Parameters.Add("@sexo", MySqlDbType.VarChar).Value = txtSexo.Text;
                cmd.Parameters.Add("@especie", MySqlDbType.VarChar).Value = txtEspecie.Text;
                cmd.Parameters.Add("@tutor", MySqlDbType.VarChar).Value = txtTutor.Text;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = txtTelefone.Text;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Alterados com sucesso");
                //limpaCampos();
                //desabiltaCampos();
                txtPesquisar.Focus();
                cmd.Parameters.Clear();
                con.DesConnectarBD();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult excluir = MessageBox.Show("Deseja excluir esse registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (excluir == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    con.ConnectarBD();
                    cmd.CommandText = "delete from tbAnimal where CodPet= " + txtCodPet.Text;
                    cmd.Connection = con.ConnectarBD();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados apagados com sucesso");
                    //limpaCampos();
                    //desabiltaCampos();
                    txtPesquisar.Focus();
                    cmd.Parameters.Clear();
                    con.DesConnectarBD();


                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
    }
}



