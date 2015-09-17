# Decorator Pattern

## Мотивация

 * Служи за добавяне на функционалност на група от класове, които наследяват общ клас/интерфейс.
 * Създаването на новите компоненти на всеки клас се осъществява чрез клас, който наследява общия интерфейс. Това елиминира нуждата от модификация на вече готовите класове, което спазва Open-Closed принципа -класовете са отворен за нови функционалности и затворени за промяна.
 

## Цел

 * Елеминиране на нуждата от модификация на всички съществуващи класове. 

## Приложение

* Пример:
 
	Нека имаме библиотека, която предлага 10 различни вида артикула. Ако искаме половината от тях да имат опцията освен да бъдат давани под наем, да бъдат и продавани можем да добавим във всеки един клас по една булева променлива, която да отговаря за това дали съответният артикул може да бъде продаван или не. Следвайки SOLID принципите както и идеята за предотвратяване на излишно писане на код бихме могли да създадем един клас 'Decorator', който имплементира базовия интерфейс, наследяващ всички тези 10 класа(артикула). Този клас 'Decorator' се явява родител на всички класове(нови функционалности), които искаме да добавим.
	
    
## Известни употреби
* I/O Api в Java и C++

## Имплментация 

```c#
using System;
using System.Collections.Generic;
 
namespace DoFactory.GangOfFour.Decorator.RealWorld
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Decorator Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create book
      Book book = new Book("Worley", "Inside ASP.NET", 10);
      book.Display();
 
      // Create video
      Video video = new Video("Spielberg", "Jaws", 23, 92);
      video.Display();
 
      // Make video borrowable, then borrow and display
      Console.WriteLine("\nMaking video borrowable:");
 
      Borrowable borrowvideo = new Borrowable(video);
      borrowvideo.BorrowItem("Customer #1");
      borrowvideo.BorrowItem("Customer #2");
 
      borrowvideo.Display();
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Component' abstract class
  /// </summary>
  abstract class LibraryItem
  {
    private int _numCopies;
 
    // Property
    public int NumCopies
    {
      get { return _numCopies; }
      set { _numCopies = value; }
    }
 
    public abstract void Display();
  }
 
  /// <summary>
  /// The 'ConcreteComponent' class
  /// </summary>
  class Book : LibraryItem
  {
    private string _author;
    private string _title;
 
    // Constructor
    public Book(string author, string title, int numCopies)
    {
      this._author = author;
      this._title = title;
      this.NumCopies = numCopies;
    }
 
    public override void Display()
    {
      Console.WriteLine("\nBook ------ ");
      Console.WriteLine(" Author: {0}", _author);
      Console.WriteLine(" Title: {0}", _title);
      Console.WriteLine(" # Copies: {0}", NumCopies);
    }
  }
 
  /// <summary>
  /// The 'ConcreteComponent' class
  /// </summary>
  class Video : LibraryItem
  {
    private string _director;
    private string _title;
    private int _playTime;
 
    // Constructor
    public Video(string director, string title,
      int numCopies, int playTime)
    {
      this._director = director;
      this._title = title;
      this.NumCopies = numCopies;
      this._playTime = playTime;
    }
 
    public override void Display()
    {
      Console.WriteLine("\nVideo ----- ");
      Console.WriteLine(" Director: {0}", _director);
      Console.WriteLine(" Title: {0}", _title);
      Console.WriteLine(" # Copies: {0}", NumCopies);
      Console.WriteLine(" Playtime: {0}\n", _playTime);
    }
  }
 
  /// <summary>
  /// The 'Decorator' abstract class
  /// </summary>
  abstract class Decorator : LibraryItem
  {
    protected LibraryItem libraryItem;
 
    // Constructor
    public Decorator(LibraryItem libraryItem)
    {
      this.libraryItem = libraryItem;
    }
 
    public override void Display()
    {
      libraryItem.Display();
    }
  }
 
  /// <summary>
  /// The 'ConcreteDecorator' class
  /// </summary>
  class Borrowable : Decorator
  {
    protected List<string> borrowers = new List<string>();
 
    // Constructor
    public Borrowable(LibraryItem libraryItem)
      : base(libraryItem)
    {
    }
 
    public void BorrowItem(string name)
    {
      borrowers.Add(name);
      libraryItem.NumCopies--;
    }
 
    public void ReturnItem(string name)
    {
      borrowers.Remove(name);
      libraryItem.NumCopies++;
    }
 
    public override void Display()
    {
      base.Display();
 
      foreach (string borrower in borrowers)
      {
        Console.WriteLine(" borrower: " + borrower);
      }
    }
  }
}
 
  ```

## Последствия
* Лесно добаване на нови функционалности

## Сродни модели
* Bridge Pattern


## UML  диаграма

![alt text](https://upload.wikimedia.org/wikipedia/commons/thumb/e/e9/Decorator_UML_class_diagram.svg/400px-Decorator_UML_class_diagram.svg.png)
a