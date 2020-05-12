﻿using System;
using System.IO;

namespace timpKR
{
    static class DataBank
    {
        public static string root = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string rootChK = root;
        static string rootChR = root;
        static string rootChC = root;
        static string rootChLOR = root;
        public static string pathK = rootChK += "\\The Best Programm\\Kassets.txt";
        public static string pathR = rootChR += "\\The Best Programm\\Rented.txt";
        public static string pathC = rootChC += "\\The Best Programm\\Clients.txt";
        public static string pathLOR = rootChLOR += "\\The Best Programm\\List_of_requests.txt";

        public static int find_Price(string name)
        {
            string[] kassets = File.ReadAllLines(pathK);
            int ind1 = Array.IndexOf(kassets, name);
            string pr1 = kassets[ind1 + 1];
            int price = Convert.ToInt32(pr1);
            return price;
        }
    }
}
