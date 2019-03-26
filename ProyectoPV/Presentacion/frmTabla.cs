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
                oTabla = db.Deudores1.Find(id);
                txtNombres.Text = oTabla.Nombres;
                txtApellidos.Text = oTabla.Apellidos;
                txtCapital.Text = oTabla.Capital.ToString();
                txtInteres.Text = oTabla.Interes.ToString();
                dateTimePicker1.Value = oTabla.FechaInicializacionPrestamo;
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
                Deudores deudor = new Deudores();
                deudor.Nombres = txtNombres.Text;
                deudor.Apellidos = txtApellidos.Text;
                deudor.Capital = Convert.ToSingle(txtCapital.Text);
                deudor.Interes = Convert.ToSingle(txtInteres.Text);
                deudor.FechaInicializacionPrestamo = dateTimePicker1.Value;
                deudor.Telefono = txtTelefono.Text;
                deudor.Telefono2 = txtTelefono2.Text;
                deudor.Email = txtEmail.Text;
                deudor.Direccion = txtDireccion.Text;


                db.Deudores1.Add(deudor);
                db.SaveChanges();
                MessageBox.Show("Registro agregado!");
                this.Close();
            }
            
        }

        private void frmTabla_Load(object sender, EventArgs e)
        {

        }
    }
}
