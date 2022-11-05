using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Columns;
using TypeProofSql.Statements;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Expressions;

namespace TypeProofSql.Statements.SQLite
{
    public class OnStatement : IStatement
    {
        public IQueryBuilder QueryBuilder { get; private set; }
        public ITable Tleft { get; private set; }
        public ITable Tright { get; private set; }
        public ISelectColumn Left { get; private set; }
        public ISelectColumn Right { get; private set; }
        public OnStatement() { }
        public OnStatement(IQueryBuilder queryBuilder, ITable tleft, ITable tright, ISelectColumn left, ISelectColumn right)
        {
            this.QueryBuilder = queryBuilder;
            this.QueryBuilder.AddStatment(this);
            this.Tleft = tleft;
            this.Tright = tright;
            this.Left = left;
            this.Right = right;
        }
    }
}
