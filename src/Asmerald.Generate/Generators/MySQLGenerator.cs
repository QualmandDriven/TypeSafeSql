﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asmerald.Generate.Generators
{
    /// <summary>
    /// Source code generator for a Postgres database.
    /// </summary>
    internal class MySQLGenerator : IGenerator
    {
        public Task<Dictionary<string, string>> Generate()
        {
            throw new NotImplementedException();
        }

        public Task<Dictionary<string, string>> Generate(string nspace)
        {
            throw new NotImplementedException();
        }
    }
}