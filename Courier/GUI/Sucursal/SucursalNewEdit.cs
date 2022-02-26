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
    public partial class SucursalNewEdit : Form
    {
        int codigo = -1;
        public SucursalNewEdit(Driver.Sucursal sc = null)
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
                txtCiudad.Text = sc.Ciudad;
                txtDireccion.Text = sc.Direccion;
                txtProvincia.Text = sc.Provincia;

                btnOk.Text = "Actualizar";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Driver.Sucursal sc = new Driver.Sucursal(
                txtProvincia.Text,
                txtCiudad.Text,
                txtDireccion.Text
            );

            if (codigo == -1)
            {
                sc.Insert();
            }
            else
            {
                sc.Codigo = codigo;
                sc.Update();
            }

            Close();
        }
    }
}
