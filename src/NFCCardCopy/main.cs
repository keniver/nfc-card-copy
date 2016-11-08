using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace NFCCardCopy
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void log( String text )
        {
            this.logbox.Text += String.Format("{0}: {1}" + Environment.NewLine, DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]"), text);
            this.logbox.SelectionStart = this.logbox.TextLength;
            this.logbox.ScrollToCaret();
        }

        private bool checkFiles()
        {
            this.log("Files integrity checking");
            this.status.Text = "Files integrity checking";

            bool missing_file = false; 
            string[] file_list = { "libnfc.dll", "libusb0.dll", "nfc.dll", "nfc-list.exe", "nfc-mfsetuid.exe" };
            String base_path = "bin/";
            foreach ( string filename in file_list )
            {
                if ( !System.IO.File.Exists( base_path + filename ) )
                {
                    this.log( filename + " is missing." );
                    missing_file = true;
                }
            }
            return !missing_file;
        }

        private void searchDevice()
        {
            this.log("Searching available device");
            this.status.Text = "Searching available device";
            this.searchTimer.Start();
        }

        private void searchTimer_Tick(object sender, EventArgs e)
        {
            if( NFCTool.checkDevice() )
            {
                this.searchTimer.Stop();
                this.label1.Enabled = true;
                this.readUID.Enabled = true;
                this.writeUID.Enabled = true;
                this.uid.Enabled = true;
                this.log(NFCTool.getDeviceName());
                this.status.Text = "Ready";
            }
        }

        private void readUID_Click(object sender, EventArgs e)
        {
            this.status.Text = "Reading UID.";
            this.uid.Enabled = false;
            this.readUID.Enabled = false;
            this.writeUID.Enabled = false;
            String origin_uid = NFCTool.readUID();
            if(origin_uid != "")
            {
                this.log("Get UID:" + origin_uid);
                this.uid.Text = origin_uid;
            } else
            {
                this.log("Unrecognized card.");
            }
            this.uid.Enabled = true;
            this.readUID.Enabled = true;
            this.writeUID.Enabled = true;
            this.status.Text = "Ready";
        }

        private void writeUID_Click(object sender, EventArgs e)
        {
            if( NFCTool.checkUID(this.uid.Text) )
            {
                this.status.Text = "Writing UID.";
                this.uid.Enabled = false;
                this.readUID.Enabled = false;
                this.writeUID.Enabled = false;
                this.log("Write UID:" + this.uid.Text);
                this.log(NFCTool.writeUID(this.uid.Text));
                this.uid.Enabled = true;
                this.readUID.Enabled = true;
                this.writeUID.Enabled = true;
                this.status.Text = "Ready";
            } else
            {
                MessageBox.Show( "Not a valid UID." );
            }
            
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By Keniver.");
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.log("Application initializing");
            if (checkFiles())
            {
                searchDevice();
            }
            else
            {
                MessageBox.Show("Someting wrong.");
            }
        }
    }
}
