using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class CollateStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public CollateStatement() { }
        public CollateStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}