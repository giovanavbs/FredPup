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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Cadastrar novoAnimal = new Cadastrar();
            novoAnimal.Show();
    }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Agendar novoAgenda = new Agendar();
            novoAgenda.Show();
        }

        private void btnExame_Click(object sender, EventArgs e)
        {
            Exame novoExame = new Exame();
            novoExame.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta novoConsulta = new Consulta();
            novoConsulta.Show();
        }
    }
}
