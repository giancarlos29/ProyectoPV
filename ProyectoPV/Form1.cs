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
            LoadData();
        }

        #region LOADDATA
        private void LoadData()
        {
            using (SistemaPrestamosPVEntities db = new SistemaPrestamosPVEntities())
            {
                var lst = from d in db.Deudores
                          select d;
                dgvDeudores.DataSource = lst.ToList();
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Presentacion.frmTabla oFrmTabla = new Presentacion.frmTabla();
            oFrmTabla.ShowDialog();
            LoadData();
        }

        #region GETID
        private int? GetId()
        {
            try
            {
                return int.Parse(dgvDeudores.Rows[dgvDeudores.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion


        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Presentacion.frmTabla oFrmTabla = new Presentacion.frmTabla(id);
                oFrmTabla.ShowDialog();
                LoadData();
            }


        }
    }
}
