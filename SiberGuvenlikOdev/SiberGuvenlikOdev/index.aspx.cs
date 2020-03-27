using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiberGuvenlikOdev
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tara_Click(object sender, EventArgs e)
        {
            ProcessStartInfo process = new ProcessStartInfo();
            process.Arguments = "-p 1-1024 127.0.0.1";
            process.RedirectStandardOutput = true;
            process.FileName = "nmap";
            Process proces = new Process();
            proces.StartInfo = process;
            proces.Start();
            StreamReader stdout = proces.StandardOutput;
            StreamWriter sw = new StreamWriter("sonuc.txt");
            sw.WriteLine(stdout.ReadToEnd());
            proces.WaitForExit();
            Console.ReadKey(true);

            StreamReader SR = new StreamReader("sonuc.txt");
            sonuc.Text = SR.ReadLine();
            SR.Close();
        }
    }
}