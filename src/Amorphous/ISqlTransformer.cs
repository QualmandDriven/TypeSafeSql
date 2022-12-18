﻿using System;
using System.Collections.Generic;
using System.Text;
using Amorphous.Statements;

namespace Amorphous
{
    public interface ISqlTransformer
    {
        Dictionary<string, object> Transform(IStatement statement, StringBuilder builder, ref int paraCount);
        Dictionary<string, object> Transform(IEnumerable<IStatement> statement, StringBuilder builder);
    }
}