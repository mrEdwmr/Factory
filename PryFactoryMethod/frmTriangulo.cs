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
    public partial class frmTriangulo : Form
    {
        clsFiguras t = clsFactory.factoryObjects(1);
        public frmTriangulo()
        {
            InitializeComponent();
            string[] cadena = t.descripcion_figura().Split(' ');
            foreach (string word in cadena)
            {
                linfo.Items.Add(word);
            }
        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            txtra.Text = "" + t.Area(double.Parse(txtba.Text), double.Parse(txtaa.Text));
        }

        private void btnperimetro_Click(object sender, EventArgs e)
        {
            txtrp.Text = "" + t.Perimetro(double.Parse(txtlado.Text), 0);
        }
    }
}
