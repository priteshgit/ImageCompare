using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageComparer
{
    public partial class FormImageComparer : Form
    {
        List<string> imgList1 = new List<string>();

        public FormImageComparer()
        {
            this.InitializeComponent();
        }
        
        private void buttonNext_Click(object sender, EventArgs e)
        {
            try{
            if (this.labelImage1.Text == "Image Name from folder 1" || this.labelImage2.Text == "Image Name from folder 2")
            {
                MessageBox.Show("Please click 'Load' first");
            }
            else
            {
                if (this.imgList1.IndexOf(this.labelImage1.Text) + 1 < this.imgList1.Count)
                {
                    this.labelImage1.Text = this.imgList1[this.imgList1.IndexOf(this.labelImage1.Text) + 1];
                    this.labelImage2.Text = this.labelImage1.Text.Replace(".", this.textBoxSuffix.Text + ".");
                    if (File.Exists(Path.Combine(this.textBoxFolder1.Text, this.labelImage1.Text)))
                    {
                        this.pictureBoxImage1.LoadAsync(Path.Combine(this.textBoxFolder1.Text, this.labelImage1.Text));
                    }
                    else
                    {
                        this.pictureBoxImage1.LoadAsync("file_not_found.jpg");
                    }
                    if (File.Exists(Path.Combine(this.textBoxFolder2.Text, this.labelImage1.Text.Replace(".", this.textBoxSuffix.Text+"."))))
                    {
                        this.pictureBoxImage2.LoadAsync(Path.Combine(this.textBoxFolder2.Text,this.labelImage1.Text.Replace(".", this.textBoxSuffix.Text+".")));
                    }
                    else
                    {
                        this.pictureBoxImage2.LoadAsync("file_not_found.jpg");
                    }
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                }
                else
                {
                    MessageBox.Show("No futher files in any of the folder");
                }
            }
            } catch(Exception ex){}
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try{
                this.imgList1.Clear();
            this.labelImage1.Text = "Image Name from folder 1"; 
            this.labelImage2.Text = "Image Name from folder 2";
            if (this.labelImage1.Text == "Image Name from folder 1" || this.labelImage2.Text == "Image Name from folder 2")
            {
                this.imgList1 = Directory.GetFiles(this.textBoxFolder1.Text, "*.*")
                                         .Select(path => Path.GetFileName(path))
                                         .ToList<string>();
                this.labelImage1.Text = this.imgList1[0];
                this.labelImage2.Text = this.labelImage1.Text.Replace(".", this.textBoxSuffix.Text + ".");
                if (File.Exists(Path.Combine(this.textBoxFolder1.Text, this.labelImage1.Text)))
                {
                    this.pictureBoxImage1.LoadAsync(Path.Combine(this.textBoxFolder1.Text, this.labelImage1.Text));
                }
                else
                {
                    this.pictureBoxImage1.LoadAsync("file_not_found.jpg");
                }
                if (File.Exists(Path.Combine(this.textBoxFolder2.Text, this.labelImage1.Text.Replace(".", this.textBoxSuffix.Text+"."))))
                {
                    this.pictureBoxImage2.LoadAsync(Path.Combine(this.textBoxFolder2.Text, this.labelImage1.Text.Replace(".", this.textBoxSuffix.Text+".")));
                }
                else
                {
                    this.pictureBoxImage2.LoadAsync("file_not_found.jpg");
                }

            }
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            }
            catch (Exception ex) { }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try{
            if (this.labelImage1.Text == "Image Name from folder 1" || this.labelImage2.Text == "Image Name from folder 2")
            {
                MessageBox.Show("Please click 'Load' first");
            }
            else
            {
                if (this.imgList1.IndexOf(this.labelImage1.Text)-1 > 0)
                {
                    this.labelImage1.Text = this.imgList1[this.imgList1.IndexOf(this.labelImage1.Text) - 1];
                    this.labelImage2.Text = this.labelImage1.Text + this.textBoxSuffix.Text;
                    if (File.Exists(Path.Combine(this.textBoxFolder1.Text, this.labelImage1.Text)))
                    {
                        this.pictureBoxImage1.LoadAsync(Path.Combine(this.textBoxFolder1.Text, this.labelImage1.Text));
                    }
                    else
                    {
                        this.pictureBoxImage1.LoadAsync("file_not_found.jpg");
                    }
                    if (File.Exists(Path.Combine(this.textBoxFolder2.Text, this.labelImage1.Text.Replace(".", this.textBoxSuffix.Text + "."))))
                    {
                        this.pictureBoxImage2.LoadAsync(Path.Combine(this.textBoxFolder2.Text, this.labelImage1.Text.Replace(".", this.textBoxSuffix.Text + ".")));
                    }
                    else
                    {
                        this.pictureBoxImage1.LoadAsync("file_not_found.jpg");
                    }
                }
                else
                {
                    MessageBox.Show("You reached first file!");
                }

            }
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            }
            catch (Exception ex) { }
        }
    }
}