using ProyectoPV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPV.Presentacion
{
    public partial class frmHistorico : Form
    {
        public frmHistorico()
        {
            InitializeComponent();
        }

        private void frmHistorico_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        #region LOADDATA
        private void LoadData()
        {
            using (SistemaPrestamosPVEntities db = new SistemaPrestamosPVEntities())
            {
                var lst = from d in db.Saldadores
                          select d;
                dgvSaldadores.DataSource = lst.ToList();
            }
        }
        #endregion
    }
}
