using System; 
namespace ConsoleApplication1 { 
   
class IN { 
    
    public string name; 
    public string subject; 
    
    public void readers(string name, string subject) 
    { 
        Console.WriteLine("Myself: " + name);  
        Console.WriteLine("My Favorite Subject is: " + subject); 
    } 
} 
    
class INHE : IN 
{  
    static void Main(string[] args) 
    { 
        INHE g = new INHE();
        Console.WriteLine("Enter Your Name") ;
        g.name=Console.ReadLine();
        Console.WriteLine("Enter Your Favourite subject name") ;
        g.subject=Console.ReadLine();
        g.readers(g.name, g.subject);
    }
}
} 
