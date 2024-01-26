namespace crud_entity
{
    partial class FormPrincEmpresa
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteLog = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSearchEmpresa = new System.Windows.Forms.Button();
            this.txtSearchEmpresa = new System.Windows.Forms.TextBox();
            this.lblBusEmpresa = new System.Windows.Forms.Label();
            this.cboCritEmpresa = new System.Windows.Forms.ComboBox();
            this.lblCritEmpresa = new System.Windows.Forms.Label();
            this.cboCampoEmpr = new System.Windows.Forms.ComboBox();
            this.lblCampoEmpr = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
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
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteLog);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.btnSearchEmpresa);
            this.splitContainer1.Panel2.Controls.Add(this.txtSearchEmpresa);
            this.splitContainer1.Panel2.Controls.Add(this.lblBusEmpresa);
            this.splitContainer1.Panel2.Controls.Add(this.cboCritEmpresa);
            this.splitContainer1.Panel2.Controls.Add(this.lblCritEmpresa);
            this.splitContainer1.Panel2.Controls.Add(this.cboCampoEmpr);
            this.splitContainer1.Panel2.Controls.Add(this.lblCampoEmpr);
            this.splitContainer1.Panel2.Controls.Add(this.lblCampo);
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
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADMIN EMPRESA";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(556, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteLog
            // 
            this.btnDeleteLog.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLog.Location = new System.Drawing.Point(397, 54);
            this.btnDeleteLog.Name = "btnDeleteLog";
            this.btnDeleteLog.Size = new System.Drawing.Size(92, 38);
            this.btnDeleteLog.TabIndex = 2;
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
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(91, 54);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSearchEmpresa
            // 
            this.btnSearchEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.btnSearchEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmpresa.Location = new System.Drawing.Point(647, 13);
            this.btnSearchEmpresa.Name = "btnSearchEmpresa";
            this.btnSearchEmpresa.Size = new System.Drawing.Size(75, 37);
            this.btnSearchEmpresa.TabIndex = 17;
            this.btnSearchEmpresa.Text = "Search";
            this.btnSearchEmpresa.UseVisualStyleBackColor = true;
            this.btnSearchEmpresa.Click += new System.EventHandler(this.btnSearchEmpre_Click);
            // 
            // txtSearchEmpresa
            // 
            this.txtSearchEmpresa.Location = new System.Drawing.Point(509, 22);
            this.txtSearchEmpresa.Name = "txtSearchEmpresa";
            this.txtSearchEmpresa.Size = new System.Drawing.Size(123, 20);
            this.txtSearchEmpresa.TabIndex = 16;
            // 
            // lblBusEmpresa
            // 
            this.lblBusEmpresa.AutoSize = true;
            this.lblBusEmpresa.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusEmpresa.Location = new System.Drawing.Point(435, 23);
            this.lblBusEmpresa.Name = "lblBusEmpresa";
            this.lblBusEmpresa.Size = new System.Drawing.Size(68, 15);
            this.lblBusEmpresa.TabIndex = 15;
            this.lblBusEmpresa.Text = "Busqueda:";
            // 
            // cboCritEmpresa
            // 
            this.cboCritEmpresa.FormattingEnabled = true;
            this.cboCritEmpresa.Location = new System.Drawing.Point(294, 21);
            this.cboCritEmpresa.Name = "cboCritEmpresa";
            this.cboCritEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cboCritEmpresa.TabIndex = 14;
            // 
            // lblCritEmpresa
            // 
            this.lblCritEmpresa.AutoSize = true;
            this.lblCritEmpresa.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCritEmpresa.Location = new System.Drawing.Point(230, 23);
            this.lblCritEmpresa.Name = "lblCritEmpresa";
            this.lblCritEmpresa.Size = new System.Drawing.Size(53, 15);
            this.lblCritEmpresa.TabIndex = 13;
            this.lblCritEmpresa.Text = "Criterio:";
            // 
            // cboCampoEmpr
            // 
            this.cboCampoEmpr.FormattingEnabled = true;
            this.cboCampoEmpr.Location = new System.Drawing.Point(91, 21);
            this.cboCampoEmpr.Name = "cboCampoEmpr";
            this.cboCampoEmpr.Size = new System.Drawing.Size(121, 21);
            this.cboCampoEmpr.TabIndex = 12;
            this.cboCampoEmpr.SelectedIndexChanged += new System.EventHandler(this.cboCampoEmpr_SelectedIndexChanged);
            // 
            // lblCampoEmpr
            // 
            this.lblCampoEmpr.AutoSize = true;
            this.lblCampoEmpr.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoEmpr.Location = new System.Drawing.Point(29, 22);
            this.lblCampoEmpr.Name = "lblCampoEmpr";
            this.lblCampoEmpr.Size = new System.Drawing.Size(51, 15);
            this.lblCampoEmpr.TabIndex = 11;
            this.lblCampoEmpr.Text = "Campo:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.Color.Black;
            this.lblCampo.Location = new System.Drawing.Point(-80, 150);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 15);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo:";
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(124, 82);
            this.dataGrid.MaximumSize = new System.Drawing.Size(475, 191);
            this.dataGrid.MinimumSize = new System.Drawing.Size(475, 191);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(475, 191);
            this.dataGrid.TabIndex = 0;
            // 
            // FormPrincEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 445);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(750, 484);
            this.MinimumSize = new System.Drawing.Size(750, 484);
            this.Name = "FormPrincEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD EMPRESA";
            this.Load += new System.EventHandler(this.FormPrincEmpresa_Load);
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
        private System.Windows.Forms.Button btnDeleteLog;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCritEmpresa;
        private System.Windows.Forms.ComboBox cboCampoEmpr;
        private System.Windows.Forms.Label lblCampoEmpr;
        private System.Windows.Forms.Label lblBusEmpresa;
        private System.Windows.Forms.ComboBox cboCritEmpresa;
        private System.Windows.Forms.TextBox txtSearchEmpresa;
        private System.Windows.Forms.Button btnSearchEmpresa;
        private System.Windows.Forms.Label label1;
    }
}