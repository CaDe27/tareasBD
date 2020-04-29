namespace tarea6A
{
  partial class Menu
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuActTablas = new System.Windows.Forms.ToolStripMenuItem();
      this.menuActPrest = new System.Windows.Forms.ToolStripMenuItem();
      this.menuVer = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // menúToolStripMenuItem
      // 
      this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuActTablas,
            this.menuActPrest,
            this.menuVer});
      this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
      this.menúToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
      this.menúToolStripMenuItem.Text = "Menú";
      // 
      // menuActTablas
      // 
      this.menuActTablas.Enabled = false;
      this.menuActTablas.Name = "menuActTablas";
      this.menuActTablas.Size = new System.Drawing.Size(237, 26);
      this.menuActTablas.Text = "Ver y actualizar tablas";
      this.menuActTablas.Click += new System.EventHandler(this.menuActTablas_Click);
      // 
      // menuActPrest
      // 
      this.menuActPrest.Enabled = false;
      this.menuActPrest.Name = "menuActPrest";
      this.menuActPrest.Size = new System.Drawing.Size(237, 26);
      this.menuActPrest.Text = "Actualiza préstamos";
      this.menuActPrest.Click += new System.EventHandler(this.menuActPrest_Click);
      // 
      // menuVer
      // 
      this.menuVer.Enabled = false;
      this.menuVer.Name = "menuVer";
      this.menuVer.Size = new System.Drawing.Size(237, 26);
      this.menuVer.Text = "Ver tus préstamos";
      this.menuVer.Click += new System.EventHandler(this.menuVer_Click);
      // 
      // Menu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Menu";
      this.Text = "Menu";
      this.Load += new System.EventHandler(this.Menu_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuActTablas;
        private System.Windows.Forms.ToolStripMenuItem menuActPrest;
        private System.Windows.Forms.ToolStripMenuItem menuVer;
    }
}