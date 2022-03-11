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
        string empleado = "";
        string cliente = "";
        public GuiaNewEdit(bool editable = false, Driver.Guia sc = null)
        {
            InitializeComponent();

            CmbEstado.SelectedIndex = 0;
            CmbSuc.SelectedIndex = 0;

            TxtFecha.Text = DateTime.Now.ToString("MM/dd/yyyy");

            if (!editable)
            {
                TxtFechaEntrega.Enabled = false;
                CmbEstado.Enabled = false;
                CmbEstado.SelectedIndex = 0;

            }

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
                empleado = sc.Empleado;
                TxtCodCliente.Text = sc.Cliente;
                cliente = sc.Cliente;
                CmbSuc.SelectedIndex = sc.Sucursal - 1;
                TxtDesc.Text = sc.Descripcion;
                TxtProv.Text = sc.ProvinciaDestino;
                TxtCiu.Text = sc.CiudadDestino;
                TxtDir.Text = sc.DireccionDestino;
                TxtFecha.Text = sc.FechaRecepcion.Split(' ')[0];
                TxtFechaEntrega.Text = sc.FechaEntrega.Split(' ')[0];
                Console.WriteLine(sc.Estado);

                var crit = new Dictionary<string, string>();
                crit["B"] = "Bodega";
                crit["C"] = "Camino";
                crit["E"] = "Entregado";

                CmbEstado.SelectedIndex = CmbEstado.Items.IndexOf(crit[sc.Estado.ToString()]);

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
                TxtFechaEntrega.Text,
                CmbEstado.SelectedItem.ToString()[0],
                codigo
            );

            switch (codigo)
            {
                case "":
                    if (!Driver.Guia.ValidateByCodigo(TxtCodPaq.Text))
                    {
                        if (Driver.Empleado.ValidateByCodigo(sc.Empleado))
                        {
                            if (Driver.Cliente.ValidateByCodigo(sc.Cliente))
                            {
                                sc.Codigo = TxtCodPaq.Text;
                                sc.Insert();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No existe el cliente " + sc.Cliente,
                                    "Guía",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop
                                );
                                TxtCodCliente.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "No existe el empleado " + sc.Empleado,
                                "Guía",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop
                            );
                            TxtCodEmpleado.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ya existe una guía con código " + TxtCodPaq.Text,
                            "Guía",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                        );
                        TxtCodPaq.Focus();
                    }
                    break;
                default:
                    if (TxtCodPaq.Text == codigo || !Driver.Guia.ValidateByCodigo(TxtCodPaq.Text))
                    {
                        if (TxtCodEmpleado.Text == empleado || Driver.Empleado.ValidateByCodigo(sc.Empleado))
                        {
                            if (TxtCodCliente.Text == cliente || Driver.Cliente.ValidateByCodigo(sc.Cliente))
                            {
                                sc.Update(TxtCodPaq.Text);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No existe el cliente " + sc.Cliente,
                                    "Guía",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Stop
                                );
                                TxtCodCliente.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "No existe el empleado " + sc.Empleado,
                                "Guía",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop
                            );
                            TxtCodEmpleado.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ya existe una guía con código " + TxtCodPaq.Text,
                            "Guía",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop
                        );
                        TxtCodPaq.Focus();
                    }
                    break;
            }
        }
    }
}
