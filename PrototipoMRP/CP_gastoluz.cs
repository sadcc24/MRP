//-- PROGRAMADO Y TRABAJADO POR CARLOS MANUEL PINEDA ESCOBAR
//-- TODOS LOS WINDOWS FORMS CON INICIAL CP TAMBIEN FUERON TRABAJADOS POR CARLOS PINEDA
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
    public partial class CP_gastoluz : Form
    {
        public CP_gastoluz()
        {
            InitializeComponent();
        }

        CAPANEGOCIO.CapaCarlos gastoLu = new CAPANEGOCIO.CapaCarlos();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["Column4"].Value);
            }
            textBox1.Text = Convert.ToString(total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = gastoLu.operaUno(textBox2.Text, textBox3.Text);  
        }

        private void CP_gastoluz_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Decimal precio, cantidad, total;
            string nombre;
            nombre = textBox5.Text;
            precio = Decimal.Parse(textBox2.Text);
            cantidad = Decimal.Parse(textBox3.Text);
            total = Decimal.Parse(textBox4.Text);
            dataGridView1.Rows.Add(nombre, precio, cantidad, total);
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
