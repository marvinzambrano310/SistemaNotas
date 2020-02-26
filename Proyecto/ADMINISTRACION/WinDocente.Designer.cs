namespace ADMINISTRACION
{
    partial class WinDocente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinDocente));
            this.label16 = new System.Windows.Forms.Label();
            this.DatoDocentes = new System.Windows.Forms.DataGridView();
            this.iDDOCENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDASIGNATURADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRE1DOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRE2DOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELPDOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELMDOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRDOCENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cELULARDOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHNACDOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLAVEDOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaNotasDataSet = new ADMINISTRACION.SistemaNotasDataSet();
            this.dOCENTETableAdapter = new ADMINISTRACION.SistemaNotasDataSetTableAdapters.DOCENTETableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatoDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaNotasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(284, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(250, 27);
            this.label16.TabIndex = 51;
            this.label16.Text = "DATOS DE  DOCENTE";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // DatoDocentes
            // 
            this.DatoDocentes.AllowUserToDeleteRows = false;
            this.DatoDocentes.AutoGenerateColumns = false;
            this.DatoDocentes.BackgroundColor = System.Drawing.Color.White;
            this.DatoDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatoDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDOCENTEDataGridViewTextBoxColumn,
            this.iDASIGNATURADataGridViewTextBoxColumn,
            this.nOMBRE1DOCDataGridViewTextBoxColumn,
            this.nOMBRE2DOCDataGridViewTextBoxColumn,
            this.aPELPDOCDataGridViewTextBoxColumn,
            this.aPELMDOCDataGridViewTextBoxColumn,
            this.dIRDOCENTEDataGridViewTextBoxColumn,
            this.cELULARDOCDataGridViewTextBoxColumn,
            this.tELEFONODOCDataGridViewTextBoxColumn,
            this.eMAILDOCDataGridViewTextBoxColumn,
            this.fECHNACDOCDataGridViewTextBoxColumn,
            this.cLAVEDOCDataGridViewTextBoxColumn});
            this.DatoDocentes.DataSource = this.dOCENTEBindingSource;
            this.DatoDocentes.Location = new System.Drawing.Point(29, 61);
            this.DatoDocentes.Name = "DatoDocentes";
            this.DatoDocentes.ReadOnly = true;
            this.DatoDocentes.Size = new System.Drawing.Size(744, 359);
            this.DatoDocentes.TabIndex = 52;
            // 
            // iDDOCENTEDataGridViewTextBoxColumn
            // 
            this.iDDOCENTEDataGridViewTextBoxColumn.DataPropertyName = "IDDOCENTE";
            this.iDDOCENTEDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.iDDOCENTEDataGridViewTextBoxColumn.Name = "iDDOCENTEDataGridViewTextBoxColumn";
            this.iDDOCENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDASIGNATURADataGridViewTextBoxColumn
            // 
            this.iDASIGNATURADataGridViewTextBoxColumn.DataPropertyName = "IDASIGNATURA";
            this.iDASIGNATURADataGridViewTextBoxColumn.HeaderText = "Asignatura";
            this.iDASIGNATURADataGridViewTextBoxColumn.Name = "iDASIGNATURADataGridViewTextBoxColumn";
            this.iDASIGNATURADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRE1DOCDataGridViewTextBoxColumn
            // 
            this.nOMBRE1DOCDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE1DOC";
            this.nOMBRE1DOCDataGridViewTextBoxColumn.HeaderText = "Nombre Inicial";
            this.nOMBRE1DOCDataGridViewTextBoxColumn.Name = "nOMBRE1DOCDataGridViewTextBoxColumn";
            this.nOMBRE1DOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRE2DOCDataGridViewTextBoxColumn
            // 
            this.nOMBRE2DOCDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE2DOC";
            this.nOMBRE2DOCDataGridViewTextBoxColumn.HeaderText = "Nombre Secundario";
            this.nOMBRE2DOCDataGridViewTextBoxColumn.Name = "nOMBRE2DOCDataGridViewTextBoxColumn";
            this.nOMBRE2DOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPELPDOCDataGridViewTextBoxColumn
            // 
            this.aPELPDOCDataGridViewTextBoxColumn.DataPropertyName = "APELPDOC";
            this.aPELPDOCDataGridViewTextBoxColumn.HeaderText = "Apellido Paterno";
            this.aPELPDOCDataGridViewTextBoxColumn.Name = "aPELPDOCDataGridViewTextBoxColumn";
            this.aPELPDOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPELMDOCDataGridViewTextBoxColumn
            // 
            this.aPELMDOCDataGridViewTextBoxColumn.DataPropertyName = "APELMDOC";
            this.aPELMDOCDataGridViewTextBoxColumn.HeaderText = "Apellido Materno";
            this.aPELMDOCDataGridViewTextBoxColumn.Name = "aPELMDOCDataGridViewTextBoxColumn";
            this.aPELMDOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIRDOCENTEDataGridViewTextBoxColumn
            // 
            this.dIRDOCENTEDataGridViewTextBoxColumn.DataPropertyName = "DIRDOCENTE";
            this.dIRDOCENTEDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.dIRDOCENTEDataGridViewTextBoxColumn.Name = "dIRDOCENTEDataGridViewTextBoxColumn";
            this.dIRDOCENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cELULARDOCDataGridViewTextBoxColumn
            // 
            this.cELULARDOCDataGridViewTextBoxColumn.DataPropertyName = "CELULARDOC";
            this.cELULARDOCDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.cELULARDOCDataGridViewTextBoxColumn.Name = "cELULARDOCDataGridViewTextBoxColumn";
            this.cELULARDOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONODOCDataGridViewTextBoxColumn
            // 
            this.tELEFONODOCDataGridViewTextBoxColumn.DataPropertyName = "TELEFONODOC";
            this.tELEFONODOCDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.tELEFONODOCDataGridViewTextBoxColumn.Name = "tELEFONODOCDataGridViewTextBoxColumn";
            this.tELEFONODOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDOCDataGridViewTextBoxColumn
            // 
            this.eMAILDOCDataGridViewTextBoxColumn.DataPropertyName = "EMAILDOC";
            this.eMAILDOCDataGridViewTextBoxColumn.HeaderText = "Email";
            this.eMAILDOCDataGridViewTextBoxColumn.Name = "eMAILDOCDataGridViewTextBoxColumn";
            this.eMAILDOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fECHNACDOCDataGridViewTextBoxColumn
            // 
            this.fECHNACDOCDataGridViewTextBoxColumn.DataPropertyName = "FECHNACDOC";
            this.fECHNACDOCDataGridViewTextBoxColumn.HeaderText = "Fech. Nacimiento";
            this.fECHNACDOCDataGridViewTextBoxColumn.Name = "fECHNACDOCDataGridViewTextBoxColumn";
            this.fECHNACDOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLAVEDOCDataGridViewTextBoxColumn
            // 
            this.cLAVEDOCDataGridViewTextBoxColumn.DataPropertyName = "CLAVEDOC";
            this.cLAVEDOCDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.cLAVEDOCDataGridViewTextBoxColumn.Name = "cLAVEDOCDataGridViewTextBoxColumn";
            this.cLAVEDOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCENTEBindingSource
            // 
            this.dOCENTEBindingSource.DataMember = "DOCENTE";
            this.dOCENTEBindingSource.DataSource = this.sistemaNotasDataSet;
            // 
            // sistemaNotasDataSet
            // 
            this.sistemaNotasDataSet.DataSetName = "SistemaNotasDataSet";
            this.sistemaNotasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOCENTETableAdapter
            // 
            this.dOCENTETableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(553, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 39);
            this.button2.TabIndex = 53;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WinDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DatoDocentes);
            this.Controls.Add(this.label16);
            this.Name = "WinDocente";
            this.Text = "WinDocente";
            this.Load += new System.EventHandler(this.WinDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatoDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaNotasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView DatoDocentes;
        private SistemaNotasDataSet sistemaNotasDataSet;
        private System.Windows.Forms.BindingSource dOCENTEBindingSource;
        private SistemaNotasDataSetTableAdapters.DOCENTETableAdapter dOCENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDOCENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDASIGNATURADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRE1DOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRE2DOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELPDOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELMDOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRDOCENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELULARDOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHNACDOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLAVEDOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}