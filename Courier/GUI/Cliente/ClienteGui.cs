﻿using System;
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
    public partial class ClienteGui : Form
    {
        public ClienteGui()
        {
            InitializeComponent();
            tscOptions.SelectedIndex = 0;
        }
    }
}
