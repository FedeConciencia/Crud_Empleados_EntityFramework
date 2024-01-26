namespace crud_entity
{
    partial class FormPrincCargo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteLog = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSearchCargo = new System.Windows.Forms.Button();
            this.txtSearchCarg = new System.Windows.Forms.TextBox();
            this.lblSearchCarg = new System.Windows.Forms.Label();
            this.cboCritCarg = new System.Windows.Forms.ComboBox();
            this.lblCriterioEmp = new System.Windows.Forms.Label();
            this.cboCampCarg = new System.Windows.Forms.ComboBox();
            this.lblCampoCargo = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteLog);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.btnSearchCargo);
            this.splitContainer1.Panel2.Controls.Add(this.txtSearchCarg);
            this.splitContainer1.Panel2.Controls.Add(this.lblSearchCarg);
            this.splitContainer1.Panel2.Controls.Add(this.cboCritCarg);
            this.splitContainer1.Panel2.Controls.Add(this.lblCriterioEmp);
            this.splitContainer1.Panel2.Controls.Add(this.cboCampCarg);
            this.splitContainer1.Panel2.Controls.Add(this.lblCampoCargo);
            this.splitContainer1.Panel2.Controls.Add(this.dataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(734, 445);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "ADMIN CARGO";
            // 
            // btnDeleteLog
            // 
            this.btnDeleteLog.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLog.Location = new System.Drawing.Point(407, 54);
            this.btnDeleteLog.Name = "btnDeleteLog";
            this.btnDeleteLog.Size = new System.Drawing.Size(92, 38);
            this.btnDeleteLog.TabIndex = 6;
            this.btnDeleteLog.Text = "DELETE LOG";
            this.btnDeleteLog.UseVisualStyleBackColor = true;
            this.btnDeleteLog.Click += new System.EventHandler(this.btnDeleteLog_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(234, 54);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 38);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(568, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(68, 54);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 38);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSearchCargo
            // 
            this.btnSearchCargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnSearchCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCargo.Location = new System.Drawing.Point(647, 16);
            this.btnSearchCargo.Name = "btnSearchCargo";
            this.btnSearchCargo.Size = new System.Drawing.Size(75, 37);
            this.btnSearchCargo.TabIndex = 18;
            this.btnSearchCargo.Text = "Search";
            this.btnSearchCargo.UseVisualStyleBackColor = true;
            this.btnSearchCargo.Click += new System.EventHandler(this.btnSearchCargo_Click);
            // 
            // txtSearchCarg
            // 
            this.txtSearchCarg.Location = new System.Drawing.Point(494, 25);
            this.txtSearchCarg.Name = "txtSearchCarg";
            this.txtSearchCarg.Size = new System.Drawing.Size(129, 20);
            this.txtSearchCarg.TabIndex = 17;
            // 
            // lblSearchCarg
            // 
            this.lblSearchCarg.AutoSize = true;
            this.lblSearchCarg.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCarg.Location = new System.Drawing.Point(420, 27);
            this.lblSearchCarg.Name = "lblSearchCarg";
            this.lblSearchCarg.Size = new System.Drawing.Size(68, 15);
            this.lblSearchCarg.TabIndex = 16;
            this.lblSearchCarg.Text = "Busqueda:";
            // 
            // cboCritCarg
            // 
            this.cboCritCarg.FormattingEnabled = true;
            this.cboCritCarg.Location = new System.Drawing.Point(281, 25);
            this.cboCritCarg.Name = "cboCritCarg";
            this.cboCritCarg.Size = new System.Drawing.Size(121, 21);
            this.cboCritCarg.TabIndex = 15;
            // 
            // lblCriterioEmp
            // 
            this.lblCriterioEmp.AutoSize = true;
            this.lblCriterioEmp.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioEmp.Location = new System.Drawing.Point(222, 27);
            this.lblCriterioEmp.Name = "lblCriterioEmp";
            this.lblCriterioEmp.Size = new System.Drawing.Size(53, 15);
            this.lblCriterioEmp.TabIndex = 14;
            this.lblCriterioEmp.Text = "Criterio:";
            // 
            // cboCampCarg
            // 
            this.cboCampCarg.FormattingEnabled = true;
            this.cboCampCarg.Location = new System.Drawing.Point(81, 25);
            this.cboCampCarg.Name = "cboCampCarg";
            this.cboCampCarg.Size = new System.Drawing.Size(121, 21);
            this.cboCampCarg.TabIndex = 13;
            this.cboCampCarg.SelectedIndexChanged += new System.EventHandler(this.cboCampCarg_SelectedIndexChanged);
            // 
            // lblCampoCargo
            // 
            this.lblCampoCargo.AutoSize = true;
            this.lblCampoCargo.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoCargo.Location = new System.Drawing.Point(24, 27);
            this.lblCampoCargo.Name = "lblCampoCargo";
            this.lblCampoCargo.Size = new System.Drawing.Size(51, 15);
            this.lblCampoCargo.TabIndex = 12;
            this.lblCampoCargo.Text = "Campo:";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(127, 84);
            this.dataGrid.MaximumSize = new System.Drawing.Size(475, 191);
            this.dataGrid.MinimumSize = new System.Drawing.Size(475, 191);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(475, 191);
            this.dataGrid.TabIndex = 1;
            // 
            // FormPrincCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 445);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(750, 484);
            this.MinimumSize = new System.Drawing.Size(750, 484);
            this.Name = "FormPrincCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD CARGO";
            this.Load += new System.EventHandler(this.FormPrincCargo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchCarg;
        private System.Windows.Forms.Label lblSearchCarg;
        private System.Windows.Forms.ComboBox cboCritCarg;
        private System.Windows.Forms.Label lblCriterioEmp;
        private System.Windows.Forms.ComboBox cboCampCarg;
        private System.Windows.Forms.Label lblCampoCargo;
        private System.Windows.Forms.Button btnSearchCargo;
    }
}