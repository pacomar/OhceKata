using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhceKata
{
    public class Ohce
    {
        private string name;

        public enum Responses
        {
            [StringValue("¡Buenas noches {0}!")]
            GoodNight = 0,
            [StringValue("¡Buenos días {0}!")]
            GoodMorning = 1,
            [StringValue("¡Buenas tardes {0}!")]
            GoodAfternoon = 2,
            [StringValue("¡Bonita palabra!")]
            Palindrome = 3,
            [StringValue("Adios {0}")]
            GoodBye = 4
        }
        public enum ReserveWords
        {
            [StringValue("ohce")]
            ohce = 0,
            [StringValue("Stop!")]
            stop = 1
        }

        public Ohce()
        {
            this.name = "";
        }

        public string AnalizeInput(string inputText, DateTime hour)
        {
            String[] words = inputText.Split(' ');
            if (words.Length > 0)
            {
                if (words[0] == StringValueAttribute.GetStringValue(ReserveWords.ohce) && words.Length > 1)
                {
                    this.name = words[1];
                    if(hour.Hour >= 6 && hour.Hour < 12)
                    {
                        return string.Format(StringValueAttribute.GetStringValue(Responses.GoodMorning), this.name);
                    }
                    else if (hour.Hour >= 12 && hour.Hour < 20)
                    {
                        return string.Format(StringValueAttribute.GetStringValue(Responses.GoodAfternoon), this.name);
                    }
                    else if (hour.Hour >= 20 && hour.Hour <= 23 || hour.Hour >= 0 && hour.Hour < 6)
                    {
                        return string.Format(StringValueAttribute.GetStringValue(Responses.GoodNight), this.name);
                    }
                }
                else if (words[0] == StringValueAttribute.GetStringValue(ReserveWords.stop))
                {
                    return string.Format(StringValueAttribute.GetStringValue(Responses.GoodBye), this.name);
                }
                else
                {

                    char[] arr = inputText.ToCharArray();
                    Array.Reverse(arr);
                    string res = new string(arr);
                    if (inputText == res)
                    {
                        return StringValueAttribute.GetStringValue(Responses.Palindrome);
                    }
                    else
                    {
                        return res;
                    }
                }
                
            }
            return String.Empty;
        }
    }
}
