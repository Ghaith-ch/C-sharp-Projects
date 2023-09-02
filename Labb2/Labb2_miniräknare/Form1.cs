using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniräknare
{
    public partial class miniraknare : Form
    {
        public miniraknare()
        {
            InitializeComponent();
        }

        int total = 0; //för att lagra den slutliga resultat efter varje beräkning
        string choice = ""; // för att lagra operation som användaren har tryckt på  
        bool operationSelected = false; //en flagga för att man veta när man ska tömma textbox fält       
        private void number_Click(object sender, EventArgs e) //om man trycker på något nummer
        {
            if ( (txt_result.Text == "0") || (operationSelected==true) ) //tömma textbox's fält OM den är 0 eller   
            {                                                            //om användare har tryckt på någon operation
                txt_result.Clear();
            }
            operationSelected = false; // för att inte skriva over den första number som man har skrivit                          
            /*
             sender, pekar till objektet som anropade händelsen som trigger händelsehanteraren
              och den är bra att använda om det finnas många objekt som använder samma händelsehanterare
             */
            Button number = (Button)sender; 
            txt_result.Text = txt_result.Text + number.Text; //för att säkerställa att den nya nummer kommer bredvid den första nummer

            TaHandOmOverflow();
        }
        private void operation_Click(object sender, EventArgs e) //om man trycker på någon operation
        {
            Button operation = (Button)sender;
            if (total == 0) // om användaren tryckt på någon operation för första gången så
                            // då tottal ska vara 0 så jag tilldela den nummer som användaren tryckt innan operation  
            {
                total = int.Parse(txt_result.Text);
            }
            else             // om användaren tryckt på någon operation(INTE för första gången)så
                             // då vill man att göra beräkningen så jag call berakna funktion
            {    
                berakna(); 
            }

            operationSelected = true;  //för att tömma textbox
            choice = operation.Text;   //lagra operationen
            label.Text = total + " " + choice; //fyll i label
        }

        private void equal_Click(object sender, EventArgs e) //om man trycker på equal operation
        {
            berakna(); //man vill att göra beräkningen så jag call berakna funktion
        }

        private void clear_Click(object sender, EventArgs e) //om man trycker på C (clear)
        {
            txt_result.Text = "0"; //tömma textbox, tottal och label
            total = 0;
            label.Text = "";
        }
        private void berakna () //funktion för att räkna resultat av flera nummer
        {
            switch (choice) // kolla vilken operation har användaren tryckt på skriv ut resultat beroande på operationen
            {
                case "+":
                    txt_result.Text = (total + int.Parse(txt_result.Text)).ToString();
                    TaHandOmOverflow();
                    break;
                case "-":
                    txt_result.Text = (total - int.Parse(txt_result.Text)).ToString();
                    TaHandOmOverflow();
                    break;
                case "x":
                    txt_result.Text = (total * int.Parse(txt_result.Text)).ToString();
                    TaHandOmOverflow();
                    break;
                case "/":
                    try // ta hand om division by zero genom att använda try catch för att visa ett meddelande till användare
                    {
                        txt_result.Text = (total / int.Parse(txt_result.Text)).ToString();
                        TaHandOmOverflow();
                    }
                    catch (DivideByZeroException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    break;
                default:
                    break;
            }
            total = int.Parse(txt_result.Text); //viktigt att lagra totta resultat inför nästa beräkning
            choice = ""; //tömma operation variabel inför nästa beräkning
        }
        private void TaHandOmOverflow()
        {
            try
            {
                if (int.MaxValue < (int.Parse(txt_result.Text)) || int.MinValue > (int.Parse(txt_result.Text)))
                {
                    throw new OverflowException("");
                }
            }
            catch (OverflowException o)
            {
                MessageBox.Show(o.Message);
                txt_result.Clear();
            }
        }
    }
}
