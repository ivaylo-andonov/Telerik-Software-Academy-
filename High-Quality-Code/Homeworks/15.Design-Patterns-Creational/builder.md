# Builder Pattern

## Мотивация

 * Служи за  създаване на обекти, при които е важна последователността на инициализиране на различните компоненти на обекта. 
 * В общия случай различните компоненти са взаимно зависими, което налага определена последователност при създаването им. 
 * Създаването на различните компоненти се осъществява чрез методи, които са дефинирани в интерфейс. Това позволява на всеки наследник на съответния интерфейс да имплементира по свой начин създаването на компонентите. 
 * Следващата стъпка е създаването на клас, който определя необходимите компоненти и последователността на създаването им. 
 * Това означава, че както можем да имаме различни имплементации на методологиите за създаване на компоненти, така можем да имаме и различни имплементации за композирането им.
 

## Цел

 * Създаване на обекти, при които е важна последователността на инициализиране на различните компоненти на обекта.

## Приложение

* Нека изясня всико казано с един пример:
 
 	Искаме да произвеждаме коли. Създаваме интерфейс, който дефинира всички методи, които ще ни създават съставните части на колата. Следващата стъпка е да създадем класове производители на колите - Мерцедес, БМВ(класове, които имплементират интерфейса). Всеки производител, ще произведе компонентите на колите по свой собствен начин. Съответно накрая ще имаме една машина, която сглобава елементите в определен ред(клас CarConstructor. Евентуално може и всеки производител да има свой собствен CarConstructor). Примерът не е напълно адекватен, защото със сигурност БМВ и Мерцедес използват различни части за конструирането на колите си и съответно ще ползват различни Builder интерфейси, но с учебна цел забравяме за това :)
    
## Известни употреби
* конструирането на HTML докимент

## Имплментация 

```
using System;
using System.Collections;

  public class MainApp
  {
    public static void Main()
    { 
      // Create director and builders 
      Director director = new Director();

      Builder b1 = new ConcreteBuilder1();
      Builder b2 = new ConcreteBuilder2();

      // Construct two products 
      director.Construct(b1);
      Product p1 = b1.GetResult();
      p1.Show();

      director.Construct(b2);
      Product p2 = b2.GetResult();
      p2.Show();

      // Wait for user 
      Console.Read();
    }
  }

  // "Director" 
  class Director
  {
    // Builder uses a complex series of steps 
    public void Construct(Builder builder)
    {
      builder.BuildPartA();
      builder.BuildPartB();
    }
  }

  // "Builder" 
  abstract class Builder
  {
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract Product GetResult();
  }

  // "ConcreteBuilder1" 
  class ConcreteBuilder1 : Builder
  {
    private Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartA");
    }

    public override void BuildPartB()
    {
      product.Add("PartB");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "ConcreteBuilder2" 
  class ConcreteBuilder2 : Builder
  {
    private Product product = new Product();

    public override void BuildPartA()
    {
      product.Add("PartX");
    }

    public override void BuildPartB()
    {
      product.Add("PartY");
    }

    public override Product GetResult()
    {
      return product;
    }
  }

  // "Product" 
  class Product
  {
    ArrayList parts = new ArrayList();

    public void Add(string part)
    {
      parts.Add(part);
    }

    public void Show()
    {
      Console.WriteLine("\nProduct Parts -------");
      foreach (string part in parts)
        Console.WriteLine(part);
    }
  }
  ```

## Последствия
* Дава ясна представа какво трябва да се имплементира от клиента 
* Осигурява цялостния модел на обекта

## Сродни модели
* Factory method
* Abstract Factory

## Проблеми
* Създава сложен обект, който ако не удовлетворява изискванията на повече от един ползватели, е безпредметно да се използва. С други думи, ако кодът, който ни създава обект няма никаква перспектива да се използва за създаване на други обекти, съставени от същите компоненти, нямаме нужда от него. По-просто би било да създадем логиката за създаване на обекта в самия клас, който го представлява.

## UML  диаграма

![alt text](http://www.apwebco.com/images/Builder.jpg")
