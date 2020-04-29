namespace tarea6A
{
  partial class Form1
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txUser = new System.Windows.Forms.TextBox();
      this.txContra = new System.Windows.Forms.TextBox();
      this.btIngresa = new System.Windows.Forms.Button();
      this.lblMsg = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(160, 105);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Usuario:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(160, 169);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(85, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Contraseña:";
      // 
      // txUser
      // 
      this.txUser.Location = new System.Drawing.Point(305, 105);
      this.txUser.Name = "txUser";
      this.txUser.Size = new System.Drawing.Size(204, 22);
      this.txUser.TabIndex = 2;
      // 
      // txContra
      // 
      this.txContra.Location = new System.Drawing.Point(305, 169);
      this.txContra.Name = "txContra";
      this.txContra.PasswordChar = '*';
      this.txContra.Size = new System.Drawing.Size(204, 22);
      this.txContra.TabIndex = 3;
      // 
      // btIngresa
      // 
      this.btIngresa.Location = new System.Drawing.Point(205, 244);
      this.btIngresa.Name = "btIngresa";
      this.btIngresa.Size = new System.Drawing.Size(283, 23);
      this.btIngresa.TabIndex = 4;
      this.btIngresa.Text = "Ingresar";
      this.btIngresa.UseVisualStyleBackColor = true;
      this.btIngresa.Click += new System.EventHandler(this.btIngresa_Click);
      // 
      // lblMsg
      // 
      this.lblMsg.AutoSize = true;
      this.lblMsg.ForeColor = System.Drawing.Color.Red;
      this.lblMsg.Location = new System.Drawing.Point(237, 306);
      this.lblMsg.Name = "lblMsg";
      this.lblMsg.Size = new System.Drawing.Size(12, 17);
      this.lblMsg.TabIndex = 5;
      this.lblMsg.Text = " ";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblMsg);
      this.Controls.Add(this.btIngresa);
      this.Controls.Add(this.txContra);
      this.Controls.Add(this.txUser);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Ventana de ingreso";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txUser;
        private System.Windows.Forms.TextBox txContra;
        private System.Windows.Forms.Button btIngresa;
        private System.Windows.Forms.Label lblMsg;
    }
}

