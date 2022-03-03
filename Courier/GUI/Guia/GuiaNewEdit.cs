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
    public partial class GuiaNewEdit : Form
    {
        string codigo = "";
        public GuiaNewEdit(Driver.Guia sc = null)
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
                TxtCodPaq.Text = sc.Codigo;
                TxtCodEmpleado.Text = sc.Empleado;
                TxtCodCliente.Text = sc.Cliente;
                CmbSuc.SelectedIndex = sc.Sucursal - 1;
                TxtDesc.Text = sc.Descripcion;
                TxtProv.Text = sc.ProvinciaDestino;
                TxtCiu.Text = sc.CiudadDestino;
                TxtDir.Text = sc.DireccionDestino;
                TxtFecha.Text = sc.FechaRecepcion;

                BtnOk.Text = "Actualizar";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Driver.Guia sc = new Driver.Guia(
                CmbSuc.SelectedIndex + 1,
                TxtCodEmpleado.Text,
                TxtCodCliente.Text,
                TxtFecha.Text,
                TxtDesc.Text,
                TxtProv.Text,
                TxtCiu.Text,
                TxtDir.Text,
                codigo
            );

            if (codigo == "")
            {
                sc.Insert();
            }
            else
            {
                sc.Update(TxtCodPaq.Text);
            }

            Close();
        }
    }
}
