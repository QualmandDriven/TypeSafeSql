using System;
using System.Collections.Generic;
using System.Linq;
using Asmerald.Columns;
using Asmerald.Expressions;
using Asmerald.QueryBuilders;
using Asmerald.Statements;
using Asmerald.Statements.Oracle;

namespace Asmerald.Oracle
{
    public static partial class AsmeraldRightJoinExtensions
    {
        public static RightOuterJoinStatement<T, J> RightJoin<T, J>(this SelectFromStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new RightOuterJoinStatement<T, J>(stmt.QueryBuilder);
        }
        public static UpdateConditionalJoinStatement<T, J> RightJoin<T, J>(this UpdateFromStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UpdateConditionalJoinStatement<T, J>(stmt.QueryBuilder);
        }
        public static UpdateConditionalJoinStatement<T, J> RightJoin<T, J>(this UpdateFromSubQueryStatement<T> stmt)
            where T : ITable, new()
            where J : ITable, new()
        {
            return new UpdateConditionalJoinStatement<T, J>(stmt.QueryBuilder);
        }
    }
}
