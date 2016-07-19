using System;
using System.Drawing;
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
            openFileDialog1.Title = "Open Text";
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;


            openFileDialog1.ShowDialog();

            
                System.IO.Stream fileStream = openFileDialog1.OpenFile();

                using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                {
                 
                    TextBox.Text = reader.ReadToEnd();
                    
                }
                fileStream.Close();



            
        }



        private void Save_Click(object sender, EventArgs e)
        {

  
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

            


                TextBox.SelectionFont = fontDialog1.Font;


      


        }



   

        private void Program_Click(object sender, EventArgs e)
        {
            Settings frm2 = new Settings();
            frm2.ShowDialog();

        }

        private void TextColor_Click(object sender, EventArgs e)
        {

            colorDialog1.ShowDialog();


            TextBox.SelectionColor = colorDialog1.Color;


        }

        private void openimage_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open Images";
            openFileDialog1.Filter = "png files (*.png)|*.png|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;


            openFileDialog1.ShowDialog();


            

                
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            




        }

        private void openimage_Click_1(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open Images";
            openFileDialog1.Filter = "png files (*.png)|*.png|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = true;


            openFileDialog1.ShowDialog();





            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

        }



        

        
        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
