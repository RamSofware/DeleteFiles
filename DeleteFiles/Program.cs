﻿using System;
using System.IO;

namespace DeleteFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            { 
            }
            int aggedDays = 0;
            Int32.TryParse(args[0], out aggedDays);
            string dirName = args[1].ToString();
            //string[] files = Directory.GetFiles();
            Console.WriteLine("Working directory = " + dirName);
            Console.WriteLine("agged days = " + args[0]);
            Console.ReadKey();
            
            /*
            string[] files = Directory.GetFiles(dirName);

			foreach (string file in files)
			{
			   FileInfo fi = new FileInfo(file);
			   if (fi.LastAccessTime < DateTime.Now.AddMonths(-3))
				  fi.Delete();
			}
            */

        }
    }
}
