using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MariaDB
{
    public class WithNotStatement : NotStatement
    {
        public WithNotStatement() { }
        public WithNotStatement(IQueryBuilder queryBuilder)
            : base(queryBuilder)
        {
        }
    }
}
