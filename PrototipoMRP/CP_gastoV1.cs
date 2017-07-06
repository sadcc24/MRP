﻿using System;
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
    public partial class CP_gastoV1 : Form
    {
        public CP_gastoV1()
        {
            InitializeComponent();
        }

        private void CP_gastoV1_Load(object sender, EventArgs e)
        {

            consulta();
        }

        CAPANEGOCIO.CapaCarlos tipoGastov2 = new CAPANEGOCIO.CapaCarlos();

        private void consulta()
        {
            dataGridView1.DataSource = tipoGastov2.consultaTipoGasto1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tipoGastov2.buscarTipoGasto1(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
                
        }
    }
}
