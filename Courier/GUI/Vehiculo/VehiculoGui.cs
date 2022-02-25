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

            tscOptions.SelectedIndex = 0;
        }

        private void TscOptions_SelectedUpdate(object sender, EventArgs e)
        {
            switch (tscOptions.SelectedIndex)
            {
                case 1:
                    tscG.Visible = true;
                    tscE.Visible = true;
                    tscL.Visible = true;

                    tscCriteria.Visible = true;
                    break;
                case 3:
                    tscML.Visible = true;
                    tscCA.Visible = true;
                    tscCL.Visible = true;
                    tscCP.Visible = true;

                    tscCriteria.Visible = false;
                    break;
                default:
                    tscML.Visible = false;
                    tscCA.Visible = false;
                    tscCL.Visible = false;
                    tscCP.Visible = false;

                    tscG.Visible = false;
                    tscE.Visible = false;
                    tscL.Visible = false;

                    tscCriteria.Visible = true;
                    break;
            }
        }
    }
}
