namespace crud_entity
{
    partial class FrmInsertCargoEmpleado
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.comboCargo = new System.Windows.Forms.ComboBox();
            this.lblErrName1 = new System.Windows.Forms.Label();
            this.lblErrName2 = new System.Windows.Forms.Label();
            this.lblErrApe1 = new System.Windows.Forms.Label();
            this.lblErrApe2 = new System.Windows.Forms.Label();
            this.lblErrCarg1 = new System.Windows.Forms.Label();
            this.lblErrCarg2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(100, 228);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(99, 44);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(307, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 44);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(110, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(108, 111);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(170, 108);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(220, 20);
            this.txtApe.TabIndex = 7;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(110, 160);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 13);
            this.lblCargo.TabIndex = 8;
            this.lblCargo.Text = "Cargo:";
            // 
            // comboCargo
            // 
            this.comboCargo.FormattingEnabled = true;
            this.comboCargo.Location = new System.Drawing.Point(170, 157);
            this.comboCargo.Name = "comboCargo";
            this.comboCargo.Size = new System.Drawing.Size(171, 21);
            this.comboCargo.TabIndex = 9;
            // 
            // lblErrName1
            // 
            this.lblErrName1.AutoSize = true;
            this.lblErrName1.ForeColor = System.Drawing.Color.Red;
            this.lblErrName1.Location = new System.Drawing.Point(170, 82);
            this.lblErrName1.Name = "lblErrName1";
            this.lblErrName1.Size = new System.Drawing.Size(0, 13);
            this.lblErrName1.TabIndex = 10;
            // 
            // lblErrName2
            // 
            this.lblErrName2.AutoSize = true;
            this.lblErrName2.ForeColor = System.Drawing.Color.Red;
            this.lblErrName2.Location = new System.Drawing.Point(396, 62);
            this.lblErrName2.Name = "lblErrName2";
            this.lblErrName2.Size = new System.Drawing.Size(0, 13);
            this.lblErrName2.TabIndex = 11;
            // 
            // lblErrApe1
            // 
            this.lblErrApe1.AutoSize = true;
            this.lblErrApe1.ForeColor = System.Drawing.Color.Red;
            this.lblErrApe1.Location = new System.Drawing.Point(170, 131);
            this.lblErrApe1.Name = "lblErrApe1";
            this.lblErrApe1.Size = new System.Drawing.Size(0, 13);
            this.lblErrApe1.TabIndex = 12;
            // 
            // lblErrApe2
            // 
            this.lblErrApe2.AutoSize = true;
            this.lblErrApe2.ForeColor = System.Drawing.Color.Red;
            this.lblErrApe2.Location = new System.Drawing.Point(396, 111);
            this.lblErrApe2.Name = "lblErrApe2";
            this.lblErrApe2.Size = new System.Drawing.Size(0, 13);
            this.lblErrApe2.TabIndex = 13;
            // 
            // lblErrCarg1
            // 
            this.lblErrCarg1.AutoSize = true;
            this.lblErrCarg1.ForeColor = System.Drawing.Color.Red;
            this.lblErrCarg1.Location = new System.Drawing.Point(170, 181);
            this.lblErrCarg1.Name = "lblErrCarg1";
            this.lblErrCarg1.Size = new System.Drawing.Size(0, 13);
            this.lblErrCarg1.TabIndex = 14;
            // 
            // lblErrCarg2
            // 
            this.lblErrCarg2.AutoSize = true;
            this.lblErrCarg2.ForeColor = System.Drawing.Color.Red;
            this.lblErrCarg2.Location = new System.Drawing.Point(347, 160);
            this.lblErrCarg2.Name = "lblErrCarg2";
            this.lblErrCarg2.Size = new System.Drawing.Size(0, 13);
            this.lblErrCarg2.TabIndex = 15;
            // 
            // FrmInsertCargoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(496, 322);
            this.Controls.Add(this.lblErrCarg2);
            this.Controls.Add(this.lblErrCarg1);
            this.Controls.Add(this.lblErrApe2);
            this.Controls.Add(this.lblErrApe1);
            this.Controls.Add(this.lblErrName2);
            this.Controls.Add(this.lblErrName1);
            this.Controls.Add(this.comboCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.MaximumSize = new System.Drawing.Size(512, 361);
            this.MinimumSize = new System.Drawing.Size(512, 361);
            this.Name = "FrmInsertCargoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInsertCargoEmpleado";
            this.Load += new System.EventHandler(this.FrmInsertCargoEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox comboCargo;
        private System.Windows.Forms.Label lblErrName1;
        private System.Windows.Forms.Label lblErrName2;
        private System.Windows.Forms.Label lblErrApe1;
        private System.Windows.Forms.Label lblErrApe2;
        private System.Windows.Forms.Label lblErrCarg1;
        private System.Windows.Forms.Label lblErrCarg2;
    }
}