using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Comisaria comisaria;
        public Form1()
        {
            InitializeComponent();
            gbx2.Enabled = false;
        }

        private void btnCrearComisaria_Click(object sender, EventArgs e)
        {
            comisaria = new Comisaria();

            Policia Juan = new Policia(5434234, "Juan", 12);
            Policia Ana = new Policia(1234650, "Ana", 22);


            comisaria.AsignarPolicia(Juan);
            comisaria.AsignarPolicia(Ana);

            cmbPlaca.Items.Clear();
            cmbPlaca.Items.Add(Juan.NumeroPlaca);
            cmbPlaca.Items.Add(Ana.NumeroPlaca);

            gbx2.Enabled = true;
        }

        private void btnAsignarGuardias_Click(object sender, EventArgs e)
        {
            if (cmbPlaca.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una placa antes de continuar.");
                return;
            }

            string nroplacString = cmbPlaca.SelectedItem.ToString();
            int nroPlaca = Convert.ToInt32(nroplacString);
            int nroGuardia = Convert.ToInt32(numNROguardia.Value);
            int desdeH = Convert.ToInt32(numDesdeHora.Value);
            int desdeM = Convert.ToInt32(numDesdeMinutos.Value);
            int duracion = Convert.ToInt32(numDuracion.Value);

            Policia agente = comisaria.VerAgente(nroPlaca);
            if (agente != null)
            {
                comisaria.AsignarGuardia(nroGuardia, desdeH, desdeM, duracion, agente);
                
            }
            else
            {

                MessageBox.Show("No se encontró el agente seleccionado.");
            }
            #region limpiar
            cmbPlaca.SelectedIndex = -1;
            numNROguardia.Value = 0;
            numDesdeHora.Value = 0;
            numDesdeMinutos.Value = 0;
            numDuracion.Value = 0;
            #endregion
        }

        private void btnRegistrarIncidente_Click(object sender, EventArgs e)
        {
            if (cmbPlaca.SelectedItem == null || cbxIncidente.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una placa y un tipo de incidente.");
                return;
            }

            string nroplacString = cmbPlaca.SelectedItem.ToString();
            int nroPlaca = Convert.ToInt32(nroplacString);

            int tipoIncidente = cbxIncidente.SelectedIndex;
            int hInicidente = Convert.ToInt32(numHoraH.Value);
            int mIncidente = Convert.ToInt32(numHoraM.Value);

            if (!int.TryParse(tbDNI.Text, out int dni))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }

            string nombre = tbPersona.Text;
            string motivo = tbMotivo.Text;

            Persona sujeto = new Persona(dni, nombre);
            Policia agente = comisaria.VerAgente(nroPlaca);

            if (agente == null)
            {
                MessageBox.Show("No se encontró el agente seleccionado.");
                return;
            }

            comisaria.RegistrarIncidente(agente, sujeto, motivo, hInicidente, mIncidente, tipoIncidente);

            #region limpiar
            cmbPlaca.SelectedIndex = -1;
            cbxIncidente.SelectedIndex = -1;
            numHoraH.Value = 0;
            numHoraM.Value = 0;
            tbMotivo.Clear();
            tbDNI.Clear();
            tbPersona.Clear();
            #endregion
        }

        private void btnListarIncidentes_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            for (int idx = 0; idx < comisaria.CantidadIncidentes; idx++)
            {
                form2.tbListado.Text += $"\r\n--{idx + 1}---------------------\r\n";

                Incidente inc = comisaria.VerIncidente(idx);

                form2.tbListado.Text += inc.VerDescripcion();
            }
            form2.tbListado.Text += $"\r\n-----------------------";


            form2.ShowDialog();
        }
    }
}