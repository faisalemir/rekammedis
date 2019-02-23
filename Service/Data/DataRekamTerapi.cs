using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace Service.Data
{
    public class DataRekamTerapi
    {
        public static bool insert(XmlNode xn)
        {
            Global.sql = "INSERT INTO rekam_terapi VALUES('" +
                xn.SelectSingleNode("id_rm").InnerText + "','" +
                xn.SelectSingleNode("id_terapi").InnerText + "')";
            return Global.ExecQuery(Global.sql);
        }

        public static bool update(XmlNode xn)
        {
            Global.sql = "UPDATE rekam_terapi SET " +
                "id_obat = '" + xn.SelectSingleNode("id_obat").InnerText +
                "' WHERE id_rm = '" + xn.SelectSingleNode("id_rm").InnerText +
                "' AND id_terapi = '" + xn.SelectSingleNode("id_terapi").InnerText + "'";
            return Global.ExecQuery(Global.sql);
        }

        public static bool delete(XmlNode xn)
        {
            Global.sql = "DELETE rekam_terapi WHERE id_rm = '" + xn.SelectSingleNode("id_rm").InnerText +
                "' And id_terapi = '" + xn.SelectSingleNode("id_terapi").InnerText + "'";
            return Global.ExecQuery(Global.sql);
        }
    }
}