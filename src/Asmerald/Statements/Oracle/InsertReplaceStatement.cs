using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.Oracle
{
    public class InsertReplaceStatement : ReplaceStatement
    {
        public InsertReplaceStatement() { }
        public InsertReplaceStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
