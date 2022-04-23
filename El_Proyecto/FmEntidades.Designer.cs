namespace El_Proyecto
{
    partial class FmEntidades
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
            this.PNFondo = new Telerik.WinControls.UI.RadPanel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.BTEliminar = new System.Windows.Forms.Button();
            this.BTCrear = new System.Windows.Forms.Button();
            this.BTModificar = new System.Windows.Forms.Button();
            this.BTLeer = new System.Windows.Forms.Button();
            this.PNContenidoEliminar = new Telerik.WinControls.UI.RadPanel();
            this.PNContenidoModificar = new Telerik.WinControls.UI.RadPanel();
            this.PNContenidoLeer = new Telerik.WinControls.UI.RadPanel();
            this.PNContenidoCrear = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PNFondo)).BeginInit();
            this.PNFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PNContenidoEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNContenidoModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNContenidoLeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNContenidoCrear)).BeginInit();
            this.SuspendLayout();
            // 
            // PNFondo
            // 
            this.PNFondo.AutoSize = true;
            this.PNFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PNFondo.Controls.Add(this.splitContainer);
            this.PNFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNFondo.Location = new System.Drawing.Point(0, 0);
            this.PNFondo.Name = "PNFondo";
            this.PNFondo.Size = new System.Drawing.Size(1030, 490);
            this.PNFondo.TabIndex = 6;
            this.PNFondo.Tag = "Usuario:";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNFondo.GetChildAt(0).GetChildAt(0))).Shape = null;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.radPanel1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.PNContenidoEliminar);
            this.splitContainer.Panel2.Controls.Add(this.PNContenidoModificar);
            this.splitContainer.Panel2.Controls.Add(this.PNContenidoLeer);
            this.splitContainer.Panel2.Controls.Add(this.PNContenidoCrear);
            this.splitContainer.Size = new System.Drawing.Size(1030, 490);
            this.splitContainer.SplitterDistance = 156;
            this.splitContainer.TabIndex = 0;
            // 
            // radPanel1
            // 
            this.radPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.radPanel1.Controls.Add(this.BTEliminar);
            this.radPanel1.Controls.Add(this.BTCrear);
            this.radPanel1.Controls.Add(this.BTModificar);
            this.radPanel1.Controls.Add(this.BTLeer);
            this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanel1.Location = new System.Drawing.Point(0, 0);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(156, 490);
            this.radPanel1.TabIndex = 0;
            // 
            // BTEliminar
            // 
            this.BTEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BTEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEliminar.ForeColor = System.Drawing.Color.White;
            this.BTEliminar.Image = global::El_Proyecto.Properties.Resources.Icono_de_eliminar_4;
            this.BTEliminar.Location = new System.Drawing.Point(0, 365);
            this.BTEliminar.Name = "BTEliminar";
            this.BTEliminar.Size = new System.Drawing.Size(209, 122);
            this.BTEliminar.TabIndex = 2;
            this.BTEliminar.Text = "Eliminar";
            this.BTEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTEliminar.UseVisualStyleBackColor = false;
            this.BTEliminar.Click += new System.EventHandler(this.BTEliminar_Click);
            // 
            // BTCrear
            // 
            this.BTCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BTCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCrear.ForeColor = System.Drawing.Color.White;
            this.BTCrear.Image = global::El_Proyecto.Properties.Resources.Icono_de_crear_3;
            this.BTCrear.Location = new System.Drawing.Point(0, 0);
            this.BTCrear.Name = "BTCrear";
            this.BTCrear.Size = new System.Drawing.Size(209, 125);
            this.BTCrear.TabIndex = 0;
            this.BTCrear.Text = "Crear";
            this.BTCrear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTCrear.UseVisualStyleBackColor = false;
            this.BTCrear.Click += new System.EventHandler(this.BTCrear_Click);
            // 
            // BTModificar
            // 
            this.BTModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BTModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModificar.ForeColor = System.Drawing.Color.White;
            this.BTModificar.Image = global::El_Proyecto.Properties.Resources.Icono_de_modificar_2;
            this.BTModificar.Location = new System.Drawing.Point(0, 245);
            this.BTModificar.Name = "BTModificar";
            this.BTModificar.Size = new System.Drawing.Size(209, 122);
            this.BTModificar.TabIndex = 2;
            this.BTModificar.Text = "Modificar";
            this.BTModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTModificar.UseVisualStyleBackColor = false;
            this.BTModificar.Click += new System.EventHandler(this.BTModificar_Click);
            // 
            // BTLeer
            // 
            this.BTLeer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BTLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTLeer.ForeColor = System.Drawing.Color.White;
            this.BTLeer.Image = global::El_Proyecto.Properties.Resources.Icono_de_buscar_3;
            this.BTLeer.Location = new System.Drawing.Point(0, 125);
            this.BTLeer.Name = "BTLeer";
            this.BTLeer.Size = new System.Drawing.Size(209, 122);
            this.BTLeer.TabIndex = 1;
            this.BTLeer.Text = "Leer";
            this.BTLeer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTLeer.UseVisualStyleBackColor = false;
            this.BTLeer.Click += new System.EventHandler(this.BTLeer_Click);
            // 
            // PNContenidoEliminar
            // 
            this.PNContenidoEliminar.Location = new System.Drawing.Point(457, 245);
            this.PNContenidoEliminar.Name = "PNContenidoEliminar";
            this.PNContenidoEliminar.Size = new System.Drawing.Size(250, 125);
            this.PNContenidoEliminar.TabIndex = 2;
            this.PNContenidoEliminar.ThemeName = "ControlDefault";
            this.PNContenidoEliminar.Visible = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoEliminar.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoEliminar.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoEliminar.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoEliminar.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // PNContenidoModificar
            // 
            this.PNContenidoModificar.Location = new System.Drawing.Point(128, 245);
            this.PNContenidoModificar.Name = "PNContenidoModificar";
            this.PNContenidoModificar.Size = new System.Drawing.Size(250, 125);
            this.PNContenidoModificar.TabIndex = 1;
            this.PNContenidoModificar.ThemeName = "ControlDefault";
            this.PNContenidoModificar.Visible = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoModificar.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoModificar.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoModificar.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoModificar.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // PNContenidoLeer
            // 
            this.PNContenidoLeer.Location = new System.Drawing.Point(457, 64);
            this.PNContenidoLeer.Name = "PNContenidoLeer";
            this.PNContenidoLeer.Size = new System.Drawing.Size(250, 125);
            this.PNContenidoLeer.TabIndex = 1;
            this.PNContenidoLeer.ThemeName = "ControlDefault";
            this.PNContenidoLeer.Visible = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoLeer.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoLeer.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoLeer.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoLeer.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // PNContenidoCrear
            // 
            this.PNContenidoCrear.Location = new System.Drawing.Point(128, 64);
            this.PNContenidoCrear.Name = "PNContenidoCrear";
            this.PNContenidoCrear.Size = new System.Drawing.Size(250, 125);
            this.PNContenidoCrear.TabIndex = 0;
            this.PNContenidoCrear.ThemeName = "ControlDefault";
            this.PNContenidoCrear.Visible = false;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoCrear.GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoCrear.GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(0)))), ((int)(((byte)(85)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoCrear.GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(2)))), ((int)(((byte)(89)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.PNContenidoCrear.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // FmEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 490);
            this.Controls.Add(this.PNFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmEntidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmEntidades";
            ((System.ComponentModel.ISupportInitialize)(this.PNFondo)).EndInit();
            this.PNFondo.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PNContenidoEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNContenidoModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNContenidoLeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PNContenidoCrear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel PNFondo;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.Button BTEliminar;
        private System.Windows.Forms.Button BTCrear;
        private System.Windows.Forms.Button BTModificar;
        private System.Windows.Forms.Button BTLeer;
        private Telerik.WinControls.UI.RadPanel PNContenidoEliminar;
        private Telerik.WinControls.UI.RadPanel PNContenidoModificar;
        private Telerik.WinControls.UI.RadPanel PNContenidoLeer;
        private Telerik.WinControls.UI.RadPanel PNContenidoCrear;
    }
}