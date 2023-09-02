using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //viktigt för att hantera filer

namespace Notepad
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string fNamn; 
        private bool arFilenSparad;
        
        public Form()
        {
            InitializeComponent();
            fNamn = "Untitled.txt"; //bra så länge
            this.Text = fNamn;
            arFilenSparad = true;
        }              
        private void MenuNy_Click(object sender, EventArgs e)
        {
            if (!this.Text.Contains("*") ) //Om man öppnar någon fil och sedan ändrar man INTE något och sedan vill skapa ny fill så
                                           //bara sätt arFilenSparad till true och sedan ska textbox tömmas
            {
                arFilenSparad = true;
            }

            if (arFilenSparad == false) //Om man har skrivit något i textbox och vill skapa ny fil
            {
                DialogResult svar = MessageBox.Show("Vill du spara?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (svar == DialogResult.Yes)
                {
                    if (this.Text.Contains("Untitled")) //Det betyder att denna fil ska sparas för första gång så vi använder savefiledialog 
                    {
                        SparadForstaGang();
                    }

                    else // Om man öppnar någon fil,ändra i den och sedan vill skapa ny fil så en frågan om man vill spara den och om Ja kommer ändringar att sparas i filen
                    {
                        Sparad();
                    }
                }
            }
            txtBox.Text = "";           // Efter alla fall ska textbox tömmas och tillbaka till standard titel(exakt som vanlig Notepad)
            fNamn = "Untitled.txt";
            this.Text = fNamn;
            arFilenSparad = true;
        }
        private void MenuÖppna_Click(object sender, EventArgs e) //exakt som vanlig Notepad
        {
            if (string.IsNullOrEmpty(txtBox.Text) || !this.Text.Contains("*")) // Tryck på öppna när textbox är tömt så openfiledialog
                                                                               // Eller om man har redan öppnat en fil(då är textbox inte tömt)
                                                                               // och inte ändrat något i den så om man trycker nu på öppna igen så openfiledialog
            {
                OppnaFil();  
            }

            else if(this.Text.Contains("*")) //Om man redan öpnat en fil och ändrat i den eller om man ändrat i nu fil
            {
                DialogResult svar = MessageBox.Show("Vill du spara?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (svar == DialogResult.Yes)
                {
                    if (this.Text.Contains("Untitled")) //Det betyder att denna fil ska sparas för första gång så vi använder savefiledialog 
                    {
                        SparadForstaGang();
                    }
                    else
                    {
                        Sparad(); //kommer ändringar att sparas i filen
                    }
                   
                    OppnaFil(); //sedan openfiledialog för att öppna den nya fil efter båda fall
                }
                else
                {
                    OppnaFil(); //Om man trycker på Nej(hen vill inte spara)så openfiledialog för att öppna den nya fil
                }
            }
        }
        private void MenuSpara_Click(object sender, EventArgs e) //exakt som vanlig Notepad
        {
            if (this.Text.Contains("Untitled")) //Det betyder att denna fil ska sparas för första gång så vi använder savefiledialog
            {
                SparadForstaGang();                 //Det betyder att denna fil ska sparas för första gång så vi använder savefiledialog
                fNamn = saveFileDialog.FileName;
                fNamn = fNamn.Substring(fNamn.LastIndexOf("\\") + 1); //För att visa bara filenamn (ej hela sökvägen) 
                this.Text = fNamn;
                arFilenSparad = true; ;
            }
            else if (this.Text.Contains("*"))
            {
                Sparad();           //kommer ändringar att sparas i filen
                this.Text = fNamn;
                arFilenSparad = true;
            }
        }
        private void MenuSparaSom_Click(object sender, EventArgs e)
        {
            SparadForstaGang();                 //Det betyder att denna fil ska sparas för första gång så vi använder savefiledialog
            fNamn = saveFileDialog.FileName;
            fNamn = fNamn.Substring(fNamn.LastIndexOf("\\") + 1); //För att visa bara filenamn (ej hela sökvägen) 
            this.Text = fNamn;
            arFilenSparad = true;
        }
        private void MenuAvsluta_Click(object sender, EventArgs e)
        {
            Avsluta();  //kolla Avsluta funktion
        }
        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            arFilenSparad = false;  //Det betyder att filen inte sparad så AndraTitelNamn() så att lägga till * i slutet
            AndraTitelNamn();       //denna * kommer att användas som flagga sen i min applikation
            StatusBarUppdate();     // När man skriva i textbox eller öppna någon fil(det betyder att man har skrivit i textbox)så uppdatera statusbar 
        }
        private void AndraTitelNamn()
        {
            if (arFilenSparad == false)   //den är flagga för att lägga till * när filen inte sparad
            {
                this.Text = fNamn + "*";  // or "*" + fname
            }
        }
        private void StatusBarUppdate()
        {
            int antalRad;
            int antalTeckenMedMellanslag;
            int antalOrd = 0;
            int antalTecken = 0;

            antalRad = txtBox.Lines.Length; //hämta hur många rader i textbox
            AntRad.Text = "Rad" + " " + antalRad.ToString();

            antalTeckenMedMellanslag = txtBox.Text.Length; //hämta antal tecken i textbox (inkludera mellanslag) 
            AntTeckenMedMellanslag.Text = "TeckenMedMellansslag" + " " + antalTeckenMedMellanslag;

            string[] textBoxRader = txtBox.Lines; //txtBox.Lines returnerar en array av strängar där
                                                  //varje element i den returnerade array är en rad.

            foreach (string rad in textBoxRader)  //loopa rad för rad
            {
                bool mellanslag = true; //ny rad betyder att vi har mellanslag
                bool tecken = false;    //kanske raden börjar med mellanslag (man kan ta bort false eftersom false är default)

                for (int i = 0; i < rad.Length; i++) //kontrollera varje tecken som finns i denna rad
                {
                    if (rad[i] == ' ') //inga tecken
                    {
                        mellanslag = true;
                        tecken = false;
                    }
                    else //en tecken hittad
                    {
                        tecken = true;
                        antalTecken++;
                    }
                    if (mellanslag == true && tecken == true) //betyder en tecken hittades med en mellanslag innan så nytt ord
                    {
                        antalOrd++;
                        mellanslag = false; //det finns inte mellanslag efter den sista tecken
                    }
                }
            }

            AntOrd.Text = "Ord" + " " + antalOrd.ToString();
            AntTecken.Text = "Tecken" + " " + antalTecken.ToString();
        }
        private void OppnaFil()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtBox.Text = File.ReadAllText(openFileDialog.FileName); //läsa allt som finns i filen och lägga dem i textbox
                fNamn = openFileDialog.FileName;
                fNamn = fNamn.Substring(fNamn.LastIndexOf("\\") + 1); //För att visa bara filenamn (ej hela sökvägen) 
                this.Text = fNamn;
            }
            
        }
        private void SparadForstaGang() //Jag kommer att använda denna kod några gågner på många ställe så jag gjorde en funktion
        {
            saveFileDialog.Filter = "Text Files | *.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtBox.Text); //läsa allt som finns i textbox och lägga dem i filen
                MessageBox.Show("Filen sparat!"); // Man kan visst ta bort den, det är för testning bara;
            }
        }
        private void Sparad()
        {
            string path = this.Text;                            //denna rad och raden som finns under den användas för att hämta filenamn(utan *) från titeln
            string pathtosave = path.Remove(path.Length - 1, 1);
            File.WriteAllText(pathtosave, txtBox.Text);         //läsa allt som finns i textbox och lägga dem i filen
        }       
        private void Avsluta()
        {
            if (!this.Text.Contains("*")) //Om inga ändringar skett i den öppna filen så stäng direkt
            {
                Application.Exit();
            }
            else if (this.Text.Contains("*") && !string.IsNullOrEmpty(txtBox.Text)) //Om ändringar skett i den öppna filen så fråga först
            {
                DialogResult svar = MessageBox.Show("Vill du spara?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (svar == DialogResult.Yes)   //Om Ja så filen sparas och sedan programmet stängs
                {
                    if (this.Text.Contains("Untitled")) //Om den öppna filen ska sparas första gågng så savefiledialog
                    {
                        SparadForstaGang();
                        fNamn = saveFileDialog.FileName;
                        this.Text = fNamn;
                        arFilenSparad = true;
                        Application.Exit();
                    }
                    else
                    {
                        Sparad();
                        fNamn = saveFileDialog.FileName;
                        this.Text = fNamn;
                        arFilenSparad = true;
                        Application.Exit();
                    }
                }
                else
                {
                    this.Text = fNamn;  //Om Nej så filen sparas inte och sedan programmet stängs
                    Application.Exit();
                }
            }
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Avsluta(); //Samma Avlsuta knappen så samma funktion användas
        }
    }
}
