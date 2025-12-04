Student Name:Adeniyi Emmanuel 
Student ID:71739
Abstract classes and Interfaces both create structures but manage code contracts in different ways. An abstract class is intended to define a family.
It implements a strict “is-a” hierarchy. For example, a Dog is an Animal. It is a model that has some of its code implemented.
A base model may hold code that is fully working such as its implemented methods applicable for reuse. 
It may also contain some abstract methods that must be defined by all subclasses. 
Furthermore, it may hold state that is instance variables/fields.  
The main limitation is that a class can only inherit from a single abstract class, so it is the best option when we want to reuse the code for closely related objects.

An interface, on the other hand, is only concerned about the definition of a capability or contract and expresses a “can do” relationship (i.e. Dog can be Walkable). 
This is a pure abstraction which has method signatures and constants alone.It lays down what must be done without any implementation details. 
This purity enables a great deal of flexibility: a single class can implement many interfaces and thus conform to many distinct contracts. 
Thus, interfaces are the best means to enforce a behaviour across multiple, unrelated classes. 
