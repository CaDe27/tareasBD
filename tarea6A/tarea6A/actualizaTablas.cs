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
  public partial class actualizaTablas : Form
  {
    //Variables de clase
    PréstamosEntities context = new PréstamosEntities();
    BindingSource AvalesBS = new BindingSource();
    BindingSource ClientesBS = new BindingSource();
    BindingSource EmpresasBS = new BindingSource();

    public actualizaTablas()
    {
      InitializeComponent();
    }

        private void actualizaTablas_Load(object sender, EventArgs e)
        {
      context.Avales.Load();
      context.Clientes.Load();
      context.Empresas.Load();



        }

    private void cbTablas_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cbTablas.Text == "Avales")
      {
        AvalesBS.DataSource = context.Avales.Local;
        dtgGeneral.DataSource = AvalesBS;
        bindingNavigator.BindingSource = AvalesBS;

      }
      else if (cbTablas.Text == "Clientes")
      {
        ClientesBS.DataSource = context.Clientes.Local;
        dtgGeneral.DataSource = ClientesBS;
        bindingNavigator.BindingSource = ClientesBS;

      }
      else
      {
        EmpresasBS.DataSource = context.Empresas.Local;
        dtgGeneral.DataSource = EmpresasBS;
        bindingNavigator.BindingSource = EmpresasBS;
      }

    }

    private void btAlta_Click(object sender, EventArgs e)
    {
      try
      {

        context.SaveChanges();
      }catch(Exception ex)
      {
        MessageBox.Show("No se pudieron guardar los cambios. Asegúrate de que la información es correcta. O si borraste algo que no deseabas, regresa al menú.");
      }
    }

    private void dtgGeneral_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dtgGeneral_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      MessageBox.Show("Hay un error en los datos que ingresaste. Asegúrate que sean del tipo correcto.");
    }

    private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
    {

    }
  }
}
