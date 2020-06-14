using System;
using TaskFour.Controllers;

namespace TaskFour
{
    class Program
    {
        static void Main()
        {
            ConsoleController consoleController = new ConsoleController();

            consoleController.Init();
        }
    }
}
