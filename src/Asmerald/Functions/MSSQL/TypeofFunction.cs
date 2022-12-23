using System;
using System.Collections.Generic;
using Asmerald.Expressions;

namespace Asmerald.Functions.MSSQL
{
    public class TypeofFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public TypeofFunction() { }
        public TypeofFunction(ISelectExpression x)
        {
            this.X = x;
        }
    }
}
