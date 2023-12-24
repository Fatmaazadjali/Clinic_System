using System;
using Clinic.Models;
using Clinic.DbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq;



namespace Clinic
{
    internal class Program
    {

        static void NewPatients()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            Console.WriteLine("Enter your name:");
            string PatientName = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number:");
            int PhoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Age:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Patients Address:");
            string PatientsAddr = Console.ReadLine();
            Console.WriteLine("Enter Patient's Gender (Male/Female):");

            string GenderChoose = Console.ReadLine();
            //string Lowerbool = GenderChoose.ToLower();
            // bool IsMale = string.Equals(GenderChoose, "Male", StringComparison.OrdinalIgnoreCase);


            Patients Patients = new Patients
            {
                PatientName = PatientName,
                PhoneNumber = PhoneNumber,
                Age = Age,
                Address = PatientsAddr,
                Gender = GenderChoose

            };

            context.Patient.Add(Patients);
            context.SaveChanges();

            Console.WriteLine("Data inserted successfully!");
        }
        //public Patients LogIn(int PatientId)
        //{
        //    using ApplicationDbContext context = new ApplicationDbContext();
        //    using (var dbContext = new ApplicationDbContext())
        //    {
        //        var patient1 = context.Patient.FirstOrDefault(p => p.PatientId == PatientId);
        //        return patient1;
        //    }

        //    return null;
        //    //Console.WriteLine("Enter Your Id:");
        //    //Console.ReadLine();
        //    //Console.WriteLine("Enter Your PhoneNumber:");
        //    //Console.ReadLine();
        //    //Console.WriteLine("Your LogIn Successfully!!");
        //}

        //public static Patients LogIn(string patientName)
        //{
        //    using (ApplicationDbContext context = new ApplicationDbContext())
        //    {
        //        // Use ToLower() for case-insensitive comparison
        //        var patient = context.Patient.FirstOrDefault(p => p.PatientName.ToLower() == patientName.ToLower());

        //        if (patient != null)
        //        {
        //            // Patient found, return the data
        //            Console.WriteLine($"Welcome back, {patient.PatientName}!");
        //            Console.WriteLine($"Phone Number: {patient.PhoneNumber}");
        //            Console.WriteLine($"Age: {patient.Age}");
        //            Console.WriteLine($"Address: {patient.Address}");
        //            Console.WriteLine($"Gender: {patient.Gender}");

        //            return patient;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Patient not found. Please check your login credentials.");
        //            return null;
        //        }
        //    }
        //}


       //public void LogIn()
       // {
       //     using ApplicationDbContext context = new ApplicationDbContext();
       //     var patient = (from p in context.Patient
       //                    where p.PatientId == this.Equals(PatientId)
       //                    select p).FirstOrDefault
       // }
        static void Displays()
        {

        }

       
        public static void Main(string[] args)
        {
           
                Console.WriteLine("Welcome to Our Clinic");
            Console.WriteLine("-----------------");

            Console.WriteLine("Choose your Option:");
            Console.WriteLine("1. Register ");
            Console.WriteLine("2. Log In");
            Console.WriteLine("3. Display the available offers");
            Console.WriteLine("4. Exit");

            string UserChoise = Console.ReadLine();

            if (UserChoise == "1")
            {
               NewPatients(); 
            } else if (UserChoise == "2"){

                Console.WriteLine(LogIn);




            }
            else if (UserChoise == "3")
            {
                Console.WriteLine("Hello");

            } else if (UserChoise == "4")
            {
                Console.ReadKey();
            }


        }

    }
}