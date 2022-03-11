using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier.GUI.Vehiculo
{
    public partial class VehiculoGui : Form
    {
        public VehiculoGui()
        {
            InitializeComponent();
            Icon = Properties.Resources.vehiculo;

            TscOptions.SelectedIndex = 0;
            Dgv.DataSource = Driver.Vehiculo.GetAll();
        }

        private void TscOptions_SelectedUpdate(object sender, EventArgs e)
        {
            switch (TscOptions.SelectedIndex)
            {
                case 1:
                    TscG.Visible = true;
                    TscE.Visible = true;
                    TscL.Visible = true;

                    TscCriteria.Visible = true;
                    break;
                case 3:
                    TscML.Visible = true;
                    TscCA.Visible = true;
                    TscCL.Visible = true;
                    TscCP.Visible = true;

                    TscCriteria.Visible = false;
                    break;
                default:
                    TscML.Visible = false;
                    TscCA.Visible = false;
                    TscCL.Visible = false;
                    TscCP.Visible = false;

                    TscG.Visible = false;
                    TscE.Visible = false;
                    TscL.Visible = false;

                    TscCriteria.Visible = true;
                    break;
            }
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {
            var sne = new VehiculoNewEdit
            {
                Text = "Nuevo Vehiculo"
            };

            sne.ShowDialog(this);

            Dgv.DataSource = Driver.Vehiculo.GetAll();
        }

        private void TsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var dgvr = Dgv.SelectedRows;
                if (dgvr.Count == 1)
                {
                    DataGridViewCellCollection row = dgvr[0].Cells;
                    var sne = new VehiculoNewEdit(
                        new Driver.Vehiculo(
                            row[1].Value.ToString(),
                            int.Parse(row[2].Value.ToString()),
                            row[3].Value.ToString(),
                            row[4].Value.ToString(),
                            row[5].Value.ToString(),
                            int.Parse(row[6].Value.ToString()),
                            row[7].Value.ToString(),
                            int.Parse(row[0].Value.ToString())
                        )
                    )
                    {
                        Text = "Actualizar vehículo"
                    };

                    sne.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show(
                        "No es posible editar varios o ningún elemento",
                        "Vehículo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Dgv.DataSource = Driver.Vehiculo.GetAll();
        }

        private void TsbDelete_Click(object sender, EventArgs e)
        {
            var dgvr = Dgv.SelectedRows;
            string message = dgvr.Count == 0
                ? "No ha seleccionado ningún vehículo"
                : "¿Está seguro de eliminar " + (dgvr.Count == 1 ? "este vehículo?" : "{0} vehículos?");

            DialogResult dr = MessageBox.Show(
                String.Format(message, dgvr.Count),
                "Vehículo",
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

                        Driver.Vehiculo.DeleteById(int.Parse(cell[0].Value.ToString()));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Dgv.DataSource = Driver.Vehiculo.GetAll();
        }

        private void TbsRefresh_Click(object sender, EventArgs e)
        {
            Dgv.DataSource = Driver.Vehiculo.GetAll();
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TsbEdit_Click(sender, e);
        }

        private void TscOk_Click(object sender, EventArgs e)
        {
            switch (TscOptions.SelectedIndex)
            {
                case 0: // Codigo Empleado
                    Dgv.DataSource = Driver.Vehiculo.GetByCodigoEmpleado(TscCriteria.Text);
                    break;
                case 1: // Capacidad
                    DataTable dt = Driver.Vehiculo.GetByCapacidad(0, "=");
                    if (TscG.Checked)
                    {
                        dt.Merge(Driver.Vehiculo.GetByCapacidad(int.Parse(TscCriteria.Text), ">"));
                    }

                    if (TscE.Checked)
                    {
                        dt.Merge(Driver.Vehiculo.GetByCapacidad(int.Parse(TscCriteria.Text), "="));
                    }

                    if (TscL.Checked)
                    {
                        dt.Merge(Driver.Vehiculo.GetByCapacidad(int.Parse(TscCriteria.Text), "<"));
                    }

                    Dgv.DataSource = dt;
                    break;
                case 2: // Placa
                    Dgv.DataSource = Driver.Vehiculo.GetByPlaca(TscCriteria.Text);
                    break;
                case 3: // Tipo
                    DataTable dtt = Driver.Vehiculo.GetByTipo("XX");                    
                    if (TscML.Checked)
                    {
                        dtt.Merge(Driver.Vehiculo.GetByTipo("ML"));
                    }

                    if (TscCL.Checked)
                    {
                        dtt.Merge(Driver.Vehiculo.GetByTipo("CL"));
                    }

                    if (TscCP.Checked)
                    {
                        dtt.Merge(Driver.Vehiculo.GetByTipo("CP"));
                    }

                    if (TscCA.Checked)
                    {
                        dtt.Merge(Driver.Vehiculo.GetByTipo("CA"));
                    }

                    Dgv.DataSource = dtt;
                    break;
                default: // No criteria
                    Dgv.DataSource = Driver.Vehiculo.GetAll();
                    break;
            }
        }
    }
}
