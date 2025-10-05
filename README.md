<h1 align="center">Object-Oriented Programming Exercises Lists</h1>

<p align="center">
  <a href="https://learn.microsoft.com/pt-br/dotnet/"><img alt="DotNet 8" src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white&style=for-the-badge" /></a>
  <a href="https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/"><img alt="C#" src="https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white&style=for-the-badge" /></a>
</p>

## 💻 Project

Repository with exercises on `Object-Oriented Programming` and the use of lists in `C#`.

## 📕 Exercise list

1 - Create a Product class with attributes like name, price, and quantity in stock. Implement a constructor and methods to add, display the total value of the stock, and remove items from stock.

2 - Create a Purchase class with attributes to record purchase information (date, product, value). Implement a constructor and methods to add and list purchases.

3 - Create a RealEstate class with attributes to store information about properties (address, price, type). Implement a constructor and methods to list available properties and calculate the average value. Create a menu containing options to insert properties, change a property's price, and present all properties. Insert the properties into a list to facilitate the work.

4 - Create a PhoneBook class with properties to store contacts (Name, Phone, Email). Implement a constructor and methods to add to a list, remove, and search for contacts.

5 - Create a JobManager class with attributes to store a list of tasks (Description, DueDate). Implement a constructor and methods to add, remove, and list tasks. Add a method to check if the task should be executed today.

6 - Create an interface called IProductManager with the methods ListProducts, SearchProductByCode, AddProduct, RemoveProduct. Then create the class ProductManager and implement the interface IProductManager, passing a list of products in the ProductManager class constructor.

7 - Create a class called Song that contains the attributes name, author, and record label. Afterward, create a class Playlist that has a list of songs as an attribute and a string to store the playlist owner. Implement a method to add songs to the list, to "play the song" (just show a message on the screen with the song's title). Try to implement random playback, meaning instead of iterating from the beginning to the end of the list, use a random number generator to access valid random values.

8 - Create classes called Manufacturer and Product. Manufacturer should have the properties Name, Address, and City. Product should have the properties Name, Manufacturer (object of the Manufacturer class), and Price. Use encapsulation to ensure the name is not empty and that the price is positive.

9 - Create a class called Book that has the properties Title and Author. Use encapsulation to ensure that the title and the author are not empty.

10 - Create a class called Animal that has the properties Name, Species, and Age. Also, create a method called MakeSound, which prints the animal's sound to the screen. Subsequently, add the classes Dog and Cat to inherit from the Animal class.

11 - Create an abstract class called Vehicle with the attributes model, year, and speed. Then, create one method to accelerate the car (increasing the speed by 10) and another to brake the car (decreasing the speed by 10, but never letting the speed become negative). After that, create the classes Car and Motorcycle to receive the implementation from the Vehicle class.

12 - Create a class called Agenda and another class called Person. The Agenda class will use a list of people for the following operations to be performed:

- void storePerson(String name, int age, float height);

- void removePerson(String name);

- Person findPerson(String name); returns the person with the specified name

- void printSchedule(); prints the data of all people in the agenda

- Create a menu to navigate between the options indefinitely.

## 📗 Exercise answers
- [Exercise 1](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise01)
- [Exercise 2](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise02)
- [Exercise 3](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise03)
- [Exercise 4](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise04)
- [Exercise 5](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise05)
- [Exercise 6](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise06)
- [Exercise 7](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise07)
- [Exercise 8](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise08)
- [Exercise 9](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise09)
- [Exercise 10](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise10)
- [Exercise 11](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise11)
- [Exercise 12](https://github.com/pauloalvesm/dotnet-oop-lists-exercises/tree/master/src/OOP.Lists.Exercise12)

## 🚀 Technologies and Tools

This project was developed using the following technologies:

- **Backend:**  
  - `.NET 8`
  - `Console Application`
  - `C#`
 
  ## 💾 Clone the repository

```bash
git clone https://github.com/pauloalvesm/dotnet-oop-lists-exercises.git
```

## 👤 Author

**[Paulo Alves](https://github.com/pauloalvesm)**
