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
using ProyectoPV.Models;

namespace ProyectoPV
{
    public partial class frmAgregar : Form
    {

        public frmAgregar()
        {
            InitializeComponent();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            using (SistemaPrestamosPVEntities db= new SistemaPrestamosPVEntities())
            {
                var lst = from d in db.Deudores
                          select d;
                dgvDeudores.DataSource = lst.ToList();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        

           
    }
}
