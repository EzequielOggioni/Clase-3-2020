using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clase6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)   
        {


            
            string genero;
            foreach (Control item in grbGenero.Controls)
            {
                if(item is RadioButton)
                {
                    if(((RadioButton)item).Checked )
                    {
                        genero = ((RadioButton)item).Name;
                        break;
                    }
                }

            } 

            double dni;


            if (Double.TryParse(this.txtDNI.Text, out dni))
            {

                Usuario persona = new Usuario(this.txtNombre.Text, this.txtApellido.Text, dni);
                this.lblSalida.Text = persona.Mostrar();
            }
            else
            {
                 MessageBox.Show("Ocurrio un error con el DNI","Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1 ,MessageBoxOptions.ServiceNotification) ;

            }
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
          //  MessageBox.Show("Activate");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
        //    MessageBox.Show("Desactivate");

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("closed");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro?", "Seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSegundo frmSegundo = new FrmSegundo();
            if (frmSegundo.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Ok");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTercero frmTercero = new FrmTercero();
            frmTercero.IsMdiContainer = true;
            frmTercero.Show(this);
            this.Cursor = Cursors.VSplit;
            
        }
    }
}
