<<<<<<< HEAD
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
    public partial class TareaMRP : Form
    {
        public TareaMRP()
        {
            InitializeComponent();
        }
       
        MRP_BD PRUEBA = new MRP_BD("user", "database123$", "MRPBD1", @".\SQLEXPRESS");



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
            PRUEBA.insertSQL("insert into [dbo].[TAREA] (descripcion,estado,nombre,idempresa) values ('" + txtdescripcion.Text + "','" + txtestado.Text + "','" + txtnombre.Text + "','" + cmbempresa.Text + "')");
            consulta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtestado.Text = "";
            txtnombre.Text = "";
            cmbempresa.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRUEBA.deleteSQL("delete [dbo].[TAREA] where codtarea = '" + txtcodigo.Text + "'");
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRUEBA.updateSQL("update tarea set descripcion ='" + txtdescripcion.Text + "',estado= '" + txtestado.Text + "',nombre='"+txtnombre.Text+"',idempresa='"+cmbempresa.Text+"' where codtarea='" + txtcodigo.Text+ "'");
            consulta();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtestado.Text = "";
            txtnombre.Text = "";
            cmbempresa.Text = "";
        }
         public void consulta()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select * from tarea");
        }
        private void TareaMRP_Load(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
=======
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
    public partial class TareaMRP : Form
    {
        public TareaMRP()
        {
            InitializeComponent();
        }
       
        MRP_BD PRUEBA = new MRP_BD("OLIVIA", "oliviamrp", "master", @".\SQLEXPRESS");

       

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
            PRUEBA.insertSQL("insert into [dbo].[TAREA] (descripcion,estado,nombre,idempresa) values ('" + txtdescripcion.Text + "','" + txtestado.Text + "','" + txtnombre.Text + "','" + cmbempresa.Text + "')");
            consulta();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtestado.Text = "";
            txtnombre.Text = "";
            cmbempresa.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRUEBA.deleteSQL("delete [dbo].[TAREA] where codtarea = '" + txtcodigo.Text + "'");
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRUEBA.updateSQL("update tarea set descripcion ='" + txtdescripcion.Text + "',estado= '" + txtestado.Text + "',nombre='"+txtnombre.Text+"',idempresa='"+cmbempresa.Text+"' where codtarea='" + txtcodigo.Text+ "'");
            consulta();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtestado.Text = "";
            txtnombre.Text = "";
            cmbempresa.Text = "";
        }
         public void consulta()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select * from tarea");
        }
        private void TareaMRP_Load(object sender, EventArgs e)
        {
            consulta();
        }
    }
}
>>>>>>> 7b41d1f3e3f8280d801b3f3d0b8172ac07053fdc
