using System;
using System.Collections.Generic;
using System.Text;
using TypeProofSql.Expressions;
using TypeProofSql.QueryBuilders;
using TypeProofSql.Columns;
using System.Linq;
using TypeProofSql.Statements;
using TypeProofSql.Functions.SQLite;

namespace TypeProofSql.SQLite
{
    public static partial class TypeProofSqlCoalesceExtensions
    {
        public static CoalesceFunction Coalesce(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x, y, z);
        }
        public static CoalesceFunction Coalesce(this Int16 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Int32 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Int64 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this UInt16 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this UInt32 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this UInt64 x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Decimal x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Double x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this String x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Char x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Boolean x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Byte x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this DateTime x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this Single x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x.Expr(), y, z);
        }
        public static CoalesceFunction Coalesce(this ISelectColumn x, ISelectExpression y, params ISelectExpression[] z)
        {
            return new CoalesceFunction(x, y, z);
        }
    }
}