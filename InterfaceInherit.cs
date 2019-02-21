using System;

 
public interface A
{
void mymethod1();
} 
public interface B : A
{ 
    void mymethod2();
}
 
class Mateusz : B
{ 
    public void mymethod1()
    {
        Console.WriteLine("Implement method 1");
        Console.ReadKey();
    }
    public void mymethod2()
    {
        Console.WriteLine("Implement method 3");
        Console.ReadKey();
    }
} 
class Mate
{ 
    static void Main(String[] args)
    {
 
        Mateusz obj = new Mateusz();
 
        obj.mymethod1();
        obj.mymethod2();
    }
}
