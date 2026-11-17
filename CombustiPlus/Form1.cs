using System.Globalization;

namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidarDatos()
        {
            if (txtPlaca.Text.Trim().Length != 7)
            {
                MessageBox.Show(
                    "La placa debe tener 7 caracteres.\nEjemplo: A123456",
                    "Placa inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (nudGalones.Value == 0)
            {
                MessageBox.Show(
                    "Los galones deben ser mayores que 0.",
                    "Galones inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;
            double galones = (double)nudGalones.Value;

            double precio = cmbCombustible.Text switch
            {
                "Regular" => 272,
                "Premium" => 290,
                "Gasoil" => 225,
                _ => 0
            };

            var ci = CultureInfo.InvariantCulture;

            lstDetalle.Items.Clear();

            double total = galones * precio;
            lstDetalle.Items.Add(string.Format(ci, "{0:F1} gal × RD$ {1:F2} = RD$ {2:N2}", galones, precio, total));

            if (galones >= 20)
            {
                total *= 0.98;
                lstDetalle.Items.Add(string.Format(ci, "Descuento 20+ galones −2 %: RD$ {0:N2}", total));
            }

            if (cmbPago.Text == "Tarjeta")
            {
                total *= 1.03;
                lstDetalle.Items.Add(string.Format(ci, "Tarjeta +3 %: RD$ {0:N2}", total));
            }

            lstDetalle.Items.Add(string.Format(ci, "TOTAL: RD$ {0:N2}", total));
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;
        }
    }
}
