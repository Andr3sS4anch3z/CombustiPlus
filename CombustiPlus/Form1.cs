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
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;
        }
    }
}
