using System;
using System.Linq;
using System.Windows.Forms;

namespace Shop_Management
{
    public partial class Warehouse_Interface : Form
    {
        ShopControl Myshop; //controller

        public BindingSource BookListSource, GameListSource, FilmListSource;
        public Warehouse_Interface()
        {
            InitializeComponent();

            BookListSource = new BindingSource();
            GameListSource = new BindingSource();
            FilmListSource = new BindingSource();

            //Skapa min kontroll och skicka med lagers vy som parameter
            Myshop = new ShopControl(this); 

            //Ladda upp alla data från mina filer till lagring vy
            Myshop.Upload("book.csv", DGV_book); 
            Myshop.Upload("game.csv", DGV_game);
            Myshop.Upload("film.csv", DGV_film);

            //Lägg till alla data till respektive lista
            Myshop.AddAllBooksToLista();
            BookListSource.DataSource = Myshop.Booklist;
            DGV_book.DataSource = BookListSource;

            Myshop.AddAllGameToLista();
            GameListSource.DataSource = Myshop.Gamelist;
            DGV_game.DataSource = GameListSource;

            Myshop.AddAllFilmToLista();
            FilmListSource.DataSource = Myshop.Filmlist;
            DGV_film.DataSource = FilmListSource;
        }

        public void Warehouse_Interface_Load(object sender, EventArgs e)
        {
            comboBox.SelectedIndex = 0;
            DGV_book.ClearSelection();
            DGV_game.ClearSelection();
            DGV_film.ClearSelection();
        }

        private void Warehouse_Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            DGV_book.DataSource = BookListSource;
            DGV_game.DataSource = GameListSource;
            DGV_film.DataSource = FilmListSource;

            //Vid avstängning av programmet så alla data sparas till filerna
            Myshop.SaveToFile("book.csv", DGV_book);
            Myshop.SaveToFile("game.csv", DGV_game);
            Myshop.SaveToFile("film.csv", DGV_film);
        }

        public void btn_productAdd_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem.ToString() == "Book")
            {
                Myshop.AddNewBook(); //Lägg till ny book
            }
            if (comboBox.SelectedItem.ToString() == "Game")
            {
                Myshop.AddNewGame(); //Lägg till ny game
            }
            if (comboBox.SelectedItem.ToString() == "Film")
            {
                Myshop.AddNewFilm(); //Lägg till ny film
            }
        }

        public void btn_productDelet_Click(object sender, EventArgs e)
        {
            if (DGV_book.SelectedRows.Count >= 1)
            {
                var bo = (Book)DGV_book.SelectedRows[0].DataBoundItem;
                if (Convert.ToInt32(bo.Quantity) > 0) //Om det finns tillräckligt kvantitet så produkten blir borttagen om användare svarar på yes
                {
                    DialogResult svar = MessageBox.Show("Are you sure?", "Delet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (svar == DialogResult.Yes)
                    {
                        BookListSource.Remove(bo);
                        Myshop.SaveToFile("book.csv", DGV_book); //Spara data till filerna
                        DGV_book.ClearSelection();
                    }
                }
            }

            if (DGV_game.SelectedRows.Count >= 1)
            {
                var ga = (Game)DGV_game.SelectedRows[0].DataBoundItem;
                if (Convert.ToInt32(ga.Quantity) > 0) //Om det finns tillräckligt kvantitet så produkten blir borttagen om användare svarar på yes
                {
                    DialogResult svar = MessageBox.Show("Are you sure?", "Delet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (svar == DialogResult.Yes)
                    {
                        GameListSource.Remove(ga);
                        Myshop.SaveToFile("game.csv", DGV_game); //Spara data till filerna
                        DGV_game.ClearSelection();
                    }
                }
            }

            if (DGV_film.SelectedRows.Count >= 1)
            {
                var fi = (Film)DGV_film.SelectedRows[0].DataBoundItem;
                if (Convert.ToInt32(fi.Quantity) > 0) //Om det finns tillräckligt kvantitet så produkten blir borttagen om användare svarar på yes
                {
                    DialogResult svar = MessageBox.Show("Are you sure?", "Delet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (svar == DialogResult.Yes)
                    {
                        FilmListSource.Remove(fi);
                        Myshop.SaveToFile("film.csv", DGV_film); //Spara data till filerna
                        DGV_film.ClearSelection();
                    }
                }
            }
        }

        public void btn_productLeverans_Click(object sender, EventArgs e)
        {
            if (DGV_book.SelectedRows.Count >= 1)
            {
                var bo = (Book)DGV_book.SelectedRows[0].DataBoundItem;
                bo.Quantity = bo.Quantity + 10; //Öka kvantitet med 10st om användaren klickar på Leverans knapp
                BookListSource.ResetCurrentItem();
                Myshop.SaveToFile("book.csv", DGV_book); //Spara data till filerna
                DGV_book.ClearSelection();
            }
            if (DGV_game.SelectedRows.Count >= 1)
            {
                var ga = (Game)DGV_game.SelectedRows[0].DataBoundItem;
                ga.Quantity = ga.Quantity + 10; //Öka kvantitet med 10st om användaren klickar på Leverans knapp
                GameListSource.ResetCurrentItem();
                Myshop.SaveToFile("game.csv", DGV_game); //Spara data till filerna
                DGV_game.ClearSelection();
            }
            if (DGV_film.SelectedRows.Count >= 1)
            {
                var fi = (Film)DGV_film.SelectedRows[0].DataBoundItem;
                fi.Quantity = fi.Quantity + 10; //Öka kvantitet med 10st om användaren klickar på Leverans knapp
                BookListSource.ResetCurrentItem();
                Myshop.SaveToFile("film.csv", DGV_film); //Spara data till filerna
                DGV_film.ClearSelection();
            }
        }

        private void btn_webData_Click(object sender, EventArgs e)
        {
            Myshop.WebBook();
            Myshop.WebGame();
            Myshop.WebMovie();

            DGV_book.ClearSelection();
            DGV_game.ClearSelection();
            DGV_film.ClearSelection();

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {        
            Myshop.Upload("book.csv", DGV_book);
            Myshop.Upload("game.csv", DGV_game);
            Myshop.Upload("film.csv", DGV_film);

            comboBox.SelectedIndex = 0;
            DGV_book.ClearSelection();
            DGV_game.ClearSelection();
            DGV_film.ClearSelection();
        }
        public void btn_toOrder_Click(object sender, EventArgs e)
        {
            Order_Interface c = new Order_Interface();
            c.Show();
        }
    }
}
