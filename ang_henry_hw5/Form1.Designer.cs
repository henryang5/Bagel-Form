namespace ang_henry_hw5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.bagelMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAndLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAndAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBagelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBagelTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.countBagelTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helkpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bagelListBox = new System.Windows.Forms.ListBox();
            this.bagelOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.titleLabel = new System.Windows.Forms.Label();
            this.bagelSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.bagelTextBox = new System.Windows.Forms.TextBox();
            this.bagelToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.fontColorContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fileDateStatusStrip = new System.Windows.Forms.StatusStrip();
            this.fileToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.spacesToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openLoadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openAddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addBagelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeBagelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.countBagelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearListToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.myColorDialog = new System.Windows.Forms.ColorDialog();
            this.myFontDialog = new System.Windows.Forms.FontDialog();
            this.bagelMenuStrip.SuspendLayout();
            this.bagelToolStrip.SuspendLayout();
            this.fontColorContextMenuStrip.SuspendLayout();
            this.fileDateStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bagelMenuStrip
            // 
            this.bagelMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageListToolStripMenuItem,
            this.helkpToolStripMenuItem});
            this.bagelMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.bagelMenuStrip.Name = "bagelMenuStrip";
            this.bagelMenuStrip.Size = new System.Drawing.Size(594, 24);
            this.bagelMenuStrip.TabIndex = 0;
            this.bagelMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAndLoadToolStripMenuItem,
            this.openAndAddToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "File ";
            // 
            // openAndLoadToolStripMenuItem
            // 
            this.openAndLoadToolStripMenuItem.Name = "openAndLoadToolStripMenuItem";
            this.openAndLoadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openAndLoadToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openAndLoadToolStripMenuItem.Text = "Open and Load ";
            this.openAndLoadToolStripMenuItem.Click += new System.EventHandler(this.openAndLoadToolStripMenuItem_Click);
            // 
            // openAndAddToolStripMenuItem
            // 
            this.openAndAddToolStripMenuItem.Name = "openAndAddToolStripMenuItem";
            this.openAndAddToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.openAndAddToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openAndAddToolStripMenuItem.Text = "Open and Add";
            this.openAndAddToolStripMenuItem.Click += new System.EventHandler(this.openAndAddToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageListToolStripMenuItem
            // 
            this.manageListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBagelTypeToolStripMenuItem,
            this.removeBagelTypeToolStripMenuItem,
            this.toolStripSeparator2,
            this.countBagelTypesToolStripMenuItem,
            this.toolStripSeparator3,
            this.clearListToolStripMenuItem});
            this.manageListToolStripMenuItem.Name = "manageListToolStripMenuItem";
            this.manageListToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.manageListToolStripMenuItem.Text = "Manage List";
            // 
            // addBagelTypeToolStripMenuItem
            // 
            this.addBagelTypeToolStripMenuItem.Name = "addBagelTypeToolStripMenuItem";
            this.addBagelTypeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addBagelTypeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addBagelTypeToolStripMenuItem.Text = "Add Bagel Type";
            this.addBagelTypeToolStripMenuItem.Click += new System.EventHandler(this.addBagelTypeToolStripMenuItem_Click);
            // 
            // removeBagelTypeToolStripMenuItem
            // 
            this.removeBagelTypeToolStripMenuItem.Name = "removeBagelTypeToolStripMenuItem";
            this.removeBagelTypeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.removeBagelTypeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.removeBagelTypeToolStripMenuItem.Text = "Remove Bagel Type";
            this.removeBagelTypeToolStripMenuItem.Click += new System.EventHandler(this.removeBagelTypeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // countBagelTypesToolStripMenuItem
            // 
            this.countBagelTypesToolStripMenuItem.Name = "countBagelTypesToolStripMenuItem";
            this.countBagelTypesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.countBagelTypesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.countBagelTypesToolStripMenuItem.Text = "Count Bagel Types";
            this.countBagelTypesToolStripMenuItem.Click += new System.EventHandler(this.countBagelTypesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(211, 6);
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // helkpToolStripMenuItem
            // 
            this.helkpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helkpToolStripMenuItem.Name = "helkpToolStripMenuItem";
            this.helkpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.helkpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helkpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // bagelListBox
            // 
            this.bagelListBox.FormattingEnabled = true;
            this.bagelListBox.Location = new System.Drawing.Point(37, 131);
            this.bagelListBox.Name = "bagelListBox";
            this.bagelListBox.Size = new System.Drawing.Size(257, 329);
            this.bagelListBox.TabIndex = 1;
            // 
            // bagelOpenFileDialog
            // 
            this.bagelOpenFileDialog.FileName = "openFileDialog1";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(132, 77);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 31);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Bobby\'s Beddar Bagel";
            // 
            // bagelTextBox
            // 
            this.bagelTextBox.Location = new System.Drawing.Point(338, 131);
            this.bagelTextBox.Name = "bagelTextBox";
            this.bagelTextBox.Size = new System.Drawing.Size(141, 20);
            this.bagelTextBox.TabIndex = 3;
            // 
            // bagelToolStrip
            // 
            this.bagelToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLoadToolStripButton,
            this.openAddToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator4,
            this.addBagelToolStripButton,
            this.removeBagelToolStripButton,
            this.countBagelToolStripButton,
            this.clearListToolStripButton,
            this.toolStripSeparator5,
            this.aboutToolStripButton});
            this.bagelToolStrip.Location = new System.Drawing.Point(0, 24);
            this.bagelToolStrip.Name = "bagelToolStrip";
            this.bagelToolStrip.Size = new System.Drawing.Size(594, 25);
            this.bagelToolStrip.TabIndex = 4;
            this.bagelToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // fontColorContextMenuStrip
            // 
            this.fontColorContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formBackgroundColorToolStripMenuItem,
            this.toolStripSeparator6,
            this.listFontToolStripMenuItem,
            this.listBackgroundColorToolStripMenuItem,
            this.listTextColorToolStripMenuItem});
            this.fontColorContextMenuStrip.Name = "ContextMenuStrip";
            this.fontColorContextMenuStrip.Size = new System.Drawing.Size(202, 120);
            // 
            // listFontToolStripMenuItem
            // 
            this.listFontToolStripMenuItem.Name = "listFontToolStripMenuItem";
            this.listFontToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listFontToolStripMenuItem.Text = "List Font ";
            this.listFontToolStripMenuItem.Click += new System.EventHandler(this.listFontToolStripMenuItem_Click);
            // 
            // listBackgroundColorToolStripMenuItem
            // 
            this.listBackgroundColorToolStripMenuItem.Name = "listBackgroundColorToolStripMenuItem";
            this.listBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listBackgroundColorToolStripMenuItem.Text = "List Background Color";
            this.listBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.listBackgroundColorToolStripMenuItem_Click);
            // 
            // listTextColorToolStripMenuItem
            // 
            this.listTextColorToolStripMenuItem.Name = "listTextColorToolStripMenuItem";
            this.listTextColorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listTextColorToolStripMenuItem.Text = "List Text Color";
            this.listTextColorToolStripMenuItem.Click += new System.EventHandler(this.listTextColorToolStripMenuItem_Click);
            // 
            // formBackgroundColorToolStripMenuItem
            // 
            this.formBackgroundColorToolStripMenuItem.Name = "formBackgroundColorToolStripMenuItem";
            this.formBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.formBackgroundColorToolStripMenuItem.Text = "Form Background Color";
            this.formBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.formBackgroundColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(198, 6);
            // 
            // fileDateStatusStrip
            // 
            this.fileDateStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripStatusLabel,
            this.spacesToolStripStatusLabel,
            this.dateToolStripStatusLabel});
            this.fileDateStatusStrip.Location = new System.Drawing.Point(0, 517);
            this.fileDateStatusStrip.Name = "fileDateStatusStrip";
            this.fileDateStatusStrip.Size = new System.Drawing.Size(594, 22);
            this.fileDateStatusStrip.TabIndex = 5;
            this.fileDateStatusStrip.Text = "statusStrip";
            // 
            // fileToolStripStatusLabel
            // 
            this.fileToolStripStatusLabel.Name = "fileToolStripStatusLabel";
            this.fileToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // dateToolStripStatusLabel
            // 
            this.dateToolStripStatusLabel.Name = "dateToolStripStatusLabel";
            this.dateToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // spacesToolStripStatusLabel
            // 
            this.spacesToolStripStatusLabel.Name = "spacesToolStripStatusLabel";
            this.spacesToolStripStatusLabel.Size = new System.Drawing.Size(579, 17);
            this.spacesToolStripStatusLabel.Spring = true;
            // 
            // openLoadToolStripButton
            // 
            this.openLoadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openLoadToolStripButton.Image = global::ang_henry_hw5.Properties.Resources.Open_6529_24;
            this.openLoadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openLoadToolStripButton.Name = "openLoadToolStripButton";
            this.openLoadToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openLoadToolStripButton.Text = "toolStripButton1";
            this.openLoadToolStripButton.ToolTipText = "Opens and Load File";
            this.openLoadToolStripButton.Click += new System.EventHandler(this.openLoadToolStripButton_Click);
            // 
            // openAddToolStripButton
            // 
            this.openAddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openAddToolStripButton.Image = global::ang_henry_hw5.Properties.Resources.Open_6529;
            this.openAddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openAddToolStripButton.Name = "openAddToolStripButton";
            this.openAddToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openAddToolStripButton.Text = "toolStripButton2";
            this.openAddToolStripButton.ToolTipText = "Open and add a file";
            this.openAddToolStripButton.Click += new System.EventHandler(this.openAddToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::ang_henry_hw5.Properties.Resources.save;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "toolStripButton1";
            this.saveToolStripButton.ToolTipText = "Save File";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // addBagelToolStripButton
            // 
            this.addBagelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addBagelToolStripButton.Image = global::ang_henry_hw5.Properties.Resources.AddTable_5632_321;
            this.addBagelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBagelToolStripButton.Name = "addBagelToolStripButton";
            this.addBagelToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addBagelToolStripButton.Text = "toolStripButton1";
            this.addBagelToolStripButton.ToolTipText = "Add bagel to list";
            this.addBagelToolStripButton.Click += new System.EventHandler(this.addBagelToolStripButton_Click);
            // 
            // removeBagelToolStripButton
            // 
            this.removeBagelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeBagelToolStripButton.Image = global::ang_henry_hw5.Properties.Resources.DeleteTablefromDatabase_270_32;
            this.removeBagelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeBagelToolStripButton.Name = "removeBagelToolStripButton";
            this.removeBagelToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.removeBagelToolStripButton.Text = "toolStripButton1";
            this.removeBagelToolStripButton.ToolTipText = "Remove bagel from list";
            this.removeBagelToolStripButton.Click += new System.EventHandler(this.removeBagelToolStripButton_Click);
            // 
            // countBagelToolStripButton
            // 
            this.countBagelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countBagelToolStripButton.Image = global::ang_henry_hw5.Properties.Resources.FindResults1_6264;
            this.countBagelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.countBagelToolStripButton.Name = "countBagelToolStripButton";
            this.countBagelToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.countBagelToolStripButton.Text = "toolStripButton2";
            this.countBagelToolStripButton.ToolTipText = "Count number of bagels";
            this.countBagelToolStripButton.Click += new System.EventHandler(this.countBagelToolStripButton_Click);
            // 
            // clearListToolStripButton
            // 
            this.clearListToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearListToolStripButton.Image = global::ang_henry_hw5.Properties.Resources.delete;
            this.clearListToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearListToolStripButton.Name = "clearListToolStripButton";
            this.clearListToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.clearListToolStripButton.Text = "toolStripButton3";
            this.clearListToolStripButton.ToolTipText = "Clear bagel list";
            this.clearListToolStripButton.Click += new System.EventHandler(this.clearListToolStripButton_Click);
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutToolStripButton.Image = global::ang_henry_hw5.Properties.Resources.InfoTooltip_16x;
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.aboutToolStripButton.Text = "toolStripButton1";
            this.aboutToolStripButton.ToolTipText = "Open an about form";
            this.aboutToolStripButton.Click += new System.EventHandler(this.aboutToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 539);
            this.ContextMenuStrip = this.fontColorContextMenuStrip;
            this.Controls.Add(this.fileDateStatusStrip);
            this.Controls.Add(this.bagelToolStrip);
            this.Controls.Add(this.bagelTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.bagelListBox);
            this.Controls.Add(this.bagelMenuStrip);
            this.MainMenuStrip = this.bagelMenuStrip;
            this.Name = "Form1";
            this.Text = "Homework 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bagelMenuStrip.ResumeLayout(false);
            this.bagelMenuStrip.PerformLayout();
            this.bagelToolStrip.ResumeLayout(false);
            this.bagelToolStrip.PerformLayout();
            this.fontColorContextMenuStrip.ResumeLayout(false);
            this.fileDateStatusStrip.ResumeLayout(false);
            this.fileDateStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip bagelMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAndLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAndAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBagelTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBagelTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem countBagelTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helkpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox bagelListBox;
        private System.Windows.Forms.OpenFileDialog bagelOpenFileDialog;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.SaveFileDialog bagelSaveFileDialog;
        private System.Windows.Forms.TextBox bagelTextBox;
        private System.Windows.Forms.ToolStrip bagelToolStrip;
        private System.Windows.Forms.ToolStripButton openLoadToolStripButton;
        private System.Windows.Forms.ToolStripButton openAddToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton addBagelToolStripButton;
        private System.Windows.Forms.ToolStripButton removeBagelToolStripButton;
        private System.Windows.Forms.ToolStripButton countBagelToolStripButton;
        private System.Windows.Forms.ToolStripButton clearListToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton aboutToolStripButton;
        private System.Windows.Forms.ContextMenuStrip fontColorContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem listFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listTextColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.StatusStrip fileDateStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel fileToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel dateToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel spacesToolStripStatusLabel;
        private System.Windows.Forms.ColorDialog myColorDialog;
        private System.Windows.Forms.FontDialog myFontDialog;
    }
}

