
namespace Courier.GUI.Vehiculo
{
    partial class VehiculoNewEdit
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
            this.TxtEmpleado = new System.Windows.Forms.TextBox();
            this.CmbSuc = new System.Windows.Forms.ComboBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.TxtCap = new System.Windows.Forms.TextBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtEmpleado
            // 
            this.TxtEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEmpleado.Location = new System.Drawing.Point(107, 38);
            this.TxtEmpleado.Name = "TxtEmpleado";
            this.TxtEmpleado.Size = new System.Drawing.Size(175, 20);
            this.TxtEmpleado.TabIndex = 1;
            // 
            // CmbSuc
            // 
            this.CmbSuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSuc.FormattingEnabled = true;
            this.CmbSuc.Items.AddRange(new object[] {
            "Quito",
            "Guayaquil",
            "Cuenca"});
            this.CmbSuc.Location = new System.Drawing.Point(107, 64);
            this.CmbSuc.Name = "CmbSuc";
            this.CmbSuc.Size = new System.Drawing.Size(175, 21);
            this.CmbSuc.TabIndex = 2;
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPlaca.Location = new System.Drawing.Point(107, 91);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(175, 20);
            this.TxtPlaca.TabIndex = 3;
            // 
            // TxtModel
            // 
            this.TxtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtModel.Location = new System.Drawing.Point(107, 117);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(175, 20);
            this.TxtModel.TabIndex = 4;
            // 
            // TxtYear
            // 
            this.TxtYear.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtYear.Location = new System.Drawing.Point(107, 143);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(175, 20);
            this.TxtYear.TabIndex = 5;
            // 
            // TxtCap
            // 
            this.TxtCap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCap.Location = new System.Drawing.Point(107, 169);
            this.TxtCap.Name = "TxtCap";
            this.TxtCap.Size = new System.Drawing.Size(175, 20);
            this.TxtCap.TabIndex = 6;
            // 
            // CmbType
            // 
            this.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "ML",
            "CL",
            "CP",
            "CA"});
            this.CmbType.Location = new System.Drawing.Point(107, 195);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(175, 21);
            this.CmbType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sucursal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Año";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Capacidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(126, 229);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Añadir";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(207, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID";
            // 
            // TxtId
            // 
            this.TxtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtId.Location = new System.Drawing.Point(108, 12);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(175, 20);
            this.TxtId.TabIndex = 0;
            // 
            // VehiculoNewEdit
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(295, 264);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.TxtCap);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.TxtModel);
            this.Controls.Add(this.TxtPlaca);
            this.Controls.Add(this.CmbSuc);
            this.Controls.Add(this.TxtEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VehiculoNewEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Vehículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEmpleado;
        private System.Windows.Forms.ComboBox CmbSuc;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.TextBox TxtCap;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtId;
    }
}