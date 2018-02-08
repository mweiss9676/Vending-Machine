﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace Capstone
{
    public class VendingMachineLogic
    {
        public Dictionary<string, List<VendingMachineItem>> Inventory { get; }

        public decimal Balance { get; private set; }

        public string[] Slots { get; }

        public VendingMachineLogic()
        {
            VendingMachineFileReader filereader = new VendingMachineFileReader();
            Inventory = filereader.GetInventory();
        }
    }
}