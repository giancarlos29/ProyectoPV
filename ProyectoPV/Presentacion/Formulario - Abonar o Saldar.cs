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
    public partial class frmAbonarSaldar : Form
    {
        Deudores saldador = new Deudores();

        public frmAbonarSaldar()
        {
            InitializeComponent();
        }

        public frmAbonarSaldar(Deudores saldador)
        {
            InitializeComponent();
            this.saldador = saldador;
            label3.Text = saldador.Nombres + " " + saldador.Apellidos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SistemaPrestamosPVEntities db = new SistemaPrestamosPVEntities())
            {
                float abono = Convert.ToSingle(textBox1.Text);

                if (saldador.ReditoAcumulado > 0)
                {
                    saldador.ReditoAcumulado = saldador.ReditoAcumulado - abono;
                    db.Entry(saldador).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                } // REcordar mañana colocar el capital y las cuotas en este form
                //else if ()
                //{

                //}

            }

        }
    }
}
