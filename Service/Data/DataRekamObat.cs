using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace Service.Data
{
    public class DataRekamObat
    {
        public static bool insert(XmlNode xn)
        {
            Global.sql = "INSERT INTO rekam_obat VALUES('" +
                xn.SelectSingleNode("id_rm").InnerText + "','" +
                xn.SelectSingleNode("id_obat").InnerText + "'," +
                xn.SelectSingleNode("jumlah").InnerText + ")";
            return Global.ExecQuery(Global.sql);
        }

        public static bool update(XmlNode xn)
        {
            Global.sql = "UPDATE rekam_obat SET " +
                "jumlah = " + xn.SelectSingleNode("jumlah").InnerText + 
                " WHERE id_rm = '" + xn.SelectSingleNode("id_rm").InnerText + "'" +
                    "AND id_obat = '" + xn.SelectSingleNode("id_obat").InnerText + "'";
            return Global.ExecQuery(Global.sql);
        }

        public static bool delete(XmlNode xn)
        {
            Global.sql = "DELETE rekam_obat WHERE id_rm = '" + xn.SelectSingleNode("id_rm").InnerText + "' And " +
                "id_obat = '" + xn.SelectSingleNode("id_obat").InnerText + "'";
            return Global.ExecQuery(Global.sql);
        }
    }
}