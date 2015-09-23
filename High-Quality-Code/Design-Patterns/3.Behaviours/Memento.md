# Behavioral Patterns

## Memento/Мементо

 * Запазва вътрешното състояние на обекта и дава възможност за последващо връщане към запазеното състояние
 * Undo и save/load операции

Шаблонът Мементо позволява да бъдат запазени дадени състояния на обект, към които обектът може да бъде върнат по-късно. По време на работата на приложението, потребителят може да поиска да върне към предишно състояние, например определен чекпойнт в игра или undo метод в програма за текстова обработка.

Ключово за този шаблон е, че клиентският код никога няма да има достъп до *Memento* обекта, като всички взаимодействия с него се осъществяват чрез класа *Caretaker*. Клиентът не се интересува как точно различните състояния се съхраняват или възстановяват.

## Клас диаграма:

![Factory method](http://www.devlake.com/design-patterns/memento/memento.PNG)

Компоненти:

 * *__Originator:__* Обектите, които ще бъдат запазвани и по-късно възстановявани:
   * Променливата *state* съдържа информация, представляваща състоянието на *Originator* обекта. Това е променливата, която запазваме и възстановяваме.
   * Методът *CreateMemento* се използва, за да се запази състоянието на *Originator*-а. Той създава обект *Memento*, запазвайки в него променливата *state* и го връща като резултат.
   * Методът *SetMemento* възстановява *Originator*-а, приемайки *Memento* обект, като го обработва и сетва променливата му *state*, използвайки съответната променлива от *Memento*, в която предварително е било запазено дадено състояние.
 * *__Memento:__* Този клас съхранява информацията за *Originator*-a в променливата си *state*.
 * *__Caretaker:__* Класът, който управлява списъка от *Memento* обекти и който клиентският код може да достъпи.
 

Примерен код:

```
public class Program
{
    static void Main()
    {
        Originator<string> orig = new Originator<string>();

        orig.SetState("state0");
        Caretaker<string>.SaveState(orig); //save state of the originator
        orig.ShowState();

        orig.SetState("state1");
        Caretaker<string>.SaveState(orig); //save state of the originator
        orig.ShowState();

        orig.SetState("state2");
        Caretaker<string>.SaveState(orig); //save state of the originator
        orig.ShowState();

        //restore state of the originator
        Caretaker<string>.RestoreState(orig, 0);
        orig.ShowState();  //shows state0
    }
}

//object that stores the historical state
public class Memento<T>
{
    private T state;

    public T GetState()
    {
        return state;
    }

    public void SetState(T state)
    {
        this.state = state;
    }
}

//the object that we want to save and restore, such as a check point in an application
public class Originator<T>
{
    private T state;

    //for saving the state
    public Memento<T> CreateMemento()
    {
        Memento<T> m = new Memento<T>();
        m.SetState(state);
        return m;
    }

    //for restoring the state
    public void SetMemento(Memento<T> m)
    {
        state = m.GetState();
    }

    //change the state of the Originator
    public void SetState(T state)
    {
        this.state = state;
    }

    //show the state of the Originator
    public void ShowState()
    {
        Console.WriteLine(state.ToString());
    }
}

//object for the client to access
public static class Caretaker<T>
{
    //list of states saved
    private static List<memento><T>> mementoList = new List<memento><T>>();

    //save state of the originator
    public static void SaveState(Originator<T> orig)
    {
        mementoList.Add(orig.CreateMemento());
    }

    //restore state of the originator
    public static void RestoreState(Originator<T> orig, int stateNumber)
    {
        orig.SetMemento(mementoList[stateNumber]);
    }
}
```