using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aLetras
{
    public partial class FrmEmisionDeCheque : Form
    {
        public FrmEmisionDeCheque()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //NUMWORD.NumerosLetras.testUnidades();
            int num = Int32.Parse(this.txtCantidad.Text);
            this.txtResultado.Text = NUMWORD.NumerosLetras.getCentenas(num);
        }
    }
}
