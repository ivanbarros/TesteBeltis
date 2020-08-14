using System;
using System.Collections.Generic;
using System.Text;

namespace TecBan.Data.SqlConfig
{
    public class SqlConfigurationServer
    {
        public SqlConfigurationServer(string value) => Value = value;
        public string Value { get; }
    }
}
