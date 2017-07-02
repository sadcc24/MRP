//Programador: Guillermo Canel
//Analista: Guillermo Canel
//Comentarios: autenticacion de los usuarios cuando ingresan al sistema
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoMRP
{
    public partial class GloginAutenticacion : Form
    {
        public GloginAutenticacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MRPmdiMRP mdi = new MRPmdiMRP();
            this.Hide();
            mdi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
