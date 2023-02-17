/*
This file was automatically generated by Asmerald.Generate library / executable.
It is not recommened to make manual changes in this file as any changes to this file will be overwritten when the next generation happens.
In case you need modifications please refer to adjusting the generation process itself.
This is possible by creating your own executable project and referencing or forking Asmerald.Generate library / executable.
*/

using System;
using Asmerald;
using Asmerald.Columns;

namespace master
{
    public partial class dbo
    {
        public static VwSpt_values spt_values() => new VwSpt_values();
        public class VwSpt_values : ITable{
            string ITable.Name() => "dbo.spt_values";
            public Col_Name Name() => new Col_Name();
            public Col_Number Number() => new Col_Number();
            public Col_Type Type() => new Col_Type();
            public Col_Low Low() => new Col_Low();
            public Col_High High() => new Col_High();
            public Col_Status Status() => new Col_Status();
            public static Col_Name Name(string tableAlias = "") => new Col_Name(tableAlias);
            public static Col_Number Number(string tableAlias = "") => new Col_Number(tableAlias);
            public static Col_Type Type(string tableAlias = "") => new Col_Type(tableAlias);
            public static Col_Low Low(string tableAlias = "") => new Col_Low(tableAlias);
            public static Col_High High(string tableAlias = "") => new Col_High(tableAlias);
            public static Col_Status Status(string tableAlias = "") => new Col_Status(tableAlias);
            public class Col_Name : StringColumn<VwSpt_values>, ISelectColumn<VwSpt_values>, ISelectColumnAlias<VwSpt_values>
            {
                private readonly string _name = "name";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Name() { }
                public Col_Name(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<VwSpt_values> As(string name) => new AliasColumn<VwSpt_values>(this, name);
                public override ISelectColumn<VwSpt_values> Count() => new CountColumn<VwSpt_values>(this);
            }
            public class Col_Number : IntegerColumn<VwSpt_values>, ISelectColumn<VwSpt_values>, ISelectColumnAlias<VwSpt_values>
            {
                private readonly string _name = "number";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Number() { }
                public Col_Number(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<VwSpt_values> As(string name) => new AliasColumn<VwSpt_values>(this, name);
                public override ISelectColumn<VwSpt_values> Count() => new CountColumn<VwSpt_values>(this);
            }
            public class Col_Type : StringColumn<VwSpt_values>, ISelectColumn<VwSpt_values>, ISelectColumnAlias<VwSpt_values>
            {
                private readonly string _name = "type";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Type() { }
                public Col_Type(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<VwSpt_values> As(string name) => new AliasColumn<VwSpt_values>(this, name);
                public override ISelectColumn<VwSpt_values> Count() => new CountColumn<VwSpt_values>(this);
            }
            public class Col_Low : IntegerColumn<VwSpt_values>, ISelectColumn<VwSpt_values>, ISelectColumnAlias<VwSpt_values>
            {
                private readonly string _name = "low";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Low() { }
                public Col_Low(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<VwSpt_values> As(string name) => new AliasColumn<VwSpt_values>(this, name);
                public override ISelectColumn<VwSpt_values> Count() => new CountColumn<VwSpt_values>(this);
            }
            public class Col_High : IntegerColumn<VwSpt_values>, ISelectColumn<VwSpt_values>, ISelectColumnAlias<VwSpt_values>
            {
                private readonly string _name = "high";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_High() { }
                public Col_High(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<VwSpt_values> As(string name) => new AliasColumn<VwSpt_values>(this, name);
                public override ISelectColumn<VwSpt_values> Count() => new CountColumn<VwSpt_values>(this);
            }
            public class Col_Status : IntegerColumn<VwSpt_values>, ISelectColumn<VwSpt_values>, ISelectColumnAlias<VwSpt_values>
            {
                private readonly string _name = "status";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Status() { }
                public Col_Status(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<VwSpt_values> As(string name) => new AliasColumn<VwSpt_values>(this, name);
                public override ISelectColumn<VwSpt_values> Count() => new CountColumn<VwSpt_values>(this);
            }
        }
    }
}
