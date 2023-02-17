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
        public static TblSpt_monitor spt_monitor() => new TblSpt_monitor();
        public class TblSpt_monitor : ITable{
            string ITable.Name() => "dbo.spt_monitor";
            public Col_Lastrun Lastrun() => new Col_Lastrun();
            public Col_Cpu_busy Cpu_busy() => new Col_Cpu_busy();
            public Col_Io_busy Io_busy() => new Col_Io_busy();
            public Col_Idle Idle() => new Col_Idle();
            public Col_Pack_received Pack_received() => new Col_Pack_received();
            public Col_Pack_sent Pack_sent() => new Col_Pack_sent();
            public Col_Connections Connections() => new Col_Connections();
            public Col_Pack_errors Pack_errors() => new Col_Pack_errors();
            public Col_Total_read Total_read() => new Col_Total_read();
            public Col_Total_write Total_write() => new Col_Total_write();
            public Col_Total_errors Total_errors() => new Col_Total_errors();
            public static Col_Lastrun Lastrun(string tableAlias = "") => new Col_Lastrun(tableAlias);
            public static Col_Cpu_busy Cpu_busy(string tableAlias = "") => new Col_Cpu_busy(tableAlias);
            public static Col_Io_busy Io_busy(string tableAlias = "") => new Col_Io_busy(tableAlias);
            public static Col_Idle Idle(string tableAlias = "") => new Col_Idle(tableAlias);
            public static Col_Pack_received Pack_received(string tableAlias = "") => new Col_Pack_received(tableAlias);
            public static Col_Pack_sent Pack_sent(string tableAlias = "") => new Col_Pack_sent(tableAlias);
            public static Col_Connections Connections(string tableAlias = "") => new Col_Connections(tableAlias);
            public static Col_Pack_errors Pack_errors(string tableAlias = "") => new Col_Pack_errors(tableAlias);
            public static Col_Total_read Total_read(string tableAlias = "") => new Col_Total_read(tableAlias);
            public static Col_Total_write Total_write(string tableAlias = "") => new Col_Total_write(tableAlias);
            public static Col_Total_errors Total_errors(string tableAlias = "") => new Col_Total_errors(tableAlias);
            public class Col_Lastrun : DateTimeColumn<TblSpt_monitor>, ISelectColumn<TblSpt_monitor>, ISelectColumnAlias<TblSpt_monitor>
            {
                private readonly string _name = "lastrun";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Lastrun() { }
                public Col_Lastrun(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_monitor> As(string name) => new AliasColumn<TblSpt_monitor>(this, name);
                public override ISelectColumn<TblSpt_monitor> Count() => new CountColumn<TblSpt_monitor>(this);
            }
            public class Col_Cpu_busy : IntegerColumn<TblSpt_monitor>, ISelectColumn<TblSpt_monitor>, ISelectColumnAlias<TblSpt_monitor>
            {
                private readonly string _name = "cpu_busy";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Cpu_busy() { }
                public Col_Cpu_busy(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_monitor> As(string name) => new AliasColumn<TblSpt_monitor>(this, name);
                public override ISelectColumn<TblSpt_monitor> Count() => new CountColumn<TblSpt_monitor>(this);
            }
            public class Col_Io_busy : IntegerColumn<TblSpt_monitor>, ISelectColumn<TblSpt_monitor>, ISelectColumnAlias<TblSpt_monitor>
            {
                private readonly string _name = "io_busy";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Io_busy() { }
                public Col_Io_busy(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_monitor> As(string name) => new AliasColumn<TblSpt_monitor>(this, name);
                public override ISelectColumn<TblSpt_monitor> Count() => new CountColumn<TblSpt_monitor>(this);
            }
            public class Col_Idle : IntegerColumn<TblSpt_monitor>, ISelectColumn<TblSpt_monitor>, ISelectColumnAlias<TblSpt_monitor>
            {
                private readonly string _name = "idle";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Idle() { }
                public Col_Idle(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_monitor> As(string name) => new AliasColumn<TblSpt_monitor>(this, name);
                public override ISelectColumn<TblSpt_monitor> Count() => new CountColumn<TblSpt_monitor>(this);
            }
            public class Col_Pack_received : IntegerColumn<TblSpt_monitor>, ISelectColumn<TblSpt_monitor>, ISelectColumnAlias<TblSpt_monitor>
            {
                private readonly string _name = "pack_received";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Pack_received() { }
                public Col_Pack_received(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_monitor> As(string name) => new AliasColumn<TblSpt_monitor>(this, name);
                public override ISelectColumn<TblSpt_monitor> Count() => new CountColumn<TblSpt_monitor>(this);
            }
            public class Col_Pack_sent : IntegerColumn<TblSpt_monitor>, ISelectColumn<TblSpt_monitor>, ISelectColumnAlias<TblSpt_monitor>
            {
                private readonly string _name = "pack_sent";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Pack_sent() { }
                public Col_Pack_sent(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_monitor> As(string name) => new AliasColumn<TblSpt_monitor>(this, name);
                public override ISelectColumn<TblSpt_monitor> Count() => new CountColumn<TblSpt_monitor>(this);
            }
            public class Col_Connections : IntegerColumn<TblSpt_monitor>, ISelectColumn<TblSpt_monitor>, ISelectColumnAlias<TblSpt_monitor>
            {
                private readonly string _name = "connections";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Connections() { }
                public Col_Connections(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_monitor> As(string name) => new AliasColumn<TblSpt_monitor>(this, name);
                public override ISelectColumn<TblSpt_monitor> Count() => new CountColumn<TblSpt_monitor>(this);
            }
            public class Col_Pack_errors : IntegerColumn<TblSpt_monitor>, ISelectColumn<TblSpt_monitor>, ISelectColumnAlias<TblSpt_monitor>
            {
                private readonly string _name = "pack_errors";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Pack_errors() { }
                public Col_Pack_errors(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_monitor> As(string name) => new AliasColumn<TblSpt_monitor>(this, name);
                public override ISelectColumn<TblSpt_monitor> Count() => new CountColumn<TblSpt_monitor>(this);
            }
            public class Col_Total_read : IntegerColumn<TblSpt_monitor>, ISelectColumn<TblSpt_monitor>, ISelectColumnAlias<TblSpt_monitor>
            {
                private readonly string _name = "total_read";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Total_read() { }
                public Col_Total_read(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_monitor> As(string name) => new AliasColumn<TblSpt_monitor>(this, name);
                public override ISelectColumn<TblSpt_monitor> Count() => new CountColumn<TblSpt_monitor>(this);
            }
            public class Col_Total_write : IntegerColumn<TblSpt_monitor>, ISelectColumn<TblSpt_monitor>, ISelectColumnAlias<TblSpt_monitor>
            {
                private readonly string _name = "total_write";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Total_write() { }
                public Col_Total_write(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_monitor> As(string name) => new AliasColumn<TblSpt_monitor>(this, name);
                public override ISelectColumn<TblSpt_monitor> Count() => new CountColumn<TblSpt_monitor>(this);
            }
            public class Col_Total_errors : IntegerColumn<TblSpt_monitor>, ISelectColumn<TblSpt_monitor>, ISelectColumnAlias<TblSpt_monitor>
            {
                private readonly string _name = "total_errors";
                string ISelectColumn.Name => string.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                readonly string? TableAlias;
                public Col_Total_errors() { }
                public Col_Total_errors(string tableAlias) { this.TableAlias = tableAlias; }
                public override string Name() => String.IsNullOrEmpty(TableAlias) ? _name : $"{TableAlias}.{_name}";
                public override ISelectColumnAlias<TblSpt_monitor> As(string name) => new AliasColumn<TblSpt_monitor>(this, name);
                public override ISelectColumn<TblSpt_monitor> Count() => new CountColumn<TblSpt_monitor>(this);
            }
        }
    }
}
