using System;

namespace StateMachine3
{
    class Machine
    {

        public Machine()
        {
            State = 1;
        }

        public int State { get; private set; }

        public void ChangeState(int c)
        {
            if (c < 1 || c > 2)
            {
                throw new ArgumentException("Argument must be either 1 or 2", "c");
            }
            else if (c == 1)
            {
                State = 1;
            }
            else
            {
                State = 2;
            }
        }

        public void DisplayState()
        {
            if (State == 1)
            {
                Console.WriteLine("State: p");
            }
            else
            {
                Console.WriteLine("State: q");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Machine machine = new Machine();
            int command = 0;
            bool validCommand;
            bool finished = false;
            machine.DisplayState();
            while (!finished)
            {
                DisplayPrompt();
                validCommand = false;
                while (!validCommand)
                {
                    if (!(Int32.TryParse(Console.ReadLine(), out command)))
                    {
                        Console.WriteLine("Please enter a number!");
                        DisplayPrompt();
                    }
                    else
                    {
                        if (command < 1 || command > 3)
                        {
                            Console.WriteLine("Invalid command!");
                            DisplayPrompt();
                        }
                        else validCommand = true;
                    }
                }
                if (command == 3)
                {
                    finished = true;
                }
                else
                {
                    machine.ChangeState(command);
                    machine.DisplayState();
                }
            }
        }

        static void DisplayPrompt()
        {
            Console.WriteLine("1 = a");
            Console.WriteLine("2 = b");
            Console.WriteLine("3 = quit");
            Console.Write("Command: ");
        }
    }
}