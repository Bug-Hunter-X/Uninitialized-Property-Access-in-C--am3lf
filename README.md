# Uninitialized Property Access in C#

This example demonstrates a common error in C#: accessing a property of a class before it has been assigned a value.  While the compiler won't prevent this, it can lead to unexpected behavior, especially when dealing with value types. 

The `UninitializedPropertyAccess.cs` file shows the problematic code. The `UninitializedPropertyAccessSolution.cs` file demonstrates the solution: initializing the property before accessing it.