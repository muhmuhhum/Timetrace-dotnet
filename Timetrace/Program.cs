using System;
using System.Collections.Generic;
using Timetrace.cli;

namespace Timetrace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Command> Commands = new List<Command>
            {
                List.ListCommand()
            };
            var cmdString = args[0];
            foreach (var command in Commands)
            {
                if (cmdString == command.Use)
                {
                    command.Run.Invoke(command, args);
                }
            }
        }
    }
}