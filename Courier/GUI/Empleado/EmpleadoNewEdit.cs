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
        public EmpleadoNewEdit(Driver.Empleado sc = null)
        {
            InitializeComponent();
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
                TxtNombre.Text = sc.Nombre;
                TxtProvincia.Text = sc.Provincia;
                TxtCiudad.Text = sc.Ciudad;
                TxtTelefono.Text = sc.Telefono;
                TxtDireccion.Text = sc.Direccion;
                CmbSuc.SelectedIndex = sc.Sucursal - 1;
                CmbRol.SelectedIndex = CmbRol.Items.IndexOf(sc.Rol.ToString());

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
                TxtProvincia.Text,
                TxtCiudad.Text,
                CmbRol.SelectedItem.ToString()[0],
                codigo
            );

            if (codigo == "")
            {
                sc.Insert();
            }
            else
            {
                sc.Update(TxtCodigo.Text);
            }

            Close();
        }
    }
}
