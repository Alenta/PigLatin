using System.Linq;
namespace PigLatin;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Is 153 Narcissistic? " + Narcissistic(153));
    }
    public static string PigIt(string str)
    {
        string[] words = str.Split(' ');
        Console.WriteLine(words);
        for (int i = 0; i < words.Length; i++)
        {
            if(words[i].Length > 1){
                char firstLetter = words[i][0];
                words[i] = words[i].Substring(1);
                words[i] = words[i] + firstLetter + "ay";
            }
            
            Console.WriteLine(words[i]);
            str = words[i] + " ";  
        }      
        return str;
    }

    public static bool Narcissistic(int value)
    {
        int expo = value.ToString().Length;
        var valuesIE = value.ToString().Select(digit => int.Parse(digit.ToString()));
        List<int>intList = valuesIE.ToList();
        List<int>intCalculated = new();
        int result=0;
        for (int i = 0; i < intList.Count(); i++)
        {
            intCalculated.Add((int)Math.Pow(intList[i], expo));
        }
        for (int i = 0; i < intCalculated.Count(); i++)
        {
            result += intCalculated[i];
        }
        if(result==value) return true;
        else return false;
    }
}
