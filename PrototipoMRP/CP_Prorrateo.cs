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
    public partial class CP_Prorrateo : Form
    {
        public CP_Prorrateo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
                    }

        private void CP_Prorrateo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eRPSeminarioDataSet1.prorrateo2' Puede moverla o quitarla según sea necesario.
            this.prorrateo2TableAdapter.Fill(this.eRPSeminarioDataSet1.prorrateo2);

        }
    }
}
