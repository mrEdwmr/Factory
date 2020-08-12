using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFactoryMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCirculo c = new frmCirculo();
            c.ShowDialog();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuadrado c = new frmCuadrado();
            c.ShowDialog();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRectangulo r = new frmRectangulo();
            r.ShowDialog();
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTriangulo t = new frmTriangulo();
            t.ShowDialog();
        }
    }
}
