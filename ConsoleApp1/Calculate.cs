using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculate
    {
        double time;
        double timefactor;
        double money;
        string risk;
        
        string inconvenience;
        
        
        

        public Calculate(double time, double money,Model model, string factors)
        {//takes info from model,then checks if factors have been inserted
            this.time = time;
            
            this.money = money;
            risk = model.risk;
            timefactor = model.timeFactor;
            if (factors.Length==0)//checks factors are inputted
            {
                inconvenience = model.inconvenience;
                
                risk = model.risk;
               
            }
            else { StringParse(factors); }

        }
        public double TotatCost() //calculate the total cost
        {
            double increase = PercentageCalc(); //calculate percentage increase by factors
            double cost = increase*(time * (timefactor/60) + money);
            return cost;
        }

        public void StringParse(string input)//string parser,takes each word into substrings then checks for keywords,after takes the word after the keyword
        {
            string[] separatingChars = { ":", " " };

            string text = input;
           

            string[] words = text.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);

           
            for (int i = 0; i < words.Length; i++)
            {
                

                if (words[i]=="Risk"|| words[i] == "risk")
                {
                    risk = words[i + 1];
                }
                if (words[i] == "Inconvenience" || words[i] == "inconvenience")
                {
                    inconvenience = words[i + 1];
                    
                }
            }
          
        }
        public double PercentageCalc() //calculates percentage increase by taken word
        { double increase=1;
            if(risk=="low")
            { increase = increase + 0.1; }
            if (risk == "medium")
            { increase = increase + 0.3; }
            if (risk == "high")
            { increase = increase + 1; }
            if (risk == "none")
            { increase = increase + 0; }
            if (inconvenience == "low")
            { increase = increase + 0.1; }
            if (inconvenience == "medium")
            { increase = increase + 0.3; }
            if (inconvenience == "high")
            { increase = increase + 1; }
            if (inconvenience == "none")
            { increase = increase + 0; }
            return increase;
        }
}
}
