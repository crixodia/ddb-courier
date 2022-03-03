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
    public partial class ClienteNewEdit : Form
    {
        string codigo = "";
        public ClienteNewEdit(Driver.Cliente sc = null)
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
                TxtZip.Text = sc.Zip;

                BtnOk.Text = "Actualizar";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Driver.Cliente sc = new Driver.Cliente(
                CmbSuc.SelectedIndex + 1,
                TxtNombre.Text,
                TxtCedula.Text,
                TxtProvincia.Text,
                TxtCiudad.Text,
                TxtProvincia.Text,
                TxtCiudad.Text,
                TxtZip.Text,
                codigo
            );

            if (codigo == "")
            {
                sc.Codigo = TxtCodigo.Text;
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
