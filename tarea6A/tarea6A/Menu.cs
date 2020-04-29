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
  public partial class Menu : Form
  {
    //Variables de clase
    PréstamosEntities context = new PréstamosEntities();
    string rfc;
    public Menu()
    {
      InitializeComponent();
    }

    public Menu(PréstamosEntities context, string rfc)
    {
      InitializeComponent();
      this.context = context;
      this.rfc = rfc;
      if(rfc == "ger")
      {
        menuActTablas.Enabled = true;
        menuActPrest.Enabled = true;
      }
      else
      {
        menuVer.Enabled = true;
      }
    }



    private void Menu_Load(object sender, EventArgs e)
        {

        }

    private void menuActTablas_Click(object sender, EventArgs e)
    {
      actualizaTablas a = new actualizaTablas();
      a.ShowDialog();

    }

    private void menuActPrest_Click(object sender, EventArgs e)
    {
      actPrest a = new actPrest();
      a.ShowDialog();
    }

    private void menuVer_Click(object sender, EventArgs e)
    {
      verCliente a = new verCliente(rfc);
      a.ShowDialog();

    }
  }
}
