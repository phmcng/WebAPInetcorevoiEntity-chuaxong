﻿using hd.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFraneworkCore;
using System.Security.Cryptography;
using System;
using ett1_web_api.Models;

namespace ett1_web_api.Data
{
    public class StudentContext : DbContext
    {
        // public StudentContext() : base("name=StudentDBConnectionString") //winform
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) //webapi
        {
        }

        public DbSet<Student> Students { get; set; }

    }
}
