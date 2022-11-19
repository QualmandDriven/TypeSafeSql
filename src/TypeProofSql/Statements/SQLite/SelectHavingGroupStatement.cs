using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class SelectHavingGroupStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ConditionalGroupStatement GroupExpr { get; private set; }
        public SelectHavingGroupStatement() { }
        public SelectHavingGroupStatement(IQueryBuilder queryBuilder, ConditionalGroupStatement groupExpr)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.GroupExpr = groupExpr;
        }
    }
}