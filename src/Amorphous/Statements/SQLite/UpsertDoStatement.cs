using System.Collections.Generic;
using Amorphous.Columns;
using Amorphous.QueryBuilders;
using Amorphous.Expressions;

namespace Amorphous.Statements.SQLite
{
    public class UpsertDoStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public UpsertDoStatement() { }
        public UpsertDoStatement(IQueryBuilder queryBuilder)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
        }
    }
}