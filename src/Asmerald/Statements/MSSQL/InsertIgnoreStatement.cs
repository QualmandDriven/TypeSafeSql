using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
{
    public class InsertIgnoreStatement : IgnoreStatement
    {
        public InsertIgnoreStatement() { }
        public InsertIgnoreStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
