# Uninitialized Property Access in C#

This repository demonstrates a subtle bug in C# that can occur when accessing a class property before it has been explicitly initialized. This can lead to unexpected values, exceptions, or unpredictable program behavior.

## The Bug
The `bug.cs` file contains a class with a property that is not initialized in the constructor.  The `MyMethod` function attempts to use this property before a value has been assigned, leading to the potential bug.

## The Solution
The `bugSolution.cs` file provides a solution to this issue by ensuring the property `MyProperty` is initialized either in the constructor or before its first use in `MyMethod`. 

This example highlights the importance of initializing class members explicitly to avoid unexpected behavior and runtime issues.