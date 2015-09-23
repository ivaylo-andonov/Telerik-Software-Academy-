## Behavioral Design Patterns

### **State** ###

##### Мотивация
State pattern е модел дизайн, който позволява на даден обект напълно да промени поведението си в зависимост от текущото си вътрешно състояние. Чрез заместване на класове в рамките на определен контекст променя типа си по време на изпълнение.
##### Цел
Този модел дизайн променя поведението на даден обект като отговор на промените на вътрешното му състояние. Той позволява да се промени поведението по време на изпълнение, без да  се променя интерфейса използван за достъп до обекта. Тази промяна се крие в контекста на този обект.
 
##### Приложение
Този модел е много полезен при създаването на софтуерни машини, където функционалността на даден обект се променя коренно според състоянието му.


##### Имплементация

```c#    
public class DVDPlayer
    {
        private DVDPlayerState state;

        public DVDPlayer()
        {
            this.state = new StandbyState();
        }

        public DVDPlayer(DVDPlayerState state)
        {
            this.state = state;
        }

        public void PressPlayButton()
        {
            this.state.PlayButtonPressed(this);
        }

        public void PressMenuButton()
        {
            this.state.MenuButtonPressed(this);
        }

        public DVDPlayerState State
        {
            get { return this.state; }
            set { this.state = value; }
        }
    }

public abstract class DVDPlayerState
    {
        public abstract void PlayButtonPressed(DVDPlayer player);

        public abstract void MenuButtonPressed(DVDPlayer player);
    }

public class MenuState : DVDPlayerState
    {
        public MenuState()
        {
            Console.WriteLine("Menu");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            Console.WriteLine("Next menu");
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new StandbyState();
        }
    }

public class MoviePausedState : DVDPlayerState
    {
        public MoviePausedState()
        {
            Console.WriteLine("Movie paused");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            player.State = new MoviePlaingState();
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new MenuState();
        }
    }

public class MoviePlaingState : DVDPlayerState
    {
        public MoviePlaingState()
        {
            Console.WriteLine("Movie Playing");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            player.State = new MoviePausedState();
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new MenuState();
        }
    }

public class StandbyState : DVDPlayerState
    {
        public StandbyState()
        {
            Console.WriteLine("STANDBY");
        }

        public override void PlayButtonPressed(DVDPlayer player)
        {
            player.State = new MoviePlaingState();
        }

        public override void MenuButtonPressed(DVDPlayer player)
        {
            player.State = new MenuState();
        }
    }

public static void Main()
        {
            DVDPlayer player = new DVDPlayer();
            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
        }

```
##### Участници
Context

StateBase

ConcreteState