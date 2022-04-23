namespace El_Proyecto
{
    partial class FmSplash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmSplash));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PNFondo = new Telerik.WinControls.UI.RadPanel();
            this.PNFondoBarra = new Telerik.WinControls.UI.RadPanel();
            this.PNProgresoBarra = new Telerik.WinControls.UI.RadPanel();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.LBTitulo = new System.Windows.Forms.Label();
            this.PBLogoSlash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PNFondo)).BeginInit();
            this.PNFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PNFondoBarra)).BeginInit();
            this.PNFondoBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PNProgresoBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogoSlash)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 15;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PNFondo
            // 
            this.PNFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PNFondo.Controls.Add(this.PNFondoBarra);
            this.PNFondo.Controls.Add(this.LBTitulo);
            this.PNFondo.Controls.Add(this.PBLogoSlash);
            this.PNFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNFondo.Location = new System.Drawing.Point(0, 0);
            this.PNFondo.Name = "PNFondo";
            this.PNFondo.Size = new System.Drawing.Size(800, 450);
            this.PNFondo.TabIndex = 0;
            ((Telerik.WinControls.UI.RadPanelElement)(this.PNFondo.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadPanelElement)(this.PNFondo.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).GradientStyle = Telerik.WinControls.GradientStyles.Linear;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // PNFondoBarra
            // 
            this.PNFondoBarra.BackColor = System.Drawing.Color.Transparent;
            this.PNFondoBarra.Controls.Add(this.PNProgresoBarra);
            this.PNFondoBarra.Location = new System.Drawing.Point(186, 306);
            this.PNFondoBarra.Name = "PNFondoBarra";
            this.PNFondoBarra.Size = new System.Drawing.Size(469, 30);
            this.PNFondoBarra.TabIndex = 1;
            this.PNFondoBarra.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadPanelElement)(this.PNFondoBarra.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadPanelElement)(this.PNFondoBarra.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondoBarra.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondoBarra.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondoBarra.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondoBarra.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.White;
            // 
            // PNProgresoBarra
            // 
            this.PNProgresoBarra.BackColor = System.Drawing.Color.Transparent;
            this.PNProgresoBarra.Location = new System.Drawing.Point(3, 3);
            this.PNProgresoBarra.Name = "PNProgresoBarra";
            // 
            // 
            // 
            this.PNProgresoBarra.RootElement.Shape = null;
            this.PNProgresoBarra.Size = new System.Drawing.Size(62, 24);
            this.PNProgresoBarra.TabIndex = 1;
            this.PNProgresoBarra.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadPanelElement)(this.PNProgresoBarra.GetChildAt(0))).Shape = this.roundRectShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNProgresoBarra.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNProgresoBarra.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNProgresoBarra.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNProgresoBarra.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // LBTitulo
            // 
            this.LBTitulo.AutoSize = true;
            this.LBTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LBTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.ForeColor = System.Drawing.Color.White;
            this.LBTitulo.Location = new System.Drawing.Point(296, 229);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.Size = new System.Drawing.Size(183, 29);
            this.LBTitulo.TabIndex = 5;
            this.LBTitulo.Text = "Purple Contacts";
            // 
            // PBLogoSlash
            // 
            this.PBLogoSlash.BackColor = System.Drawing.Color.Transparent;
            this.PBLogoSlash.Image = global::El_Proyecto.Properties.Resources.Logo_de_la_aplicacion;
            this.PBLogoSlash.Location = new System.Drawing.Point(342, 109);
            this.PBLogoSlash.Name = "PBLogoSlash";
            this.PBLogoSlash.Size = new System.Drawing.Size(100, 100);
            this.PBLogoSlash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogoSlash.TabIndex = 4;
            this.PBLogoSlash.TabStop = false;
            // 
            // FmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PNFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PNFondo)).EndInit();
            this.PNFondo.ResumeLayout(false);
            this.PNFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PNFondoBarra)).EndInit();
            this.PNFondoBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PNProgresoBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogoSlash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private Telerik.WinControls.UI.RadPanel PNFondo;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.PictureBox PBLogoSlash;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.UI.RadPanel PNFondoBarra;
        private Telerik.WinControls.UI.RadPanel PNProgresoBarra;
    }
}

