using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] programArray;
        public Form1()
        {
            InitializeComponent();
            countLabel.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));

            //This will update the list of install programs
            updateInstalledPrograms();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Clear the listbox each time of unreleated terms
            listBox1.Items.Clear();
            //Search the array for text, using Regex
            for (int i = 0; i < programArray.Length; i++)
            {

                if (System.Text.RegularExpressions.Regex.Match(programArray[i], searchBox.Text.ToString(), RegexOptions.IgnoreCase).Success)
                {
                    listBox1.Items.Add(programArray[i].ToString());
                }
            }
            countLabel.Text = listBox1.Items.Count.ToString();
        }


        private void uninstallButton_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("You need to select at least one item.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Get list of installed software
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        try
                        {
                            if(subkey.GetValue("DisplayName").ToString() == listBox1.SelectedItem.ToString())
                            {
                                string uninstallCommand = null;
                                try
                                {
                                    uninstallCommand = subkey.GetValue("UninstallString").ToString();
                                }
                                catch(Exception)
                                {
                                    MessageBox.Show("Cann't find uninstaller for that program.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                if(uninstallCommand != null)
                                {
                                    //Now try to uninstall the program
                                    Process.Start(uninstallCommand);
                                }
                                
                                

                            }
                        }
                        catch (Exception)
                        {

                        }
                    }

                    programArray = new string[listBox1.Items.Count];
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        object s = listBox1.Items[i];
                        programArray[i] = s.ToString();
                    }




                }
            }
            updateInstalledPrograms();
        }

        private void viewCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/martinoj2009/applicationManager/blob/master/WindowsFormsApplication1/Form1.cs");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutBox = new about();
            aboutBox.ShowDialog();
            aboutBox = null;
        }

        private void updateInstalledPrograms()
        {
            listBox1.Items.Clear();

            //Get list of installed software
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        try
                        {
                            listBox1.Items.Add(subkey.GetValue("DisplayName"));
                        }
                        catch (Exception)
                        {

                        }
                    }

                    programArray = new string[listBox1.Items.Count];
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        object s = listBox1.Items[i];
                        programArray[i] = s.ToString();
                    }




                }
            }
            countLabel.Text = listBox1.Items.Count.ToString();
            registry_key = null;
        }
    }
}
