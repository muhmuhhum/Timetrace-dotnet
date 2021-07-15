using System;

namespace Timetrace.cli
{
    public class List
    {
        public static Command ListCommand()
        {
            return new Command
            {
                Use = "list",
                Short = "List all resources",
                Run = new Action<Command, string[]>((cmd, args) =>
                {
                    cmd.Help();
                })
            };
        }
    }
}