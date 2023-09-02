namespace Shop_Management
{
    partial class Warehouse_Interface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_productAdd = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btn_webData = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btn_toOrder = new System.Windows.Forms.Button();
            this.btn_productLeverans = new System.Windows.Forms.Button();
            this.btn_productDelet = new System.Windows.Forms.Button();
            this.DSD = new System.Windows.Forms.Label();
            this.DGV_book = new System.Windows.Forms.DataGridView();
            this.DGV_game = new System.Windows.Forms.DataGridView();
            this.lbl_warehouse = new System.Windows.Forms.Label();
            this.DGV_film = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_game)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_film)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_productAdd
            // 
            this.btn_productAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_productAdd.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_productAdd.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productAdd.Location = new System.Drawing.Point(11, 158);
            this.btn_productAdd.Name = "btn_productAdd";
            this.btn_productAdd.Size = new System.Drawing.Size(253, 50);
            this.btn_productAdd.TabIndex = 0;
            this.btn_productAdd.Text = "Add";
            this.btn_productAdd.UseVisualStyleBackColor = false;
            this.btn_productAdd.Click += new System.EventHandler(this.btn_productAdd_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btn_webData);
            this.splitContainer.Panel1.Controls.Add(this.btn_refresh);
            this.splitContainer.Panel1.Controls.Add(this.comboBox);
            this.splitContainer.Panel1.Controls.Add(this.btn_toOrder);
            this.splitContainer.Panel1.Controls.Add(this.btn_productLeverans);
            this.splitContainer.Panel1.Controls.Add(this.btn_productDelet);
            this.splitContainer.Panel1.Controls.Add(this.DSD);
            this.splitContainer.Panel1.Controls.Add(this.btn_productAdd);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.DGV_book);
            this.splitContainer.Panel2.Controls.Add(this.DGV_game);
            this.splitContainer.Panel2.Controls.Add(this.lbl_warehouse);
            this.splitContainer.Panel2.Controls.Add(this.DGV_film);
            this.splitContainer.Size = new System.Drawing.Size(1182, 853);
            this.splitContainer.SplitterDistance = 288;
            this.splitContainer.TabIndex = 1;
            // 
            // btn_webData
            // 
            this.btn_webData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_webData.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_webData.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_webData.Location = new System.Drawing.Point(11, 386);
            this.btn_webData.Name = "btn_webData";
            this.btn_webData.Size = new System.Drawing.Size(253, 50);
            this.btn_webData.TabIndex = 17;
            this.btn_webData.Text = "Add Web Data";
            this.btn_webData.UseVisualStyleBackColor = false;
            this.btn_webData.Click += new System.EventHandler(this.btn_webData_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_refresh.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(18, 669);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(131, 50);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Refresh ";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Book",
            "Game",
            "Film"});
            this.comboBox.Location = new System.Drawing.Point(144, 79);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(120, 46);
            this.comboBox.TabIndex = 15;
            // 
            // btn_toOrder
            // 
            this.btn_toOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_toOrder.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_toOrder.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_toOrder.Location = new System.Drawing.Point(18, 750);
            this.btn_toOrder.Name = "btn_toOrder";
            this.btn_toOrder.Size = new System.Drawing.Size(261, 71);
            this.btn_toOrder.TabIndex = 14;
            this.btn_toOrder.Text = "To Order Page";
            this.btn_toOrder.UseVisualStyleBackColor = false;
            this.btn_toOrder.Click += new System.EventHandler(this.btn_toOrder_Click);
            // 
            // btn_productLeverans
            // 
            this.btn_productLeverans.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_productLeverans.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productLeverans.Location = new System.Drawing.Point(11, 233);
            this.btn_productLeverans.Name = "btn_productLeverans";
            this.btn_productLeverans.Size = new System.Drawing.Size(131, 50);
            this.btn_productLeverans.TabIndex = 13;
            this.btn_productLeverans.Text = "Leverans";
            this.btn_productLeverans.UseVisualStyleBackColor = false;
            this.btn_productLeverans.Click += new System.EventHandler(this.btn_productLeverans_Click);
            // 
            // btn_productDelet
            // 
            this.btn_productDelet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_productDelet.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_productDelet.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productDelet.Location = new System.Drawing.Point(162, 233);
            this.btn_productDelet.Name = "btn_productDelet";
            this.btn_productDelet.Size = new System.Drawing.Size(102, 50);
            this.btn_productDelet.TabIndex = 12;
            this.btn_productDelet.Text = "Delete";
            this.btn_productDelet.UseVisualStyleBackColor = false;
            this.btn_productDelet.Click += new System.EventHandler(this.btn_productDelet_Click);
            // 
            // DSD
            // 
            this.DSD.AutoSize = true;
            this.DSD.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSD.Location = new System.Drawing.Point(7, 88);
            this.DSD.Name = "DSD";
            this.DSD.Size = new System.Drawing.Size(110, 31);
            this.DSD.TabIndex = 11;
            this.DSD.Text = "Category";
            // 
            // DGV_book
            // 
            this.DGV_book.AllowUserToAddRows = false;
            this.DGV_book.AllowUserToDeleteRows = false;
            this.DGV_book.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_book.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_book.DefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_book.Location = new System.Drawing.Point(3, 79);
            this.DGV_book.MultiSelect = false;
            this.DGV_book.Name = "DGV_book";
            this.DGV_book.ReadOnly = true;
            this.DGV_book.RowHeadersWidth = 51;
            this.DGV_book.RowTemplate.Height = 24;
            this.DGV_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_book.Size = new System.Drawing.Size(875, 230);
            this.DGV_book.TabIndex = 17;
            // 
            // DGV_game
            // 
            this.DGV_game.AllowUserToAddRows = false;
            this.DGV_game.AllowUserToDeleteRows = false;
            this.DGV_game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_game.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_game.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_game.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_game.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_game.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_game.Location = new System.Drawing.Point(3, 335);
            this.DGV_game.MultiSelect = false;
            this.DGV_game.Name = "DGV_game";
            this.DGV_game.ReadOnly = true;
            this.DGV_game.RowHeadersWidth = 51;
            this.DGV_game.RowTemplate.Height = 24;
            this.DGV_game.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_game.Size = new System.Drawing.Size(875, 230);
            this.DGV_game.TabIndex = 16;
            // 
            // lbl_warehouse
            // 
            this.lbl_warehouse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_warehouse.AutoSize = true;
            this.lbl_warehouse.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warehouse.Location = new System.Drawing.Point(343, 9);
            this.lbl_warehouse.Name = "lbl_warehouse";
            this.lbl_warehouse.Size = new System.Drawing.Size(193, 45);
            this.lbl_warehouse.TabIndex = 15;
            this.lbl_warehouse.Text = "Warehouse";
            // 
            // DGV_film
            // 
            this.DGV_film.AllowUserToAddRows = false;
            this.DGV_film.AllowUserToDeleteRows = false;
            this.DGV_film.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_film.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_film.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_film.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_film.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_film.Location = new System.Drawing.Point(3, 591);
            this.DGV_film.MultiSelect = false;
            this.DGV_film.Name = "DGV_film";
            this.DGV_film.ReadOnly = true;
            this.DGV_film.RowHeadersWidth = 51;
            this.DGV_film.RowTemplate.Height = 24;
            this.DGV_film.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_film.Size = new System.Drawing.Size(875, 230);
            this.DGV_film.TabIndex = 0;
            // 
            // Warehouse_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "Warehouse_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Warehouse_Interface_FormClosing);
            this.Load += new System.EventHandler(this.Warehouse_Interface_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_game)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_film)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_productAdd;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label DSD;
        private System.Windows.Forms.Button btn_toOrder;
        private System.Windows.Forms.Button btn_productLeverans;
        private System.Windows.Forms.Button btn_productDelet;
        private System.Windows.Forms.Label lbl_warehouse;
        private System.Windows.Forms.ComboBox comboBox;
        public System.Windows.Forms.DataGridView DGV_book;
        public System.Windows.Forms.DataGridView DGV_film;
        public System.Windows.Forms.DataGridView DGV_game;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_webData;
    }
}

