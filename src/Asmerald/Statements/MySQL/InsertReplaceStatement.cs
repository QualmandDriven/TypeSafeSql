using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
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
