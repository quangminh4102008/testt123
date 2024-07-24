namespace Test.Test1;

public class People
{
    public string Name{ get; set; }
    public bool Gender{ get; set; }
    public int Age{ get; set; }
    public People(string name, bool gender, int age)
    {
        Name = name;
        Gender = gender;
        Age = age;
    }
    public override string ToString()
    {
        return $" Name = {Name} , {(Gender ? "Male" : "Female")}, Age = {Age}";
    }


}