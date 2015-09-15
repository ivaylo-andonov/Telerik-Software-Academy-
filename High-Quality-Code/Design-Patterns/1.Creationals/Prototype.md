# Prototype

## Намерение
Този шаблон за дизайн се използва за създаване на инстанция от даден клас чрез клониране на вече съществуващ обект.
Определя видовете обекти за създаване чрез прототипна инстанция.
Създава обекти с клониране на един от няколко предварително съхранени прототипа.

## Мотив
Когато имаме нужда от създаване на високоструващ обект (отнема време и ресурси за създаването му), се използва този шаблон. Не се използва самото създаване на обектите, а тяхното клониране.
Шаблонът позволява на обекта да създаде конкретни, персонализирани обекти, като ги клонира, без да се знае техния клас или каквито и да е било подробности за това как да ги създаде.

## Участници
#### Prototype:
Декларира интерфейс за самото клониране.
#### Concrete Prototype:
Изпълнява операцията по клонирането.
#### Client:
Създава нов обект (клониран такъв), като казва на Prototype-а да се клонира.

## Приложимост
Шаблонът Prototype се използва когато:
*   Една система трябва да бъде независима от това как нейните продукти са създадени, съставени (съдържат полета и други) и как се представят.
*   Когато инстанцираните обекти са специфични по време на изпълнението на програмата.

## Свързани шаблони
Abstract Factory. Разликата е че, Abstract Factory-то може да се съхранява набор от прототипи, от които да се клонират и да се връщат обекти.

## Структура

![alt text](schemes/structures/prototype-structure.png)

## Пример
Prototype за създаване на Stormtrooper

![alt prototype-classdiagram](schemes/diagrams/prototype-classdiagram.png)

###### Abstract Stormtrooper Prototypr
~~~c#
public abstract class StormtrooperPrototype
{
    public abstract Stormtrooper Clone();
}
~~~

###### Abstract Stormtrooper Prototypr
~~~c#
public class Stormtrooper : StormtrooperPrototype
{
    public Stormtrooper(string type, int height, int weight)
    {
        Thread.Sleep(3000); // Doing something slow
        this.Type = type;
        this.Height = height;
        this.Weight = weight;
    }
    
    public string Type { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }

    public override Stormtrooper Clone()
    {
        return this.MemberwiseClone() as Stormtrooper;
    }
    
    public override string ToString()
    {
        return string.Format("Type: {0}, Height: {1}, Weight: {2}", this.Type, this.Height, this.Weight);
    }
}
~~~

###### Usage
~~~c#
public static void Main()
{
    var darkTrooper = new Stormtrooper("Dark trooper", 180, 80);
    Console.WriteLine(darkTrooper);
            
    var anotherDarkTrooper = darkTrooper.Clone();
    darkTrooper.Height = 200;
    Console.WriteLine(anotherDarkTrooper);
}
~~~