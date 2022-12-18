using System;
using System.Collections.Generic;
using System.Linq;
using Amorphous.Columns;
using Amorphous.Expressions;
using Amorphous.Functions.SQLite;
using Amorphous.Statements;

namespace Amorphous.SQLite
{
    public static partial class TypeProofSqlGlobExtensions
    {
        public static GlobFunction Glob(this SQLiteDSLContext stmt, ISelectExpression x, ISelectExpression y)
        {
            return new GlobFunction(x, y);
        }
        public static GlobFunction Glob(this Int16 x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this Int32 x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this Int64 x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this UInt16 x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this UInt32 x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this UInt64 x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this Decimal x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this Double x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this String x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this Char x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this Boolean x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this Byte x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this DateTime x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this Single x, ISelectExpression y)
        {
            return new GlobFunction(x.Expr(), y);
        }
        public static GlobFunction Glob(this ISelectColumn x, ISelectExpression y)
        {
            return new GlobFunction(x, y);
        }
    }
}