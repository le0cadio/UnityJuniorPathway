# What is Abstraction?
![abstraction](https://user-images.githubusercontent.com/99060199/181403377-883fa7cd-b2ca-4b48-b7af-654477936d45.png)



The first pillar of OOP is all about keeping your code clean and simple for the programmer using it, whether that is you or someone else. Abstraction is the process of removing complex code from the scripts where other programmers will see it, and only exposing the functionality other programmers really need. When you “abstract out” the details, you reduce duplicate code and provide easy access to the most useful functions.

Abstraction simplifies your code and keeps it clean, making it easier for programmers to use. The core tenet of abstraction is to hide unnecessary complexity from the other programmers, and only expose what is needed to make the code run as it’s meant to. It means taking the complex inner workings and replacing them with abstract, more reusable pieces of code.  Following this principle also simplifies the process of refactoring later.

# What is inheritance?

![inheritance](https://user-images.githubusercontent.com/99060199/181403583-e2bb4479-dcb2-4e76-8dba-b60a33d1dfc5.png)


Inheritance is the process of creating a primary class (also known as a parent class) from which other classes (called child classes) can be created. A child class takes on, or inherits, all of the features of the parent class automatically. It’s common to have different classes share similar features in an application. For example, a video game may feature many different types of enemy classes, but they are likely to share the same core features, such as managing their own health and the ability to deal damage to the player. With inheritance, the need to write that health and damage functionality for each individual enemy class is eliminated, so that you can focus on writing functionality that’s unique to each class. 

![inheritance2](https://user-images.githubusercontent.com/99060199/181403602-f6fd407f-2b77-4c84-b00a-c698247f3cde.png)

# What is polymorphism?

![polymorphism](https://user-images.githubusercontent.com/99060199/181403787-42ee3c39-8845-4b1e-97dd-65839c02abde.png)

Although inheriting core functionality from a parent class can be helpful, there are many situations where you don’t want the child class to perform exactly the same action as the parent class. Polymorphism allows you to change the functionality of what an object inherits from its parent class. Inheritance and polymorphism help you create interrelationships between your classes that ultimately help to reduce the total amount of code you need to write.

# What is encapsulation?


Much like abstraction, encapsulation focuses heavily on maintaining a level of separation between the underlying complexity of your code and other code that uses it. Due to their similarity, you will sometimes see some followers of OOP practices group abstraction and encapsulation into a single pillar, typically under the header of encapsulation. However, we’re making a distinction that we think is important: while abstraction is all about summarizing code to make it simpler for other programmers, encapsulation is all about protecting values and data, as if they are enclosed in a capsule, so that you control what others do and do not have access to.  

A major theme of encapsulation is safety in code — in other words, the process of ensuring that code is only used as it is intended to be used, and the values and data you are manipulating can’t be corrupted. In encapsulated code, other programmers can’t easily change the values of variables or the properties of objects. It’s impossible to account for all of the different ways that other scripts might access your code, so it's far better to encapsulate what you’ve created so it can only perform as intended. 

Encapsulation protects your code by controlling the ways values are accessed and changed, so that your code is only used as explicitly designed. Like abstraction, encapsulation places a layer of separation between the underlying complexity of your code and the programmers who might be accessing it. 


