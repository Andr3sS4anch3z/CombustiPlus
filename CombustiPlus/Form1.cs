using System.Globalization;

namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        List<Despacho> despachos = new List<Despacho>();
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
            double galones = (double)nudGalones.Value;

            double precio = cmbCombustible.Text switch
            {
                "Regular" => 272,
                "Premium" => 290,
                "Gasoil" => 225,
                _ => 0
            };

            double total = galones * precio;
            if (galones >= 20) total *= 0.98;
            if (cmbPago.Text == "Tarjeta") total *= 1.03;

            Despacho d = new Despacho
            {
                Numero = despachos.Count + 1,
                Placa = txtPlaca.Text.Trim(),
                Combustible = cmbCombustible.Text,
                Galones = galones,
                Pago = cmbPago.Text,
                Total = total
            };

            despachos.Add(d);
            lstDespachos.Items.Add(d.ToString());

            double totalVendido = 0;
            double galonesTotales = 0;
            Despacho mayor = despachos[0];

            foreach (Despacho x in despachos)
            {
                totalVendido += x.Total;
                galonesTotales += x.Galones;
                if (x.Total > mayor.Total) mayor = x;
            }

            lblResumen.Text = FormattableString.Invariant(
                $"{despachos.Count} despachos · Vendido RD$ {totalVendido:N2} · Galones {galonesTotales:F1} · Mayor: #{mayor.Numero:00} {mayor.Placa} (RD$ {mayor.Total:N2})");
        }

        private void btnPorCombustible_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> galonesPorCombustible = new Dictionary<string, decimal>();

            foreach (Despacho d in despachos)
            {
                if (galonesPorCombustible.ContainsKey(d.Combustible))
                    galonesPorCombustible[d.Combustible] += (decimal)d.Galones;
                else
                    galonesPorCombustible[d.Combustible] = (decimal)d.Galones;
            }

            lstDetalle.Items.Clear();
            foreach (var par in galonesPorCombustible)
            {
                lstDetalle.Items.Add(FormattableString.Invariant($"{par.Key}: {par.Value:F1} gal"));
            }
        }
    }
}
