// constructors are used to initialize a class


// this still has a constructor even though we cant see it!
class ImplicitConstructor
{

}


// this class has a parameterless constructor
class ExplicitConstructor
{
    public ExplicitConstructor()
    {
        // we can put initialization logic here
        Console.WriteLine("ExplicitConstructor called!");
    }
}


// this class has a constructor that takes in a value
class ConstructorWithParameter
{
    public ConstructorWithParameter(string message)
    {
        Console.WriteLine(message);
    }
}


// this is a class with multiple constructors "chained"
// together by using : this() syntax
class MultipleConstructors
{

}


// Instructor was on something, impossible to reproduce
