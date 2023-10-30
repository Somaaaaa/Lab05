using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat
            /*
            StreamReader myReader = new StreamReader("colorem_ipsum.txt", System.Text.Encoding.ASCII);
            while (!myReader.EndOfStream)
            {
                string oneLine = myReader.ReadLine();
                string[] a = oneLine.Split('#');
                ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), a[0]);
                Console.ForegroundColor = color;
                Console.WriteLine(a[1]);
            }
            myReader.Close();
            */
            #endregion
            #region 2. feladat
            /*
            StreamWriter myWriter = new StreamWriter("lotto.txt", true);
            Random rnd = new Random();
            List<int> numbers = new List<int>();
            string answer;
            int szam;
            DateTime today = DateTime.Now;
            do
            {
                numbers.Clear();
                for (int i = 0; i < 5; i++)
                {
                    do
                    {
                        szam = rnd.Next(1, 91);

                    } while (numbers.Contains(szam) == true);
                    numbers.Add(szam);
                }
                Console.WriteLine("On {0} numbers were {1} {2} {3} {4} {5}", today.ToShortDateString(), numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
                myWriter.WriteLine("On {0} numbers were {1} {2} {3} {4} {5}", today.ToShortDateString(), numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
                Console.Write("Another week? [y/n] ");
                today = today.AddDays(7);
                answer = Console.ReadLine();
            } while (answer != "n");
            myWriter.Close();
            */
            #endregion
            #region 4. feladat
            //string[] allLines = File.ReadAllLines("NHANES_1999-2018.csv");

            //string[] SURVEY = new string[allLines.Length-1];
            //int[] RIAGENDR = new int[allLines.Length-1];
            //int[] RIDAGEYR = new int[allLines.Length-1];
            //double[] BMXBMI = new double[allLines.Length-1];
            //double[] LBDGLUSI = new double[allLines.Length-1];

            //for (int i = 1; i < allLines.Length; i++)
            //{
            //    string[] a = allLines[i ].Split(',');
            //    SURVEY[i] = a[1];
            //    RIAGENDR[i] = int.Parse(a[2].Trim('.'));
            //    RIDAGEYR[i] = int.Parse(a[3]);
            //    BMXBMI[i] = double.Parse(a[4]);
            //    LBDGLUSI[i] = double.Parse(a[5]);
            //}
            string a = "24.0";
            Console.WriteLine(a.Trim('.',' '));
            #endregion
            Console.ReadLine();
        }
    }
}
