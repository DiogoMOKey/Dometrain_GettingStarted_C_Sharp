

// what does pricate do in the above examples?
// "private" is an access modifier
// We saw "public" as an access modifier in earlier videos.
// "private" specifies that something is accessible only within the class


Person2 john = new Person2();
// john._name = "John";  // this will not work because _name is private

Person3 johnWithMethod = new Person3();
Console.WriteLine(johnWithMethod.GetName());


// methods and functions can also have "privatre" access modifier
// if a method/function is private, it can only be accessed within the class
// There are other access modifiesrs that we will cover later

Person4 johnWithProperty = new Person4();
Console.WriteLine(johnWithProperty.Name);
Console.WriteLine(johnWithProperty.Name2);
Console.WriteLine(johnWithProperty.Name3);


Console.WriteLine("Setting the name...");
johnWithProperty.MutableName = "John Doe";
Console.WriteLine(johnWithProperty.MutableName);
Console.WriteLine(johnWithProperty.Name);
Console.WriteLine(johnWithProperty.Name2);
Console.WriteLine(johnWithProperty.Name3);


// a field is a variable that is declared directly in a class
// here is how we declare a field in a class
class Person
{
    private string _name;

    public void SomeMe()
    {
        this._name = "John";
    }
}

// We can give a field a value when declared
class Person2
{
    private string _name = "John";
}


// we can give a field a value when we declare it
class Person3
{
    private string _name = "John";

    public string GetName() { return _name; }
}



class Person4
{
    private string _name = "John";

    public string Name
    {
        get { return _name; }
    }
    public string Name2 => _name;  // this the same as above

    public string Name3 { get; } = "John";  // Name 3 is complety independent of _name

    public string MutableName 
    {
        get { return _name; }
        set { _name = value; }
    }
}
