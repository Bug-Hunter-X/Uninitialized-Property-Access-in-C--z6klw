public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize the property in the constructor
        MyProperty = 0; 
    }

    public void MyMethod()
    {
        int value = MyProperty * 2; // Now MyProperty is guaranteed to be initialized
    }
} 