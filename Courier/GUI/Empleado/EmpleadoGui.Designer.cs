
namespace Courier.GUI.Empleado
{
    partial class EmpleadoGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoGui));
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.TscOk = new System.Windows.Forms.ToolStripButton();
            this.TscS = new System.Windows.Forms.ToolStripButton();
            this.TscA = new System.Windows.Forms.ToolStripButton();
            this.TscC = new System.Windows.Forms.ToolStripButton();
            this.TscB = new System.Windows.Forms.ToolStripButton();
            this.TscCriteria = new System.Windows.Forms.ToolStripTextBox();
            this.TscOptions = new System.Windows.Forms.ToolStripComboBox();
            this.TsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbDelete = new System.Windows.Forms.ToolStripButton();
            this.TsbEdit = new System.Windows.Forms.ToolStripButton();
            this.TsbNew = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AllowUserToOrderColumns = true;
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
            this.Dgv.Size = new System.Drawing.Size(800, 425);
            this.Dgv.TabIndex = 2;
            this.Dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellDoubleClick);
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
            // TscS
            // 
            this.TscS.CheckOnClick = true;
            this.TscS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TscS.Image = ((System.Drawing.Image)(resources.GetObject("TscS.Image")));
            this.TscS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscS.Name = "TscS";
            this.TscS.Size = new System.Drawing.Size(23, 22);
            this.TscS.Text = "S";
            // 
            // TscA
            // 
            this.TscA.CheckOnClick = true;
            this.TscA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TscA.Image = ((System.Drawing.Image)(resources.GetObject("TscA.Image")));
            this.TscA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscA.Name = "TscA";
            this.TscA.Size = new System.Drawing.Size(23, 22);
            this.TscA.Text = "A";
            // 
            // TscC
            // 
            this.TscC.CheckOnClick = true;
            this.TscC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TscC.Image = ((System.Drawing.Image)(resources.GetObject("TscC.Image")));
            this.TscC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscC.Name = "TscC";
            this.TscC.Size = new System.Drawing.Size(23, 22);
            this.TscC.Text = "C";
            // 
            // TscB
            // 
            this.TscB.CheckOnClick = true;
            this.TscB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TscB.Image = ((System.Drawing.Image)(resources.GetObject("TscB.Image")));
            this.TscB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TscB.Name = "TscB";
            this.TscB.Size = new System.Drawing.Size(23, 22);
            this.TscB.Text = "B";
            this.TscB.ToolTipText = "B";
            // 
            // TscCriteria
            // 
            this.TscCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TscCriteria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TscCriteria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TscCriteria.Name = "TscCriteria";
            this.TscCriteria.Size = new System.Drawing.Size(200, 25);
            // 
            // TscOptions
            // 
            this.TscOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TscOptions.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.TscOptions.Items.AddRange(new object[] {
            "Cédula Empleado",
            "Provincia",
            "Ciudad",
            "Rol"});
            this.TscOptions.Name = "TscOptions";
            this.TscOptions.Size = new System.Drawing.Size(121, 25);
            this.TscOptions.ToolTipText = "Elija un criterio de búsqueda";
            this.TscOptions.SelectedIndexChanged += new System.EventHandler(this.TscOptions_SelectedIndexChanged);
            // 
            // TsbRefresh
            // 
            this.TsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbRefresh.Image = global::Courier.Properties.Resources.filter16;
            this.TsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbRefresh.Name = "TsbRefresh";
            this.TsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.TsbRefresh.Text = "tscAll";
            this.TsbRefresh.Click += new System.EventHandler(this.TsbRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbDelete
            // 
            this.TsbDelete.Image = global::Courier.Properties.Resources.delete16;
            this.TsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbDelete.Name = "TsbDelete";
            this.TsbDelete.Size = new System.Drawing.Size(70, 22);
            this.TsbDelete.Text = "Eliminar";
            this.TsbDelete.Click += new System.EventHandler(this.TsbDelete_Click);
            // 
            // TsbEdit
            // 
            this.TsbEdit.Image = global::Courier.Properties.Resources.edit16;
            this.TsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEdit.Name = "TsbEdit";
            this.TsbEdit.Size = new System.Drawing.Size(57, 22);
            this.TsbEdit.Text = "Editar";
            this.TsbEdit.Click += new System.EventHandler(this.TsbEdit_Click);
            // 
            // TsbNew
            // 
            this.TsbNew.Image = global::Courier.Properties.Resources.new16;
            this.TsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNew.Name = "TsbNew";
            this.TsbNew.Size = new System.Drawing.Size(62, 22);
            this.TsbNew.Text = "Nuevo";
            this.TsbNew.Click += new System.EventHandler(this.TsbNew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNew,
            this.TsbEdit,
            this.TsbDelete,
            this.toolStripSeparator1,
            this.TsbRefresh,
            this.TscOptions,
            this.TscCriteria,
            this.TscB,
            this.TscC,
            this.TscA,
            this.TscS,
            this.TscOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "ts";
            // 
            // EmpleadoGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EmpleadoGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.ToolStripButton TscOk;
        private System.Windows.Forms.ToolStripButton TscS;
        private System.Windows.Forms.ToolStripButton TscA;
        private System.Windows.Forms.ToolStripButton TscC;
        private System.Windows.Forms.ToolStripButton TscB;
        private System.Windows.Forms.ToolStripTextBox TscCriteria;
        private System.Windows.Forms.ToolStripComboBox TscOptions;
        private System.Windows.Forms.ToolStripButton TsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbDelete;
        private System.Windows.Forms.ToolStripButton TsbEdit;
        private System.Windows.Forms.ToolStripButton TsbNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}