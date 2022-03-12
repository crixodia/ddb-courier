
namespace Courier.GUI.Vehiculo
{
    partial class VehiculoGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiculoGui));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbNew = new System.Windows.Forms.ToolStripButton();
            this.TsbEdit = new System.Windows.Forms.ToolStripButton();
            this.TsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TbsRefresh = new System.Windows.Forms.ToolStripButton();
            this.TscOptions = new System.Windows.Forms.ToolStripComboBox();
            this.TscCriteria = new System.Windows.Forms.ToolStripTextBox();
            this.TscML = new System.Windows.Forms.ToolStripButton();
            this.TscCL = new System.Windows.Forms.ToolStripButton();
            this.TscCP = new System.Windows.Forms.ToolStripButton();
            this.TscCA = new System.Windows.Forms.ToolStripButton();
            this.TscG = new System.Windows.Forms.ToolStripButton();
            this.TscE = new System.Windows.Forms.ToolStripButton();
            this.TscL = new System.Windows.Forms.ToolStripButton();
            this.TscOk = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNew,
            this.TsbEdit,
            this.TsbDelete,
            this.toolStripSeparator1,
            this.TbsRefresh,
            this.TscOptions,
            this.TscCriteria,
            this.TscML,
            this.TscCL,
            this.TscCP,
            this.TscCA,
            this.TscG,
            this.TscE,
            this.TscL,
            this.TscOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(854, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "ts";
            // 
            // TsbNew
            // 
            this.TsbNew.Enabled = false;
            this.TsbNew.Image = global::Courier.Properties.Resources.new16;
            this.TsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNew.Name = "TsbNew";
            this.TsbNew.Size = new System.Drawing.Size(62, 22);
            this.TsbNew.Text = "Nuevo";
            this.TsbNew.Click += new System.EventHandler(this.TsbNew_Click);
            // 
            // TsbEdit
            // 
            this.TsbEdit.Enabled = false;
            this.TsbEdit.Image = global::Courier.Properties.Resources.edit16;
            this.TsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEdit.Name = "TsbEdit";
            this.TsbEdit.Size = new System.Drawing.Size(57, 22);
            this.TsbEdit.Text = "Editar";
            this.TsbEdit.Click += new System.EventHandler(this.TsbEdit_Click);
            // 
            // TsbDelete
            // 
            this.TsbDelete.Enabled = false;
            this.TsbDelete.Image = global::Courier.Properties.Resources.delete16;
            this.TsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbDelete.Name = "TsbDelete";
            this.TsbDelete.Size = new System.Drawing.Size(70, 22);
            this.TsbDelete.Text = "Eliminar";
            this.TsbDelete.Click += new System.EventHandler(this.TsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TbsRefresh
            // 
            this.TbsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TbsRefresh.Image = global::Courier.Properties.Resources.filter16;
            this.TbsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbsRefresh.Name = "TbsRefresh";
            this.TbsRefresh.Size = new System.Drawing.Size(23, 22);
            this.TbsRefresh.Text = "tscAll";
            this.TbsRefresh.Click += new System.EventHandler(this.TbsRefresh_Click);
            // 
            // TscOptions
            // 
            this.TscOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TscOptions.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.TscOptions.Items.AddRange(new object[] {
            "Código Empleado",
            "Capacidad",
            "Placa",
            "Tipo"});
            this.TscOptions.Name = "TscOptions";
            this.TscOptions.Size = new System.Drawing.Size(121, 25);
            this.TscOptions.ToolTipText = "Elija un criterio de búsqueda";
            this.TscOptions.SelectedIndexChanged += new System.EventHandler(this.TscOptions_SelectedUpdate);
            // 
            // TscCriteria
            // 
            this.TscCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TscCriteria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TscCriteria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TscCriteria.Name = "TscCriteria";
            this.TscCriteria.Size = new System.Drawing.Size(200, 25);
            // 
            // TscML
            // 
            this.TscML.CheckOnClick = true;
            this.TscML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TscML.Image = ((System.Drawing.Image)(resources.GetObject("TscML.Image")));
            this.TscML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscML.Name = "TscML";
            this.TscML.Size = new System.Drawing.Size(28, 22);
            this.TscML.Text = "ML";
            // 
            // TscCL
            // 
            this.TscCL.CheckOnClick = true;
            this.TscCL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TscCL.Image = ((System.Drawing.Image)(resources.GetObject("TscCL.Image")));
            this.TscCL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscCL.Name = "TscCL";
            this.TscCL.Size = new System.Drawing.Size(25, 22);
            this.TscCL.Text = "CL";
            // 
            // TscCP
            // 
            this.TscCP.CheckOnClick = true;
            this.TscCP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TscCP.Image = ((System.Drawing.Image)(resources.GetObject("TscCP.Image")));
            this.TscCP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscCP.Name = "TscCP";
            this.TscCP.Size = new System.Drawing.Size(26, 22);
            this.TscCP.Text = "CP";
            // 
            // TscCA
            // 
            this.TscCA.CheckOnClick = true;
            this.TscCA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TscCA.Image = ((System.Drawing.Image)(resources.GetObject("TscCA.Image")));
            this.TscCA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscCA.Name = "TscCA";
            this.TscCA.Size = new System.Drawing.Size(27, 22);
            this.TscCA.Text = "CA";
            // 
            // TscG
            // 
            this.TscG.CheckOnClick = true;
            this.TscG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TscG.Image = ((System.Drawing.Image)(resources.GetObject("TscG.Image")));
            this.TscG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscG.Name = "TscG";
            this.TscG.Size = new System.Drawing.Size(56, 22);
            this.TscG.Text = "Mayores";
            // 
            // TscE
            // 
            this.TscE.CheckOnClick = true;
            this.TscE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TscE.Image = ((System.Drawing.Image)(resources.GetObject("TscE.Image")));
            this.TscE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscE.Name = "TscE";
            this.TscE.Size = new System.Drawing.Size(48, 22);
            this.TscE.Text = "Iguales";
            // 
            // TscL
            // 
            this.TscL.CheckOnClick = true;
            this.TscL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TscL.Image = ((System.Drawing.Image)(resources.GetObject("TscL.Image")));
            this.TscL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscL.Name = "TscL";
            this.TscL.Size = new System.Drawing.Size(57, 22);
            this.TscL.Text = "Menores";
            // 
            // TscOk
            // 
            this.TscOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TscOk.Image = global::Courier.Properties.Resources.search16;
            this.TscOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscOk.Name = "TscOk";
            this.TscOk.Size = new System.Drawing.Size(23, 22);
            this.TscOk.Text = "toolStripButton6";
            this.TscOk.Click += new System.EventHandler(this.TscOk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 452);
            this.panel1.TabIndex = 2;
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AllowUserToResizeRows = false;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.Location = new System.Drawing.Point(0, 0);
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(854, 452);
            this.Dgv.TabIndex = 2;
            this.Dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellDoubleClick);
            // 
            // VehiculoGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Enabled = false;
            this.Name = "VehiculoGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehículos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox TscCriteria;
        private System.Windows.Forms.ToolStripButton TscML;
        private System.Windows.Forms.ToolStripButton TscCL;
        private System.Windows.Forms.ToolStripButton TscCP;
        private System.Windows.Forms.ToolStripButton TscCA;
        private System.Windows.Forms.ToolStripButton TscG;
        private System.Windows.Forms.ToolStripButton TscOk;
        private System.Windows.Forms.ToolStripComboBox TscOptions;
        private System.Windows.Forms.ToolStripButton TsbNew;
        private System.Windows.Forms.ToolStripButton TsbEdit;
        private System.Windows.Forms.ToolStripButton TsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.ToolStripButton TscE;
        private System.Windows.Forms.ToolStripButton TscL;
        private System.Windows.Forms.ToolStripButton TbsRefresh;
    }
}