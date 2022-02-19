
namespace Courier.GUI
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tscOptions = new System.Windows.Forms.ToolStripComboBox();
            this.tscCriteria = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tscML = new System.Windows.Forms.ToolStripButton();
            this.tscCL = new System.Windows.Forms.ToolStripButton();
            this.tscCP = new System.Windows.Forms.ToolStripButton();
            this.tscCA = new System.Windows.Forms.ToolStripButton();
            this.tscG = new System.Windows.Forms.ToolStripButton();
            this.tscE = new System.Windows.Forms.ToolStripButton();
            this.tscL = new System.Windows.Forms.ToolStripButton();
            this.tscOk = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbEdit,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.tscOptions,
            this.tscCriteria,
            this.tscML,
            this.tscCL,
            this.tscCP,
            this.tscCA,
            this.tscG,
            this.tscE,
            this.tscL,
            this.tscOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(854, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "ts";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tscOptions
            // 
            this.tscOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscOptions.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscOptions.Items.AddRange(new object[] {
            "Empleado (CI)",
            "Capacidad",
            "Placa",
            "Tipo"});
            this.tscOptions.Name = "tscOptions";
            this.tscOptions.Size = new System.Drawing.Size(121, 25);
            this.tscOptions.ToolTipText = "Elija un criterio de búsqueda";
            this.tscOptions.SelectedIndexChanged += new System.EventHandler(this.TscOptions_SelectedUpdate);
            // 
            // tscCriteria
            // 
            this.tscCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tscCriteria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tscCriteria.Name = "tscCriteria";
            this.tscCriteria.Size = new System.Drawing.Size(200, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 452);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 452);
            this.dataGridView1.TabIndex = 2;
            // 
            // tsbNew
            // 
            this.tsbNew.Image = global::Courier.Properties.Resources.new16;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(62, 22);
            this.tsbNew.Text = "Nuevo";
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::Courier.Properties.Resources.edit16;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(57, 22);
            this.tsbEdit.Text = "Editar";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Courier.Properties.Resources.delete16;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(70, 22);
            this.tsbDelete.Text = "Eliminar";
            // 
            // tscML
            // 
            this.tscML.CheckOnClick = true;
            this.tscML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tscML.Image = ((System.Drawing.Image)(resources.GetObject("tscML.Image")));
            this.tscML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscML.Name = "tscML";
            this.tscML.Size = new System.Drawing.Size(28, 22);
            this.tscML.Text = "ML";
            // 
            // tscCL
            // 
            this.tscCL.CheckOnClick = true;
            this.tscCL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tscCL.Image = ((System.Drawing.Image)(resources.GetObject("tscCL.Image")));
            this.tscCL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscCL.Name = "tscCL";
            this.tscCL.Size = new System.Drawing.Size(25, 22);
            this.tscCL.Text = "CL";
            // 
            // tscCP
            // 
            this.tscCP.CheckOnClick = true;
            this.tscCP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tscCP.Image = ((System.Drawing.Image)(resources.GetObject("tscCP.Image")));
            this.tscCP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscCP.Name = "tscCP";
            this.tscCP.Size = new System.Drawing.Size(26, 22);
            this.tscCP.Text = "CP";
            // 
            // tscCA
            // 
            this.tscCA.CheckOnClick = true;
            this.tscCA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tscCA.Image = ((System.Drawing.Image)(resources.GetObject("tscCA.Image")));
            this.tscCA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscCA.Name = "tscCA";
            this.tscCA.Size = new System.Drawing.Size(27, 22);
            this.tscCA.Text = "CA";
            // 
            // tscG
            // 
            this.tscG.CheckOnClick = true;
            this.tscG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tscG.Image = ((System.Drawing.Image)(resources.GetObject("tscG.Image")));
            this.tscG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscG.Name = "tscG";
            this.tscG.Size = new System.Drawing.Size(56, 22);
            this.tscG.Text = "Mayores";
            // 
            // tscE
            // 
            this.tscE.CheckOnClick = true;
            this.tscE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tscE.Image = ((System.Drawing.Image)(resources.GetObject("tscE.Image")));
            this.tscE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscE.Name = "tscE";
            this.tscE.Size = new System.Drawing.Size(48, 22);
            this.tscE.Text = "Iguales";
            // 
            // tscL
            // 
            this.tscL.CheckOnClick = true;
            this.tscL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tscL.Image = ((System.Drawing.Image)(resources.GetObject("tscL.Image")));
            this.tscL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscL.Name = "tscL";
            this.tscL.Size = new System.Drawing.Size(57, 22);
            this.tscL.Text = "Menores";
            // 
            // tscOk
            // 
            this.tscOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tscOk.Image = global::Courier.Properties.Resources.search16;
            this.tscOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscOk.Name = "tscOk";
            this.tscOk.Size = new System.Drawing.Size(23, 22);
            this.tscOk.Text = "toolStripButton6";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Courier.Properties.Resources.filter16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "tscAll";
            // 
            // VehiculoGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VehiculoGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehículos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox tscCriteria;
        private System.Windows.Forms.ToolStripButton tscML;
        private System.Windows.Forms.ToolStripButton tscCL;
        private System.Windows.Forms.ToolStripButton tscCP;
        private System.Windows.Forms.ToolStripButton tscCA;
        private System.Windows.Forms.ToolStripButton tscG;
        private System.Windows.Forms.ToolStripButton tscOk;
        private System.Windows.Forms.ToolStripComboBox tscOptions;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton tscE;
        private System.Windows.Forms.ToolStripButton tscL;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}