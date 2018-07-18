using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagement1._0
{
    public partial class Form_Cadastro : Form
    {
        public Form_Cadastro()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bt_Inicio_Inicio_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form_Inicio Form_Inicio = new Form_Inicio();
            //Form_Inicio.Show();
            this.Hide();
            Form_Inicio Form_Inicio = new Form_Inicio();
            Form_Inicio.Closed += (s, args) => this.Close();
            Form_Inicio.Show();
        }

        private void bt_Cadastro_Inicio_Click(object sender, EventArgs e)
        {

        }

        private void bt_Sobre_Inicio_Click(object sender, EventArgs e)
        {

        }
    }
}
