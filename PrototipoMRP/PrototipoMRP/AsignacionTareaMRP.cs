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
    public partial class AsignacionTareaMRP : Form
    {
        public AsignacionTareaMRP()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD("user", "database123$", "MRPBD1", @".\SQLEXPRESS");

        public void consulta()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select * from detalletarea");
        }
        private void AsignacionTareaMRP_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[DETALLETAREA] (codtarea,codtipo) values ('" + cmdtarea.Text + "','" + cmdfase.Text + "')");
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdfase.Text = "";
            cmdtarea.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmdfase.Text = "";
            cmdtarea.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRUEBA.deleteSQL("delete [dbo].[DETALLETAREA] where coddetalletarea = '" + txtcodigo.Text + "'");
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRUEBA.updateSQL("update detalletarea set codtarea ='" + cmdtarea.Text+ "',codtipo= '" + cmdfase.Text + "' where coddetalletarea='" + txtcodigo.Text + "'");
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
    public partial class AsignacionTareaMRP : Form
    {
        public AsignacionTareaMRP()
        {
            InitializeComponent();
        }
        MRP_BD PRUEBA = new MRP_BD("OLIVIA", "oliviamrp", "master", @".\SQLEXPRESS");

        public void consulta()
        {
            dataGridView1.DataSource = PRUEBA.getSQL("select * from detalletarea");
        }
        private void AsignacionTareaMRP_Load(object sender, EventArgs e)
        {
            consulta();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PRUEBA.insertSQL("insert into [dbo].[DETALLETAREA] (codtarea,codtipo) values ('" + cmdtarea.Text + "','" + cmdfase.Text + "')");
            consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdfase.Text = "";
            cmdtarea.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmdfase.Text = "";
            cmdtarea.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            consulta();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRUEBA.deleteSQL("delete [dbo].[DETALLETAREA] where coddetalletarea = '" + txtcodigo.Text + "'");
            consulta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRUEBA.updateSQL("update detalletarea set codtarea ='" + cmdtarea.Text+ "',codtipo= '" + cmdfase.Text + "' where coddetalletarea='" + txtcodigo.Text + "'");
            consulta();
        }
    }
}
>>>>>>> 7b41d1f3e3f8280d801b3f3d0b8172ac07053fdc
