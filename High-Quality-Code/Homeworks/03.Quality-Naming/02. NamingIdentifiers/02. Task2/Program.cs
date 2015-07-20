namespace People
{
    public class Creater
    {
        public Person CreatePerson(int id)
        {
            Person person = new Person();
            person.Age = id;

            if (id % 2 == 0)
            {
                person.Name = "Dobromir";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Iliana";
                person.Gender = Gender.Female;
            }

            return person;
        }
    }
}