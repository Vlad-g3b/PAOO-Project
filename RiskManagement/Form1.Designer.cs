
using System;

namespace RiskManagement
{
    partial class main
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
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unelteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainInterface = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.verticalMenu = new System.Windows.Forms.MenuStrip();
            this.identificareBunuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificareAmenintariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificareVulnerabilitatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificareaRiscuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tratareRiscuriSiIdentificareContramasuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainInterface)).BeginInit();
            this.mainInterface.Panel1.SuspendLayout();
            this.mainInterface.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.verticalMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.editareToolStripMenuItem,
            this.vizualizareToolStripMenuItem,
            this.unelteToolStripMenuItem,
            this.ajutorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1643, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editareToolStripMenuItem.Text = "Editare";
            // 
            // vizualizareToolStripMenuItem
            // 
            this.vizualizareToolStripMenuItem.Name = "vizualizareToolStripMenuItem";
            this.vizualizareToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.vizualizareToolStripMenuItem.Text = "Vizualizare";
            // 
            // unelteToolStripMenuItem
            // 
            this.unelteToolStripMenuItem.Name = "unelteToolStripMenuItem";
            this.unelteToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.unelteToolStripMenuItem.Text = "Unelte";
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mainInterface);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1643, 541);
            this.panel1.TabIndex = 2;
            // 
            // mainInterface
            // 
            this.mainInterface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainInterface.IsSplitterFixed = true;
            this.mainInterface.Location = new System.Drawing.Point(0, 0);
            this.mainInterface.Name = "mainInterface";
            // 
            // mainInterface.Panel1
            // 
            this.mainInterface.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.mainInterface.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.mainInterface.Size = new System.Drawing.Size(1641, 517);
            this.mainInterface.SplitterDistance = 289;
            this.mainInterface.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.verticalMenu, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 457F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 515);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(3, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(281, 49);
            this.title.TabIndex = 0;
            this.title.Text = "RiskIT";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // verticalMenu
            // 
            this.verticalMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verticalMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identificareBunuriToolStripMenuItem,
            this.identificareAmenintariToolStripMenuItem,
            this.identificareVulnerabilitatiToolStripMenuItem,
            this.identificareaRiscuriToolStripMenuItem,
            this.tratareRiscuriSiIdentificareContramasuriToolStripMenuItem});
            this.verticalMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.verticalMenu.Location = new System.Drawing.Point(0, 58);
            this.verticalMenu.MdiWindowListItem = this.identificareBunuriToolStripMenuItem;
            this.verticalMenu.Name = "verticalMenu";
            this.verticalMenu.Size = new System.Drawing.Size(287, 192);
            this.verticalMenu.TabIndex = 1;
            this.verticalMenu.Text = "menuStrip2";
            // 
            // identificareBunuriToolStripMenuItem
            // 
            this.identificareBunuriToolStripMenuItem.Name = "identificareBunuriToolStripMenuItem";
            this.identificareBunuriToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.identificareBunuriToolStripMenuItem.Size = new System.Drawing.Size(280, 33);
            this.identificareBunuriToolStripMenuItem.Text = "Identificare bunuri";
            // 
            // identificareAmenintariToolStripMenuItem
            // 
            this.identificareAmenintariToolStripMenuItem.Name = "identificareAmenintariToolStripMenuItem";
            this.identificareAmenintariToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.identificareAmenintariToolStripMenuItem.Size = new System.Drawing.Size(280, 33);
            this.identificareAmenintariToolStripMenuItem.Text = "Identificare amenintari";
            // 
            // identificareVulnerabilitatiToolStripMenuItem
            // 
            this.identificareVulnerabilitatiToolStripMenuItem.Name = "identificareVulnerabilitatiToolStripMenuItem";
            this.identificareVulnerabilitatiToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.identificareVulnerabilitatiToolStripMenuItem.Size = new System.Drawing.Size(280, 33);
            this.identificareVulnerabilitatiToolStripMenuItem.Text = "Identificare vulnerabilitati";
            // 
            // identificareaRiscuriToolStripMenuItem
            // 
            this.identificareaRiscuriToolStripMenuItem.Name = "identificareaRiscuriToolStripMenuItem";
            this.identificareaRiscuriToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.identificareaRiscuriToolStripMenuItem.Size = new System.Drawing.Size(280, 33);
            this.identificareaRiscuriToolStripMenuItem.Text = "Identificarea riscuri";
            // 
            // tratareRiscuriSiIdentificareContramasuriToolStripMenuItem
            // 
            this.tratareRiscuriSiIdentificareContramasuriToolStripMenuItem.Name = "tratareRiscuriSiIdentificareContramasuriToolStripMenuItem";
            this.tratareRiscuriSiIdentificareContramasuriToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.tratareRiscuriSiIdentificareContramasuriToolStripMenuItem.Size = new System.Drawing.Size(280, 54);
            this.tratareRiscuriSiIdentificareContramasuriToolStripMenuItem.Text = "Tratare riscuri si\r\n identificare contramasuri";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1641, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel1.Text = "Insert Name here";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 9);
            this.panel2.TabIndex = 2;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1643, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Text = "RiskIT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainInterface.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainInterface)).EndInit();
            this.mainInterface.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.verticalMenu.ResumeLayout(false);
            this.verticalMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unelteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer mainInterface;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.MenuStrip verticalMenu;
        private System.Windows.Forms.ToolStripMenuItem identificareBunuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificareAmenintariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificareVulnerabilitatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificareaRiscuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tratareRiscuriSiIdentificareContramasuriToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
    }
}

