﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripPlanner.Classes
{
    public class Plans
    {
        private DateTime startDate;
        private DateTime endDate;
        private string location;
        private double budget;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        public Plans()
        {
            startDate = DateTime.Today;
            endDate = DateTime.Today;
            location = "";
            budget = 0;
        }
        public void SetPlanDetails(DateTime startDate, DateTime endDate, string location, double bugget)
        {
            StartDate = startDate;
            EndDate = endDate;
            Location = location;
            Budget = budget;
        }
    }
}