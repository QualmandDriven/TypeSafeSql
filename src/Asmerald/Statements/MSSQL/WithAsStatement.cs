using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
{
    public class WithAsStatement : AsStatement
    {
        public WithAsStatement() { }
        public WithAsStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
