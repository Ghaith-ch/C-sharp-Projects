using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management
{
    public partial class AddGameForm : Form
    {
        public Game newgame { get; private set; }
        DataGridView dBook, dGame, dFilm;
        public AddGameForm(DataGridView dGV_book, DataGridView dGV_game, DataGridView dGV_film)
        {
            InitializeComponent();
            dBook = dGV_book;
            dGame = dGV_game;
            dFilm = dGV_film;
        }
        private void btn_gameAdd_Click(object sender, EventArgs e)
        {
            if (CheckForm() == true)
            {
                newgame = new Game();
                newgame.Id = Convert.ToInt32(txt_Id.Text);
                newgame.Name = txt_Name.Text;
                newgame.Quantity = Convert.ToInt32(txt_Quantity.Text);
                newgame.Price = Convert.ToDouble(txt_Price.Text);
                newgame.Plateform = txt_Platfrom.Text;

                DialogResult = DialogResult.OK;
                Close();
            }           
        }

        private bool CheckForm() //En funktion för att göra mina kontroller innan att lägga till den nya booken till min booklista
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                try
                {
                    if (tb.Name == "txt_Id" || tb.Name == "txt_Price" || tb.Name == "txt_Quantity")
                    {
                        if (string.IsNullOrEmpty(tb.Text))
                        {
                            throw new Exception(tb.Name + " is required!");
                        }
                        bool isNumber = int.TryParse(tb.Text, out int tal); //TryParse är en färdig metod i c# som konvertera ett strängvärde till ett heltalsvärde
                                                                            //och retunera true om konvertering lyckas och false om om konvertering misslyckas 
                        if (!isNumber)
                        {
                            throw new Exception(tb.Name + " must be a number! ");
                        }
                        if (tal < 0)
                        {
                            throw new Exception(tb.Name + " must be a positive number! ");
                        }

                        foreach (DataGridViewRow row in dBook.Rows)
                        {
                            if (tb.Name == "txt_Id" && tb.Text == row.Cells["Id"].Value.ToString())
                            {
                                throw new Exception("Id must be unique!");
                            }
                        }
                        foreach (DataGridViewRow row in dGame.Rows)
                        {
                            if (tb.Name == "txt_Id" && tb.Text == row.Cells["Id"].Value.ToString())
                            {
                                throw new Exception("Id must be unique!");
                            }
                        }
                        foreach (DataGridViewRow row in dFilm.Rows)
                        {
                            if (tb.Name == "txt_Id" && tb.Text == row.Cells["Id"].Value.ToString())
                            {
                                throw new Exception("Id must be unique!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
            }
            return true;
        }
        private void btn_gameCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }        
    }
}
