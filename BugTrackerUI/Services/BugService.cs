﻿using BugTrackerUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI.Services
{
    public class BugService : IBugService
    {
        private List<Bug> Bugs = new List<Bug>();

        public void AddBug(Bug newBug)
        {
            newBug.Id = Bugs.Count + 1; // simulate database id
            Bugs.Add(newBug);
        }

        public List<Bug> GetBugs()
        {
            return Bugs;
        }
    }
}
