
namespace Courier.GUI.Cliente
{
    partial class ClienteGui
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
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.TscOk = new System.Windows.Forms.ToolStripButton();
            this.TscCriteria = new System.Windows.Forms.ToolStripTextBox();
            this.TscOptions = new System.Windows.Forms.ToolStripComboBox();
            this.TbsRefresh = new System.Windows.Forms.ToolStripButton();
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
            "Cédula Cliente",
            "Provincia",
            "Ciudad",
            "ZIP"});
            this.TscOptions.Name = "TscOptions";
            this.TscOptions.Size = new System.Drawing.Size(121, 25);
            this.TscOptions.ToolTipText = "Elija un criterio de búsqueda";
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
            this.TbsRefresh,
            this.TscOptions,
            this.TscCriteria,
            this.TscOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "ts";
            // 
            // ClienteGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ClienteGui";
            this.Text = "Cliente";
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
        private System.Windows.Forms.ToolStripTextBox TscCriteria;
        private System.Windows.Forms.ToolStripComboBox TscOptions;
        private System.Windows.Forms.ToolStripButton TbsRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbDelete;
        private System.Windows.Forms.ToolStripButton TsbEdit;
        private System.Windows.Forms.ToolStripButton TsbNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}