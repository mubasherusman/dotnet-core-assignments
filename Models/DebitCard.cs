﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAssignment.Models
{
    public class DebitCard
    {
        public int Id { get; set; }

        public string CardName { get; set; }

        public BankAccount BankAccount { get; set; }

    }
}
