using CarManagerApp;
using System;
using System.Windows.Forms;

public partial class MasinaForm : Form
{
    public Masina Masina { get; set; }

    public MasinaForm(Masina masina = null)
    {
        InitializeComponent();

        if (masina != null)
        {
            txtMarca.Text = masina.Marca;
            txtModel.Text = masina.Model;
            txtAn.Text = masina.An.ToString();
            txtPret.Text = masina.Pret.ToString();
            Masina = masina;
        }
        else
        {
            Masina = new Masina();
        }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtModel.Text))
        {
            MessageBox.Show("Toate câmpurile sunt obligatorii.");
            return;
        }

        if (!int.TryParse(txtAn.Text, out int an) || an < 1900 || an > DateTime.Now.Year)
        {
            MessageBox.Show("An invalid.");
            return;
        }

        if (!double.TryParse(txtPret.Text, out double pret) || pret < 0)
        {
            MessageBox.Show("Preț invalid.");
            return;
        }

        Masina.Marca = txtMarca.Text;
        Masina.Model = txtModel.Text;
        Masina.An = an;
        Masina.Pret = pret;

        DialogResult = DialogResult.OK;
    }
}
