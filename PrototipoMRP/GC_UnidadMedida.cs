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
    public partial class GC_UnidadMedida : Form
    {
        public GC_UnidadMedida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GC_NuevaUnidadMedida nueva = new GC_NuevaUnidadMedida();
            nueva.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GC_MantUnidadMedidacs unidad = new GC_MantUnidadMedidacs();
            unidad.ShowDialog();
        }
    }
}
