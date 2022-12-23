using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.Functions.Oracle;
using Asmerald.Statements;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldRandomExtensions
    {
        public static RandomFunction Random(this OracleDSLContext stmt)
        {
            return new RandomFunction();
        }
    }
}
