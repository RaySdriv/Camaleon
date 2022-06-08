using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using AccesoDatos;
namespace Presentacion
{
    public partial class FormProveedor : Form
    {
        CD_Proveedor objectoCD = new CD_Proveedor();//instanciar capa 
        private string idProv; //= null;
        private bool editar = false;
        public FormProveedor()
        {
            InitializeComponent();
        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            MostrarProveedores();
        }
        private void MostrarProveedores()
        {
            CD_Proveedor objectoCD = new CD_Proveedor();
            dgv_proveedores.DataSource = objectoCD.MostrarProveedor();
        }
    }
}