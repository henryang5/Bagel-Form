using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace ang_henry_hw5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openAndLoad()
        {
            StreamReader bagelSteam;
            string bagelName;

            bagelOpenFileDialog.Filter = "Text file (*.txt)|*.txt|All File(*.)|*.*";
            bagelOpenFileDialog.InitialDirectory = "C:\\Resources";
            bagelOpenFileDialog.Title = "Select File to Open";

            bagelListBox.Items.Clear();  // delete current bagels from list box 

            try
            {
                if (bagelOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bagelSteam = File.OpenText(bagelOpenFileDialog.FileName);
                    fileToolStripStatusLabel.Text = bagelOpenFileDialog.FileName.ToString();
                    if (new FileInfo(bagelOpenFileDialog.FileName).Length == 0)
                    {
                        MessageBox.Show("File is empty.", "Empty file Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        while (bagelSteam.EndOfStream == false)
                        {
                            bagelName = bagelSteam.ReadLine();
                            if (!bagelListBox.Items.Contains(bagelName))
                            {
                                bagelListBox.Items.Add(bagelName);
                            }
                        }
                        bagelListBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    return;
                }
                bagelSteam.Close();
            }
            catch (Exception fileEx)
            {
                MessageBox.Show(bagelOpenFileDialog.FileName, fileEx.Message, MessageBoxButtons.OK);
            }
        }
        private void openAndLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAndLoad(); 
        }

        private void openAndAdd()
        {
            StreamReader bagelSteam;
            string bagelName;

            bagelOpenFileDialog.Filter = "Text file (*.txt)|*.txt|All File(*.)|*.*";
            bagelOpenFileDialog.InitialDirectory = "C:\\Resources";
            bagelOpenFileDialog.Title = "Select File to Open";

            try
            {
                if (bagelOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bagelSteam = File.OpenText(bagelOpenFileDialog.FileName);
                    fileToolStripStatusLabel.Text = bagelOpenFileDialog.FileName.ToString();
                    if (new FileInfo(bagelOpenFileDialog.FileName).Length == 0)
                    {
                        MessageBox.Show("File is empty.", "Empty file Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        while (bagelSteam.EndOfStream == false)
                        {
                            bagelName = bagelSteam.ReadLine();
                            if (!bagelListBox.Items.Contains(bagelName))
                            {
                                bagelListBox.Items.Add(bagelName);
                            }
                        }
                        bagelListBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    return;
                }
                bagelSteam.Close();
            }
            catch (Exception fileEx)
            {
                MessageBox.Show(bagelOpenFileDialog.FileName, fileEx.Message, MessageBoxButtons.OK);
            }
        }

        private void openAndAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAndAdd();
        }

        private void saveFile()
        {
            StreamWriter saveSteam;
            int i;

            bagelSaveFileDialog.Filter = "Text file (*.txt)|*.txt|All File(*.)|*.*";
            bagelSaveFileDialog.InitialDirectory = "C:\\Resoures";
            bagelSaveFileDialog.Title = "Select File to Open";

            if (bagelListBox.Items.Count == 0)
            {
                MessageBox.Show("Bagel list is empty.", "Empty List Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    if (bagelSaveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        saveSteam = File.CreateText(bagelSaveFileDialog.FileName);
                        fileToolStripStatusLabel.Text = bagelSaveFileDialog.FileName.ToString();
                    }
                    else
                    {
                        return;
                    }
                    for (i = 0; i < bagelListBox.Items.Count; i++)
                    {
                        saveSteam.WriteLine(bagelListBox.Items[i]);
                    }
                    saveSteam.Close();
                    bagelListBox.SelectedIndex = 0;
                }
                catch (Exception fileEx)
                {
                    MessageBox.Show(bagelOpenFileDialog.FileName, fileEx.Message, MessageBoxButtons.OK);
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close the program 

            if (bagelListBox.Items.Count != 0)
            {
                DialogResult result = MessageBox.Show("Do you want to save current bagel list?","Current list not saved",
                                                        MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    saveFile(); 
                } 
            }
            this.Close(); 
        }

        private bool newBagel(string bagelStr)
        {
            int index;
            for (index = 0; index < bagelListBox.Items.Count; index++)
                if (bagelStr == ((string)(bagelListBox.Items[index])).ToLower())
                    return false;
                return true;
        }

        private void addBagel()
        {
            string addString;
            if (bagelTextBox.Text == "")
            {
                MessageBox.Show("Please enter a bagel type", "Textbox empty", MessageBoxButtons.OK);
            }
            else
            {
                addString = bagelTextBox.Text.ToLower();
                if (newBagel(addString) == true)
                    bagelListBox.Items.Add(addString);
                else
                    MessageBox.Show("Bagel Type already in List", "Duplicate type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBagel(); 
        }


        private void removeBagel()
        {
            try
            {
                if (bagelListBox.Items.Count == 0)
                {
                    MessageBox.Show("Bagel list is empty ", "Empty List", MessageBoxButtons.OK);
                }
                else
                {
                    bagelListBox.Items.RemoveAt(bagelListBox.SelectedIndex);
                    if (bagelListBox.Items.Count == 0)
                    {
                        MessageBox.Show("Bagel list is empty ", "Empty List", MessageBoxButtons.OK);
                    }
                    else
                    {
                        bagelListBox.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a bagel type before removing", "Type not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeBagel();
        }

        private void countBagelTypes()
        {
            int bagelTypeCount = 0;
            int index;
            for (index = 0; index < bagelListBox.Items.Count; index++)
            {
                bagelTypeCount++;
            }
            MessageBox.Show("There are " + bagelTypeCount + " bagel types currenly in stock", "", MessageBoxButtons.OK);
        }

        private void countBagelTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countBagelTypes();
        }

        private void clearList()
        {
            DialogResult result = MessageBox.Show("Do you want to clear current bagel list?", "Clear List",
                                                       MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bagelListBox.Items.Clear();
            }
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearList(); 
        }

        private void about()
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about(); 
        }

        private void openLoadToolStripButton_Click(object sender, EventArgs e)
        {
            openAndLoad();
        }

        private void openAddToolStripButton_Click(object sender, EventArgs e)
        {
            openAndAdd();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void addBagelToolStripButton_Click(object sender, EventArgs e)
        {
            addBagel();
        }

        private void removeBagelToolStripButton_Click(object sender, EventArgs e)
        {
            removeBagel(); 
        }

        private void countBagelToolStripButton_Click(object sender, EventArgs e)
        {
            countBagelTypes();
        }

        private void clearListToolStripButton_Click(object sender, EventArgs e)
        {
            clearList(); 
        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            about(); 
        }

        private void formBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColorDialog.AllowFullOpen = true;
            myColorDialog.AnyColor = true;
            myColorDialog.FullOpen = true;

            myColorDialog.ShowDialog();
            this.BackColor = myColorDialog.Color; 
        }

        private void listFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myFontDialog.ShowEffects = true;
            myFontDialog.ShowApply = true; 
            myFontDialog.ShowDialog();
            bagelListBox.Font = myFontDialog.Font; 
        }

        private void myFontDialog_Apply(object sender, EventArgs e)
        {
            bagelListBox.Font = myFontDialog.Font; 
        }

        private void listBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColorDialog.AllowFullOpen = true;
            myColorDialog.AnyColor = true;
            myColorDialog.FullOpen = true;

            myColorDialog.ShowDialog();
            bagelListBox.BackColor = myColorDialog.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateToolStripStatusLabel.Text = DateTime.Today.ToString("D"); 
        }

        private void listTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColorDialog.AllowFullOpen = true;
            myColorDialog.AnyColor = true;
            myColorDialog.FullOpen = true;

            myColorDialog.ShowDialog();
            bagelListBox.ForeColor = myColorDialog.Color;
        }
    }
}
