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
    public partial class GuiaGui : Form
    {
        public GuiaGui()
        {
            InitializeComponent();
            tscOptions.SelectedIndex = 0;
        }

        private void TscOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tscOptions.SelectedIndex)
            {
                case 1:
                    tsDateTo.Visible = true;

                    tscCriteria.Size = new Size(100, tsDateTo.Size.Height);
                    break;
                default:
                    tsDateTo.Visible = false;

                    tscCriteria.Visible = true;
                    tscCriteria.Size = new Size(200, tsDateTo.Size.Height);
                    break;
            }
        }
    }
}
