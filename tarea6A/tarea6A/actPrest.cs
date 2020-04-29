using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea6A
{
  public partial class actPrest : Form
  {

    PréstamosEntities context = new PréstamosEntities();
    String cadSql;
    public actPrest()
    {
      InitializeComponent();
    }

        private void btMenu_Click(object sender, EventArgs e)
        {
          this.Close();
        }

    private void actPrest_Load(object sender, EventArgs e)
    {
      context.Clientes.Load();
      context.Préstamos.Load();
      context.Pagos.Load();
      
      List<Clientes> cl = context.Clientes.ToList();
      cbCliente.Items.Add(" ");
      foreach (Clientes c in cl)
      {
        cbCliente.Items.Add(c.Nombre);
      }

    }

    private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cbCliente.Text == " ")
        return;
      
      cadSql = $"select * from clientes where nombre='{ cbCliente.Text}'";
      List<Clientes> cl = context.Clientes.SqlQuery(cadSql).ToList();

      cadSql = $"select * from préstamos where rfc = '{cl[0].Rfc}'";
      List<Préstamos> pr = context.Préstamos.SqlQuery(cadSql).ToList();

      cbPrestamo.Items.Add(" ");
      foreach (Préstamos p in pr)
        cbPrestamo.Items.Add(p.Folio.ToString());


    }

    private void cbPrestamo_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cbPrestamo.Text == " ")
        return;

      cadSql = $"select * from Pagos where folio = '{cbPrestamo.Text}'";
      List<Pagos> pg = context.Pagos.SqlQuery(cadSql).ToList();
      dtgGeneral.DataSource = pg;
    }

    private void actualizaSaldo()
    {

      try
      {

        List<Pagos> pagos = context.Pagos.SqlQuery("select * from pagos where folio = " + cbPrestamo.Text).ToList();
        decimal saldo = 0;
        foreach (Pagos p in pagos)
          saldo += Convert.ToDecimal(p.MontoPago);

        MessageBox.Show("el nuevo saldo es "+saldo.ToString());

        Préstamos prestamo = (context.Préstamos.SqlQuery($"select * from Préstamos where folio = '{cbPrestamo.Text}'").ToList())[0];
        prestamo.Saldo = saldo;
        context.SaveChanges();

      }
      catch (Exception ex)
      {
        MessageBox.Show("Hubo un error con los datos ingresados. Por favor asegúrate de que los datos están completos.");
      }
    }
    private void btActualiza_Click(object sender, EventArgs e)
    {
      lblMonto.Visible = true; 
      txMonto.Visible = true; txMonto.Enabled = true;
      btAct.Visible = true; btAct.Enabled = true;

      btQuita.Enabled = false;
      btDarAlta.Enabled = false;
      btActualiza.Enabled = false;


      lblMonto.Text = "Nuevo monto:";
      txMonto.Text = "";



    }

    private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
    {
      
    }

    private void dtgGeneral_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      lblMonto.Visible = true;
      txMonto.Visible = true; txMonto.Enabled = true;
      btAlt.Visible = true; btAlt.Enabled = true;
      dateP.Enabled = true; dateP.Visible = true;

      btQuita.Enabled = false;
      btDarAlta.Enabled = false;
      btActualiza.Enabled = false;


      lblMonto.Text = "Monto: ";
      txMonto.Text = "";

    }

    private void button1_Click(object sender, EventArgs e)
    {
      int fila = dtgGeneral.CurrentCell.RowIndex;
      string IdP = dtgGeneral["IdP", fila].Value.ToString();

      DialogResult boton = MessageBox.Show("¿Se elimina el registro con folio " + cbPrestamo.Text + " y idP= " + IdP,
      "Eliminación", MessageBoxButtons.YesNo);

      //Si se selecciona el botón Yes, del MessageBox, elimina el registro asociado.
      if (boton == DialogResult.Yes)
      {
        //Construye la cadena de eliminación y la envía para su ejecución.
        cadSql = "select * from Pagos where folio="+cbPrestamo.Text + " and IdP = " + IdP;
        Pagos p = (context.Pagos.SqlQuery(cadSql).ToList())[0];
     
          context.Pagos.Remove(p);
        context.SaveChanges();
          actualizaSaldo();
          MessageBox.Show("Se eliminó el pago con folio "+cbPrestamo.Text+" y con IdP " + IdP + " exitosamente");

        cadSql = $"select * from Pagos where folio = '{cbPrestamo.Text}'";
        List<Pagos> pg = context.Pagos.SqlQuery(cadSql).ToList();
        dtgGeneral.DataSource = pg;
      }

    }

    private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
    {

    }

    private void btAct_Click(object sender, EventArgs e)
    {
      int fila = dtgGeneral.CurrentCell.RowIndex;
      string IdP = dtgGeneral["IdP", fila].Value.ToString();

      DialogResult boton = MessageBox.Show("¿Se modifica el registro con idP= " + IdP,
      "Modificación", MessageBoxButtons.YesNo);

      //Si se selecciona el botón Yes, del MessageBox, elimina el registro asociado.
      if (boton == DialogResult.Yes)
      {
        //Construye la cadena de eliminación y la envía para su ejecución.
        cadSql = "select * from Pagos where folio="+cbPrestamo.Text + " and IdP =" + IdP;
        Pagos p = (context.Pagos.SqlQuery(cadSql).ToList())[0];
        p.MontoPago = Convert.ToDecimal(txMonto.Text);
        context.SaveChanges();
        actualizaSaldo();

        MessageBox.Show("Se modificó el pago con folio "+cbPrestamo.Text+" y con idP " + IdP + " exitosamente");

        cadSql = $"select * from Pagos where folio = '{cbPrestamo.Text}'";
        List<Pagos> pg = context.Pagos.SqlQuery(cadSql).ToList();
        dtgGeneral.DataSource = pg;

        lblMonto.Visible = false;
        txMonto.Visible = false; txMonto.Enabled = false;
        btAct.Visible = false; btAct.Enabled = false;

        btQuita.Enabled = true;
        btDarAlta.Enabled = true;
        btActualiza.Enabled = true;
      }
    }

    private void btAlt_Click(object sender, EventArgs e)
    {
      DialogResult boton = MessageBox.Show("¿Se da de alta el registro?",
      "Modificación", MessageBoxButtons.YesNo);

      //Si se selecciona el botón Yes, del MessageBox, elimina el registro asociado.
      if (boton == DialogResult.Yes)
      {
        //Construye la cadena de eliminación y la envía para su ejecución.

        int folio = Convert.ToInt32(cbPrestamo.Text);
        int idP = context.Pagos.SqlQuery($"select * from Pagos where folio = {folio} order by IdP desc").ToList()[0].IdP + 1;

        Pagos p = new Pagos(folio, idP, dateP.Value, Convert.ToDecimal(txMonto.Text));
        context.Pagos.Add(p);
        context.SaveChanges();

        actualizaSaldo();
        MessageBox.Show("Se agregó el pago exitosamente");

        cadSql = $"select * from Pagos where folio = '{cbPrestamo.Text}'";
        List<Pagos> pg = context.Pagos.SqlQuery(cadSql).ToList();
        dtgGeneral.DataSource = pg;

        lblMonto.Visible = !true;
        txMonto.Visible = !true; txMonto.Enabled = !true;
        btAlt.Visible = !true; btAlt.Enabled = !true;
        dateP.Enabled = !true; dateP.Visible = !true;

        btQuita.Enabled = !false;
        btDarAlta.Enabled = !false;
        btActualiza.Enabled = !false;

      }
    }
  }
}
