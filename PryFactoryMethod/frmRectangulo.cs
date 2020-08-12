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
    public partial class frmRectangulo : Form
    {
        clsFiguras c = clsFactory.factoryObjects(3);
        public frmRectangulo()
        {
            InitializeComponent();
            string[] cadena = c.descripcion_figura().Split(' ');
            foreach (string word in cadena)
            {
                linfo.Items.Add(word);
            }
        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            txtra.Text = "" + c.Area(double.Parse(txtba.Text), double.Parse(txtaa.Text));
        }

        private void btnperimetro_Click(object sender, EventArgs e)
        {
            txtrp.Text = "" + c.Perimetro(double.Parse(txtbp.Text), double.Parse(txtap.Text));
        }
    }
}
