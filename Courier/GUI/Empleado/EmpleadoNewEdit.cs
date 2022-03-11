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
    public partial class EmpleadoNewEdit : Form
    {
        string codigo = "";
        string cedula = "";
        public EmpleadoNewEdit(Driver.Empleado sc = null)
        {
            InitializeComponent();
            
            CmbSuc.SelectedIndex = 0;
            CmbRol.SelectedIndex = 0;

            if (sc == null)
            {
                Icon = Properties.Resources._new;
            }
            else
            {
                Icon = Properties.Resources.edit;

                codigo = sc.Codigo;
                TxtCodigo.Text = sc.Codigo;
                TxtCedula.Text = sc.Cedula;
                cedula = sc.Cedula;
                TxtNombre.Text = sc.Nombre;
                TxtProvincia.Text = sc.Provincia;
                TxtCiudad.Text = sc.Ciudad;
                TxtTelefono.Text = sc.Telefono;
                TxtDireccion.Text = sc.Direccion;
                CmbSuc.SelectedIndex = sc.Sucursal - 1;


                var crit = new Dictionary<string, string>();
                crit["B"] = "Bodeguero";
                crit["C"] = "Chofer";
                crit["A"] = "Administrador";
                crit["S"] = "Soporte";


                CmbRol.SelectedIndex = CmbRol.Items.IndexOf(crit[sc.Rol.ToString()]);

                BtnOk.Text = "Actualizar";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Driver.Empleado sc = new Driver.Empleado(
                CmbSuc.SelectedIndex + 1,
                TxtNombre.Text,
                TxtCedula.Text,
                TxtProvincia.Text,
                TxtCiudad.Text,
                TxtDireccion.Text,
                TxtTelefono.Text,
                CmbRol.SelectedItem.ToString()[0],
                codigo
            );

            switch (codigo)
            {
                case "":
                    if (!Driver.Empleado.ValidateByCodigo(TxtCodigo.Text))
                    {
                        if (!Driver.Empleado.ValidateByCedula(sc.Cedula))
                        {
                            sc.Codigo = TxtCodigo.Text;
                            sc.Insert();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Ya existe un empleado con cédula " + sc.Cedula,
                                "Empleado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop
                            );
                            TxtCedula.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ya existe un empleado con código " + TxtCodigo.Text,
                            "Empleado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                        );
                        TxtCodigo.Focus();
                    }
                    break;
                default:
                    if (TxtCodigo.Text == sc.Codigo || !Driver.Empleado.ValidateByCodigo(TxtCodigo.Text))
                    {
                        if (TxtCedula.Text == cedula || !Driver.Empleado.ValidateByCedula(sc.Cedula))
                        {
                            sc.Update(TxtCodigo.Text);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Ya existe un empleado con cédula " + sc.Cedula,
                                "Empleado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop
                            );
                            TxtCedula.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ya existe un empleado con código " + TxtCodigo.Text,
                            "Empleado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                        );
                        TxtCodigo.Focus();
                    }
                    break;
            }
        }
    }
}
