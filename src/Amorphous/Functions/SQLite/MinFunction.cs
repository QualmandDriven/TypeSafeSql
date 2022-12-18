using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
{
    public class MinFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public MinFunction() { }
        public MinFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}