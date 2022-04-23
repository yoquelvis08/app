namespace El_Proyecto
{
    partial class FmGEPNCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmGEPNCrear));
            this.radScrollablePanel2 = new Telerik.WinControls.UI.RadScrollablePanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PBImagenUsuario = new System.Windows.Forms.PictureBox();
            this.LBEditable = new System.Windows.Forms.ListBox();
            this.LBStatus = new System.Windows.Forms.ListBox();
            this.BTCrear = new Telerik.WinControls.UI.RadButton();
            this.TBDescripcion = new System.Windows.Forms.RichTextBox();
            this.TBComentario = new Telerik.WinControls.UI.RadTextBox();
            this.SPCrear = new Telerik.WinControls.UI.RadScrollablePanel();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.PNFondo = new Telerik.WinControls.UI.RadPanel();
            this.PanelContainer = new Telerik.WinControls.UI.RadScrollablePanelContainer();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel2)).BeginInit();
            this.radScrollablePanel2.PanelContainer.SuspendLayout();
            this.radScrollablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCrear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBComentario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPCrear)).BeginInit();
            this.SPCrear.PanelContainer.SuspendLayout();
            this.SPCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PNFondo)).BeginInit();
            this.PNFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // radScrollablePanel2
            // 
            this.radScrollablePanel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.radScrollablePanel2, "radScrollablePanel2");
            this.radScrollablePanel2.Name = "radScrollablePanel2";
            // 
            // radScrollablePanel2.PanelContainer
            // 
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.pictureBox2);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.pictureBox1);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.PBImagenUsuario);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.LBEditable);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.LBStatus);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.BTCrear);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.TBDescripcion);
            this.radScrollablePanel2.PanelContainer.Controls.Add(this.TBComentario);
            resources.ApplyResources(this.radScrollablePanel2.PanelContainer, "radScrollablePanel2.PanelContainer");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::El_Proyecto.Properties.Resources.Icono_de_status;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::El_Proyecto.Properties.Resources.Icono_de_descripcion;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // PBImagenUsuario
            // 
            this.PBImagenUsuario.BackColor = System.Drawing.Color.Transparent;
            this.PBImagenUsuario.Image = global::El_Proyecto.Properties.Resources.Icono_de_comentario;
            resources.ApplyResources(this.PBImagenUsuario, "PBImagenUsuario");
            this.PBImagenUsuario.Name = "PBImagenUsuario";
            this.PBImagenUsuario.TabStop = false;
            // 
            // LBEditable
            // 
            resources.ApplyResources(this.LBEditable, "LBEditable");
            this.LBEditable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LBEditable.FormattingEnabled = true;
            this.LBEditable.Items.AddRange(new object[] {
            resources.GetString("LBEditable.Items"),
            resources.GetString("LBEditable.Items1")});
            this.LBEditable.Name = "LBEditable";
            // 
            // LBStatus
            // 
            resources.ApplyResources(this.LBStatus, "LBStatus");
            this.LBStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LBStatus.FormattingEnabled = true;
            this.LBStatus.Items.AddRange(new object[] {
            resources.GetString("LBStatus.Items"),
            resources.GetString("LBStatus.Items1")});
            this.LBStatus.Name = "LBStatus";
            // 
            // BTCrear
            // 
            this.BTCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.BTCrear, "BTCrear");
            this.BTCrear.ForeColor = System.Drawing.Color.Purple;
            this.BTCrear.Name = "BTCrear";
            this.BTCrear.ThemeName = "ControlDefault";
            this.BTCrear.Click += new System.EventHandler(this.BTCrear_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BTCrear.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.BTCrear.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.BTCrear.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.BTCrear.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.BTCrear.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.White;
            // 
            // TBDescripcion
            // 
            resources.ApplyResources(this.TBDescripcion, "TBDescripcion");
            this.TBDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TBDescripcion.Name = "TBDescripcion";
            // 
            // TBComentario
            // 
            this.TBComentario.BackColor = System.Drawing.Color.White;
            this.TBComentario.EmbeddedLabelText = "Comentario:";
            resources.ApplyResources(this.TBComentario, "TBComentario");
            this.TBComentario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TBComentario.Name = "TBComentario";
            this.TBComentario.ShowClearButton = true;
            this.TBComentario.ShowEmbeddedLabel = true;
            this.TBComentario.Tag = "";
            this.TBComentario.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.TBComentario.GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.TBComentario.GetChildAt(0))).Shape = null;
            // 
            // SPCrear
            // 
            this.SPCrear.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SPCrear, "SPCrear");
            this.SPCrear.Name = "SPCrear";
            // 
            // SPCrear.PanelContainer
            // 
            this.SPCrear.PanelContainer.Controls.Add(this.radScrollablePanel2);
            this.SPCrear.PanelContainer.Controls.Add(this.LBTitulo);
            resources.ApplyResources(this.SPCrear.PanelContainer, "SPCrear.PanelContainer");
            ((Telerik.WinControls.UI.RadScrollablePanelElement)(this.SPCrear.GetChildAt(0))).Padding = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Padding")));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.SPCrear.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.SPCrear.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.SPCrear.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.Transparent;
            // 
            // LBTitulo
            // 
            this.LBTitulo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LBTitulo, "LBTitulo");
            this.LBTitulo.ForeColor = System.Drawing.Color.White;
            this.LBTitulo.Name = "LBTitulo";
            // 
            // PNFondo
            // 
            this.PNFondo.BackColor = System.Drawing.Color.White;
            this.PNFondo.Controls.Add(this.SPCrear);
            resources.ApplyResources(this.PNFondo, "PNFondo");
            this.PNFondo.Name = "PNFondo";
            this.PNFondo.ThemeName = "ControlDefault";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // PanelContainer
            // 
            resources.ApplyResources(this.PanelContainer, "PanelContainer");
            // 
            // FmGEPNCrear
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PNFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmGEPNCrear";
            this.radScrollablePanel2.PanelContainer.ResumeLayout(false);
            this.radScrollablePanel2.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanel2)).EndInit();
            this.radScrollablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImagenUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCrear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBComentario)).EndInit();
            this.SPCrear.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPCrear)).EndInit();
            this.SPCrear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PNFondo)).EndInit();
            this.PNFondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel PNFondo;
        private Telerik.WinControls.UI.RadScrollablePanel SPCrear;
        private Telerik.WinControls.UI.RadScrollablePanel radScrollablePanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PBImagenUsuario;
        private System.Windows.Forms.ListBox LBEditable;
        private System.Windows.Forms.ListBox LBStatus;
        private Telerik.WinControls.UI.RadButton BTCrear;
        private System.Windows.Forms.RichTextBox TBDescripcion;
        private Telerik.WinControls.UI.RadTextBox TBComentario;
        private System.Windows.Forms.Label LBTitulo;
        private Telerik.WinControls.UI.RadScrollablePanelContainer PanelContainer;
    }
}