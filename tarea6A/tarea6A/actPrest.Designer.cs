namespace tarea6A
{
  partial class actPrest
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
      this.cbCliente = new System.Windows.Forms.ComboBox();
      this.cbPrestamo = new System.Windows.Forms.ComboBox();
      this.dtgGeneral = new System.Windows.Forms.DataGridView();
      this.btActualiza = new System.Windows.Forms.Button();
      this.btQuita = new System.Windows.Forms.Button();
      this.btDarAlta = new System.Windows.Forms.Button();
      this.txMonto = new System.Windows.Forms.TextBox();
      this.lblMonto = new System.Windows.Forms.Label();
      this.btAct = new System.Windows.Forms.Button();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.dateP = new System.Windows.Forms.DateTimePicker();
      this.btAlt = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(286, 55);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(130, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nombre del cliente:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(286, 101);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(135, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "Folio del préstamos:";
      // 
      // cbCliente
      // 
      this.cbCliente.FormattingEnabled = true;
      this.cbCliente.Location = new System.Drawing.Point(532, 48);
      this.cbCliente.Name = "cbCliente";
      this.cbCliente.Size = new System.Drawing.Size(160, 24);
      this.cbCliente.TabIndex = 2;
      this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
      // 
      // cbPrestamo
      // 
      this.cbPrestamo.FormattingEnabled = true;
      this.cbPrestamo.Location = new System.Drawing.Point(532, 101);
      this.cbPrestamo.Name = "cbPrestamo";
      this.cbPrestamo.Size = new System.Drawing.Size(160, 24);
      this.cbPrestamo.TabIndex = 3;
      this.cbPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbPrestamo_SelectedIndexChanged);
      // 
      // dtgGeneral
      // 
      this.dtgGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgGeneral.Location = new System.Drawing.Point(107, 159);
      this.dtgGeneral.Name = "dtgGeneral";
      this.dtgGeneral.RowHeadersWidth = 51;
      this.dtgGeneral.RowTemplate.Height = 24;
      this.dtgGeneral.Size = new System.Drawing.Size(815, 150);
      this.dtgGeneral.TabIndex = 4;
      this.dtgGeneral.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgGeneral_CellContentClick);
      // 
      // btActualiza
      // 
      this.btActualiza.Location = new System.Drawing.Point(394, 334);
      this.btActualiza.Name = "btActualiza";
      this.btActualiza.Size = new System.Drawing.Size(240, 23);
      this.btActualiza.TabIndex = 8;
      this.btActualiza.Text = "Actualizar el pago seleccionado ";
      this.btActualiza.UseVisualStyleBackColor = true;
      this.btActualiza.Click += new System.EventHandler(this.btActualiza_Click);
      // 
      // btQuita
      // 
      this.btQuita.Location = new System.Drawing.Point(107, 334);
      this.btQuita.Name = "btQuita";
      this.btQuita.Size = new System.Drawing.Size(240, 23);
      this.btQuita.TabIndex = 9;
      this.btQuita.Text = "Quitar pago seleccionado";
      this.btQuita.UseVisualStyleBackColor = true;
      this.btQuita.Click += new System.EventHandler(this.button1_Click);
      // 
      // btDarAlta
      // 
      this.btDarAlta.Location = new System.Drawing.Point(682, 334);
      this.btDarAlta.Name = "btDarAlta";
      this.btDarAlta.Size = new System.Drawing.Size(240, 23);
      this.btDarAlta.TabIndex = 10;
      this.btDarAlta.Text = "Dar de alta un pago";
      this.btDarAlta.UseVisualStyleBackColor = true;
      this.btDarAlta.Click += new System.EventHandler(this.button2_Click);
      // 
      // txMonto
      // 
      this.txMonto.Location = new System.Drawing.Point(259, 387);
      this.txMonto.Name = "txMonto";
      this.txMonto.Size = new System.Drawing.Size(120, 22);
      this.txMonto.TabIndex = 11;
      this.txMonto.Visible = false;
      // 
      // lblMonto
      // 
      this.lblMonto.AutoSize = true;
      this.lblMonto.Location = new System.Drawing.Point(124, 390);
      this.lblMonto.Name = "lblMonto";
      this.lblMonto.Size = new System.Drawing.Size(96, 17);
      this.lblMonto.TabIndex = 12;
      this.lblMonto.Text = "Nuevo monto:";
      this.lblMonto.Visible = false;
      // 
      // btAct
      // 
      this.btAct.Enabled = false;
      this.btAct.Location = new System.Drawing.Point(127, 436);
      this.btAct.Name = "btAct";
      this.btAct.Size = new System.Drawing.Size(252, 23);
      this.btAct.TabIndex = 13;
      this.btAct.Text = "Actualizar";
      this.btAct.UseVisualStyleBackColor = true;
      this.btAct.Visible = false;
      this.btAct.Click += new System.EventHandler(this.btAct_Click);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
      this.dateTimePicker1.TabIndex = 14;
      // 
      // dateP
      // 
      this.dateP.Enabled = false;
      this.dateP.Location = new System.Drawing.Point(430, 385);
      this.dateP.Name = "dateP";
      this.dateP.Size = new System.Drawing.Size(262, 22);
      this.dateP.TabIndex = 15;
      this.dateP.Visible = false;
      this.dateP.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
      // 
      // btAlt
      // 
      this.btAlt.Enabled = false;
      this.btAlt.Location = new System.Drawing.Point(430, 436);
      this.btAlt.Name = "btAlt";
      this.btAlt.Size = new System.Drawing.Size(262, 23);
      this.btAlt.TabIndex = 16;
      this.btAlt.Text = "dar de alta";
      this.btAlt.UseVisualStyleBackColor = true;
      this.btAlt.Visible = false;
      this.btAlt.Click += new System.EventHandler(this.btAlt_Click);
      // 
      // actPrest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(979, 523);
      this.Controls.Add(this.btAlt);
      this.Controls.Add(this.dateP);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.btAct);
      this.Controls.Add(this.lblMonto);
      this.Controls.Add(this.txMonto);
      this.Controls.Add(this.btDarAlta);
      this.Controls.Add(this.btQuita);
      this.Controls.Add(this.btActualiza);
      this.Controls.Add(this.dtgGeneral);
      this.Controls.Add(this.cbPrestamo);
      this.Controls.Add(this.cbCliente);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "actPrest";
      this.Text = "actPrest";
      this.Load += new System.EventHandler(this.actPrest_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dtgGeneral)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbPrestamo;
        private System.Windows.Forms.DataGridView dtgGeneral;
        private System.Windows.Forms.Button btActualiza;
        private System.Windows.Forms.Button btQuita;
        private System.Windows.Forms.Button btDarAlta;
        private System.Windows.Forms.TextBox txMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btAct;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateP;
        private System.Windows.Forms.Button btAlt;
    }
}