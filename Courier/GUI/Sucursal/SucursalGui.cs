using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Courier.GUI.Sucursal;

namespace Courier.GUI.Sucursal
{
    public partial class SucursalGui : Form
    {
        public SucursalGui()
        {
            InitializeComponent();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            var sne = new SucursalNewEdit();
            sne.ShowDialog();
        }
    }
}
