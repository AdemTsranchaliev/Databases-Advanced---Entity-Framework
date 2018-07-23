using P01_HospitalDatabase.Data;
using P01_HospitalDatabase.Data.Models;
using P01_HospitalDatabase.Initializer;
using System;

namespace P01_HospitalDatabase
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            using (HospitalContext context= new HospitalContext())
            {
                DatabaseInitializer.InitialSeed(context);
               
            }
        }
    }
}
