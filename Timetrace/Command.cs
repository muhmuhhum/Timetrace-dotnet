using System;
using System.Collections.Generic;

namespace Timetrace
{
    public class Command
    {
        public string Use { get; set; }
        public string Short { get; set; }
        public int ArgCount { get; set; }
        public List<Command> SubCommands { get; set; }
        public Action<Command, string[]> Run { get; set; }


        public void Help()
        {
            Console.WriteLine(Short);
            Console.WriteLine();
            Console.WriteLine("Usage:");
        }

        private void Usage()
        {
            
        }
    }
}