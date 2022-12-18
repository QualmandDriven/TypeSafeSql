using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
{
    public class LikelihoodFunction : IFunction
    {
        public ISelectExpression X { get; private set; }
        public ISelectExpression Y { get; private set; }
        public LikelihoodFunction() { }
        public LikelihoodFunction(ISelectExpression x, ISelectExpression y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}