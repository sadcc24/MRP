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
    public partial class CP_Prorrateo : Form
    {
        public CP_Prorrateo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
                    }

        private void CP_Prorrateo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eRPSeminarioDataSet1.prorrateo2' Puede moverla o quitarla según sea necesario.
            this.prorrateo2TableAdapter.Fill(this.eRPSeminarioDataSet1.prorrateo2);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prorrateo2TableAdapter.FillBy(this.eRPSeminarioDataSet1.prorrateo2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prorrateo2TableAdapter.FillBy1(this.eRPSeminarioDataSet1.prorrateo2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void idordenproduccionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscaridToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prorrateo2TableAdapter.buscarid(this.eRPSeminarioDataSet1.prorrateo2, ((int)(System.Convert.ChangeType(idordenproduccionTextBoxToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void idordenproduccionTextBoxToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void buscafechaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prorrateo2TableAdapter.buscafecha(this.eRPSeminarioDataSet1.prorrateo2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prorrateo2TableAdapter.FillBy2(this.eRPSeminarioDataSet1.prorrateo2, ((int)(System.Convert.ChangeType(idordenproduccionTextBoxToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}