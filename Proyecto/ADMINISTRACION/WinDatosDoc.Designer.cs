namespace ADMINISTRACION
{
    partial class WinDatosDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinDatosDoc));
            this.DatoDocentes = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatoDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // DatoDocentes
            // 
            this.DatoDocentes.AllowUserToDeleteRows = false;
            this.DatoDocentes.BackgroundColor = System.Drawing.Color.White;
            this.DatoDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatoDocentes.Location = new System.Drawing.Point(28, 70);
            this.DatoDocentes.Name = "DatoDocentes";
            this.DatoDocentes.ReadOnly = true;
            this.DatoDocentes.Size = new System.Drawing.Size(744, 359);
            this.DatoDocentes.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(283, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(250, 27);
            this.label16.TabIndex = 54;
            this.label16.Text = "DATOS DE  DOCENTE";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(552, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 39);
            this.button2.TabIndex = 56;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WinDatosDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DatoDocentes);
            this.Controls.Add(this.label16);
            this.Name = "WinDatosDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinDatosDoc";
            this.Load += new System.EventHandler(this.WinDatosDoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatoDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DatoDocentes;
        private System.Windows.Forms.Label label16;
    }
}