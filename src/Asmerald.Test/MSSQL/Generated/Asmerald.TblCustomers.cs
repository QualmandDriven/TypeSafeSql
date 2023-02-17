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
    public partial class sales
    {
        public static TblCustomers customers() => new TblCustomers();
        public class TblCustomers : ITable{
            string ITable.Name() => "sales.customers";
            public Col_Customer_id Customer_id() => new Col_Customer_id();
            public Col_First_name First_name() => new Col_First_name();
            public Col_Last_name Last_name() => new Col_Last_name();
            public Col_Phone Phone() => new Col_Phone();
            public Col_Email Email() => new Col_Email();
            public Col_Street Street() => new Col_Street();
            public Col_City City() => new Col_City();
            public Col_State State() => new Col_State();
            public Col_Zip_code Zip_code() => new Col_Zip_code();
            public static Col_Customer_id Customer_id(string tableAlias = "") => new Col_Customer_id(tableAlias);
            public static Col_First_name First_name(string tableAlias = "") => new Col_First_name(tableAlias);
            public static Col_Last_name Last_name(string tableAlias = "") => new Col_Last_name(tableAlias);
            public static Col_Phone Phone(string tableAlias = "") => new Col_Phone(tableAlias);
            public static Col_Email Email(string tableAlias = "") => new Col_Email(tableAlias);
            public static Col_Street Street(string tableAlias = "") => new Col_Street(tableAlias);
            public static Col_City City(string tableAlias = "") => new Col_City(tableAlias);
            public static Col_State State(string tableAlias = "") => new Col_State(tableAlias);
            public static Col_Zip_code Zip_code(string tableAlias = "") => new Col_Zip_code(tableAlias);
            public class Col_Customer_id : IntegerColumn<TblCustomers>, ISelectColumn<TblCustomers>, ISelectColumnAlias<TblCustomers>
            {
                private readonly string _name = "customer_id";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Customer_id() { }
                public Col_Customer_id(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblCustomers> As(string name) => new AliasColumn<TblCustomers>(this, name);
                public override ISelectColumn<TblCustomers> Count() => new CountColumn<TblCustomers>(this);
            }
            public class Col_First_name : StringColumn<TblCustomers>, ISelectColumn<TblCustomers>, ISelectColumnAlias<TblCustomers>
            {
                private readonly string _name = "first_name";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_First_name() { }
                public Col_First_name(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblCustomers> As(string name) => new AliasColumn<TblCustomers>(this, name);
                public override ISelectColumn<TblCustomers> Count() => new CountColumn<TblCustomers>(this);
            }
            public class Col_Last_name : StringColumn<TblCustomers>, ISelectColumn<TblCustomers>, ISelectColumnAlias<TblCustomers>
            {
                private readonly string _name = "last_name";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Last_name() { }
                public Col_Last_name(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblCustomers> As(string name) => new AliasColumn<TblCustomers>(this, name);
                public override ISelectColumn<TblCustomers> Count() => new CountColumn<TblCustomers>(this);
            }
            public class Col_Phone : StringColumn<TblCustomers>, ISelectColumn<TblCustomers>, ISelectColumnAlias<TblCustomers>
            {
                private readonly string _name = "phone";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Phone() { }
                public Col_Phone(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblCustomers> As(string name) => new AliasColumn<TblCustomers>(this, name);
                public override ISelectColumn<TblCustomers> Count() => new CountColumn<TblCustomers>(this);
            }
            public class Col_Email : StringColumn<TblCustomers>, ISelectColumn<TblCustomers>, ISelectColumnAlias<TblCustomers>
            {
                private readonly string _name = "email";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Email() { }
                public Col_Email(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblCustomers> As(string name) => new AliasColumn<TblCustomers>(this, name);
                public override ISelectColumn<TblCustomers> Count() => new CountColumn<TblCustomers>(this);
            }
            public class Col_Street : StringColumn<TblCustomers>, ISelectColumn<TblCustomers>, ISelectColumnAlias<TblCustomers>
            {
                private readonly string _name = "street";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Street() { }
                public Col_Street(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblCustomers> As(string name) => new AliasColumn<TblCustomers>(this, name);
                public override ISelectColumn<TblCustomers> Count() => new CountColumn<TblCustomers>(this);
            }
            public class Col_City : StringColumn<TblCustomers>, ISelectColumn<TblCustomers>, ISelectColumnAlias<TblCustomers>
            {
                private readonly string _name = "city";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_City() { }
                public Col_City(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblCustomers> As(string name) => new AliasColumn<TblCustomers>(this, name);
                public override ISelectColumn<TblCustomers> Count() => new CountColumn<TblCustomers>(this);
            }
            public class Col_State : StringColumn<TblCustomers>, ISelectColumn<TblCustomers>, ISelectColumnAlias<TblCustomers>
            {
                private readonly string _name = "state";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_State() { }
                public Col_State(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblCustomers> As(string name) => new AliasColumn<TblCustomers>(this, name);
                public override ISelectColumn<TblCustomers> Count() => new CountColumn<TblCustomers>(this);
            }
            public class Col_Zip_code : StringColumn<TblCustomers>, ISelectColumn<TblCustomers>, ISelectColumnAlias<TblCustomers>
            {
                private readonly string _name = "zip_code";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Zip_code() { }
                public Col_Zip_code(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblCustomers> As(string name) => new AliasColumn<TblCustomers>(this, name);
                public override ISelectColumn<TblCustomers> Count() => new CountColumn<TblCustomers>(this);
            }
        }
    }
}
