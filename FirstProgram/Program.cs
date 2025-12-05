// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


OurClass ourObject = new OurClass();
OurClass anotherObject = new();

OurSecondClass ourSecondObject = new();
ourSecondObject.ExampleMethod();


int result = ourSecondObject.ExampleFunction();



OurClass object1 = new OurClass();
OurClass object2 = new OurClass();
OurClass object3 = object1;  // variable object3 references the same object as object1

Console.WriteLine("object1 == object2");
Console.WriteLine(object1 == object2);  //False
Console.WriteLine("object1 == object3");
Console.WriteLine(object1 == object3);  // True



List <int> myNumbers1 = new List<int> { 1, 2, 3, 4, 5 };
List <int> myNumbers2 = new List<int> { 1, 2, 3, 4, 5 };

Console.WriteLine("myNumbers1 == myNumbers2");
Console.WriteLine(myNumbers1 == myNumbers2);  //False - Thet are not the same object in memory


void ChangeValue(int value)
{
    value = 42;
}

int myValue = 1337;
Console.WriteLine("myValue before ChangeValue:");
Console.WriteLine(myValue);  // 1337

ChangeValue(myValue);  // It will only change inside it

Console.WriteLine("myValue before ChangeValue:");  
Console.WriteLine(myValue);  // 1337


void ChangeReference(List<string> words)
{
    // words = new List<string>();  // This list only exist inside the function
    words.Add("from");
    words.Add("Dev");
    words.Add("Leader");
}


List<string> myWords = new List<string> {"Hello", "World" };
Console.WriteLine("myWords before ChangeReference:");
Console.WriteLine(string.Join(" ", myWords)); // Hello World

ChangeReference(myWords);

Console.WriteLine("myWords after ChangeReference:");  //  Hello World from Dev Leader
Console.WriteLine(string.Join(" ", myWords));


 




class OurClass
{

}

public class OurSecondClass
{
    public void ExampleMethod()
    {
        Console.WriteLine("Hello from our method!");
    }

    public int ExampleFunction()
    {
        return 42;
    }
}