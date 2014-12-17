using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Batl.DAL
{
 public class GenelOzelIsler
{
    public static string GetString(OleDbDataReader reader, String s)
    {
        if (reader.IsDBNull(reader.GetOrdinal(s)))
            return String.Empty;
        else
            return reader.GetString(reader.GetOrdinal(s));
    }

    public static DateTime GetDateTime(OleDbDataReader reader, String s)
    {
        if (reader.IsDBNull(reader.GetOrdinal(s)))
            return DateTime.MinValue;
        else
            return reader.GetDateTime(reader.GetOrdinal(s));
    }

    public static bool GetBoolean(OleDbDataReader reader, String s)
    {
        if (reader.IsDBNull(reader.GetOrdinal(s)))
            return false;
        else
            return reader.GetBoolean(reader.GetOrdinal(s));
    }

    public static int GetInteger(OleDbDataReader reader, String s)
    {
        if (reader.IsDBNull(reader.GetOrdinal(s)))
            return 0;
        else
            return reader.GetInt32(reader.GetOrdinal(s));
    }

    public static int GetTinyInteger(OleDbDataReader reader, String s)
    {
        if (reader.IsDBNull(reader.GetOrdinal(s)))
            return 0;
        else
            return reader.GetByte(reader.GetOrdinal(s));
    }

}
}
