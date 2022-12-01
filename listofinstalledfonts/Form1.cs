using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
namespace listofinstalledfonts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create the font collection.
            using (InstalledFontCollection fontFamilies =
            new InstalledFontCollection())
            {
                // Iterate through all font families.
                int offset = 10;
                foreach (FontFamily family in fontFamilies.Families)
                {
                    try
                    {
                        // Create a label that will display text in this font.
                        Label fontLabel = new Label();
                        fontLabel.Text = family.Name;
                        fontLabel.Font = new Font(family, 14);
                        fontLabel.Left = 10;
                        fontLabel.Width = pnlFonts.Width;
                        fontLabel.Top = offset;
                        // Add the label to a scrollable Panel.
                        pnlFonts.Controls.Add(fontLabel);
                        offset += 30;
                        comboBox1.Items.Add(family.Name);
                    }
                    catch
                    {
                        // An error will occur if the selected font does
                        // not support normal style (the default used when
                        // creating a Font object). This problem can be
                        // harmlessly ignored.
                    }
                }
            }
        }

        private void comboBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fontLabelx.Text = comboBox1.SelectedItem.ToString();
                fontLabelx.Font = new Font(fontLabelx.Text, 14);
                fontLabelx.Width = pnlFonts.Width;
            }
            catch { }
        }
    }
}
