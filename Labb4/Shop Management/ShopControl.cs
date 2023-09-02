using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management
{
    class ShopControl
    {
        public BindingList<Book> Booklist { get; private set; } //Skapa listorna
        public BindingList<Game> Gamelist { get; private set; }
        public BindingList<Film> Filmlist { get; private set; }

        private Warehouse_Interface mywarehouse; //Skapa instance av lagers vy

        public ShopControl(Warehouse_Interface warehouse)
        {
            Booklist = new BindingList<Book>();
            Gamelist = new BindingList<Game>();
            Filmlist = new BindingList<Film>();

            mywarehouse = warehouse;
        }

        //Upload funktion är en funktion som jag inte har skapat utan hämtad från nätet och anpassat den för mitt program (länken finns i rapporten så klart)
        public void Upload(string filNamn, DataGridView dataGridView) 
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filNamn);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        try
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        catch
                        {
                            MessageBox.Show("Fel med att ladda upp filerna!");
                        }
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView.DataSource = dt;
            }
        }

        //SaveToFile funktion är en funktion som jag inte har skapat utan hämtad från nätet och anpassat den för mitt program (länken finns i rapporten så klart)
        public void SaveToFile(string fileNamn, DataGridView dataGridView)
        {
            int columnCount = dataGridView.Columns.Count;
            string columnNames = "";
            string[] outputCsv = new string[dataGridView.Rows.Count + 1];
            for (int i = 0; i < columnCount; i++)
            {
                columnNames += dataGridView.Columns[i].HeaderText.ToString() + ",";
            }
            columnNames = columnNames.Remove(columnNames.Length - 1);
            outputCsv[0] += columnNames;

            for (int i = 1; (i - 1) < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    outputCsv[i] += dataGridView.Rows[i - 1].Cells[j].Value.ToString() + ",";
                }
            }
            File.WriteAllLines(fileNamn, outputCsv, Encoding.UTF8);          
        }

        public void AddAllBooksToLista() //En funktion som används för att lägga till alla böcker till min booklista
        {
            string[] my = new string[8];
            int j;

            for (int i = 0; i < mywarehouse.DGV_book.Rows.Count; i++)
            {
                Book n = new Book();

                j = 0;
                while (j < 8)
                {
                    my[j] = mywarehouse.DGV_book.Rows[i].Cells[j].Value.ToString();
                    j++;
                }
                n.Id = Convert.ToInt32(my[0]);
                n.Name = my[1];
                n.Quantity = Convert.ToInt32(my[2]);
                n.Price = Convert.ToDouble(my[3]);
                n.Author = my[4];
                n.Genre = my[5];
                n.Format = my[6];
                n.Language = my[7];

                Booklist.Add(n);
            }
        }
        public void AddAllGameToLista() //En funktion som används för att lägga till alla spelar till min gamelista
        {
            string[] my = new string[5];
            int j;

            for (int i = 0; i < mywarehouse.DGV_game.Rows.Count; i++)
            {
                Game n = new Game();

                j = 0;
                while (j < 5)
                {
                    my[j] = mywarehouse.DGV_game.Rows[i].Cells[j].Value.ToString();
                    j++;
                }
                n.Id = Convert.ToInt32(my[0]);
                n.Name = my[1];
                n.Quantity = Convert.ToInt32(my[2]);
                n.Price = Convert.ToDouble(my[3]);
                n.Plateform = my[4];

                Gamelist.Add(n);
            }
        }
        public void AddAllFilmToLista() //En funktion som används för att lägga till alla filmer till min filmlista
        {
            string[] my = new string[6];
            int j;

            for (int i = 0; i < mywarehouse.DGV_film.Rows.Count; i++)
            {
                Film n = new Film();

                j = 0;
                while (j < 6)
                {
                    my[j] = mywarehouse.DGV_film.Rows[i].Cells[j].Value.ToString();
                    j++;
                }
                n.Id = Convert.ToInt32(my[0]);
                n.Name = my[1];
                n.Quantity = Convert.ToInt32(my[2]);
                n.Price = Convert.ToDouble(my[3]);
                n.Format = my[4];
                n.Time = Convert.ToDouble(my[5]);

                Filmlist.Add(n);
            }
        }

        public void AddNewBook() //En funktion som används för att lägga till ny book
        {
            AddBookForm add = new AddBookForm(mywarehouse.DGV_book,mywarehouse.DGV_game,mywarehouse.DGV_film);
            if (add.ShowDialog() == DialogResult.OK)
            {
                mywarehouse.BookListSource.Add(add.newbook);
                SaveToFile("book.csv", mywarehouse.DGV_book);
            }
        }
        public void AddNewGame() //En funktion som används för att lägga till ny game
        {
            AddGameForm add = new AddGameForm(mywarehouse.DGV_book, mywarehouse.DGV_game, mywarehouse.DGV_film);
            if (add.ShowDialog() == DialogResult.OK)
            {
                mywarehouse.GameListSource.Add(add.newgame);
                SaveToFile("game.csv", mywarehouse.DGV_game);
            }
        }
        public void AddNewFilm() //En funktion som används för att lägga till ny film
        {
            AddFilmForm add = new AddFilmForm(mywarehouse.DGV_book, mywarehouse.DGV_game, mywarehouse.DGV_film);
            if (add.ShowDialog() == DialogResult.OK)
            {
                mywarehouse.FilmListSource.Add(add.newfilm);
                SaveToFile("film.csv", mywarehouse.DGV_film);
            }
        }
    }

}
