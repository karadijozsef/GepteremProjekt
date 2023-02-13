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

namespace GepteremProjekt
{
    public partial class Form1 : Form
    {
        PetrikLajosSzg Pl = new PetrikLajosSzg("petrikgepek.txt");
        int akt = 0;
        int meret = 45;
        List<Image> pontKep = new List<Image> { Image.FromFile(@"Kepek1\Kepek\Pont0.jpg"), Image.FromFile(@"Kepek1\Kepek\Pont1.jpg"), Image.FromFile(@"Kepek1\Kepek\Pont2.jpg"), Image.FromFile(@"Kepek1\Kepek\Pont3.jpg") };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel_update();
        }

        void Panel_update()
        {
            this.Text = $"{Pl.Gepterem[akt].Nev} ({Pl.Gepterem[akt].Atlag().ToString("0.00")})";
            pictureBox_image.Image = Image.FromFile(@"Kepek\" + Pl.Gepterem[akt].Nev.Split()[0] + ".jpg");
            pictureBox_image.SizeMode = PictureBoxSizeMode.Zoom;
            ertekelespanel.Controls.Clear();
            for (int i = 0; i < Pl.Gepterem[akt].SorDb; i++)
            {
                for (int j = 0; j < Pl.Gepterem[akt].HelyDb; j++)
                {
                    PictureBox uj = new PictureBox();
                    uj.Image = pontKep[Pl.Gepterem[akt].Ertekeles[i, j]];
                    uj.SetBounds(j * meret, i * meret, meret, meret);
                    uj.SizeMode = PictureBoxSizeMode.StretchImage;
                    uj.Padding = new Padding(2);
                    int i2 = i; int j2 = j;
                    uj.Click += (o, e) =>
                    {
                        switch (Pl.Gepterem[akt].Ertekeles[i2, j2])
                        {
                            case 1:
                                Pl.Gepterem[akt].Ertekeles[i2, j2] = 2;
                                uj.Image = pontKep[Pl.Gepterem[akt].Ertekeles[i2, j2]];
                                break;
                            case 2:
                                Pl.Gepterem[akt].Ertekeles[i2, j2] = 3;
                                uj.Image = pontKep[Pl.Gepterem[akt].Ertekeles[i2, j2]];
                                break;
                            case 3:
                                Pl.Gepterem[akt].Ertekeles[i2, j2] = 1;
                                uj.Image = pontKep[Pl.Gepterem[akt].Ertekeles[i2, j2]];
                                break;
                            default:
                                MessageBox.Show("Ezen a helyen nem ült senki!");
                                break;
                        }
                        this.Text = $"{Pl.Gepterem[akt].Nev} ({Pl.Gepterem[akt].Atlag().ToString("0.00")})";
                    };
                    ertekelespanel.Controls.Add(uj);
                }
            }
        }

        private void balrabutton_Click(object sender, EventArgs e)
        {
            akt = --akt < 0 ? Pl.Gepterem.Count - 1 : akt;
            Panel_update();
        }

        private void jobbrabutton_Click(object sender, EventArgs e)
        {
            akt = ++akt > Pl.Gepterem.Count - 1 ? 0 : akt;
            Panel_update();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy("petrikgepek.txt", "petrikgepek.bak", true);
                using (StreamWriter sw = new StreamWriter("petrikgepek.txt"))
                {
                    foreach (Gepterem item in Pl.Gepterem)
                    {
                        sw.WriteLine(item.Nev);
                        sw.WriteLine(string.Join(";", item.SorDb, item.HelyDb));
                        for (int i = 0; i < item.SorDb; i++)
                        {
                            string[] row = new string[item.HelyDb];
                            for (int j = 0; j < item.HelyDb - 1; j++)
                            {
                                row[j] = item.Ertekeles[i, j].ToString();
                            }
                            sw.WriteLine(string.Join(";", row));
                        }
                        sw.WriteLine();
                    }
                    MessageBox.Show("A mentés sikeres!");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message + "\nA mentés sikertelen!");
                return;
            }
        }
    }
}
