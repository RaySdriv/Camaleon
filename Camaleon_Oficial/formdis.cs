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

namespace Presentacion
{
    public partial class formdis : Form
    {
        CD_Distribuidor objetoCD = new CD_Distribuidor();//instanciar capa 
        private string idDis = null;
        private bool editar = false;



        public formdis()
        
            {
                InitializeComponent();
            }

        
        

        private void dgv_dis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void formdis_Load(object sender, EventArgs e)
        {
            Mostrardistribuidor();
        }
        private void Mostrardistribuidor()
        {
            CD_Distribuidor objectoCD = new CD_Distribuidor();
            dgv_dis.DataSource = objectoCD.Mostrardistribuidor();
        }
        
    }
    
}
