namespace Notepad
{
    partial class Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuÖppna = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSpara = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSparaSom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuAvsluta = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.AntRad = new System.Windows.Forms.ToolStripStatusLabel();
            this.AntOrd = new System.Windows.Forms.ToolStripStatusLabel();
            this.AntTecken = new System.Windows.Forms.ToolStripStatusLabel();
            this.AntTeckenMedMellanslag = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNy,
            this.MenuÖppna,
            this.MenuSpara,
            this.MenuSparaSom,
            this.toolStripMenuItem1,
            this.MenuAvsluta});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(46, 24);
            this.MenuFile.Text = "File";
            // 
            // MenuNy
            // 
            this.MenuNy.Name = "MenuNy";
            this.MenuNy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuNy.Size = new System.Drawing.Size(252, 26);
            this.MenuNy.Text = "Ny";
            this.MenuNy.Click += new System.EventHandler(this.MenuNy_Click);
            // 
            // MenuÖppna
            // 
            this.MenuÖppna.Name = "MenuÖppna";
            this.MenuÖppna.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuÖppna.Size = new System.Drawing.Size(252, 26);
            this.MenuÖppna.Text = "Öppna";
            this.MenuÖppna.Click += new System.EventHandler(this.MenuÖppna_Click);
            // 
            // MenuSpara
            // 
            this.MenuSpara.Name = "MenuSpara";
            this.MenuSpara.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSpara.Size = new System.Drawing.Size(252, 26);
            this.MenuSpara.Text = "Spara";
            this.MenuSpara.Click += new System.EventHandler(this.MenuSpara_Click);
            // 
            // MenuSparaSom
            // 
            this.MenuSparaSom.Name = "MenuSparaSom";
            this.MenuSparaSom.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuSparaSom.Size = new System.Drawing.Size(252, 26);
            this.MenuSparaSom.Text = "Spara som";
            this.MenuSparaSom.Click += new System.EventHandler(this.MenuSparaSom_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 6);
            // 
            // MenuAvsluta
            // 
            this.MenuAvsluta.Name = "MenuAvsluta";
            this.MenuAvsluta.Size = new System.Drawing.Size(252, 26);
            this.MenuAvsluta.Text = "Avsluta";
            this.MenuAvsluta.Click += new System.EventHandler(this.MenuAvsluta_Click);
            // 
            // txtBox
            // 
            this.txtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(0, 31);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(882, 432);
            this.txtBox.TabIndex = 3;
            this.txtBox.Text = "";
            this.txtBox.TextChanged += new System.EventHandler(this.TxtBox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save as";
            // 
            // AntRad
            // 
            this.AntRad.Margin = new System.Windows.Forms.Padding(15, 4, 0, 4);
            this.AntRad.Name = "AntRad";
            this.AntRad.Size = new System.Drawing.Size(39, 23);
            this.AntRad.Text = "Rad";
            // 
            // AntOrd
            // 
            this.AntOrd.Margin = new System.Windows.Forms.Padding(15, 4, 0, 4);
            this.AntOrd.Name = "AntOrd";
            this.AntOrd.Size = new System.Drawing.Size(39, 23);
            this.AntOrd.Text = "Ord";
            // 
            // AntTecken
            // 
            this.AntTecken.Margin = new System.Windows.Forms.Padding(15, 4, 0, 4);
            this.AntTecken.Name = "AntTecken";
            this.AntTecken.Size = new System.Drawing.Size(61, 23);
            this.AntTecken.Text = "Tecken";
            // 
            // AntTeckenMedMellanslag
            // 
            this.AntTeckenMedMellanslag.Margin = new System.Windows.Forms.Padding(15, 4, 0, 4);
            this.AntTeckenMedMellanslag.Name = "AntTeckenMedMellanslag";
            this.AntTeckenMedMellanslag.Size = new System.Drawing.Size(176, 23);
            this.AntTeckenMedMellanslag.Text = "TeckenMedMellanslag";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AntRad,
            this.AntOrd,
            this.AntTecken,
            this.AntTeckenMedMellanslag});
            this.statusStrip.Location = new System.Drawing.Point(0, 422);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(882, 31);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuNy;
        private System.Windows.Forms.ToolStripMenuItem MenuÖppna;
        private System.Windows.Forms.ToolStripMenuItem MenuSpara;
        private System.Windows.Forms.ToolStripMenuItem MenuSparaSom;
        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuAvsluta;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel AntRad;
        private System.Windows.Forms.ToolStripStatusLabel AntOrd;
        private System.Windows.Forms.ToolStripStatusLabel AntTecken;
        private System.Windows.Forms.ToolStripStatusLabel AntTeckenMedMellanslag;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}

