namespace Navegador_tarea
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Atras = new System.Windows.Forms.ToolStripButton();
            this.Adelante = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.NavTxt = new System.Windows.Forms.ToolStripTextBox();
            this.BuscarBtn = new System.Windows.Forms.ToolStripButton();
            this.FavCmb = new System.Windows.Forms.ToolStripComboBox();
            this.FavBtn = new System.Windows.Forms.ToolStripButton();
            this.WebB = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Atras,
            this.Adelante,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.NavTxt,
            this.BuscarBtn,
            this.FavCmb,
            this.FavBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Atras
            // 
            this.Atras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Atras.Image = ((System.Drawing.Image)(resources.GetObject("Atras.Image")));
            this.Atras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(23, 22);
            this.Atras.Text = "Atras";
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Adelante
            // 
            this.Adelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Adelante.Image = ((System.Drawing.Image)(resources.GetObject("Adelante.Image")));
            this.Adelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Adelante.Name = "Adelante";
            this.Adelante.Size = new System.Drawing.Size(23, 22);
            this.Adelante.Text = "Adelante";
            this.Adelante.Click += new System.EventHandler(this.Adelante_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Actualizar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Stop";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Home";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // NavTxt
            // 
            this.NavTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NavTxt.Name = "NavTxt";
            this.NavTxt.Size = new System.Drawing.Size(800, 25);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BuscarBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarBtn.Image")));
            this.BuscarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(23, 22);
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // FavCmb
            // 
            this.FavCmb.Name = "FavCmb";
            this.FavCmb.Size = new System.Drawing.Size(121, 25);
            this.FavCmb.SelectedIndexChanged += new System.EventHandler(this.FavCmb_SelectedIndexChanged);
            this.FavCmb.Click += new System.EventHandler(this.FavCmb_Click);
            // 
            // FavBtn
            // 
            this.FavBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FavBtn.Image = ((System.Drawing.Image)(resources.GetObject("FavBtn.Image")));
            this.FavBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FavBtn.Name = "FavBtn";
            this.FavBtn.Size = new System.Drawing.Size(23, 22);
            this.FavBtn.Text = "Fav";
            this.FavBtn.Click += new System.EventHandler(this.FavBtn_Click);
            // 
            // WebB
            // 
            this.WebB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebB.Location = new System.Drawing.Point(0, 25);
            this.WebB.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebB.Name = "WebB";
            this.WebB.Size = new System.Drawing.Size(1184, 586);
            this.WebB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.WebB);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yahweh browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Atras;
        private System.Windows.Forms.ToolStripButton Adelante;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox NavTxt;
        private System.Windows.Forms.ToolStripButton BuscarBtn;
        private System.Windows.Forms.WebBrowser WebB;
        private System.Windows.Forms.ToolStripComboBox FavCmb;
        private System.Windows.Forms.ToolStripButton FavBtn;
    }
}

