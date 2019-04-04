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
            label4.Text = saldador.Capital.ToString();
            label6.Text = saldador.ReditoAcumulado.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SistemaPrestamosPVEntities db = new SistemaPrestamosPVEntities())
            {
                float abono = Convert.ToSingle(textBox1.Text);

                if (saldador.ReditoAcumulado > 0)
                {
                    saldador.ReditoAcumulado = saldador.ReditoAcumulado - abono;
                    if(saldador.ReditoAcumulado < 0)
                    {
                        float abonocapital = Convert.ToSingle(saldador.ReditoAcumulado) * (-1);
                        saldador.ReditoAcumulado = 0;
                        saldador.Capital = saldador.Capital - abonocapital;
                        MessageBox.Show("El deudor " + saldador.Nombres + " tiene su balance de reditos en:$RD"
                            + saldador.ReditoAcumulado);
                        MessageBox.Show("El deudor " + saldador.Nombres + " tiene su balance de capital en:$RD" 
                            + saldador.Capital);
                    }
                    db.Entry(saldador).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    Close();
                }
                else if (saldador.Capital > 0)
                {
                    saldador.Capital = saldador.Capital - abono;
                    db.Entry(saldador).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("El deudor " + saldador.Nombres + " ha disminuido su capital a " + saldador.Capital);
                    Close();
                }

            }

        }
    }
}
