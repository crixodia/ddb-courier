using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier.GUI.Guia
{
    public partial class GuiaGui : Form
    {
        public GuiaGui()
        {
            InitializeComponent();
            Icon = Properties.Resources.guide;

            TscOptions.SelectedIndex = 0;
            Dgv.DataSource = Driver.Guia.GetAll();
        }

        private void TscOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TscOptions.SelectedIndex)
            {
                case 1:
                    tsDateTo.Visible = true;

                    TscCriteria.Size = new Size(100, tsDateTo.Size.Height);
                    break;
                default:
                    tsDateTo.Visible = false;

                    TscCriteria.Visible = true;
                    TscCriteria.Size = new Size(200, tsDateTo.Size.Height);
                    break;
            }
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {
            var sne = new GuiaNewEdit(true)
            {
                Text = "Nueva guía"
            };

            sne.ShowDialog(this);

            Dgv.DataSource = Driver.Guia.GetAll();
        }

        private void TsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var dgvr = Dgv.SelectedRows;
                if (dgvr.Count == 1)
                {
                    DataGridViewCellCollection row = dgvr[0].Cells;
                    var sne = new GuiaNewEdit(true,
                        new Driver.Guia(
                            int.Parse(row[1].Value.ToString()),
                            row[2].Value.ToString(),
                            row[3].Value.ToString(),
                            row[4].Value.ToString(),
                            row[5].Value.ToString(),
                            row[6].Value.ToString(),
                            row[7].Value.ToString(),
                            row[8].Value.ToString(),
                            row[9].Value.ToString(),
                            row[10].Value.ToString()[0],
                            row[0].Value.ToString()
                        )
                    )
                    {
                        Text = "Actualizar guía"
                    };

                    sne.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show(
                        "No es posible editar varios o ningún elemento",
                        "Guía",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Dgv.DataSource = Driver.Guia.GetAll();
        }

        private void TsbDelete_Click(object sender, EventArgs e)
        {
            var dgvr = Dgv.SelectedRows;
            string message = dgvr.Count == 0
                ? "No ha seleccionado ninguna guía"
                : "¿Está seguro de eliminar " + (dgvr.Count == 1 ? "esta guía?" : "{0} guías?");

            DialogResult dr = MessageBox.Show(
                message,
                "Guía",
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

                        Driver.Guia.DeleteByCodigo(cell[0].Value.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Dgv.DataSource = Driver.Guia.GetAll();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Dgv.DataSource = Driver.Guia.GetAll();
        }

        private void TscOk_Click(object sender, EventArgs e)
        {
            switch (TscOptions.SelectedIndex)
            {
                case 0: // Codigo Cliente
                    Dgv.DataSource = Driver.Guia.GetByCodigoCliente(TscCriteria.Text);
                    break;
                case 1: // Fecha
                    Dgv.DataSource = Driver.Guia.GetByFecha(TscCriteria.Text, tsDateTo.Text);
                    break;
                case 2: // Provincia
                    Dgv.DataSource = Driver.Guia.GetByProvincia(TscCriteria.Text);
                    break;
                case 3: // Ciudad
                    Dgv.DataSource = Driver.Guia.GetByCiudad(TscCriteria.Text);
                    break;
                default: // No criteria
                    Dgv.DataSource = Driver.Guia.GetAll();
                    break;
            }
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TsbEdit_Click(sender, e);
        }
    }
}
