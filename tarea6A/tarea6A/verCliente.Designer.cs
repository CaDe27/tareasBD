namespace tarea6A
{
  partial class verCliente
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
      this.dtgGen = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dtgGen)).BeginInit();
      this.SuspendLayout();
      // 
      // dtgGen
      // 
      this.dtgGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgGen.Location = new System.Drawing.Point(61, 71);
      this.dtgGen.Name = "dtgGen";
      this.dtgGen.RowHeadersWidth = 51;
      this.dtgGen.RowTemplate.Height = 24;
      this.dtgGen.Size = new System.Drawing.Size(697, 264);
      this.dtgGen.TabIndex = 0;
      // 
      // verCliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.dtgGen);
      this.Name = "verCliente";
      this.Text = "Datos de sus préstamos";
      this.Load += new System.EventHandler(this.verCliente_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgGen)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.DataGridView dtgGen;
    }
}