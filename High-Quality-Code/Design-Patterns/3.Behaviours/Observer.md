# Behavioral Patterns

## Observer/Наблюдател

 * Дефинира връзка "едно към много" между различни обекти
 * Когато някой обект промени състоянието си, всички наблюдатели са уведомени и обновени
 * Представя интерфейс, който позволява на обектите да комуникират помежду си, без да съдържат конкретна връзка един с друг

Както личи от името му, Наблюдател е обект, който следи/наблюдава други обекти, следвайки холивудския принцип ("Не ни се обаждай, ние ще ти се обадим"). В модела има специален обект (субект), който други обекти следят, регистрирайки се за някакво събитие. Когато субектът провокира събитието, всички наблюдатели биват уведомени.

## Клас диаграма:

![Factory method](http://www.dofactory.com/images/diagrams/net/observer.gif)

Компоненти:

 * *__Subject:__*
   * Знае кои са наблюдателите му
   * Предоставя интефейс за закачване и разкачване на обекти-наблюдатели
 * *__ConcreteSubject:__*
   * Съхранява състояние, което представлява интерес за наблюдателя
   * Уведомява наблюдателите, когато състоянието се промени
 * *__Observer:__*
   * Дефинира интерфейс за обновяване за обектите, които трябва да бъдат уведомени за промени в субекта.
 * *__ConcreteObserver:__*
   * Поддържа референция към обект *ConcreteSubject*
   * Съхранява състояние, което трябва да остане консистентно с това на субекта
   * имплементира обновяващия интерфейс на *Observer*-a, за да поддържа състоянието си в унисон с това на субекта

Примерен код:

```
static void Main()
{
   Subject subject = new Subject();
   // Observer1 takes a subscription to the store
   Observer observer1 = new Observer("Observer 1");
   subject.Subscribe(observer1);
   // Observer2 also subscribes to the store
   subject.Subscribe(new Observer("Observer 2"));
   subject.Inventory++;
   // Observer1 unsubscribes and Observer3 subscribes to notifications.
   subject.Unsubscribe(observer1);
   subject.Subscribe(new Observer("Observer 3"));
   subject.Inventory++;
   Console.ReadLine();
}

public class Subject:ISubject
{
  private List<Observer> observers = new List<Observer>();
  private int _int;
  public int Inventory
  {
    get
    {
       return _int;
    }
    set
    {
       // Just to make sure that if there is an increase in inventory then only we are notifying 
          the observers.
          if (value > _int)
             Notify();
          _int = value;
    }
  }
  public void Subscribe(Observer observer)
  {
     observers.Add(observer);
  }

  public void Unsubscribe(Observer observer)
  {
     observers.Remove(observer);
  }

  public void Notify()
  {
     observers.ForEach(x => x.Update());
  }
}

interface ISubject
{
   void Subscribe(Observer observer);
   void Unsubscribe(Observer observer);
   void Notify();
}

public class Observer:IObserver
{
  public string ObserverName { get;private set; }
  public Observer(string name)
  {
    this.ObserverName = name;
  }
  public void Update()
  {
    Console.WriteLine("{0}: A new product has arrived at the
    store",this.ObserverName);
  }
}

interface IObserver
{
  void Update();
}
```