namespace Test.Test1;

public class main
{
    public static void Main(String[] args)
    {
        People people = new People("minh",true,25);
        Console.WriteLine("Hello");
        Console.WriteLine("Properties Demo");
        Console.WriteLine("Person details: Name = " + people.Name + "Gender:" + people.Gender +"Age: "+ people.Age );
    }
}