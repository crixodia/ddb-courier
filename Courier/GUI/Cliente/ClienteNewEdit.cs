using System;
using System.Windows.Forms;

namespace Courier.GUI.Cliente
{
    public partial class ClienteNewEdit : Form
    {
        string codigo = "";
        string cedula = "";
        public ClienteNewEdit(Driver.Cliente sc = null)
        {
            InitializeComponent();

            CmbSuc.SelectedIndex = 0;


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
                TxtDireccion.Text,
                TxtTelefono.Text,
                TxtZip.Text,
                codigo
            );

            switch (codigo)
            {
                case "":
                    if (!Driver.Cliente.ValidateByCodigo(TxtCodigo.Text))
                    {
                        if (!Driver.Cliente.ValidateByCedula(sc.Cedula))
                        {
                            sc.Codigo = TxtCodigo.Text;
                            sc.Insert();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Ya existe un cliente con cédula " + sc.Cedula,
                                "Cliente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop
                            );
                            TxtCedula.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ya existe un cliente con código " + TxtCodigo.Text,
                            "Cliente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                        );
                        TxtCodigo.Focus();
                    }
                    break;
                default:
                    if (TxtCodigo.Text == sc.Codigo || !Driver.Cliente.ValidateByCodigo(TxtCodigo.Text))
                    {
                        if (TxtCedula.Text == cedula || !Driver.Cliente.ValidateByCedula(sc.Cedula))
                        {
                            sc.Update(TxtCodigo.Text);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Ya existe un cliente con cédula " + sc.Cedula,
                                "Cliente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop
                            );
                            TxtCedula.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ya existe un cliente con código " + TxtCodigo.Text,
                            "Cliente",
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
