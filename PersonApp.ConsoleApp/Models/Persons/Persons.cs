﻿// ------------------------------------------------
// Copyright (c) MumsWhoCode. All rights reserved.
// ------------------------------------------------

using System;

namespace PersonApp.ConsoleApp.Models.Persons
{
    internal class Persons
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        internal void Add(Persons persons)
        {
            throw new NotImplementedException();
        }
    }
}