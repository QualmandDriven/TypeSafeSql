using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MariaDB
{
    public class QuoteFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public QuoteFunction() { }
        public QuoteFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
