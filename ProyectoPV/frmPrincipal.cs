using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPV.Models;
using System.Data.Entity;
using ProyectoPV.Presentacion;
using System.Data.SqlClient;

namespace ProyectoPV
{
    public partial class frmPrincipal : Form
    {
        Deudores deudor = new Deudores();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaPrestamosPVDataSet.Deudores' table. You can move, or remove it, as needed.
            this.deudoresTableAdapter.Fill(this.sistemaPrestamosPVDataSet.Deudores);
            LoadData();
        }

        #region LOADDATA
        private void LoadData()
        {
            using (SistemaPrestamosPVEntities db = new SistemaPrestamosPVEntities())
            {
                var lst = from d in db.Deudores
                          where d.CuotasVencidas > 0
                          select d;
                dgvPool.DataSource = lst.ToList();
            }
        }
        #endregion

        #region GETID
        private int? GetId()
        {
            try
            {
                return int.Parse(dgvPool.Rows[dgvPool.CurrentRow.Index].Cells[0].Value.ToString());

            }
            catch (Exception)
            {

                return null;
            }
        }
        #endregion


        private void btnPagarUltimaCuota_Click(object sender, EventArgs e)
        {
            try
            {
                var id = GetId();
                DateTime fecha = DateTime.Now;
                using (SistemaPrestamosPVEntities db = new SistemaPrestamosPVEntities())
                {
                    Deudores deu = db.Deudores.Find(id);
                    if (id != null)
                    {
                        if (deu.CuotasVencidas < 2)
                        {
                            deu.CuotasPagadasATiempo++;
                        }
                        deu.CuotasVencidas--;
                        deu.UltimoPago = fecha;
                        deu.CuotasPagadas++;
                        deu.ReditoAcumulado -= deu.ReditoMensual;
                        db.Entry(deu).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show(deu.Nombres.ToString() + " " + deu.Apellidos.ToString() + " Ha pagado" +
                        " una cuota, le quedan " + deu.CuotasVencidas.ToString() + " Cuotas vencidas");
                    }
                    LoadData();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Por haga click en algun registro!","Error:No cliente seleccionado");
            }

        }
    

        private void dgvPool_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            using (SistemaPrestamosPVEntities db = new SistemaPrestamosPVEntities())
            {
                var id = GetId();
                Deudores deu = db.Deudores.Find(id);
                frmAbonarSaldar form = new frmAbonarSaldar(deu);
                form.ShowDialog();
                LoadData();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

 

        private void dgvPool_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPagarUltimaCuota.Enabled = true;
            btnPagos.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Esta seguro de que desea salir del programa?", "Aviso!", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (DialogResult == DialogResult.Yes)//Se crea el backup de DB cada 25 dias
            {
                using (SistemaPrestamosPVEntities db = new SistemaPrestamosPVEntities())
                { 
                    DateTime fechaActual = DateTime.Now;
                    TimeSpan? diasDesdeUltimoBackUp;


                    var MyDate = db.BackUps.Select(x => x.UltimoBackUp).Max();

                    diasDesdeUltimoBackUp = fechaActual - MyDate;

                    if (diasDesdeUltimoBackUp.Value.Days > 25)
                    {
                        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SistemaPrestamosPV;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "backupdb";
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmCliente = new frmClientes();
            frmCliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdministrarUsuarios admUsu = new AdministrarUsuarios();
            admUsu.ShowDialog();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            var frmHistoric = new frmHistorico();
            frmHistoric.ShowDialog();
        }

        private void frmPrincipal_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
    
}


