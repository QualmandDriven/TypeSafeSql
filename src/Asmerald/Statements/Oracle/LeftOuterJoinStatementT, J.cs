using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class LeftOuterJoinStatement<T, J> : LeftOuterJoinStatement
        where T : ITable, new()
        where J : ITable, new()
    {
        public LeftOuterJoinStatement() { }
        public LeftOuterJoinStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder, new T(), new J())
        {
        }
    }
}
