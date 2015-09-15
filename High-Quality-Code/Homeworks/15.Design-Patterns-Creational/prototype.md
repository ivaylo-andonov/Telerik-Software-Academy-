# Prototype Pattern

## Мотивация

 * Служи за  клониране на вече създадени обекти.
 * Ползват се, когато създаването на нов обект(копие) използва много повече ресурси, отколкото, ако го клонираме. 
 *  При класове, които се инстанцират по време на изпълнение на програмата
 
## Цел

 * Създава нови обекти като клонира вече създадени такива.

## Приложение

* Пример 1:

 Нека имаме игра 'лабиринт' с различни нива. Всеки един лабиринт има нужда от елемент играч, врата, стена, живот, бонус и т.н. подадени като параметър на обекта 'лабиринт'. Вместо за всяко едно ниво да инстанцираме всеки един елемент наново при подаването му в констуктора ла 'лабиринт' е по-подходящо да ги клонираме и да подаваме копията като параметър.
 
 * Пример 2:

Нека имаме игра, в която след всяко едно ниво, тя трябва да запомня state-a си и при евентуално умиране на играча или crash на играта да се връща в последното си запазено състояние, вместо в началото. Това може да се постигне с клониране на обекта 'game' и запазването му в накакъв файл.

* Пример 3:

Нека кажем, че създаваме библиотека. Ако при създаването на обектите, не искаме да бъде ясно на клиента как точно става това, можем да направим констуктора на дадения клас 'internal' и съответно да предоставим възможност за клонирането на готов такъв обект.



## Известни употреби

* клониране на всякакви данни, до които ще ни струва скъпо да достъпим отново(например от база с данни)


## Имплментация 

```
using System;
 
namespace PrototypeExample
{
  class MainApp
  {
    static void Main()
    {
      // Create two instances and clone each
 
      ConcretePrototype1 p1 = new ConcretePrototype1("I");
      ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
      Console.WriteLine("Cloned: {0}", c1.Id);
 
      ConcretePrototype2 p2 = new ConcretePrototype2("II");
      ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
      Console.WriteLine("Cloned: {0}", c2.Id);
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  abstract class Prototype
  {
    private string _id;

    public Prototype(string id)
    {
      this._id = id;
    }
 
    // Gets id
    public string Id
    {
      get { return _id; }
    }
 
    public abstract Prototype Clone();
  }
 
  class ConcretePrototype1 : Prototype
  {
    public ConcretePrototype1(string id)
      : base(id)
    {
    }
 
    // Returns a shallow copy
    public override Prototype Clone()
    {
      return (Prototype)this.MemberwiseClone();
    }
  }

  class ConcretePrototype2 : Prototype
  {
  
    public ConcretePrototype2(string id)
      : base(id)
    {
    }
 
    // Returns a shallow copy
    public override Prototype Clone()
    {
      return (Prototype)this.MemberwiseClone();
    }
  }
}
  ```

## Последствия
* Спестява използвани ресурси.
* Улеснява значително създаването на нови обекти

## Сродни модели
* Factory method
* Abstract Factory

## Проблеми

* Използването на този шаблон изисква всички класове, които трябва да бъдат копирани да наследяват ICloneable(ако ползваме вградения в .NET интерфейс) или да имат свой собствен метод Clone(). В случаите, когато това не е изпълнено, клонирането става по-трудно.
* Трябва да се внимава при имлементирането на методите, защото методът 'MemberwiseClone()'(когато става въпрос за референтни типове) копира референцията им, което води до създаването на 'shallow copy'.

## UML  диаграма

![alt text](http://www.apwebco.com/images/Prototype.jpg")
