using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Metadata;
using Aspose.Pdf;
using Aspose.Pdf.Text;
using HackatOrga.Models;

namespace HackatOrga
{

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            HackatonContext cnx = new HackatonContext();

           

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());

        }
    }
}

// command scafold: Scaffold-DbContext -d "server=192.168.49.1;port=3306;user=hackaweb;password=password;database=Hackathon;charset=utf8" Pomelo.EntityFrameworkCore.MySql -Outputdir Models -f