using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CMMS_Draft
{
    public enum Category { HVAC = 1, Machinig, FAS, Process }
    class Resources
    {
        private static string adminPassword;
        public static bool exitFlag;
        internal static string AdminPassword 
        { 
            get 
            { 
                return adminPassword; 
            }
            set
            {
                if (value != "password" && value !="admin")
                {
                    adminPassword = value;
                    Console.WriteLine("Password successfully changed.");
                } else
                {
                    Console.WriteLine("Srsly? Password NOT changed.");
                }
            }
        }

        internal static MachineActionService Initialize(MachineActionService machineActionService)
        {
            machineActionService.AddNewMachine("AHU-1", Category.HVAC);
            machineActionService.AddNewMachine("AHU-2", Category.HVAC);
            machineActionService.AddNewMachine("AHU-3", Category.HVAC);
            machineActionService.AddNewMachine("AHU-4", Category.HVAC);
            machineActionService.AddNewMachine("AHU-5", Category.HVAC);
            machineActionService.AddNewMachine("FirePump_1", Category.FAS);
            machineActionService.AddNewMachine("FirePump_2", Category.FAS);
            machineActionService.AddNewMachine("Sprinklers", Category.FAS);
            machineActionService.AddNewMachine("ProcessLathe_1", Category.Process);
            machineActionService.AddNewMachine("ToolroomLathe_2", Category.Machinig);
            machineActionService.AddNewMachine("ProcessHeatTreatment_1", Category.Process);

            machineActionService.AddNewEntry(machineActionService.GetAllMachines().First(), "First serious problem");
            machineActionService.AddNewEntry(machineActionService.GetAllMachines().First(), "Second serious problem");
            machineActionService.AddNewEntry(machineActionService.GetAllMachines().First(), "Third very serious problem");

            return machineActionService;
        }

        public static MenuActionService Initialize(MenuActionService actionService)
        {
            AdminPassword = "1234";

            // Admin Menu Items
            actionService.AddNewAction(1, "Add new machine", "AdminMenu");
            actionService.AddNewAction(2, "Delete machine", "AdminMenu");
            actionService.AddNewAction(3, "Change Password", "AdminMenu");
            actionService.AddNewAction(4, "Exit program", "AdminMenu");

            // User Menu Items
            actionService.AddNewAction(1, "Add entry to machine", "UserMenu");
            actionService.AddNewAction(2, "Display all entries for machine", "UserMenu");
            actionService.AddNewAction(3, "Exit program", "UserMenu");

            // Add New Machine Menu Items
            actionService.AddNewAction(1, "HVAC", "AddMachineMenu");
            actionService.AddNewAction(2, "Machinig", "AddMachineMenu");
            actionService.AddNewAction(3, "FAS", "AddMachineMenu");
            actionService.AddNewAction(4, "Process", "AddMachineMenu");

            return actionService;
        }
    }
}
