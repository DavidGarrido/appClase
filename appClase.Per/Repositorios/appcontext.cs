using System;
using Microsoft.EntityFrameworkCore;
using appClase.Dom;

namespace appClase.Per{
    public class appcontext:DbContext
    {
        public DbSet<Cerdo> Cerdo {get;set;}
    }
}