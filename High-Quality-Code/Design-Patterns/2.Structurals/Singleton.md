aaasaаас# Creational Patterns

## Singleton/Сингълтън

 * Шаблонът се използва, за да подсигури, че от даден клас може да бъде създадена една единствена инстанция
 * При нужда от допълнителни обекти от класа, се връща първоначално създадената единствена инстанция
 * Достъпването на класа от много нишки едновременно е предпоставка за проблем, затова се използва thread-safe имплементация

Шаблонът Сингълтън е един от най-добре познатите шаблони в софтуерното инженерство. В основата си това е клас, който позволява от него да може да бъде създадена единствена инстанция и дава достъп до тази инстанция.

Най-често тези класове не позволяват да се задават параметри при създаването на инстанцията, тъй като при подобен сценарий втори опит за създаване на инстанция с различни параметри би могъл да създаде проблем.

Обичайното изискване за Сингълтън инстанцията е тя да бъде създавана при нужда чрез т.нар. *lazy loading*, т.е. инстанцирането да се случва само, когато за първи път има нужда от инстанцията.

Използва се някой от методите за *thread-safe* инстанциране, за да няма възможност две или повече нишки едновременно да създадат инстанция на класа.


## Клас диаграма:

![Singleton pattern](http://www.dofactory.com/images/diagrams/net/singleton.gif)

Компоненти:

 * *__Singleton:__* Дефинира операция по създаването и поддържането на единствена уникална инстанция от класа.

Примерен код с използване на Lazy\<T>:

```
public sealed class Singleton
{
    private static readonly Lazy<Singleton> lazy =
        new Lazy<Singleton>(() => new Singleton());
    
    public static Singleton Instance { get { return lazy.Value; } }

    private Singleton()
    {
    }
}
```
Примерен код с използване на двойно заключване:

```
public sealed class Singleton
{
    private static Singleton instance = null;
    private static readonly object padlock = new object();

    private Singleton()
    {
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}
```
