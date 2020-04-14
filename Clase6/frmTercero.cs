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
    public partial class FrmTercero : Form
    {
        public FrmTercero()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuarto frmCuarto = new FrmCuarto();
            frmCuarto.MdiParent = this;
            frmCuarto.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
