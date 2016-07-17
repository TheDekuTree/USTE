using System;
using System.IO;
using System.Windows.Forms;


namespace NathansProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;


            openFileDialog1.ShowDialog();

            
                // Open the selected file to read.
                System.IO.Stream fileStream = openFileDialog1.OpenFile();

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                    // Read the first line from the file and write it the textbox.
                    TextBox.Text = reader.ReadToEnd();
                }
                fileStream.Close();



            
        }



        private void Save_Click(object sender, EventArgs e)
        {

            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.ShowDialog();


            if (saveFileDialog1.FileName != "")
            {

               

                    {
                        using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                        {
                            sw.Write(TextBox.Text);
                            
                            
                        }
                    



                }
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {

            fontDialog1.ShowDialog();

            


                TextBox.Font = fontDialog1.Font;


            


        }

        private void Program_Click(object sender, EventArgs e)
        {
            Settings frm2 = new Settings();
            frm2.ShowDialog();

        }

       

      
       
    }
}
