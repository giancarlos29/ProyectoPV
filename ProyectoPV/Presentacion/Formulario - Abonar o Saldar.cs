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
    }
}
