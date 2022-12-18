using System;
using System.Collections.Generic;
using Amorphous.Expressions;

namespace Amorphous.Functions.SQLite
{
    public class TimeFuncFunction : IFunction
    {
        public ISelectExpression Value { get; private set; }
        public List<String> Modifier { get; private set; } = new List<String>();
        public TimeFuncFunction() { }
        public TimeFuncFunction(ISelectExpression value, IEnumerable<String> modifier)
        {
            this.Value = value;
            this.Modifier.AddRange(modifier);
        }
    }
}