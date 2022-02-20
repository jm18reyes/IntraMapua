using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;


namespace DAL
{
    public class DataAccess
    {
         public static string Username;
        

        public string SearchUsers(string u, string p)
        {
            string username, password, Fullname = "";
            char separator = ';';
            StreamReader rdr = new StreamReader(@"C: \Users\Jean Marc\Documents\Jean Marc Documents\IntraMAPua(1)\IntraMAPua\DAL\user.txt");
           
            while (!rdr.EndOfStream)
            {
                string line = rdr.ReadLine();
                if (line == String.Empty)
                {
                    continue;
                }
                string[] text = line.Split(separator);
                username = text[0];
                password = text[1];

                if (username == u && password == p)
                {
                    Fullname = text[2];

                    break;
                }
            }
            rdr.Close();
            return Fullname;
        }
      

        public bool AddAccount(string user, string pass, string FullName)
        {
            StreamReader FileReader = new StreamReader(@"C: \Users\Jean Marc\Documents\Jean Marc Documents\IntraMAPua(1)\IntraMAPua\DAL\user.txt");

            string Line;
            string[] LineSplit;
            bool validity = true;
            while (!FileReader.EndOfStream)
            {
                Line = FileReader.ReadLine();
                LineSplit = Line.Split(';');
                if (user == LineSplit[0] || FullName == LineSplit[2])
                {
                    validity = false;

                }
            }
            FileReader.Close();
            if (validity == true)
            {
                if (File.Exists(@"C: \Users\Jean Marc\Documents\Jean Marc Documents\IntraMAPua(1)\IntraMAPua\DAL\user.txt"))
                {
                    StreamWriter FileWriter = new StreamWriter(@"C: \Users\Jean Marc\Documents\Jean Marc Documents\IntraMAPua(1)\IntraMAPua\DAL\user.txt", true);
                    FileWriter.WriteLine(user + ";" + pass + ";" + FullName);
                    FileWriter.Close();
                }
                else
                {
                    validity = false;
                }
            }
            return validity;
        }

        public string GetFullName(string user, string pass)
        {
            StreamReader FileReader = new StreamReader(@"C: \Users\Jean Marc\Documents\Jean Marc Documents\IntraMAPua(1)\IntraMAPua\DAL\user.txt");
            string FullName = "";
            string Line;
            string[] LineSplit;

            while (!FileReader.EndOfStream)
            {
                Line = FileReader.ReadLine();
                LineSplit = Line.Split(';');
                if (LineSplit[0] == user && LineSplit[1] == pass)
                {
                    FullName = LineSplit[2];
                    break;
                }
            }
            return FullName;
        }


        public string UnivCoordinates(string univ)
        {
            StreamReader FileReader = new StreamReader(@"C: \Users\Jean Marc\Documents\Jean Marc Documents\IntraMAPua(1)\IntraMAPua\DAL\Univ.txt");
            string line;
            string[] LineSplit;
            string coordinates = "";
            while (!FileReader.EndOfStream)
            {
                line = FileReader.ReadLine();
                LineSplit = line.Split(';');
                if (univ == LineSplit[0])
                {
                    coordinates = LineSplit[1];
                    break;
                }
            }
            return coordinates;


        }

        public string HotelCoordinates(string hotel)
        {
            StreamReader FileReader = new StreamReader(@"C: \Users\Jean Marc\Documents\Jean Marc Documents\IntraMAPua(1)\IntraMAPua\DAL\Hotel.txt");
            string line;
            string[] LineSplit;
            string coordinates = "";
            while (!FileReader.EndOfStream)
            {
                line = FileReader.ReadLine();
                LineSplit = line.Split(';');
                if (hotel == LineSplit[1])
                {
                    coordinates = LineSplit[2];
                    break;
                }
            }
            return coordinates;
        }

        public string TourAttractCoordinates(string tourAttract)
        {
            StreamReader FileReader = new StreamReader(@"C: \Users\Jean Marc\Documents\Jean Marc Documents\IntraMAPua(1)\IntraMAPua\DAL\Tourist.txt");
            string line;
            string[] LineSplit;
            string coordinates = "";
            while (!FileReader.EndOfStream)
            {
                line = FileReader.ReadLine();
                LineSplit = line.Split(';');
                if (tourAttract == LineSplit[0])
                {
                    coordinates = LineSplit[1];
                    break;
                }
            }
            return coordinates;


        }

   
   }
}
