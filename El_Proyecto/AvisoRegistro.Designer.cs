namespace El_Proyecto
{
    partial class AvisoRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvisoRegistro));
            this.PNFondo = new Telerik.WinControls.UI.RadPanel();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.PBImagenAyuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PNFondo)).BeginInit();
            this.PNFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // PNFondo
            // 
            this.PNFondo.AutoSize = true;
            this.PNFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PNFondo.Controls.Add(this.LBTitulo);
            this.PNFondo.Controls.Add(this.PBImagenAyuda);
            this.PNFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNFondo.Location = new System.Drawing.Point(0, 0);
            this.PNFondo.Name = "PNFondo";
            this.PNFondo.Size = new System.Drawing.Size(356, 141);
            this.PNFondo.TabIndex = 3;
            this.PNFondo.Tag = "Usuario:";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).Shape = null;
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.ForeColor = System.Drawing.Color.White;
            this.LBTitulo.Location = new System.Drawing.Point(75, 64);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(211, 29);
            this.LBTitulo.TabIndex = 18;
            this.LBTitulo.Text = "Usuario registrado";
            // 
            // PBImagenAyuda
            // 
            this.PBImagenAyuda.BackColor = System.Drawing.Color.Transparent;
            this.PBImagenAyuda.Image = global::El_Proyecto.Properties.Resources.Icono_de_X;
            this.PBImagenAyuda.Location = new System.Drawing.Point(318, 12);
            this.PBImagenAyuda.Name = "PBImagenAyuda";
            this.PBImagenAyuda.Size = new System.Drawing.Size(26, 25);
            this.PBImagenAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImagenAyuda.TabIndex = 17;
            this.PBImagenAyuda.TabStop = false;
            this.PBImagenAyuda.Click += new System.EventHandler(this.PBImagenAyuda_Click);
            // 
            // AvisoRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 141);
            this.Controls.Add(this.PNFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AvisoRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvisoRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.PNFondo)).EndInit();
            this.PNFondo.ResumeLayout(false);
            this.PNFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenAyuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel PNFondo;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.PictureBox PBImagenAyuda;
    }
}