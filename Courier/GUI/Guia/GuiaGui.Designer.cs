
namespace Courier.GUI.Guia
{
    partial class GuiaGui
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tscOk = new System.Windows.Forms.ToolStripButton();
            this.tscCriteria = new System.Windows.Forms.ToolStripTextBox();
            this.tscOptions = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsDateTo = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 2;
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
            // tscCriteria
            // 
            this.tscCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tscCriteria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tscCriteria.Name = "tscCriteria";
            this.tscCriteria.Size = new System.Drawing.Size(200, 25);
            // 
            // tscOptions
            // 
            this.tscOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscOptions.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscOptions.Items.AddRange(new object[] {
            "Cliente (CI)",
            "Fecha",
            "Provincia",
            "Ciudad"});
            this.tscOptions.Name = "tscOptions";
            this.tscOptions.Size = new System.Drawing.Size(121, 25);
            this.tscOptions.ToolTipText = "Elija un criterio de búsqueda";
            this.tscOptions.SelectedIndexChanged += new System.EventHandler(this.TscOptions_SelectedIndexChanged);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Courier.Properties.Resources.delete16;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(70, 22);
            this.tsbDelete.Text = "Eliminar";
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::Courier.Properties.Resources.edit16;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(57, 22);
            this.tsbEdit.Text = "Editar";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = global::Courier.Properties.Resources.new16;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(62, 22);
            this.tsbNew.Text = "Nuevo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 4;
            // 
            // ts
            // 
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbEdit,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.tscOptions,
            this.tscCriteria,
            this.tsDateTo,
            this.tscOk});
            this.ts.Location = new System.Drawing.Point(0, 0);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(800, 25);
            this.ts.TabIndex = 3;
            this.ts.Text = "ts";
            // 
            // tsDateTo
            // 
            this.tsDateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsDateTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsDateTo.Name = "tsDateTo";
            this.tsDateTo.Size = new System.Drawing.Size(100, 25);
            // 
            // GuiaGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ts);
            this.Name = "GuiaGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuiaGui";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton tscOk;
        private System.Windows.Forms.ToolStripTextBox tscCriteria;
        private System.Windows.Forms.ToolStripComboBox tscOptions;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripTextBox tsDateTo;
    }
}