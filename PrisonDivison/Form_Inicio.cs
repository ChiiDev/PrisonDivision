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
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Botões
        private void bt_Inicio_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_Cadastro_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form_Cadastro Form_Cadastro = new Form_Cadastro();
            //Form_Cadastro.Show();
            this.Hide();
            Form_Cadastro Form_Cadastro = new Form_Cadastro();
            Form_Cadastro.Closed += (s, args) => this.Close();
            Form_Cadastro.Show();
        }

        private void bt_Sobre_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void detentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
