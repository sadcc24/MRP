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
    public partial class GMantUnidadMedidacs : Form
    {
        public GMantUnidadMedidacs()
        {
            InitializeComponent();
        }
        MRP_BD MRP = new MRP_BD("canel", "canel", "BDMRP", @".\SQL");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void cargarCombos() {

            this.cmborigen.DataSource =MRP.getSQL(" select tipounidad, simbolo, descripcionunidad from tipounidad");
            this.cmborigen.ValueMember = "tipounidad";
            this.cmborigen.DisplayMember = "simbolo";
            
            this.cmbdestino.DataSource = MRP.getSQL(" select tipounidad, simbolo, descripcionunidad from tipounidad");
            this.cmbdestino.ValueMember = "tipounidad";
            this.cmbdestino.DisplayMember = "simbolo";


        }

        private void GMantUnidadMedidacs_Load(object sender, EventArgs e)
        {
            cargarCombos();


        }
    }
}
