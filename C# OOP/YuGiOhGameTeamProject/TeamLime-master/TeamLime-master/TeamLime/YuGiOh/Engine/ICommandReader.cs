namespace YuGiOh.Engine
{
    using System;

    public interface ICommandReader
    {
        void RunCommand(FieldManager fieldManager, string command);
    }
}
