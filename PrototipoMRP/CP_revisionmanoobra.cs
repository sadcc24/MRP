﻿//-- PROGRAMADO Y TRABAJADO POR CARLOS MANUEL PINEDA ESCOBAR
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
    public partial class CP_revisionmanoobra : Form
    {
        public CP_revisionmanoobra()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }
        CAPANEGOCIO.CapaCarlos rev2 = new CAPANEGOCIO.CapaCarlos();
        private void consulta()
        {
            dataGridView1.DataSource = rev2.revisaManoobra();
        }
        private void CP_revisionmanoobra_Load(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
