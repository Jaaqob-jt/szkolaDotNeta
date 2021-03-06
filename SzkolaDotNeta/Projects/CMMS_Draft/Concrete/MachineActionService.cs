﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.Security.Cryptography;

namespace CMMS_Draft 
{
    public class MachineActionService : IService<Machine>
    {
        private List<Machine> allMachines = new List<Machine>();
        private List<Entry> allEntries = new List<Entry>();
        public List<Machine> Items { get { return allMachines; } set{ allMachines = value; } }

        public void AddNewMachine(string name, Category category)
        {
            Machine machine = new Machine() { Id = Machine.IdSeed, Name = name, Category = category, Entries = new List<Entry>() };
            Machine.IdSeed++;
            allMachines.Add(machine);
        }
        public List<Machine> GetAllMachines()
        {
            return allMachines;
        }
        public Machine GetMachineById(int id)
        {
            try 
            {
                return allMachines.Where(item => item.Id == id).First();
            }
            catch
            {
                Console.WriteLine("\tCould not find a machine with this identifier.");
                return null;
            }
        }
        public void RemoveMachine(int id)
        {
            try
            {
                allMachines.Remove(allMachines.Where(item => item.Id == id).First());
                Console.WriteLine("\tMachine removed.");
            }
            catch 
            {
                Console.WriteLine("\tCould not find a machine with this identifier.");
            }
        }
        public List<Entry> GetMachineEntries(Machine machine)
        {
            if (!machine.Entries.Any<Entry>())
            {
                return Resources.GetNoEntries();
            }
            return machine.Entries;
        }
        public void AddNewEntry(Machine machine, string description)
        {
            machine.Entries.Add(new Entry(description));
        }
        public Entry GetLastEntry(Machine machine)
        {
            return machine.Entries.Last();
        }

        public int AddItem(Machine item)
        {
            throw new NotImplementedException();
        }

        public int UpdateItem(Machine item)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(Machine item)
        {
            throw new NotImplementedException();
        }
    }
}
