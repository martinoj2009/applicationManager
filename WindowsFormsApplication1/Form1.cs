using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] programArray;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ipLabel.Text = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(o => o.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).First().ToString();
            hostName.Text = Dns.GetHostName().ToString();


            MessageBox.Show(System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE"));


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
                        catch (Exception ex)
                        { }
                    }

                    programArray = new string[listBox1.Items.Count];
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        object s = listBox1.Items[i];
                        programArray[i] = s.ToString();
                    }




                }
            }
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
        }
    }
}
