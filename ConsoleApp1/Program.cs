using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    class Program
    {
     
        static void Main(string[] args)
        {//c++ doesn't have cmd functionality,you have to input time,money model id and the factors,pressing enter after each
            double time= double.Parse(Console.ReadLine()); 
            double money=double.Parse(Console.ReadLine());
            string modelId = Console.ReadLine();
            string factors = "0";
            //factors can be put like "First:low Second:high"
             factors = Console.ReadLine();
            ModelRepo modelRepo = new ModelRepo();
            
            Model model = modelRepo.Finder(modelId);

            Calculate calculate = new Calculate(time, money , model,factors);

            double value = calculate.TotatCost();
            value = Math.Round(value,0);
            Console.WriteLine(value);
            Console.ReadLine();
           
        }
       
    }
}
