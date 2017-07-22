using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Visualizador : Form
    {
        public Visualizador()
        {
            InitializeComponent();
        }
        public Visualizador(ReportClass reporte)
        {
            InitializeComponent();
            this.crystalReportViewer1.ReportSource = reporte;
        }
    }
}
