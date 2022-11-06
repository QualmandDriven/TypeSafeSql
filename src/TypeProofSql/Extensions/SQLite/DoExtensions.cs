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
    public static partial class TypeProofSqlDoExtensions
    {
        public static UpsertDoStatement Do(this ConflictStatement stmt)
        {
            return new UpsertDoStatement(stmt.QueryBuilder);
        }
        public static UpsertDoStatement Do(this SelectWhereStatement stmt)
        {
            return new UpsertDoStatement(stmt.QueryBuilder);
        }
        public static UpsertDoStatement Do(this SelectWhereGroupStatement stmt)
        {
            return new UpsertDoStatement(stmt.QueryBuilder);
        }
    }
}
