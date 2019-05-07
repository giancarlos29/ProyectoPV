using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPV.Models;
using System.Data.Entity.Migrations;

namespace ProyectoPV.Presentacion
{
    public partial class frmTabla : Form
    {
        public int? id;
        public Deudores oTabla = null;

        public frmTabla(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                CargarDatos();
            }
        }


        private void CargarDatos()
        {
            using (SistemaPrestamosPVEntities db = new SistemaPrestamosPVEntities())
            {
                oTabla = db.Deudores.Find(id);
                txtNombres.Text = oTabla.Nombres;
                txtApellidos.Text = oTabla.Apellidos;
                txtCapital.Text = oTabla.Capital.ToString();
                var interes =oTabla.Interes;
                txtInteres.Text = interes.ToString();
                dtpFechaInicializacionPrestamo.Value = oTabla.FechaInicializacionPrestamo;
                txtTelefono.Text = oTabla.Telefono;
                txtTelefono2.Text = oTabla.Telefono2;
                txtDireccion.Text = oTabla.Direccion;
                txtEmail.Text = oTabla.Email;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SistemaPrestamosPVEntities db = new SistemaPrestamosPVEntities())
            {
                if (id == null)
                {
                    oTabla = new Deudores();
                    oTabla.Nombres = txtNombres.Text;
                    oTabla.Apellidos = txtApellidos.Text;
                    oTabla.Capital = Convert.ToSingle(txtCapital.Text);
                    var interes = Convert.ToSingle(txtInteres.Text);
                    oTabla.Interes = interes;
                    oTabla.ReditoMensual = Convert.ToSingle(txtCapital.Text) * (interes / 100);
                    oTabla.CuotasVencidas = 0;
                    if (oTabla.CuotasVencidas == 0)
                    {
                        oTabla.ReditoAcumulado = oTabla.ReditoMensual;
                    } else
                    {
                        oTabla.ReditoAcumulado = oTabla.ReditoMensual * oTabla.CuotasVencidas;
                    }
                    oTabla.FechaInicializacionPrestamo = oTabla.UltimoPago = dtpFechaInicializacionPrestamo.Value;
                    oTabla.CuotasGeneradas = 0;
                    oTabla.CuotasPagadas = 0;
                    oTabla.CuotasPagadasATiempo = 0;
                    oTabla.Score = 1;
                    oTabla.Telefono = txtTelefono.Text;
                    oTabla.Telefono2 = txtTelefono2.Text;
                    oTabla.Email = txtEmail.Text;
                    oTabla.Direccion = txtDireccion.Text;
                    oTabla.Cedula = txtCedula.Text;

                    db.Deudores.Add(oTabla);
                    MessageBox.Show("Registro agregado");
                }
                else
                {
                    oTabla.Nombres = txtNombres.Text;
                    oTabla.Apellidos = txtApellidos.Text;
                    txtCapital.Enabled = false;
                    var interes = Convert.ToSingle(txtInteres.Text) / 100;
                    dtpFechaInicializacionPrestamo.Enabled = false;
                    oTabla.Interes = interes;
                    oTabla.Telefono = txtTelefono.Text;
                    oTabla.Telefono2 = txtTelefono2.Text;
                    oTabla.Email = txtEmail.Text;
                    oTabla.Direccion = txtDireccion.Text;
                    oTabla.Cedula = txtCedula.Text;

                    db.Entry(oTabla).State = EntityState.Modified;
                    MessageBox.Show("Registro editado");
                }
                
                db.SaveChanges();
                Close();
            }
            
        }

        private void frmTabla_Load(object sender, EventArgs e)
        {

        }
    }
}
