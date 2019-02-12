﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    public class Vehicle
    {
        public string Id { get; }

        public Location Location { get; set; }

        public Vehicle (string id)
        {
            Id = id;
        }

        public event EventHandler LocationChanged;

        private void OnLocationChanged()
        {
            LocationChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
