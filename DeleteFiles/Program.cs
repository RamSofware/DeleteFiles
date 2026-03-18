using System;
using System.IO;
using CommandLine.Utility;

namespace DeleteFiles
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string usage = "Specify agged files in days from now to the past ex: -a 30 \n do not forget specify the folder to work on, ex: -d \"c:\\tmp\\files\"";
            Arguments CommandLine = new Arguments(args);

            if (CommandLine.Parameters.Count < 2)
            {
                Console.WriteLine(usage);
                //Console.ReadKey();
                return;
            }
            if (args.Length == 0)
            {
                Console.WriteLine("please especify working directory and aged files in days");
                //Console.ReadKey();
                return;
            }
            if (CommandLine["d"] == null)
            {
                //Console.WriteLine("-d =" + CommandLine["d"]);
                Console.WriteLine("Please specify the directory, example:[-d \"c:\tmp\files\"]");
                return;
            }
            int aggedDays = 0;
            Int32.TryParse(args[0], out aggedDays);
            string dirName = args[1].ToString();
            //string[] files = Directory.GetFiles();
            Console.WriteLine("Working directory = " + dirName);
            Console.WriteLine("agged days = " + args[0]);
            Console.ReadKey();
            /*
            this is a test on March 18 2026
            */
            /*
            string[] files = Directory.GetFiles(dirName);

            string[] files = Directory.GetFiles(CommandLine["d"]);
            int agged = Convert.ToInt32(CommandLine["a"]);
           
			foreach (string file in files)
			{
			   FileInfo fi = new FileInfo(file);
               string fiCreationDate = fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss,fff");
               string today = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff");
               double ageOfFile = (DateTime.ParseExact(today, "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture)
                                - DateTime.ParseExact(fiCreationDate, "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture)).TotalDays;
               Console.WriteLine("file = " + fi.Name + "\nAgged = " + ageOfFile.ToString()+ " \nDateTime: " + fiCreationDate );
               //if (fi.CreationTime < DateTime.Now.AddDays((-1) * agged))
               if (ageOfFile >= agged )
               {
                   //Console.WriteLine("=== file to be deleted : " + fi.Name+" ===");
                   //Console.ReadKey();
                   fi.Delete();
               }
                   
			}                        
        }
    }
}
