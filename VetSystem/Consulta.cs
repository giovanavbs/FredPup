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
    public partial class Consulta : Form
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public Consulta()
        {
            InitializeComponent();
        }

        private void carregarConsultas(string pesquisa)
        {
            try
            {
                con.ConnectarBD();
                MySqlCommand cmd = new MySqlCommand();

                if (string.IsNullOrEmpty(pesquisa))
                {
                    // Se o filtro estiver vazio, carregar todas as consultas
                    cmd.CommandText = "SELECT * FROM tbConsultas";
                }
                else
                {
                    // Se o filtro não estiver vazio, carregar consultas que correspondem ao filtro em vários campos
                    cmd.CommandText = "SELECT * FROM tbConsultas WHERE nome LIKE @pesquisa OR dataConsulta LIKE @pesquisa";
                    cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
                }

                cmd.Connection = con.ConnectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_Consultas.DataSource = dt;
                con.DesConnectarBD();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar consultas: " + erro.Message);
            }
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            carregarConsultas(txtPesquisar.Text);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            carregarConsultas(txtPesquisar.Text);
        }

        private void dgv_Consultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarConsultas(txtPesquisar.Text);
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (dgv_Consultas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma consulta.");
                return;
            }

            try
            {
                con.ConnectarBD();
                int idConsulta = Convert.ToInt32(dgv_Consultas.SelectedRows[0].Cells["codConsulta"].Value);
                string sql = "UPDATE tbConsultas SET receituario = @receituario, descricao = @descricao WHERE codConsulta = @codConsulta";

                cmd = new MySqlCommand(sql, con.ConnectarBD());
                cmd.Parameters.AddWithValue("@receituario", txtReceituario.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDesc.Text);
                cmd.Parameters.AddWithValue("@codConsulta", idConsulta);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Consulta atualizada com sucesso!");
                carregarConsultas(txtPesquisar.Text); // Recarregar consultas atualizadas
                con.DesConnectarBD();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar consulta: " + erro.Message);
            }
        }
    }
}
