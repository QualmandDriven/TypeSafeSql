using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
{
    public class SubstrFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public SubstrFunction() { }
        public SubstrFunction(ISelectExpression x, ISelectExpression y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}