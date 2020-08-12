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
    public partial class frmCirculo : Form
    {
        clsFiguras obj = clsFactory.factoryObjects(4);
        public frmCirculo()
        {
            InitializeComponent();
            string[] cadena = obj.descripcion_figura().Split(' ');
            foreach (string word in cadena)
            {
                linfo.Items.Add(word);
            }
        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            txtra.Text =""+obj.Area(double.Parse(txtradioa.Text), 0);
        }

        private void btnperimetro_Click(object sender, EventArgs e)
        {
            txtrp.Text = "" + obj.Perimetro(double.Parse(txtradiop.Text), 0);
        }
    }
}
