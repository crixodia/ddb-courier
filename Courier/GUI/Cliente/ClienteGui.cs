using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier.GUI.Cliente
{
    public partial class ClienteGui : Form
    {
        public ClienteGui()
        {
            InitializeComponent();
            Icon = Properties.Resources.cliente;

            TscOptions.SelectedIndex = 0;

            Dgv.DataSource = Driver.Cliente.GetAll();
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {
            var sne = new ClienteNewEdit
            {
                Text = "Nuevo cliente"
            };

            sne.ShowDialog(this);

            Dgv.DataSource = Driver.Cliente.GetAll();
        }

        private void TsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var dgvr = Dgv.SelectedRows;
                if (dgvr.Count == 1)
                {
                    DataGridViewCellCollection row = dgvr[0].Cells;
                    var sne = new ClienteNewEdit(
                        new Driver.Cliente(
                            int.Parse(row[1].Value.ToString()),
                            row[2].Value.ToString(),
                            row[3].Value.ToString(),
                            row[4].Value.ToString(),
                            row[5].Value.ToString(),
                            row[6].Value.ToString(),
                            row[7].Value.ToString(),
                            row[8].Value.ToString(),
                            row[0].Value.ToString()
                        )
                    )
                    {
                        Text = "Actualizar cliente"
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

            Dgv.DataSource = Driver.Cliente.GetAll();
        }

        private void TsbDelete_Click(object sender, EventArgs e)
        {
            var dgvr = Dgv.SelectedRows;
            string message = dgvr.Count == 0
                ? "No ha seleccionado ningún empleado"
                : "¿Está seguro de eliminar " + (dgvr.Count == 1 ? "este cliente?" : "{0} clientes?");

            DialogResult dr = MessageBox.Show(
                String.Format(message, dgvr.Count),
                "Cliente",
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

                        Driver.Cliente.DeleteByCodigo(cell[0].Value.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Dgv.DataSource = Driver.Cliente.GetAll();
        }

        private void TbsRefresh_Click(object sender, EventArgs e)
        {
            Dgv.DataSource = Driver.Cliente.GetAll();
        }

        private void TscOk_Click(object sender, EventArgs e)
        {
            switch (TscOptions.SelectedIndex)
            {
                case 0: // Cédula
                    Dgv.DataSource = Driver.Cliente.GetByCedula(TscCriteria.Text);
                    break;
                case 1: //Provincia
                    Dgv.DataSource = Driver.Cliente.GetByProvincia(TscCriteria.Text);
                    break;
                case 2: // Ciudad
                    Dgv.DataSource = Driver.Cliente.GetByCiudad(TscCriteria.Text);
                    break;
                case 3: //Zip
                    Dgv.DataSource = Driver.Cliente.GetByZip(TscCriteria.Text);
                    break;
                default: // No Criteria
                    Dgv.DataSource = Driver.Cliente.GetAll();
                    break;
            }
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TsbEdit_Click(sender, e);
        }
    }
}
