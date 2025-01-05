# C# Reference Semantics and Unexpected Object Modification

This example demonstrates a common issue in C# related to reference semantics.  When you assign an object to a new variable, you're not creating a copy; you're creating a new reference to the same object in memory.

The `bug.cs` file shows how changing a property on one reference also changes the property on the other reference. This can be unexpected behavior if you assume you're working with separate copies of the object.

The `bugSolution.cs` file provides a solution using cloning to create a new instance and avoid this issue.