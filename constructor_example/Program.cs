using constructor_example;
using System.ComponentModel;
using System.Threading.Channels;

public class Program
{
    public static void Main(string[] args)
    {
        //Default Constructor ile bebek nesnesi oluşturma
        baby baby1 = new baby();

        baby1.name = "ahsen";
        baby1.surname = "durmaz";

        baby1.PrintInformation();

        //alternative
        
        baby baby2 = new baby();
        baby2.name = "metehan";
        baby2.surname = "karahan";

        baby2.PrintInformation();


    }
    
}