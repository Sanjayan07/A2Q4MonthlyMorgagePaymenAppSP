/*Name: Sansayan Pratheepan
 * Date: 2/24/2024
 * Title: A2Q4 Mortgage Payment APP SP
 * Purpose:Ask the User for their Interest Rate per period, Initial Principal (initial Loan), and total number of payment periods, and using that find the amount of money they need to give to the bank per month, for mortgage. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q4MonthlyMorgagePaymenAppSP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declare Variables
            string strLoan;
            double dblLoan;
            string strInterestRate;
            double dblInterestRate;
            string strPaymentPeriods;
            double dblPaymentPeriod;
            double dblMonthlyPayment;
            double monthlyInterestRate;
            double dblCal1;
            double dblCal2;
            double dblCal3;

            // Input
            Console.WriteLine("What was your initial Loan Amount (how much you took from the bank?"); //ask for principal
            Console.Write("Principal Amount: ");
            strLoan = Console.ReadLine();
            dblLoan = Double.Parse(strLoan); //Convert the string to double 

            Console.WriteLine("What is your annual interest rate (how much interest the bank is charging you with, normally a percent, divided by 12 (convert from annual))?");
            Console.Write("Annual Interest Rate: ");
            strInterestRate = Console.ReadLine();
            dblInterestRate = Double.Parse(strInterestRate); // Convert annual rate to monthly rate

            Console.WriteLine("What Are Your Total Number of Payments (Normally the amount of years multiplied by 12)?"); //Ask for total payments
            Console.Write("Total Number of Payments: ");
            strPaymentPeriods = Console.ReadLine();
            dblPaymentPeriod = Double.Parse(strPaymentPeriods);
              

            // Process
            monthlyInterestRate = dblInterestRate / 100 / 12;
            dblCal1 = dblLoan * monthlyInterestRate; //Break down the equation into simpler parts so that everything can be done separately by reducing confusion.
            dblCal2 = Math.Pow(1 + monthlyInterestRate, dblPaymentPeriod * 12); //Top half of the fraction
            dblCal3 = (Math.Pow(1 + monthlyInterestRate, dblPaymentPeriod * 12) - 1); //bottom half of the fraction
            dblMonthlyPayment = dblCal1 * (dblCal2 / dblCal3); //combine everything
            dblMonthlyPayment = Math.Round(dblMonthlyPayment, 2); //round to 2 decimal places

            // Output
            Console.WriteLine("Your Total Payment For Your Monthly Mortgage is: $" + dblMonthlyPayment);

            Console.ReadKey();

        }
    }
}
