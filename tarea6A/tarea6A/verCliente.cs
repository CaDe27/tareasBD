using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace tarea6A
{
  public partial class verCliente : Form
  {
    string rfc;
    PréstamosEntities context = new PréstamosEntities();
    public verCliente()
    {
      InitializeComponent();
    }

    public verCliente(string rfc)
    {
      InitializeComponent();
      this.rfc = rfc;
    }

    private void verCliente_Load(object sender, EventArgs e)
    {
      context.Préstamos.Load();
      List<Préstamos> prest = context.Préstamos.SqlQuery("select * from Préstamos where rfc = '" + rfc + "'").ToList();
      dtgGen.DataSource = prest;
       



        }
  }
}
