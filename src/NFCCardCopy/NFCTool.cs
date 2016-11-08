using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NFCCardCopy
{
    class NFCTool
    {

        private static string[] hex = new String[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        public static String exec( string filename, String argv = "" )
        {
            string output = "";
            Process process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.FileName = "bin/" + filename;
            process.StartInfo.Arguments = argv;
            process.Start();
            while ( !process.HasExited )
            {
                output = process.StandardOutput.ReadToEnd();
            }
            process.WaitForExit();
            return output;
        }

        public static bool checkDevice()
        {
            return !NFCTool.exec("nfc-list.exe").Trim().Contains("No NFC device found.");
        }

        public static String getDeviceName()
        {
            return NFCTool.exec("nfc-list.exe").Trim().Split('\n')[1].Replace("opened","").Trim();
        }

        public static String readUID()
        {
            String output = NFCTool.exec("nfc-list.exe").Trim();
            Regex regx = new Regex("UID \\(\\S*\\): ((\\S\\S\\s\\s){4})", RegexOptions.IgnoreCase);
            if (regx.IsMatch(output))
            {
                return regx.Match(output).Value.ToUpper().Replace(" ", "").Split(':')[1];
            }
            return "";
        }

        public static String writeUID( string uid )
        {
            return NFCTool.exec("nfc-mfsetuid.exe", " -f " + uid).Trim();
        }

        public static bool checkUID( string uid )
        {

            if( uid.Length != 8 )
            {
                return false;
            }

            for( int i=0; i<8; i++ )
            {
                if( !NFCTool.hex.Contains( uid[i].ToString() ) )
                {
                    return false;
                }
            }

            return true;
        }

    }
}
