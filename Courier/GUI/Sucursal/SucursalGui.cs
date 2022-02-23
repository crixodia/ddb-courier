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
using Courier.Driver;

namespace Courier.GUI.Sucursal
{
    public partial class SucursalGui : Form
    {
        public SucursalGui()
        {
            InitializeComponent();
            Connection cn = new Connection("localhost", "sa", "P@ssw0rd", "tramaco_quito");
            
            dgv.DataSource = cn.Query("SELECT * FROM SUCURSAL");
            cn.Close();
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {
            var sne = new SucursalNewEdit();
            sne.ShowDialog();
        }
    }
}
