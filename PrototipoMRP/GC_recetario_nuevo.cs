using CAPANEGOCIO;
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
    public partial class recetario_nuevo : Form
    {

        public string accion;
        public recetario_nuevo(MPRCL_Empresa empresa) {
            InitializeComponent();
            accion = "insertar";
        }
        public recetario_nuevo(MPRCL_Empresa empresa, int id_recetario)
        {
            InitializeComponent();
            accion = "modificar";
        }

        private void recetario_nuevo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
