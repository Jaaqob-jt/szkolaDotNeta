using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace CMMS_Draft
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            MachineActionService machineActionService = new MachineActionService();
            actionService = Resources.Initialize(actionService);
            machineActionService = Resources.Initialize(machineActionService);
            Console.WriteLine("Hello to your User-Friendly CMMS System!\n\n");

            while (!Resources.exitFlag)
            {
                // Check credentials and use proper menu
                Console.WriteLine("\nPlease type password, to access Admin menu.");
                bool adminMenu = (Console.ReadLine() == Resources.AdminPassword) ? true : false;
                string currentMenu = adminMenu ? "AdminMenu" : "UserMenu";

                // Dispaly list of machines
                Console.WriteLine("\nAvailable Machines:");
                foreach (var machine in machineActionService.GetAllMachines()) Console.WriteLine(machine.ToString());
                Console.WriteLine();

                // Menu list
                Console.WriteLine("\nPlease choose an item from the list:");

                foreach (var item in actionService.GetMenuActionsByMenuName(currentMenu))
                {
                    Console.WriteLine(item.ToString());
                }
                var operation = Console.ReadKey();
                if (adminMenu)
                {
                    switch (operation.KeyChar)
                    {
                        // Add machine
                        case '1':
                            Console.WriteLine("\tPlease choose a category:");
                            int cat = 1;
                            foreach (var item in Enum.GetValues(typeof(Category)).Cast<Category>())
                            {
                                Console.WriteLine($"{(int)item}. {item}");
                            }
                            if (int.TryParse(Console.ReadLine(), out int tempCategory) && Enum.IsDefined(typeof(Category), tempCategory))
                            {
                                cat = tempCategory;
                            }
                            else
                            {
                                Console.WriteLine($"\tThere is no such category. By default is should be {Enum.GetName(typeof(Category), cat)}");
                            }
                            Console.WriteLine("\tPlease describe your machine:");
                            machineActionService.AddNewMachine(Console.ReadLine(), (Category)cat);
                            Console.WriteLine($"Added machine:\n{machineActionService.GetAllMachines().Last()}");
                            break;

                        // Delete Machine
                        case '2': 
                            Console.WriteLine("\nPlease type machine Id to remove it from the list:");
                            if (int.TryParse(Console.ReadLine(), out int result))
                            {
                                machineActionService.RemoveMachine(result);
                            }
                            else
                            {
                                Console.WriteLine("\tCould not find a machine with this identifier.");
                            }
                            break;
                        // Change Password
                        case '3': 
                            Console.WriteLine("\nPlease choose new password");
                            Resources.AdminPassword = Console.ReadLine();
                            break;
                        // Exit
                        case '4': 
                            Resources.exitFlag = true;
                            break;
                        default:
                            Console.WriteLine("\nInvalid option");
                            break;
                    }
                } else
                {
                    // Choose machine

                    switch (operation.KeyChar)
                    {
                        // Add new entry
                        case '1':
                            Console.WriteLine("\nPlease type machine Id to add an entry");
                            if (int.TryParse(Console.ReadLine(), out int tryId))
                            {
                                Console.WriteLine("Please describe your problem:");
                                machineActionService.AddNewEntry(machineActionService.GetMachineById(tryId), Console.ReadLine());
                            }
                            else
                            {
                                Console.WriteLine("\tCould not find a machine with this identifier.");
                            }
                            break;
                        // Display historical entries
                        case '2':
                            Console.WriteLine("\nPlease type machine Id to see all entries:");
                            if (int.TryParse(Console.ReadLine(), out int tryId2))
                            {
                                foreach (var item in machineActionService.GetMachineEntries(machineActionService.GetMachineById(tryId2)))
                                {
                                    Console.WriteLine(item.ToString());
                                }
                            }
                            else
                            {
                                Console.WriteLine("\tCould not find a machine with this identifier.");
                            }
                            break;
                        // Exit
                        case '3': 
                            Resources.exitFlag = true;
                            break;
                        default:
                            Console.WriteLine("\nInvalid option");
                            break;
                    }
                }
            } 
            Console.WriteLine("\nKurtyna");
        }
    }
}
