using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb2_Lotto
{
    public partial class LottoForm : Form
    {
        public LottoForm()
        {
            InitializeComponent();
        }

        private List<int> minRad; //en list som ska innehålla min 7 unika nummer 
        Random rnd = new Random();
        public bool check() //en funktion som kontrollera att alla vilkor är uppfyllda
        {
            string[] txtboxes = { txt1.Text, txt2.Text, txt3.Text, txt4.Text, txt5.Text, txt6.Text, txt7.Text };// en array som innehåller nummeren som användaren skrivit 
            minRad = new List<int> { };
            try
            {
                for (int i = 0; i < txtboxes.Length; i++)
                {
                    if (string.IsNullOrEmpty(txtboxes[i])) //IsNullOrEmpty är en metod som  används för att kontrollera
                                                           //om den angivna strängen är null eller en tom sträng. 
                    {
                        throw new Exception("Radens fält måste vara uppfyllda!");
                    }
                    bool isNumber = int.TryParse(txtboxes[i], out int tal); //TryParse är en färdig metod i c# som konvertera ett strängvärde till ett heltalsvärde
                                                                            //och retunera true om konvertering lyckas och false om om konvertering misslyckas 
                    if (!isNumber)
                    {
                        throw new Exception(txtboxes[i] + " is not a number! ");
                    }
                    if (tal < 1 || tal > 35)
                    {
                        throw new Exception(txtboxes[i] + " is not between 1 and 35! ");
                    }
                    if (minRad.Contains(tal)) // är en färdig funktion som används för att kontrollera om ett element(talet i min fall) finns i listan eller inte
                    {
                        throw new Exception("Du får inte att skriva dubletter");
                    }
                    if (string.IsNullOrEmpty(txtDragning.Text))
                    {
                        throw new Exception("dragnings fält måste vara uppfyllda!");
                    }
                    bool isNumberDragning = int.TryParse(txtDragning.Text, out int AntalDragning);
                    if (!isNumberDragning)
                    {
                        throw new Exception(txtDragning.Text + " is not a number! ");
                    }
                    minRad.Add(tal); //om alla vilkor är uppfyllda så addar jag detta nummer till min unika lista
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); // för att visa meddelande till användare med fel som hen gjort med inmattning 
                return false;
            }
        }
        private void btnDragning_Click(object sender, EventArgs e)
        {;
            bool CheckAllFalt = check(); 
            if (CheckAllFalt)
            {
                int five = 0, six = 0, seven = 0; //för att lagra antal för varje siffra
                for (int i = 0; i < int.Parse(txtDragning.Text); i++)
                {
                    List<int> vin = new List<int> { }; //en list som ska innehålla 7 unika nummer 
                    int c = 0; //counter för räkna antal i varje varv
                    for (int k = 0; k < 7; k++) // här slumpar jag 7 unika nummer och kontrollera om min lista innehålla någon av slumbade tal
                    {                           // och om det är så blir min counter +1
                        int number;
                        do
                        {
                            number = rnd.Next(1, 35);
                        }
                        while (vin.Contains(number));

                        if (minRad.Contains(number))
                        {
                            c++;
                        }

                        vin.Add(number);
                    }
                    switch (c) //här kollar jag om min counter är lika med 5,6 eller 7 
                    {
                        case 5:
                            five++;
                            break;
                        case 6:
                            six++;
                            break;
                        case 7:
                            seven++;
                            break;
                    }
                }
                MessageBox.Show("Klar!"); 
                txt5right.Text = five.ToString(); // skriva resultatet i textboxer
                txt6right.Text = six.ToString();
                txt7right.Text = seven.ToString();       
            }
        } 
    }
}
