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
            tscOptions.SelectedIndex = 0;
        }

        private void TscOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tscOptions.SelectedIndex)
            {
                case 3:
                    tscB.Visible = true;
                    tscS.Visible = true;
                    tscC.Visible = true;
                    tscA.Visible = true;

                    tscCriteria.Visible = false;
                    break;
                default:
                    tscB.Visible = false;
                    tscS.Visible = false;
                    tscC.Visible = false;
                    tscA.Visible = false;

                    tscCriteria.Visible = true;
                    break;
            }
        }
    }
}
