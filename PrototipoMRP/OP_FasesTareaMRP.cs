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
    public partial class OP_FasesTareaMRP : Form
    {
        public OP_FasesTareaMRP()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD();


        public void consulta()
        {
            
            dgvfases.DataSource = PRUEBA.getSQL("select codtipo as 'Codigo',nombre as 'Nombre',descripcion as 'Descripcion',estado as 'Estado' from fasetarea");
        }
        private void FasesTareaMRP_Load(object sender, EventArgs e)
        {
            txtcodigo.Enabled = false;
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true;
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtnombre.Text = "";
            cmbestado.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[FASETAREA] (descripcion,estado,nombre) values ('" + txtdescripcion.Text + "','" + cmbestado.Text + "','" + txtnombre.Text + "')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta();
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtnombre.Text = "";
            cmbestado.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true;
            MessageBox.Show("Esta seguro de eliminar la Fase?", "Esta seguro de eliminar la Fase?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PRUEBA.deleteSQL("delete [dbo].[FASETAREA] where codtipo = '" + txtcodigo.Text + "'");
            consulta();
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtnombre.Text = "";
            cmbestado.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcodigo.Enabled = true;
            PRUEBA.updateSQL("update fasetarea set descripcion ='" + txtdescripcion.Text + "',estado= '" + cmbestado.Text + "',nombre='" + txtnombre.Text + "' where codtipo='" + txtcodigo.Text + "'");
            consulta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtdescripcion.Text = "";
            txtcodigo.Text = "";
            cmbestado.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
