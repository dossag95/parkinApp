using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace parkingApp
{
    public partial class frmEstacionamiento : Form
    {
        string dia;

        public frmEstacionamiento()
        {
            InitializeComponent();
        }

        private void frmEstacionamiento_Load(object sender, EventArgs e)
        {
            //Fecha actual
            lblFecha.Text = DateTime.Now.ToString();

            //Dia
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            dia = fecha.ToString("dddd");

            //Dependiendo del dia se cobrara Sabados y domingos es gratis
            double costo = 0;
            switch (dia)
            {
                case "Sunday":
                    costo = 0;
                    break;
                case "Monday":
                    costo = 950;
                    break;
                case "Tuesday":
                    costo = 950;
                    break;
                case "Wednesday":
                    costo = 950;
                    break;
                case "Thrusday":
                    costo = 950;
                    break;
                case "Friday":
                    costo = 950;
                    break;
                case "Saturday":
                    costo = 0;
                    break;
            }
            lblCosto.Text = costo.ToString("0.00");
        }


            
        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?",
                                             "Estacionamiento",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);
            if ( r == DialogResult.Yes)
            {
                this.Close(); 
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando los datos en el formulario
            string placa = txtPlaca.Text;
            double costo = double.Parse(lblCosto.Text);
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            DateTime horaInicio = DateTime.Parse(txtHoraInicio.Text);
            DateTime horaFin = DateTime.Parse(txtHoraFin.Text);

            //Calcular la hora
            TimeSpan hora = horaFin - horaInicio;

            //Calcular el importe total a cobrar 
            double importe = costo * (hora.TotalHours);

            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(horaInicio.ToString("t"));
            fila.SubItems.Add(horaFin.ToString("t"));
            fila.SubItems.Add(hora.TotalHours.ToString());
            fila.SubItems.Add(costo.ToString("C"));
            fila.SubItems.Add(importe.ToString("C"));
            lvRegistro.Items.Add(fila);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            txtHoraInicio.Clear();
            txtHoraFin.Clear();
            txtPlaca.Focus();
        }
    }
}
