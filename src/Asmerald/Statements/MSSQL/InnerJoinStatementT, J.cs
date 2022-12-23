using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MSSQL
{
    public class InnerJoinStatement<T, J> : InnerJoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public InnerJoinStatement() { }
        public InnerJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T(), new J())
        {
        }
    }
}
