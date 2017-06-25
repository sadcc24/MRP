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
    public partial class Inicial : Form
    {
        int contador = 1;
        int limite = 4;
        public Inicial()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador == limite)
            {
                timer1.Stop();
                GloginAutenticacion login = new GloginAutenticacion();
                this.Hide();
                login.Show();
            }
            else {

                    progressBar1.Value =  contador * 25 ;
                
                contador = contador + 1;
                
            }
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
    }
}
