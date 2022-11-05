using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Statements.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlIgnoreExtensions
    {
        public static InsertIgnoreStatement Ignore(this InsertOrStatement stmt)
        {
            return new InsertIgnoreStatement(stmt.QueryBuilder);
        }
        public static UpdateIgnoreStatement<T> Ignore<T>(this UpdateOrStatement<T> stmt)
            where T : ITable, new()
        {
            return new UpdateIgnoreStatement<T>(stmt.QueryBuilder);
        }
    }
}
