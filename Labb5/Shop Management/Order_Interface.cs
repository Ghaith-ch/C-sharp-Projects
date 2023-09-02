using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Shop_Management
{
    public partial class Order_Interface : Form
    {
        ShopControl Myshop;
        DataTable dt;
        BindingList<Order> Orderlist;
        Warehouse_Interface warehouse; 
        public Order_Interface()
        {
            InitializeComponent();
            Myshop = new ShopControl(this.warehouse);
            dt = new DataTable();
            Orderlist = new BindingList<Order>();

            Myshop.Upload("book.csv", DGV_display);
            DGV_display.ClearSelection();
        }
        private void Order_Interface_Load(object sender, EventArgs e) 
        {
            comboBox_order.SelectedIndex = 0;           
            string[] array = new string[] { "ItemNum", "ProdNum", "Quantity", "PriceOfPiece", "Total" };
            for (int i = 0; i < 5; i++)
            {
                DataColumn column = new DataColumn(); //Skapa datatable med några Kolumner
                column.ColumnName = array[i];
                dt.Columns.Add(column);
            }
            DataView view = new DataView(dt); 
            DGV_order.DataSource = view;        //tilldela datatable till min datagridview
        }

        private void comboBox_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_order.SelectedIndex == 1)
            {
                Myshop.Upload("game.csv", DGV_display);
                DGV_display.ClearSelection();
            }

            else if (comboBox_order.SelectedIndex == 2)
            {
                Myshop.Upload("film.csv", DGV_display);
                DGV_display.ClearSelection();
            }
            else
            {
                Myshop.Upload("book.csv", DGV_display);
                DGV_display.ClearSelection();
            }
        }

        int itemNum = 0;
        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            if (CheckAddToShoppingCart() == true) //Om en funktion retunerar true så det betyder att alla vilkor är uppfyllda
            {
                itemNum = itemNum + 1;
                string prodName = DGV_display.SelectedRows[0].Cells[1].Value.ToString();
                int quantity = int.Parse(txt_qty.Text);
                int price = Convert.ToInt32(DGV_display.SelectedRows[0].Cells[3].Value);
                int total = quantity * price;

                DataRow row = dt.NewRow();  
                row["ItemNum"] = itemNum;
                row["ProdNum"] = prodName;
                row["Quantity"] = quantity;
                row["PriceOfPiece"] = price;
                row["Total"] = total;

                dt.Rows.Add(row); //Lägga till en ny rad till min datatable 
                DGV_order.ClearSelection();

                int currentValue = Convert.ToInt32(DGV_display.SelectedRows[0].Cells[2].Value);
                int newValue = currentValue - quantity;
                DGV_display.SelectedRows[0].Cells[2].Value = newValue;
            }
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            Order or = new Order(); //ny order en instanse of orderclass
            Random rn = new Random();
            foreach (Order order in Orderlist) //För att få unika id
            {
                if (order.Id == rn.Next(1, 1000))
                {
                    rn.Next(1, 1000);
                }
            }
            or.Id = rn.Next(1, 1000);
            or.date = bunifuDatepicker.Value.ToString();
            or.Numberofitems = dt.Rows.Count;
            int counter = 0;
            foreach (DataRow row in dt.Rows)
            {
                counter = counter + Convert.ToInt32(row["Total"]);
            }
            or.Total = counter;
            Orderlist.Add(or);

            MessageBox.Show("your order has been received\n" + "Your orderId is: " + or.Id + "\nDate of Order is : " + or.date);

            dt.AcceptChanges();
            foreach (DataRow row in dt.Rows)
            {
                row.Delete();
            }
            dt.AcceptChanges();

            if (comboBox_order.SelectedIndex == 1)
            {
                Myshop.SaveToFile("game.csv", DGV_display);
            }
            else if (comboBox_order.SelectedIndex == 2)
            {
                Myshop.SaveToFile("film.csv", DGV_display);
            }
            else
            {
                Myshop.SaveToFile("book.csv", DGV_display);
            }
        }
        public bool CheckAddToShoppingCart() //En funktion för att göra mina kontroller innan att lägga till den selectade produkt till varukorg
        {
            try
            {
                if (DGV_display.SelectedRows.Count < 1)
                {
                    throw new Exception("Select a row!");
                }

                int qty = Convert.ToInt32(DGV_display.SelectedRows[0].Cells[2].Value);

                if (qty < 1)
                {
                    throw new Exception("Selected item is out of stock !");
                }

                if (string.IsNullOrEmpty(txt_qty.Text))
                {
                    throw new Exception("Write the quantity!");
                }

                if (qty < int.Parse(txt_qty.Text))
                {
                    throw new Exception("We do not have all the quantity you want!");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

   
    }
}
