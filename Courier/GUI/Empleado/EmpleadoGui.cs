using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier.GUI.Empleado
{
    public partial class EmpleadoGui : Form
    {
        public EmpleadoGui()
        {
            InitializeComponent();
            Icon = Properties.Resources.courier;

            TscOptions.SelectedIndex = 0;

            Dgv.DataSource = Driver.Empleado.GetAll();
        }

        private void TscOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TscOptions.SelectedIndex)
            {
                case 3:
                    TscB.Visible = true;
                    TscS.Visible = true;
                    TscC.Visible = true;
                    TscA.Visible = true;

                    TscCriteria.Visible = false;
                    break;
                default:
                    TscB.Visible = false;
                    TscS.Visible = false;
                    TscC.Visible = false;
                    TscA.Visible = false;

                    TscCriteria.Visible = true;
                    break;
            }
        }

        private void TsbNew_Click(object sender, EventArgs e)
        {
            var sne = new EmpleadoNewEdit
            {
                Text = "Nuevo empleado"
            };

            sne.ShowDialog(this);

            Dgv.DataSource = Driver.Empleado.GetAll();
        }

        private void TsbEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var dgvr = Dgv.SelectedRows;
                if (dgvr.Count == 1)
                {
                    DataGridViewCellCollection row = dgvr[0].Cells;
                    var sne = new EmpleadoNewEdit(
                        new Driver.Empleado(
                            int.Parse(row[1].Value.ToString()),
                            row[2].Value.ToString(),
                            row[3].Value.ToString(),
                            row[4].Value.ToString(),
                            row[5].Value.ToString(),
                            row[6].Value.ToString(),
                            row[7].Value.ToString(),
                            row[8].Value.ToString()[0],
                            row[0].Value.ToString()
                        )
                    )
                    {
                        Text = "Actualizar empleado"
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

            Dgv.DataSource = Driver.Empleado.GetAll();
        }

        private void TsbDelete_Click(object sender, EventArgs e)
        {
            var dgvr = Dgv.SelectedRows;
            string message = dgvr.Count == 0
                ? "No ha seleccionado ningún empleado"
                : "¿Está seguro de eliminar " + (dgvr.Count == 1 ? "este empleado?" : "{0} empleados?");

            DialogResult dr = MessageBox.Show(
                String.Format(message, dgvr.Count),
                "Empleado",
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

                        Driver.Empleado.DeleteByCodigo(cell[0].Value.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Dgv.DataSource = Driver.Empleado.GetAll();
        }

        private void TsbRefresh_Click(object sender, EventArgs e)
        {
            Dgv.DataSource = Driver.Empleado.GetAll();
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TsbEdit_Click(sender, e);
        }

        private void TscOk_Click(object sender, EventArgs e)
        {
            switch (TscOptions.SelectedIndex)
            {
                case 0: // Cédula
                    Dgv.DataSource = Driver.Empleado.GetByCedula(TscCriteria.Text);
                    break;
                case 1: // Provincia
                    Dgv.DataSource = Driver.Empleado.GetByProvincia(TscCriteria.Text);
                    break;
                case 2: // Ciudad
                    Dgv.DataSource = Driver.Empleado.GetByCiudad(TscCriteria.Text);
                    break;
                case 3: // Rol
                    DataTable dtt = Driver.Empleado.GetByRol("X");

                    if (TscB.Checked)
                    {
                        dtt.Merge(Driver.Empleado.GetByRol("B"));
                    }

                    if (TscC.Checked)
                    {
                        dtt.Merge(Driver.Empleado.GetByRol("C"));
                    }

                    if (TscA.Checked)
                    {
                        dtt.Merge(Driver.Empleado.GetByRol("A"));
                    }

                    if (TscS.Checked)
                    {
                        dtt.Merge(Driver.Empleado.GetByRol("S"));
                    }

                    Dgv.DataSource = dtt;

                    break;
                default: // No Criteria
                    Dgv.DataSource = Driver.Empleado.GetAll();
                    break;
            }
        }

        private void EmpleadoGui_Load(object sender, EventArgs e)
        {

        }
    }
}
