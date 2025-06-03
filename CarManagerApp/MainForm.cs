using System;                        
using System.Collections.Generic;    
using System.Drawing;                
using System.IO;                     
using System.Linq;                   
using System.Windows.Forms;         
using System.Xml.Linq;               

namespace CarManagerApp
{
    public partial class MainForm : Form
    {
        private List<Masina> masini = new List<Masina>(); 
        string xmlPath = "masini.xml"; 

        public MainForm()
        {
            InitializeComponent();      
            IncarcaMasini();            // Încarcă mașinile din fișierul XML
            this.AllowDrop = true;      //  drag & drop în fereastră
            this.DragEnter += MainForm_DragEnter;  // Eveniment când fișierele intră în fereastră
            this.DragDrop += MainForm_DragDrop;    // Eveniment când fișierele sunt "drop-uite"
        }

        private void IncarcaMasini()
        {
           
            if (File.Exists(xmlPath))
            {
                // fișierul XML și construiește lista de mașini din el
                XDocument doc = XDocument.Load(xmlPath);
                masini = doc.Root.Elements("Masina").Select(x => new Masina
                {
                    Marca = x.Element("Marca")?.Value,
                    Model = x.Element("Model")?.Value,
                    An = int.Parse(x.Element("An")?.Value ?? "0"),
                    Pret = double.Parse(x.Element("Pret")?.Value ?? "0")
                    // ImaginePath = x.Element("ImaginePath")?.Value 
                }).ToList();
            }

            RefreshGrid(); // Actualizează grid ul 
        }

        private void SalveazaMasini()
        {
            // Creează un document XML nou cu toate mașinile din listă
            var doc = new XDocument(
                new XElement("Masini",
                    masini.Select(m => new XElement("Masina",
                        new XElement("Marca", m.Marca),
                        new XElement("Model", m.Model),
                        new XElement("An", m.An),
                        new XElement("Pret", m.Pret)
                    // new XElement("ImaginePath", m.ImaginePath)
                    ))
                )
            );
            doc.Save(xmlPath); 
        }

        private void RefreshGrid()
        {
            // Reîncarcă DataGridView-ul cu lista actualizată
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = masini;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            // Verifică dacă obiectul drag & drop conține fișiere
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy; // Arată că se permite copierea fișierului
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            // Primește lista de fișiere aruncate în fereastră
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                // Verifică dacă fișierul are extensia .xml
                if (file.EndsWith(".xml"))
                {
                    // Încarcă mașinile din acel fișier XML
                    XDocument doc = XDocument.Load(file);
                    var masiniImportate = doc.Root.Elements("Masina").Select(x => new Masina
                    {
                        Marca = x.Element("Marca")?.Value,
                        Model = x.Element("Model")?.Value,
                        An = int.Parse(x.Element("An")?.Value ?? "0"),
                        Pret = double.Parse(x.Element("Pret")?.Value ?? "0")
                    }).ToList();

                    // Adaugă noile mașini la lista existentă
                    masini.AddRange(masiniImportate);
                    SalveazaMasini(); // Salvează lista actualizată în XML
                    RefreshGrid();    // Actualizează vizualizarea
                }
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            var form = new MasinaForm(); // Deschide formularul pentru adăugare
            if (form.ShowDialog() == DialogResult.OK)
            {
                masini.Add(form.Masina); // Adaugă mașina completată de utilizator
                SalveazaMasini();        // Salvează în fișier
                RefreshGrid();           // Actualizează DataGridView-ul
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var masina = dataGridView1.CurrentRow.DataBoundItem as Masina;
                masini.Remove(masina);    // Elimină mașina selectată
                SalveazaMasini();         // Salvează modificările
                RefreshGrid();            // Actualizează afișarea
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var masina = dataGridView1.CurrentRow.DataBoundItem as Masina;
                var form = new MasinaForm(masina); // Deschide formularul cu datele mașinii
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SalveazaMasini();     // Salvează modificările
                    RefreshGrid();        // Reîncarcă DataGridView-ul
                }
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string cauta = txtCauta.Text.ToLower(); // Textul introdus de utilizator
            var rezultate = masini.Where(f => f.Marca.ToLower().Contains(cauta)).ToList(); //  il cauta , filtare
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = rezultate; // Afișează doar rezultatele filtrate
        }

        private void btnDetaliiDinamice_Click(object sender, EventArgs e)
        {
            panelDetalii.Controls.Clear(); // Curăță panelul de control

            if (dataGridView1.CurrentRow != null)
            {
                var masina = dataGridView1.CurrentRow.DataBoundItem as Masina;

                // Creează un label cu detaliile mașinii
                Label lblInfo = new Label();
                lblInfo.AutoSize = true;
                lblInfo.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                lblInfo.Text = $"Marca: {masina.Marca}\nModel: {masina.Model}\nAn: {masina.An}\nPreț: {masina.Pret} €";
                lblInfo.Location = new Point(10, 10);

                // Creează un PictureBox cu o imagine simbolică
               /* PictureBox pic = new PictureBox();
                pic.Image = Properties.Resources.car_icon; // Imagine adăugată în Resources
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Size = new Size(100, 100);
                pic.Location = new Point(10, lblInfo.Bottom + 10);*/

                // Adaugă labelul in panel
                panelDetalii.Controls.Add(lblInfo);
               // panelDetalii.Controls.Add(pic);
            }
        }
    }
}
