using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Macs;

namespace VetSystem
{
    public partial class Login : Form

    {
        //instanciando a string conexao

        Conexao con = new Conexao();
        //MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dados;


        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Usuario e senha inválidos");
            }
            else
            {
                try
                {
                    string sql = "select * from tblogin where email=@email and senha=@senha";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text;
                    cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtSenha.Text;
                    dados = cmd.ExecuteReader();

                    if (dados.HasRows)
                    {
                        Inicio inicio= new Inicio();
                        inicio.Show();
                        MessageBox.Show("Seja bem Vindo ao sistema");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario e senha invalidos");
                        txtEmail.Clear();
                        txtSenha.Clear();
                        txtEmail.Focus();
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    con.DesConnectarBD();
                }

            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void Login_Load_2(object sender, EventArgs e)
        {

        }
    }
}
