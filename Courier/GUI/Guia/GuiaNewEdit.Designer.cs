
namespace Courier.GUI.Guia
{
    partial class GuiaNewEdit
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCiu = new System.Windows.Forms.TextBox();
            this.TxtProv = new System.Windows.Forms.TextBox();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.CmbSuc = new System.Windows.Forms.ComboBox();
            this.TxtCodEmpleado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodCliente = new System.Windows.Forms.TextBox();
            this.TxtDir = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCodPaq = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtFechaEntrega = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(208, 392);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(127, 392);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 11;
            this.BtnOk.Text = "Añadir";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Provincia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Código Empleado";
            // 
            // TxtCiu
            // 
            this.TxtCiu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCiu.Location = new System.Drawing.Point(107, 207);
            this.TxtCiu.Name = "TxtCiu";
            this.TxtCiu.Size = new System.Drawing.Size(176, 20);
            this.TxtCiu.TabIndex = 6;
            // 
            // TxtProv
            // 
            this.TxtProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtProv.Location = new System.Drawing.Point(107, 181);
            this.TxtProv.Name = "TxtProv";
            this.TxtProv.Size = new System.Drawing.Size(176, 20);
            this.TxtProv.TabIndex = 5;
            // 
            // TxtDesc
            // 
            this.TxtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDesc.Location = new System.Drawing.Point(107, 117);
            this.TxtDesc.Multiline = true;
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(176, 58);
            this.TxtDesc.TabIndex = 4;
            // 
            // CmbSuc
            // 
            this.CmbSuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSuc.FormattingEnabled = true;
            this.CmbSuc.Items.AddRange(new object[] {
            "Quito",
            "Guayaquil",
            "Cuenca"});
            this.CmbSuc.Location = new System.Drawing.Point(107, 90);
            this.CmbSuc.Name = "CmbSuc";
            this.CmbSuc.Size = new System.Drawing.Size(176, 21);
            this.CmbSuc.TabIndex = 3;
            // 
            // TxtCodEmpleado
            // 
            this.TxtCodEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodEmpleado.Location = new System.Drawing.Point(107, 38);
            this.TxtCodEmpleado.Name = "TxtCodEmpleado";
            this.TxtCodEmpleado.Size = new System.Drawing.Size(176, 20);
            this.TxtCodEmpleado.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Código Cliente";
            // 
            // TxtCodCliente
            // 
            this.TxtCodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodCliente.Location = new System.Drawing.Point(107, 64);
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.Size = new System.Drawing.Size(176, 20);
            this.TxtCodCliente.TabIndex = 2;
            // 
            // TxtDir
            // 
            this.TxtDir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDir.Location = new System.Drawing.Point(107, 259);
            this.TxtDir.Multiline = true;
            this.TxtDir.Name = "TxtDir";
            this.TxtDir.Size = new System.Drawing.Size(176, 58);
            this.TxtDir.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Código Paquete";
            // 
            // TxtCodPaq
            // 
            this.TxtCodPaq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodPaq.Location = new System.Drawing.Point(107, 12);
            this.TxtCodPaq.Name = "TxtCodPaq";
            this.TxtCodPaq.Size = new System.Drawing.Size(176, 20);
            this.TxtCodPaq.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Fecha Recepción d/m/a";
            // 
            // TxtFecha
            // 
            this.TxtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFecha.Location = new System.Drawing.Point(141, 233);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(142, 20);
            this.TxtFecha.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "B",
            "C",
            "E"});
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Bodega",
            "Camino",
            "Entregado"});
            this.CmbEstado.Location = new System.Drawing.Point(107, 323);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(176, 21);
            this.CmbEstado.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Fecha Entrega d/m/a";
            // 
            // TxtFechaEntrega
            // 
            this.TxtFechaEntrega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFechaEntrega.Location = new System.Drawing.Point(141, 350);
            this.TxtFechaEntrega.Name = "TxtFechaEntrega";
            this.TxtFechaEntrega.Size = new System.Drawing.Size(142, 20);
            this.TxtFechaEntrega.TabIndex = 10;
            // 
            // GuiaNewEdit
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(295, 426);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtFechaEntrega);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtCodPaq);
            this.Controls.Add(this.TxtDir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtCodCliente);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCiu);
            this.Controls.Add(this.TxtProv);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.CmbSuc);
            this.Controls.Add(this.TxtCodEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GuiaNewEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuiaNewEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCiu;
        private System.Windows.Forms.TextBox TxtProv;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.ComboBox CmbSuc;
        private System.Windows.Forms.TextBox TxtCodEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodCliente;
        private System.Windows.Forms.TextBox TxtDir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCodPaq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtFechaEntrega;
    }
}