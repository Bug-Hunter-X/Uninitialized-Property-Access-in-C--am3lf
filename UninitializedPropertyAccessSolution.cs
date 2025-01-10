public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before accessing it.
        MyProperty = 0; // Or another suitable default value
        int value = MyProperty; 
    }

    //Alternative solution:  using constructor to set values
    public ExampleClass()
    {
        MyProperty = 0;
    }
}    