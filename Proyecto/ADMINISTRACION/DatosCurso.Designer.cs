namespace ADMINISTRACION
{
    partial class DatosCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosCurso));
            this.DatoDocentes = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatoDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // DatoDocentes
            // 
            this.DatoDocentes.AllowUserToDeleteRows = false;
            this.DatoDocentes.BackgroundColor = System.Drawing.Color.White;
            this.DatoDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatoDocentes.Location = new System.Drawing.Point(43, 60);
            this.DatoDocentes.Name = "DatoDocentes";
            this.DatoDocentes.ReadOnly = true;
            this.DatoDocentes.Size = new System.Drawing.Size(513, 262);
            this.DatoDocentes.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(181, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(227, 27);
            this.label16.TabIndex = 61;
            this.label16.Text = "DATOS DE CURSOS";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(461, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 39);
            this.button1.TabIndex = 63;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatosCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DatoDocentes);
            this.Controls.Add(this.label16);
            this.Name = "DatosCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Estudiantil de Notas \"SEN\"";
            this.Load += new System.EventHandler(this.DatosCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatoDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DatoDocentes;
        private System.Windows.Forms.Label label16;
    }
}