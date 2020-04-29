using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea6A
{
  public partial class Form1 : Form
  {
    //Variables de clase
    //Variables de clase
    PréstamosEntities context = new PréstamosEntities();

    public Form1()
    {
      InitializeComponent();
    }

    private void btIngresa_Click(object sender, EventArgs e)
    {
      string cadSql;

      cadSql = $"select * from clientes where rfc = '{txUser.Text}' and " +
        $"contraseña = '{txContra.Text}'";

      List<Clientes> lsClientes = context.Clientes.SqlQuery(cadSql).ToList();

      if (lsClientes.Count != 0)
      {
        Menu m = new Menu(context, txUser.Text);
        m.ShowDialog();
      }
      else
      {
        lblMsg.Text = "Error en el usuario o contraseña";

      }
    }
  }
}
