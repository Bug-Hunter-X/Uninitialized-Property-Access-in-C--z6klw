public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized can lead to unpredictable behavior
        int value = MyProperty * 2; // Bug: MyProperty might not be initialized
    }
}