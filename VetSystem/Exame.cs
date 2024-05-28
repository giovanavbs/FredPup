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
    public partial class Exame : Form
    {

        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public Exame()
        {
            InitializeComponent();
        }

        private void carregarExames(string pesquisa)
        {
            try
            {
                con.ConnectarBD();
                MySqlCommand cmd = new MySqlCommand();

                if (string.IsNullOrEmpty(pesquisa))
                {
                    // Se o filtro estiver vazio, carregar todos os exames
                    cmd.CommandText = "SELECT * FROM tbExames";
                }
                else
                {
                    // Se o filtro não estiver vazio, carregar exames que correspondem ao filtro em vários campos
                    cmd.CommandText = "SELECT * FROM tbExames WHERE nome LIKE @pesquisa OR dataExame LIKE @pesquisa";
                    cmd.Parameters.AddWithValue("@pesquisa", "%" + pesquisa + "%");
                }

                cmd.Connection = con.ConnectarBD();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_Exames.DataSource = dt;
                con.DesConnectarBD();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar exames: " + erro.Message);
            }
        }


        private void Exame_Load(object sender, EventArgs e)
        {
            carregarExames(txtPesquisar.Text);
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            carregarExames(txtPesquisar.Text);
        }

        private void dgv_Exames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarExames(txtPesquisar.Text);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (dgv_Exames.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um exame.");
                return;
            }

            try
            {
                con.ConnectarBD();
                int idExame = Convert.ToInt32(dgv_Exames.SelectedRows[0].Cells["codExame"].Value);
                string sql = "UPDATE tbExames SET diagnostico = @diagnostico, descricao = @descricao WHERE codExame = @codExame";

                cmd = new MySqlCommand(sql, con.ConnectarBD());
                cmd.Parameters.AddWithValue("@diagnostico", txtDiagnostico.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDesc.Text);
                cmd.Parameters.AddWithValue("@codExame", idExame);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Exame atualizado com sucesso!");
                carregarExames(txtPesquisar.Text); // Recarregar exames atualizados
                con.DesConnectarBD();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar exame: " + erro.Message);
            }
        }
    }
}
