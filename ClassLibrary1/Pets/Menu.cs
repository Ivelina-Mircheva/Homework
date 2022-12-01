using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Menu
    {
        private int close = 6;

        private void ShowMenu()
        {
            Console.WriteLine(new string('-',40));
            Console.WriteLine(new string(' ',18)+"MENU"+ new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Get All");
            Console.WriteLine("2. Create");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Get by id");
            Console.WriteLine("6.Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        //All();
                        break;
                    case 2:
                        //Create();
                        break;
                    case 3: 
                        //Update();
                        break;
                    case 4:
                        //Delete();
                        break;
                    case 5:
                        //GetById();
                        break;
                    default:
                        break;

                }
            } while (operation != close);
        }
    }
}
