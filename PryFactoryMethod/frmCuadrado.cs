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
    public partial class frmCuadrado : Form
    {
        clsFiguras c = clsFactory.factoryObjects(2);
        public frmCuadrado()
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
            txtra.Text = "" + c.Area(double.Parse(txtlado.Text), 0);
        }

        private void btnperimetro_Click(object sender, EventArgs e)
        {
            txtrp.Text = "" + c.Perimetro(double.Parse(txtladop.Text), 0);
        }
    }
}
