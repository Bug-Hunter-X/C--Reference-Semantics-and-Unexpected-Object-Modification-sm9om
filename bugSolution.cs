using System;

public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    //Method for cloning the object
    public MyClass Clone() => new MyClass(this.MyProperty);

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        // Create a copy of obj1 instead of a reference
        MyClass obj2 = obj1.Clone();

        obj2.MyProperty = 20;

        Console.WriteLine(obj1.MyProperty); // Output: 10
        Console.WriteLine(obj2.MyProperty); // Output: 20
    }
}