using System.Linq;
namespace PigLatin;

class Program
{
    static void Main(string[] args)
    {
        bouncingBall(3.0, 0.66, 1.5);
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

    public static int bouncingBall(double h, double bounce, double window) {
		//Mother is at 1.5m
        //H must be over 0, bounce must be >0-<1, window must be less than H.
        double reboundHeight = h;
        int timesOverWindow = 1;
        if(h<0) return -1;
        if(bounce <= 0 || bounce>=1) return -1;
        if(window > h) return -1;
        while(reboundHeight>window)
        {
            reboundHeight *= bounce;
            if(reboundHeight>window) timesOverWindow+=2;
        }
	    return timesOverWindow;
	}
}
