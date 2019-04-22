﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPV.Models;


namespace ProyectoPV.Presentacion
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            using (var db = new SistemaPrestamosPVEntities())
            {
                 var totalCuotas =
                 (from deu in db.Deudores
                  select deu.CuotasVencidas)
                 .Sum();
                label13.Text = totalCuotas.ToString();

                var totalACobrar =
                 (from deu in db.Deudores
                  select deu.ReditoAcumulado)
                 .Sum();
                label7.Text = totalACobrar.ToString();


                var totalCapital =
                 (from deu in db.Deudores
                  select deu.Capital)
                 .Sum();
                label8.Text = totalCapital.ToString();


                var totalClientes =
                 (from deu in db.Deudores
                  select deu.ReditoAcumulado)
                 .Count();
                label9.Text = totalClientes.ToString();


                var totalClientesEnAtraso =
                 (from deu in db.Deudores
                  where deu.CuotasVencidas>2
                  select deu)
                 .Count();
                label10.Text = totalClientesEnAtraso.ToString();

                var mayorDeudor =  from deu in db.Deudores
                orderby deu.Capital ascending
                select deu.Nombres.FirstOrDefault();

                label11.Text = mayorDeudor.ToString();


            }
        }
    }
}
