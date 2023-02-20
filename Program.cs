using MigrantsTransferTrackerBLL;
using System;

namespace MigrantsTransferTrackerConsoleUi   //DO NOT change the namespace name
{
    class Program     //DO NOT change the class name
    {
        static void Main(string[] args)
        {
            int choice;
            var migrantsTransferService = new MigrantsTransferService();
            do
            {
                Console.WriteLine("Available Operations");
                Console.WriteLine("1. Add migrants transfers data");
                Console.WriteLine("2. Show data by state");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choice:");
                choice = int.Parse(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            CollectData(migrantsTransferService);
                            break;
                        case 2:
                            DisplayTransferHistory(migrantsTransferService);
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                catch (MigrantsTransferValidationException ex)
                {
                    Console.WriteLine("Validation error : " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : " + ex.Message);
                }
            } while (choice != 3);
        }
              
        private static void CollectData(MigrantsTransferService service)
        {
            //Implement code here. 
            //Do not change method signature

            Console.WriteLine("Enter transfer dtae in mm/dd/yyyy format");
            DateTime tdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of state from where migrants are transfered");
            string fstate = Console.ReadLine();
            Console.WriteLine("Enter name of state to where migrants are transfered");
            string tstate = Console.ReadLine();
            Console.WriteLine("Enter the total number of migrants being transferred");
            int tno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the mode of transfer being used");
            string tmode = Console.ReadLine();
            Console.WriteLine("Enter the vehicle number used for transfer");
            string tvehicle = Console.ReadLine();
            MigrantsTransferService mts = new MigrantsTransferService();
            MigrantsTransfer mt = new MigrantsTransfer(tdate, fstate, tstate, tno, tmode, tvehicle);
            if (mts.AddTransferDetails(mt))
            {
                Console.WriteLine("Transfer details saved successfully");
            }



        }       

        private static void DisplayTransferHistory(MigrantsTransferService service)
        {
            //Implement code here. 
            //Do not change method signature
        }        
    }
}

