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
    public partial class Agendar : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public Agendar()
        {
            InitializeComponent();
        }

        private void carregarAnimais(string pesquisa)
        {
            try
            {
                con.ConnectarBD();
                MySqlCommand cmd = new MySqlCommand();

                if (string.IsNullOrEmpty(pesquisa))
                {
                    // Se o filtro estiver vazio, carregar todos os animais
                    cmd.CommandText = "SELECT * FROM tbAnimal";
                }
                else
                {
                    // Se o filtro não estiver vazio, carregar animais que correspondem ao filtro em vários campos
                    cmd.CommandText = "SELECT * FROM tbAnimal WHERE nome LIKE @pesquisa OR raca LIKE @pesquisa OR especie LIKE @pesquisa OR tutor LIKE @pesquisa";
                    cmd.Parameters.AddWithValue("@pesqisa", "%" + pesquisa + "%");
                }

                cmd.Connection = con.ConnectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_Animais.DataSource = dt;
                con.DesConnectarBD();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar animais: " + erro.Message);
            }
        }


        private void Agendar_Load(object sender, EventArgs e)
        {
            carregarAnimais(txtPesquisar.Text);
        }

        private void dgv_Animais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarAnimais(txtPesquisar.Text);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            carregarAnimais(txtPesquisar.Text);
        }


        private void Agendamento(string tipo)
        {
            try
            {
                con.ConnectarBD();
                string sql;
                if (tipo == "consulta")
                {
                    sql = "INSERT INTO tbConsultas(CodPet, dataConsulta) VALUES(@CodPet, @data)";
                }
                else // exame
                {
                    sql = "INSERT INTO tbExames(CodPet, dataExame) VALUES(@CodPet, @data)";
                }

                cmd = new MySqlCommand(sql, con.ConnectarBD());
                cmd.Parameters.AddWithValue("@CodPet", dgv_Animais.SelectedRows[0].Cells["CodPet"].Value);
                cmd.Parameters.AddWithValue("@data", dtpData.Value);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Agendamento realizado com sucesso!");
                con.DesConnectarBD();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao agendar: " + erro.Message);
            }
        }



        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (dgv_Animais.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um animal.");
                return;
            }

            DateTime dataSelecionada = dtpData.Value;
            if (dataSelecionada == DateTime.MinValue)
            {
                MessageBox.Show("Selecione uma data.");
                return;
            }

            // Chamar o método para agendar consulta
            Agendamento("consulta");
        }


        private void btnExame_Click(object sender, EventArgs e)
        {
            if (dgv_Animais.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um animal.");
                return;
            }

            DateTime dataSelecionada = dtpData.Value;
            if (dataSelecionada == DateTime.MinValue)
            {
                MessageBox.Show("Selecione uma data.");
                return;
            }

            // Chamar o método para agendar consulta
            Agendamento("exame");
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

        }
    }
}
