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
    public partial class CP_polizaV2 : Form
    {
        public CP_polizaV2()
        {
            InitializeComponent();
        }

        CAPANEGOCIO.CapaCarlos polizav2 = new CAPANEGOCIO.CapaCarlos();

        private void button8_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = polizav2.buscarPoliza(dateTimePicker1.Text, dateTimePicker2.Text);
        }

        public void limpiar(String limpiarDato)
        {
            textBox2.Text = polizav2.limpiarPoliza(textBox2.Text);
            textBox3.Text = polizav2.limpiarPoliza(textBox3.Text);
            textBox4.Text = polizav2.limpiarPoliza(textBox4.Text);
            textBox5.Text = polizav2.limpiarPoliza(textBox5.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CP_polizapoliza polipoli = new CP_polizapoliza();
            polipoli.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CP_polizacontable policon = new CP_polizacontable();
            policon.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CP_polizaV2_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy/MM/dd";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            polizav2.insertarPoliza(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar("");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Utilice el boton buscar para generar la poliza, la poliza se realiza desde el 1 de enero hasta el 31 de diciembre \n utilice el primer boton limpia la busqueda ", "Programa realizado por Carlos Pineda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
