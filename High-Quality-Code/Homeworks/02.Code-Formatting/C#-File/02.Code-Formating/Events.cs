namespace _02.Code_Formating
{
    using System;
    using System.Text;

    public class Events
    {
        private static StringBuilder output = new StringBuilder();
        private static EventHolder events = new EventHolder();

        public static void Main()
        {
            while (ExecuteNextCommand())
            {
            }

            Console.WriteLine(output);
        }

        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();

            if (command[0] == 'A')
            {
                AddEvent(command);
                return true;
            }

            if (command[0] == 'D')
            {
                DeleteEvents(command);
                return true;
            }

            if (command[0] == 'L')
            {
                ListEvents(command);
                return true;
            }

            if (command[0] == 'E')
            {
                return false;
            }

            return false;
        }

        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = GetDate(command, "ListEvents");
            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);

            events.ListEvents(date, count);
        }

        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);

            events.DeleteEvents(title);
        }

        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            GetParameters(command, "AddEvent", out date, out title, out location);

            events.AddEvent(date, title, location);
        }

        private static void GetParameters(string commandForExecution, string commandType, out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            int firstPipeIndex = commandForExecution.IndexOf('|');
            int lastPipeIndex = commandForExecution.LastIndexOf('|');

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        private static DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
            return date;
        }

        public static class Messages
        {
            public static void EventAdded()
            {
                output.Append("Event added\n");
            }

            public static void EventDeleted(int x)
            {
                if (x == 0)
                {
                    NoEventsFound();
                }
                else
                {
                    output.AppendFormat("{0} events deleted\n", x);
                }
            }

            public static void NoEventsFound()
            {
                output.Append("No events found\n");
            }

            public static void PrintEvent(Event eventToPrint)
            {
                if (eventToPrint != null)
                {
                    output.Append(eventToPrint + "\n");
                }
            }
        }
    }
}
