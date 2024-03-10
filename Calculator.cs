using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_tapsiriq
{
    public class Calculator
    {
        public decimal Price;
        public decimal One;
        public decimal Two;
        public char Symbol;
        public Calculator(decimal a, decimal b, char c)
        {
            One = a;
            Two = b;
            Symbol = c;
        }
        
        public void Calc()
        {
         
            
                if (Symbol == '+')
                {
                    Price += One + Two;
                }
                else if (Symbol == '-')
                {
                    if (One < Two)
                    {
                        Console.WriteLine("Menfi ededen musbet eded cixmaq mumkun deyil");
                    }
                    else
                    {
                        Price += One - Two;
                    }
                }
                else if (Symbol == '*')
                {
                    Price += One * Two;
                }
                else if (Symbol == '/')
                {
                    Price += One / Two;
                }
                else
                {
                    Console.WriteLine("Zehmet Olmasa Daxil Etdiyiniz Reqemleri Yoxlayin");
                }

                Console.WriteLine("Cavabiniz:" + Price);
                Console.ReadLine();  
        }
    }
}
