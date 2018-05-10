using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalwcf
{
    public class addy
    {
        private string service;
        private string route;
        private string routee;
        private string bus;
        private string capacity;

        public string Service
        {
            get
            {
                return service;
            }

            set
            {
                service = value;
            }
        }

        public string Route
        {
            get
            {
                return route;
            }

            set
            {
                route = value;
            }
        }

        public string Routee
        {
            get
            {
                return routee;
            }

            set
            {
                routee = value;
            }
        }

        public string Bus
        {
            get
            {
                return bus;
            }

            set
            {
                bus = value;
            }
        }

        public string Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }
    }
}