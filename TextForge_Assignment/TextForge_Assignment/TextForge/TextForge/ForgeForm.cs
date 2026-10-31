
using System;
using System.IO;
using System.Windows.Forms;

namespace TextForge
{
    public partial class ForgeForm : Form
    {
        public ForgeForm()
        {
            InitializeComponent();
        }

        private void btnForgeNew_Click(object sender, EventArgs e)
        {
            try
            {
                // Qaadashada File Name-ka
                string path = txtTargetFile.Text.Trim();

                // Hubinta in magaca File-ka la geliyay
                if (string.IsNullOrWhiteSpace(path))
                {
                    MessageBox.Show("Please Enter File Name!");
                    return;
                }

                // Helitaanka Documents Folder-ka
                string folder = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.MyDocuments
                    ),
                    "TextForge"
                );

                // Abuurista Folder-ka haddii uusan jirin
                Directory.CreateDirectory(folder);

                // Isku darista Folder iyo File Name
                if (!Path.IsPathRooted(path))
                {
                    path = Path.Combine(folder, path);
                }

                // Abuurista File cusub
                using (StreamWriter sw = File.CreateText(path))
                {
                }

                // Muujinta File Path-ka
                txtTargetFile.Text = path;

                MessageBox.Show("File Created Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForgePath_Click(object sender, EventArgs e)
        {
            try
            {
                // Furitaanka Folder Browser
                using (FolderBrowserDialog folder = new FolderBrowserDialog())
                {
                    folder.Description = "Select File Location";

                    // Hubinta in Folder la doortay
                    if (folder.ShowDialog() == DialogResult.OK)
                    {
                        // Qaadashada magaca File-ka
                        string fileName = Path.GetFileName(
                            txtTargetFile.Text.Trim()
                        );

                        // Haddii magac uusan jirin
                        if (string.IsNullOrWhiteSpace(fileName))
                        {
                            fileName = "example.txt";
                        }

                        // Isku darista Folder Path iyo File Name
                        string fullPath = Path.Combine(
                            folder.SelectedPath,
                            fileName
                        );

                        // Ku muujinta Path-ka TextBox
                        txtTargetFile.Text = fullPath;

                        MessageBox.Show("File Path Selected Successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForgeName_Click(object sender, EventArgs e)
        {
            try
            {
                // Furitaanka Save File Dialog
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Title = "Create New File";
                    save.Filter = "Text Files (*.txt)|*.txt";
                    save.FileName = "example.txt";

                    // Hubinta in user-ku doortay Save
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        // Qaadashada File Path-ka
                        string path = save.FileName;

                        // Abuurista File cusub
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            // File cusub ayaa la sameeyay
                        }

                        // Ku muujinta File Name iyo Path
                        txtTargetFile.Text = path;

                        MessageBox.Show("New File Created Successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForgeWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // Qaadashada File Name-ka
                string path = txtTargetFile.Text.Trim();

                // Hubinta magaca File-ka
                if (string.IsNullOrWhiteSpace(path))
                {
                    MessageBox.Show("Please Enter File Name!");
                    return;
                }

                // Hubinta in Text la geliyay
                if (string.IsNullOrWhiteSpace(txtWriteHere.Text))
                {
                    MessageBox.Show("Please Enter Text!");
                    return;
                }

                // Qorista xogta File-ka
                using (StreamWriter sw = File.CreateText(path))
                {
                    // WriteLine wuxuu qoraalka geliyaa line cusub
                    sw.WriteLine(txtWriteHere.Text);
                }

                MessageBox.Show("Data Written Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForgeRead_Click(object sender, EventArgs e)
        {
            try
            {
                // Qaadashada File Path-ka
                string path = txtTargetFile.Text.Trim();

                // Hubinta in File-ku jiro
                if (File.Exists(path))
                {
                    // Furitaanka File-ka si loo akhriyo
                    using (StreamReader sr = File.OpenText(path))
                    {
                        // ReadToEnd wuxuu akhriyaa dhammaan xogta
                        txtResultHere.Text = sr.ReadToEnd();
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForgeLines_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtTargetFile.Text.Trim();

                if (File.Exists(path))
                {
                    txtResultHere.Clear();

                    using (StreamReader sr = File.OpenText(path))
                    {
                        string line;
                        int count = 1;

                        while ((line = sr.ReadLine()) != null)
                        {
                            txtResultHere.AppendText(
                                "Line " + count + ": " + line +
                                Environment.NewLine
                            );

                            count++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForgeAll_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtTargetFile.Text.Trim();

                if (File.Exists(path))
                {
                    string data = File.ReadAllText(path);

                    txtResultHere.Text = data;
                }
                else
                {
                    MessageBox.Show("File Not Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForgeChars_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtTargetFile.Text.Trim();

                if (File.Exists(path))
                {
                    txtResultHere.Clear();

                    using (StreamReader sr = File.OpenText(path))
                    {
                        int character;
                        int count = 0;

                        while ((character = sr.Read()) != -1)
                        {
                            txtResultHere.AppendText(
                                ((char)character).ToString()
                            );

                            count++;
                        }

                        MessageBox.Show(
                            "Total Characters: " + count
                        );
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForgeAppend_Click(object sender, EventArgs e)
        {
            try
            {
                // Qaadashada File Path-ka
                string path = txtTargetFile.Text.Trim();

                // Hubinta File Name-ka
                if (string.IsNullOrWhiteSpace(path))
                {
                    MessageBox.Show("Please Enter File Name!");
                    return;
                }

                // Hubinta qoraalka cusub
                if (string.IsNullOrWhiteSpace(txtWriteHere.Text))
                {
                    MessageBox.Show("Please Enter Text!");
                    return;
                }

                // Furitaanka File-ka si xog loogu daro
                using (StreamWriter sw = File.AppendText(path))
                {
                    // Qoraalka cusub ku dar dhammaadka File-ka
                    sw.WriteLine(txtWriteHere.Text);
                }

                MessageBox.Show("Data Appended Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForgeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Qaadashada File Path-ka
                string path = txtTargetFile.Text.Trim();

                // Hubinta in File-ku jiro
                if (File.Exists(path))
                {
                    // Weydiinta ogolaanshaha user-ka
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this file?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    // Haddii user-ku doorto Yes
                    if (result == DialogResult.Yes)
                    {
                        // Tirtirista File-ka
                        File.Delete(path);

                        // Nadiifinta Output
                        txtResultHere.Clear();

                        MessageBox.Show("File Deleted Successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("File Not Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnForgeClear_Click(object sender, EventArgs e)
        {
            // Nadiifinta File Name
            txtTargetFile.Clear();

            // Nadiifinta Input TextBox
            txtWriteHere.Clear();

            // Nadiifinta Output TextBox
            txtResultHere.Clear();
        }
    }
}




