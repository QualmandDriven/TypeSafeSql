using System.Collections.Generic;
using Asmerald.Columns;
using Asmerald.QueryBuilders;
using Asmerald.Expressions;

namespace Asmerald.Statements.MySQL
{
    public class UpdateRollbackStatement : RollbackStatement
    {
        public ITable Table { get; private set; }
        public UpdateRollbackStatement() { }
        public UpdateRollbackStatement(IQueryBuilder queryBuilder, ITable table)
            : base(queryBuilder)
        {
            this.Table = table;
        }
    }
}