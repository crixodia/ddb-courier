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
    public partial class VehiculoNewEdit : Form
    {
        int codigo = -1;
        string placa = "";
        public VehiculoNewEdit(Driver.Vehiculo sc = null)
        {
            InitializeComponent();
            if (sc == null)
            {
                Icon = Properties.Resources._new;
            }
            else
            {
                Icon = Properties.Resources.edit;

                codigo = sc.Id;
                TxtId.Text = sc.Id.ToString();
                TxtEmpleado.Text = sc.Empleado;
                CmbSuc.SelectedIndex = sc.Sucursal - 1;
                TxtPlaca.Text = sc.Placa;
                placa = sc.Placa;
                TxtModel.Text = sc.Modelo;
                TxtYear.Text = sc.Anio;
                TxtCap.Text = sc.Capacidad.ToString();
                CmbType.SelectedIndex = CmbType.Items.IndexOf(sc.Tipo);

                btnOk.Text = "Actualizar";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Driver.Vehiculo sc = new Driver.Vehiculo(
                TxtEmpleado.Text,
                CmbSuc.SelectedIndex + 1,
                TxtPlaca.Text,
                TxtModel.Text,
                TxtYear.Text,
                int.Parse(TxtCap.Text),
                CmbType.SelectedItem.ToString(),
                int.Parse(TxtId.Text)
            );

            switch (codigo)
            {
                case -1:
                    if (!Driver.Vehiculo.ValidateByID(sc.Id))
                    {
                        if (!Driver.Vehiculo.ValidateByPlaca(sc.Placa))
                        {
                            if (Driver.Empleado.ValidateByCodigo(sc.Empleado))
                            {
                                sc.Insert();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No existe el empleado " + sc.Empleado,
                                    "Vehículo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop
                                );
                                TxtEmpleado.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "Ya existe un vehículo con placa " + sc.Placa,
                                "Vehículo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop
                            );
                            TxtPlaca.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ya existe un vehículo con ID " + sc.Id,
                            "Vehículo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                        );
                        TxtId.Focus();
                    }
                    break;
                default:
                    if (TxtPlaca.Text == placa || !Driver.Vehiculo.ValidateByPlaca(sc.Placa))
                    {
                        if (Driver.Empleado.ValidateByCodigo(sc.Empleado))
                        {
                            sc.Update(codigo);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "No existe el empleado " + sc.Empleado,
                                "Vehículo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop
                            );
                            TxtEmpleado.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ya existe un vehículo con placa " + sc.Placa,
                            "Vehículo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                        );
                        TxtPlaca.Focus();
                    }
                    break;
            }
        }
    }
}
