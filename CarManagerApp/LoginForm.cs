using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagerApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent(); // // Inițializează componentele vizuale ale formularului
        }



         private void btnLogin_Click(object sender, EventArgs e)
        {
            // var linii = System.IO.File.ReadAllLines("utilizatori.txt");
             // Construiește calea completă către fișierul utilizatori.txt aflat în folderul aplicației
            string path = Path.Combine(Application.StartupPath, "utilizatori.txt");
            var linii = System.IO.File.ReadAllLines(path); //citeste din fisier 
            foreach (var linie in linii) //parcurge linii din fiseri 
            {
                var parts = linie.Split(';'); //delimiteaza user de parola 
                if (txtUser.Text == parts[0] && txtPass.Text == parts[1]) //verifica daca date introduse sunt corecte 
                {
                    MainForm f = new MainForm(); // deschide urmatoarea pagina 
                    f.Show(); // afiseaza pagina principala 
                    this.Hide(); // ascunde pagina de login 
                    return;
                }
            }
            MessageBox.Show("Autentificare eșuată.");
        }

       
    }
}
