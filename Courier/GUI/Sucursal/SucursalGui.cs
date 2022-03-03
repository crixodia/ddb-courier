using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Courier.Driver;

namespace Courier.GUI.Sucursal
{
    public partial class SucursalGui : Form
    {
        public SucursalGui()
        {
            InitializeComponent();
            Icon = Properties.Resources.home;

            dgv.DataSource = Driver.Sucursal.GetAll();
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {
            var sne = new SucursalNewEdit
            {
                Text = "Nueva sucursal"
            };

            sne.ShowDialog(this);

            dgv.DataSource = Driver.Sucursal.GetAll();
        }

        private void TsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var dgvr = dgv.SelectedRows;
                if (dgvr.Count == 1)
                {
                    DataGridViewCellCollection row = dgvr[0].Cells;
                    var sne = new SucursalNewEdit(
                        new Driver.Sucursal(
                            row[1].Value.ToString(),
                            row[2].Value.ToString(),
                            row[3].Value.ToString(),
                            int.Parse(row[0].Value.ToString())
                        )
                    )
                    {
                        Text = "Actualizar sucursal"
                    };

                    sne.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show(
                        "No es posible editar varios o ningún elemento",
                        "Sucursal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            dgv.DataSource = Driver.Sucursal.GetAll();
        }


        private void TsbDelete_Click(object sender, EventArgs e)
        {
            var dgvr = dgv.SelectedRows;
            string message = dgvr.Count == 0
                ? "No ha seleccionado ninguna sucursal"
                : "¿Está seguro de eliminar " + (dgvr.Count == 1 ? "esta sucursal?" : "{0} sucursales?");

            DialogResult dr = MessageBox.Show(
                message,
                "Sucursal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dr == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dgvr)
                    {
                        DataGridViewCellCollection cell = row.Cells;

                        Driver.Sucursal.DeleteByCodigo(int.Parse(cell[0].Value.ToString()));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            dgv.DataSource = Driver.Sucursal.GetAll();
        }


        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TsbEdit_Click(sender, e);
        }
    }
}
