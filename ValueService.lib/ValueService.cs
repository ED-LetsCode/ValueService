using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ValueServiceLibrary
{
    public class ValueService : IValueService
    {
        public ValueService()
        {
            PostFactors = new List<PostFactor>(){
                new PostFactor() { Text = "",       TextShort = "",  Potenz = null},
                new PostFactor() { Text = "pico",   TextShort = "p", Potenz = -12 },
                new PostFactor() { Text = "nano",   TextShort = "n", Potenz = -9 },
                new PostFactor() { Text = "mikro",  TextShort = "µ", Potenz = -6 },
                new PostFactor() { Text = "mili",   TextShort = "m", Potenz = -3 },
                new PostFactor() { Text = "kilo",   TextShort = "k", Potenz = 3 },
                new PostFactor() { Text = "Mega",   TextShort = "M", Potenz = 6 },
                new PostFactor() { Text = "Giga",   TextShort = "G", Potenz = 9 },
                new PostFactor() { Text = "Tera",   TextShort = "T", Potenz = 12 },
                new PostFactor() { Text = "Peta",   TextShort = "P", Potenz = 15 },
                new PostFactor() { Text = "Exa",    TextShort = "E", Potenz = 18 }
            };

        }
        public List<PostFactor> PostFactors { get; }

        public decimal GetDecimal(string value)
        {
            decimal result = 0;
            value = value.Replace('.', ',');
            string? postFactor = null;
            string?[] numbers = null;
            try
            {
                //if a value conatains a textshort then true example => 10k2
                foreach (var textShort in PostFactors.Where(element => value.Contains(element.TextShort)))
                {
                    numbers = value.Split(textShort.TextShort);
                    postFactor = textShort.TextShort;
                }
                //else try to parse value to a decimal number
                if (numbers == null) result = decimal.Parse(value);


                if (numbers != null)
                {
                    //if numbers array has mor then 2 indexes throw new Exception because string value was not in correct Format => example 10kk2
                    if (numbers.Count() > 2) throw new FormatException();
                    //if numbers array is not null and number array index 1 is not empty then join numbers array and parse it to a decimal number example => 10,2
                    if (numbers[1] != "") return Pow10PostFactor(decimal.Parse(string.Join(",", numbers)), postFactor);
                    //else join string with "" example 10
                    return Pow10PostFactor(decimal.Parse(string.Join("", numbers)), postFactor);
                }
            }
            catch (FormatException) { throw new FormatException(); }
            return Pow10PostFactor(result, postFactor);
        }

        public string GetDisplayValue(decimal value, int precision, string postFactorParam = "")
        {
            //if postfactor is not empty then use post factor from parameter else use post factor from GetPostFactor method
            string postFactor = postFactorParam != string.Empty ? postFactorParam : GetPostFactor(value);
            double.TryParse(Convert.ToString(GetPotenz(postFactor)), out var result);
            value /= (decimal)Math.Pow(10.00d, result);
            return $"{Math.Round(value, precision) + postFactor}";
        }

        public string GetPostFactor(decimal value)
        {
            var potenz = (int)Math.Floor(Math.Log10((double)value));
            var postfactor = PostFactors.FirstOrDefault(element => element.Potenz + 1 == potenz ||
                                                                   element.Potenz + 2 == potenz ||
                                                                   element.Potenz == potenz);
            return postfactor != null ? postfactor.TextShort! : string.Empty;
        }

        public int? GetPotenz(string value) => value == "" ? 0 : PostFactors.FirstOrDefault(element => element.TextShort == value)?.Potenz;

        public decimal Pow10PostFactor(decimal number, string postFactor)
        {
            double.TryParse(Convert.ToString(GetPotenz(postFactor)), out double result);
            return number * (decimal)Math.Pow(10.00d, result);
        }
    }
}
