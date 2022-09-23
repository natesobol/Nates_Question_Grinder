using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Question_Grinder
{
    public partial class Form1 : Form
    {
        System.IO.Stream fileStream = new System.IO.MemoryStream();
        String fileContent = string.Empty;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            
            SoundPlayer snd = new SoundPlayer(Properties.Resources.nate_says_chuck_1);
            snd.Play();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    System.Diagnostics.Debug.WriteLine(filePath);
                    dirText.Text = filePath;
                    //Read the contents of the file into a stream
                    fileStream = openFileDialog.OpenFile();

                  
                        ///questionList.Add() = fileContent;
                    
                }
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            List<String> questionList = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    questionList = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        
                        fileContent = reader.ReadLine();
                        System.Diagnostics.Debug.WriteLine(fileContent);
                        if (fileContent.Contains("?"))
                        {
                            questionList.Add(questionParse.Text + fileContent + backParse.Text);
                            fileContent = reader.ReadLine();
                            questionList.Add(frontParse.Text + fileContent + backParse.Text);
                            fileContent = reader.ReadLine();
                            questionList.Add(frontWrong1.Text + fileContent + backParse.Text);
                            fileContent = reader.ReadLine();
                            questionList.Add(frontWrong2.Text + fileContent + backParse.Text);
                            fileContent = reader.ReadLine();
                            questionList.Add(frontWrong3.Text + fileContent + backParse.Text);
                            fileContent = reader.ReadLine();
                        }
                        else if (fileContent.StartsWith(" "))
                        {
                            questionList.Add("");
                        }

                        else
                        {
                            questionList.Add(frontParse.Text + fileContent + backParse.Text);
                            //questionList.ForEach(Console.WriteLine);
                        }

                    }

                }
            }
            catch (Exception q)
            {

            }

            SaveFileDialog oSaveFileDialog = new SaveFileDialog();
            oSaveFileDialog.Filter = "All files (*.*) | *.*";
            if (oSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                oSaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                string fileName = oSaveFileDialog.FileName;
                dirText.Text = fileName;
                System.IO.File.WriteAllLines(fileName, questionList);

            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
