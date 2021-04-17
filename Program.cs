using System;
//Comment Latest Name and Date
namespace assignment_four
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global Declarations
            int num_days;
            double  CODE_A = 169.00 , CODE_C= 112.00,  RATE = 75.00, total;
            //char code;
            char[] code = new char[0];
        
            //initialising 
            Console.WriteLine("Welcome! This program will have you input the number of days your pet will be staying with us.");
            Console.WriteLine("Please enter the number of days your pet will stay with us. ");
            num_days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Will there be any add-on services? Enter Y for yes or N for no.");
            if(Console.ReadLine().ToUpper() == "Y"){
               total = computeRateCode(num_days, CODE_A = 169.00 , CODE_C= 112.00,  RATE = 75.00);
            }else{
                total = computeRate(num_days, RATE = 75.00);

                }
                                    
        }

        //Overloaded method with one argument
        static int computeRate(int num_days, double RATE = 75.00)
        {
            

            Console.WriteLine("Please re-enter the number of days your pet will be staying with us.");
            num_days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The rate is $75.00 per day.");

            //logic for determining the total
            double total = num_days * RATE;
            Console.WriteLine($"The rate for your pet is ${total}.");

            Console.WriteLine("Thank you for using this program. ");
            Console.WriteLine($"You pet will be staying with us for {num_days} days, and for a total of ${total}.");


            return num_days;
        }



        //Overloaded method with two arguments
        static double computeRateCode( double num_days, double CODE_A = 169.00 , double CODE_C= 112.00, double RATE = 75.00, char code = '0')
        {
            //double num_days, code_a = 169.00 , code_c= 112.00;
            double total;



            Console.WriteLine("Please re-enter the number of days your pet will be staying with us.");
            num_days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You have two options of add-ons. One is bathing and grooming for $169.00 per day. The other is only bathing for $112.00 per day. Enter A for bathing and grooming. Enter C for bath only.");
            
            string strng = Console.ReadLine();
            char[] c = strng.ToCharArray();

            //code = Convert.ToChar(Console.ReadLine());

            //logic for determining the total based on code
            try{
            if(Console.ReadLine().ToUpper() == "A"){
                total = num_days * RATE + CODE_A;
                Console.WriteLine($"Your total per day is ${total}");
                Console.WriteLine("Thank you for using this program. ");
            Console.WriteLine($"You pet will be staying with us for {num_days} days, and for a total of ${total}.");
            }else {
                total = num_days * RATE + CODE_C;
                Console.WriteLine($"Your total per day is ${total}");
                Console.WriteLine("Thank you for using this program. ");
            Console.WriteLine($"You pet will be staying with us for {num_days} days, and for a total of ${total}.");
            }}

            catch(IndexOutOfRangeException){
                Console.WriteLine("The data you entered is not valid. Please re-enter the information.");
                
            }

            

            return num_days;


        }


    }
}
