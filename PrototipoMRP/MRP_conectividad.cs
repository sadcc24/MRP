//Programador: Guillermo Canel
//Analista: Guillermo Canel
//Comentarios: Configuracion de autenticacion con la base de datos para que funcione el modulo MRP


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoMRP
{
    public partial class MRP_conectividad : Form
    {
        public MRP_conectividad()
        {
            InitializeComponent();
        }
        int autorizado = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add("txtusuario", "");
            config.AppSettings.Settings["txtusuario"].Value = txtusuario.Text.ToString();

            config.AppSettings.Settings.Add("txtpass", "");
            config.AppSettings.Settings["txtpass"].Value = txtcontrasenia.Text.ToString();


            config.AppSettings.Settings.Add("txtbd", "");
            config.AppSettings.Settings["txtbd"].Value = txtbd.Text.ToString();


            config.AppSettings.Settings.Add("txtservidor", "");
            config.AppSettings.Settings["txtservidor"].Value = @""+txtservidor.Text.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (autorizado == 1)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Add("txtusuario", "");
                config.AppSettings.Settings["txtusuario"].Value = txtusuario.Text.ToString();

                config.AppSettings.Settings.Add("txtpass", "");
                config.AppSettings.Settings["txtpass"].Value = txtcontrasenia.Text.ToString();


                config.AppSettings.Settings.Add("txtbd", "");
                config.AppSettings.Settings["txtbd"].Value = txtbd.Text.ToString();


                config.AppSettings.Settings.Add("txtservidor", "");
                config.AppSettings.Settings["txtservidor"].Value = txtservidor.Text.ToString();
                config.Save(ConfigurationSaveMode.Modified);

                MessageBox.Show("Cierre y Abra nuevamente la aplicacion");
            }
            else {
                autorizado = 0;
                MessageBox.Show("Presione el boton Test para Validar configuracion");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtbd.Text = "";
            txtcontrasenia.Text = "";
            txtservidor.Text = "";
            txtusuario.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MRP_BD mpr = new MRP_BD(txtusuario.Text, txtcontrasenia.Text, txtbd.Text, txtservidor.Text);

            
            
            try
            {

                if (mpr.getSQL("select @@VERSION 'Version'").Rows.Count > 0)
                {
                    MessageBox.Show("Listo!! Puede guardar la configuracion");
                }
                autorizado = 1;              

            }
            catch (Exception)
            {
                MessageBox.Show("No hay conectividad con la base de datos");
                autorizado = 0;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MRP_conectividad_Load(object sender, EventArgs e)
        {
            txtbd.Text= ConfigurationManager.AppSettings["txtbd"];
            txtcontrasenia.Text = ConfigurationManager.AppSettings["txtpass"];
            txtservidor.Text = ConfigurationManager.AppSettings["txtservidor"];
            txtusuario.Text = ConfigurationManager.AppSettings["txtusuario"];


        }
    }
}
