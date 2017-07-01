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
    public partial class GSolicitudProducto : Form
    {
        public GSolicitudProducto()
        {
            InitializeComponent();
        }

        private void GSolicitudProducto_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                bool estado = false;
                if (i % 2 == 0)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                dataGridView1.Rows.Add("Producto " + i.ToString(), "Descripcion " + i.ToString(), i * 10, i * 5);
            }
        }
    }
}
