// static is a modifier that makes a member belong to a type, rather than an "instance" of a type
// we can even make entire classes static

/*
static class MyStaticClass  // Associated with the type itself
{
    public static void MyStaticMethod()
    {
        Console.WriteLine("Hello from a static method!");
    }
}
*/

// note that we cannot make an instance of "MyStaticClass" because it is marked static
//MyStaticClass myStaticClass = new MyStaticClass(); // This would cause a compile-time error


// static class canot have instance members, so anything inside of a static class must also be a static

// Notice How we don't need to make an instance of MyStaticClass to call MyStaticMethod
// this is just like Console.WriteLine. This means that Console.WriteLine is a static method!

// on non-static classes, we *can* add static members

MyNonStaticClass myNonStaticClass1 = new MyNonStaticClass();
MyNonStaticClass myNonStaticClass2 = new MyNonStaticClass();



Console.WriteLine("Before mutating properties on MyNonStaticClass...");
myNonStaticClass1.MyInstanceMethod();
myNonStaticClass2.MyInstanceMethod();
MyNonStaticClass.MyStaticMethod();


// lets mutate these things and see what happens!
myNonStaticClass1.MyInstanceProperty = "Dev";
myNonStaticClass2.MyInstanceProperty = "Leader";
MyNonStaticClass.MyStaticProperty = "Nick Cosentino";

Console.WriteLine("After mutating properties on MyNonStaticCLass...");
myNonStaticClass1.MyInstanceMethod();
myNonStaticClass2.MyInstanceMethod();
MyNonStaticClass.MyStaticMethod();


// static members are accessible acress all instances. this can be
// 

class MyNonStaticClass
{
    public string MyInstanceProperty { get; set; } = "Nick";

    public static string MyStaticProperty { get; set; } = "Cosentino";

    public static void MyStaticMethod()
    {
        Console.WriteLine("Hello from a static method!");

        // tHIS WILL NOT WORK because MyinstanceProperty is not static
        Console.WriteLine("Hello from a static method!");

    }

    public void MyInstanceMethod()
    {
        Console.WriteLine($"the static property value is: {MyStaticProperty}");
        Console.WriteLine($"MyInstanceProperty: {MyInstanceProperty}");

    }
}