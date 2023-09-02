namespace Shop_Management
{
    partial class Order_Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_order = new System.Windows.Forms.ComboBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.btn_addToCart = new System.Windows.Forms.Button();
            this.DGV_display = new System.Windows.Forms.DataGridView();
            this.lbl_order = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.bunifuDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DGV_order = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_order)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_order);
            this.splitContainer1.Panel1.Controls.Add(this.txt_qty);
            this.splitContainer1.Panel1.Controls.Add(this.btn_addToCart);
            this.splitContainer1.Panel1.Controls.Add(this.DGV_display);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_order);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_order);
            this.splitContainer1.Panel2.Controls.Add(this.bunifuDatepicker);
            this.splitContainer1.Panel2.Controls.Add(this.DGV_order);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 603);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1023, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Qty";
            // 
            // comboBox_order
            // 
            this.comboBox_order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_order.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_order.FormattingEnabled = true;
            this.comboBox_order.Items.AddRange(new object[] {
            "Book",
            "Game",
            "Film"});
            this.comboBox_order.Location = new System.Drawing.Point(1028, 57);
            this.comboBox_order.Name = "comboBox_order";
            this.comboBox_order.Size = new System.Drawing.Size(131, 46);
            this.comboBox_order.TabIndex = 17;
            this.comboBox_order.SelectedIndexChanged += new System.EventHandler(this.comboBox_order_SelectedIndexChanged);
            // 
            // txt_qty
            // 
            this.txt_qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_qty.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(1094, 144);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(65, 31);
            this.txt_qty.TabIndex = 26;
            // 
            // btn_addToCart
            // 
            this.btn_addToCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addToCart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_addToCart.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToCart.Location = new System.Drawing.Point(1028, 214);
            this.btn_addToCart.Name = "btn_addToCart";
            this.btn_addToCart.Size = new System.Drawing.Size(131, 84);
            this.btn_addToCart.TabIndex = 19;
            this.btn_addToCart.Text = "Add to cart";
            this.btn_addToCart.UseVisualStyleBackColor = false;
            this.btn_addToCart.Click += new System.EventHandler(this.btn_addToCart_Click);
            // 
            // DGV_display
            // 
            this.DGV_display.AllowUserToAddRows = false;
            this.DGV_display.AllowUserToDeleteRows = false;
            this.DGV_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_display.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_display.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_display.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_display.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_display.Location = new System.Drawing.Point(12, 57);
            this.DGV_display.MultiSelect = false;
            this.DGV_display.Name = "DGV_display";
            this.DGV_display.ReadOnly = true;
            this.DGV_display.RowHeadersWidth = 51;
            this.DGV_display.RowTemplate.Height = 24;
            this.DGV_display.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_display.Size = new System.Drawing.Size(972, 241);
            this.DGV_display.TabIndex = 18;
            // 
            // lbl_order
            // 
            this.lbl_order.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_order.AutoSize = true;
            this.lbl_order.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order.Location = new System.Drawing.Point(519, 9);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(115, 45);
            this.lbl_order.TabIndex = 16;
            this.lbl_order.Text = "Order";
            // 
            // btn_order
            // 
            this.btn_order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_order.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_order.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.Location = new System.Drawing.Point(685, 79);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(131, 57);
            this.btn_order.TabIndex = 28;
            this.btn_order.Text = "Order ";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // bunifuDatepicker
            // 
            this.bunifuDatepicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDatepicker.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bunifuDatepicker.BorderRadius = 0;
            this.bunifuDatepicker.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker.FormatCustom = null;
            this.bunifuDatepicker.Location = new System.Drawing.Point(685, 11);
            this.bunifuDatepicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker.Name = "bunifuDatepicker";
            this.bunifuDatepicker.Size = new System.Drawing.Size(202, 44);
            this.bunifuDatepicker.TabIndex = 25;
            this.bunifuDatepicker.Value = new System.DateTime(2022, 3, 28, 23, 6, 12, 915);
            // 
            // DGV_order
            // 
            this.DGV_order.AllowUserToAddRows = false;
            this.DGV_order.AllowUserToDeleteRows = false;
            this.DGV_order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_order.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_order.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_order.Location = new System.Drawing.Point(12, 11);
            this.DGV_order.MultiSelect = false;
            this.DGV_order.Name = "DGV_order";
            this.DGV_order.ReadOnly = true;
            this.DGV_order.RowHeadersWidth = 51;
            this.DGV_order.RowTemplate.Height = 24;
            this.DGV_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_order.Size = new System.Drawing.Size(649, 241);
            this.DGV_order.TabIndex = 20;
            // 
            // Order_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "Order_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Interface_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.ComboBox comboBox_order;
        private System.Windows.Forms.Button btn_addToCart;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_order;
        public System.Windows.Forms.DataGridView DGV_display;
        public System.Windows.Forms.DataGridView DGV_order;
        public System.Windows.Forms.TextBox txt_qty;
    }
}