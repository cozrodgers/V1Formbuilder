using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formbuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateSeverityLevels();
            PopulatePriorityLevels();
            System.IO.Directory.CreateDirectory("_Tickets");
            this.Text = "V1 form Builder";

        }

        private void outputToFile()
        {
            //outputs the ticket information to file 

            string fileName = $@"_Tickets\#{tboxTicketNum.Text}_.txt";
            string textToAdd = rtOutput.Text;

            if (File.Exists(fileName))
            {
                DialogResult fileExists = MessageBox.Show("File Already Exists, Overwrite?", "Yes/No", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (fileExists == DialogResult.Yes)
                {

                }
                else if (fileExists == DialogResult.No)
                {
                    MessageBox.Show("Please Rename the Case File");
                }
                else if (fileExists == DialogResult.Cancel)
                {
                    //code for Cancel
                }
            }
            else
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(fileName, FileMode.CreateNew);
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.Write(textToAdd);
                        DialogResult result1 = MessageBox.Show($"#{tboxTicketNum.Text}Saved to file");
                    }
                }
                finally
                {
                    if (fs != null)
                        fs.Dispose();
                }
            }
        }


        private void PopulateSeverityLevels()
        {
            // Easier to add, modify, or remove levels.
            List<string> severityLevels = new List<string>
            {
                "Low",
                "Medium",
                "High",


            };




            foreach (string severityLevel in severityLevels)
            {
                lstSeverity.Items.Add(severityLevel);



            }

            // Select the top item to avoid errors if the user doesn't select a severity
            lstSeverity.SelectedIndex = 0;

            //lstCustPriority.SelectedIndex = 0;
        }

        private void PopulatePriorityLevels()
        {
            // Easier to add, modify, or remove levels.
            List<string> priorityLevels = new List<string>
            {
                "1",
                "2",
                "3",
                "4",
                "5",


            };

            foreach (string priorityLevel in priorityLevels)
            {
                lstCustPriority.Items.Add(priorityLevel);



            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Clear the current content, and replace with the new values.
            rtOutput.Clear();
            rtOutput.AppendText(BuildTemplate());
        }

        /// <summary>
        /// Fetches all of the needed data, and creates the template.
        /// </summary>
        /// <returns>The template ready for copy.</returns>
        private string BuildTemplate()
        {
            //Assign control values to variables.You can then change how each individual section will display.
            string sSeverity = $"Severity:\r\n ->  {lstSeverity.SelectedItem}";
            string sSubject = $"Short Description:\r\n -> {tboxSubject.Text}";
            string sCustPriority = $"Priority:\r\n -> {lstCustPriority.SelectedItem}";
            //string sCustSeverity = $"Customer - Severity:\r\n -> {lstCustSeverity.SelectedItem}";
            string sWorkaround = $"Workaround:\r\n -> {tboxWorkaround.Text}";
            string sImpact = $"Impact:\r\n -> {tboxImpact.Text}";
            string sExpected = $"Expected Results:\r\n -> {tboxExpected.Text}";
            string sURL = $"URL/Logins & Passwords:\n URL: \n -> {tboxURL.Text}";
            string sUser = $" Username-> {tboxUser.Text}";
            string sPass = $" Password-> {tboxPassword.Text}";
            string sSteps = $"Steps to reproduce:\r\n -> {tboxSteps.Text}";
            string sDetail = $"Detailed Description:\r\n -> {tboxDetail.Text}";
            //string sEffectsEveryone = $"Effects Everyone:\r\n -> {chkEffectsEveryone.Checked}";
            string sKnowledge = $"Knowledge base utilised:\r\n -> {tboxKnowledge.Text}";




            string sNewLine = "\r\n\r\n";

            //If any of the boxes are empty, fill with N/A

            if (String.IsNullOrEmpty(tboxImpact.Text))
            {
                MessageBox.Show("Subject field is empty", "No Subject",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (String.IsNullOrEmpty(tboxTicketNum.Text))
            {
                MessageBox.Show("Case ID field is empty", "No Case ID",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (String.IsNullOrEmpty(tboxWorkaround.Text))
            {
                sWorkaround = $"Workaround:\r\n -> N/A";
            }

            if (String.IsNullOrEmpty(tboxExpected.Text))
            {
                sExpected = $"Expected Results:\r\n -> N/A";
            }

            if (String.IsNullOrEmpty(tboxSteps.Text))
            {
                sSteps = $"Steps to reproduce:\r\n -> N/A";
            }

            if (String.IsNullOrEmpty(tboxURL.Text))
            {
                sURL = $"URL/Logins & Passwords:\n URL: \r\n -> N/A ";
            }

            if (String.IsNullOrEmpty(tboxImpact.Text))
            {
                sImpact = $"Impact :\r\n -> N/A ";
            }

            if (String.IsNullOrEmpty(tboxUser.Text))
            {
                sUser = $"Username:\n -> N/A ";
            }

            if (String.IsNullOrEmpty(tboxPassword.Text))
            {
                sPass = $"Password:\n -> N/A ";
            }

            if (String.IsNullOrEmpty(tboxSteps.Text))
            {
                sSteps = $"Steps to Reproduce:\n -> N/A ";
            }

            if (String.IsNullOrEmpty(tboxDetail.Text))
            {
                sDetail = $"Detailed Description:\n -> N/A ";
            }

            if (checkBox1.Checked == false)
            {
                sKnowledge = $"Knowledge base: Not Used";
            }

            if (checkBox1.Checked == true)
            {
                sKnowledge = $"Knowledge base utilised:\r\n -> {tboxKnowledge.Text}";
            }

            if (String.IsNullOrEmpty(tboxKnowledge.Text))
            {

                checkBox1.Checked = true;

            }






            //// Build the template using the variables. This allows you to easily change the layout of the template.
            string sTemplate = $"{sSubject}" +
                               $"{sNewLine}" +
                               $"{sSeverity}" +
                               $"{sNewLine}" +
                               $"{sImpact}" +
                               $"{sNewLine}" +
                               $"{sCustPriority}" +
                               $"{sNewLine}" +
                               $"{sExpected}" +
                               $"{sNewLine}" +
                               $"{sURL} \n {sUser} \n {sPass} " +
                               // $"{sEffectsEveryone}" +
                               $"{sNewLine}" +
                               $"{sSteps}" +
                               $"{sNewLine}" +
                               $"{sWorkaround} " +
                               $"{sNewLine}" +
                               $"{sDetail}" +
                               $"{sNewLine}" +

                              $"{sKnowledge}"

                              ;






            return sTemplate;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tboxSubject_Leave(object sender, EventArgs e)
        {
            if (tboxImpact.Text != String.Empty)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputToFile();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            rtOutput.Clear();
            lstCustPriority.ClearSelected();
            lstSeverity.ClearSelected();
            tboxSubject.Clear();
            tboxImpact.Clear();
            tboxExpected.Clear();
            tboxSteps.Clear();
            tboxDetail.Clear();
            tboxURL.Clear();
            tboxUser.Clear();
            tboxPassword.Clear();
            tboxWorkaround.Clear();
            tboxTicketNum.Clear();
            tboxKnowledge.Clear();
            checkBox1.Checked = false;

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtOutput.Text);
            MessageBox.Show("Template succesfully added to clipboard.");
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void tboxTicketNum_Leave(object sender, EventArgs e)
        {
            this.Text = $"Case ID: {tboxTicketNum.Text}";
        }

        private void newV1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/corey-rodgers/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/corey-rodgers/");
        }

        private void tboxKnowledge_TextChanged(object sender, EventArgs e)

        {
            checkBox1.Checked = true;
        }

        private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.pepess;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void applyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.dark;
        }

        private void applyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.asimov;
        }

        private void applyToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
        }
    }

}


