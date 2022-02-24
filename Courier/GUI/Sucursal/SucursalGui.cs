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
            dgv.DataSource = Driver.Sucursal.GetAll();
            Connection.Close();
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {
            var sne = new SucursalNewEdit();
            sne.ShowDialog();
        }

        private void Dgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    Console.WriteLine(row.Cells[0].Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
