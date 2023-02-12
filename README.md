# Prototype

The code is a simple implementation of the Prototype design pattern in C#. 

It demonstrates how to create a new object by copying an existing object instead of creating it from scratch. 

The Prototype abstract class defines the Clone method that must be implemented by classes that use the Prototype pattern. 

The Drink class implements the Prototype class, with two properties Brand and Price, and a Clone method that returns a new Drink object with the same values as the original. 
In the Main method, a Drink object is created, cloned, and assigned to another variable, showcasing how the Prototype pattern can be used.

