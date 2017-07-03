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
    public partial class OP_TareaMRP : Form
    {
        public OP_TareaMRP()
        {
            InitializeComponent();
        }
       
        MRP_BD PRUEBA = new MRP_BD();



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            PRUEBA.insertSQL("insert into [dbo].[TAREA] (descripcion,estado,nombre,idempresa) values ('" + txtdescripcion.Text + "','" + cmbestado.Text + "','" + txtnombre.Text + "','"+cmbempresa.SelectedValue.ToString()+"')");
            MessageBox.Show("Ingreso Exitoso", "Ingreso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            consulta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            cmbestado.Text = "";
            txtnombre.Text = "";
            cmbempresa.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRUEBA.deleteSQL("delete [dbo].[TAREA] where codtarea = '" + txtcodigo.Text + "'");
            MessageBox.Show("Esta seguro de eliminar la tarea?", "Esta seguro de eliminar la tarea?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcodigo.Visible = true;
            PRUEBA.updateSQL("update tarea set descripcion ='" + txtdescripcion.Text + "',estado= '" + cmbestado.Text + "',nombre='"+txtnombre.Text+"',idempresa='"+cmbempresa.Text+"' where codtarea='" + txtcodigo.Text+ "'");
            consulta();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            cmbestado.Text = "";
            txtnombre.Text = "";
            cmbempresa.Text = "";
        }
         public void consulta()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select codtarea as 'Codigo', nombre as 'Nombre',descripcion as 'Descripcion',estado as 'Estado Activo/Inactivo',idempresa as 'Cod Empresa' from tarea");
        }
        private void TareaMRP_Load(object sender, EventArgs e)
        {
            cmbempresa.DataSource = PRUEBA.getSQL("select idempresa, nombre_empresa from empresa");
            cmbempresa.DisplayMember = "nombre_empresa";
            cmbempresa.ValueMember = "idempresa";
            
            consulta();
            txtcodigo.Visible = false;
        }
    }
}
