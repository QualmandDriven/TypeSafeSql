using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class UpsertConflictStatement : ConflictStatement
    {
        public UpsertConflictStatement() { }
        public UpsertConflictStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
