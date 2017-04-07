﻿using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new NancyHost(new Uri("http://localhost:1111")))
            {
                host.Start();
                Console.WriteLine("Running on http://localhost:1111");
                Console.ReadLine();
            }
        }
    }
}