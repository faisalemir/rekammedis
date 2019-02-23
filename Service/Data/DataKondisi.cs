using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace Service.Data
{
    public static class DataKondisi
    {
        public static bool insert(XmlNode xn) 
        {
            Global.sql = "INSERT INTO kondisi_keluar VALUES('" + 
                xn.SelectSingleNode("id_kondisi").InnerText + "','" +
                xn.SelectSingleNode("kondisi").InnerText + "')";
            return Global.ExecQuery(Global.sql);
        }

        public static bool update(XmlNode xn) 
        {
            Global.sql = "UPDATE kondisi_keluar SET kondisi = '" +
                xn.SelectSingleNode("kondisi").InnerText + "' WHERE id_kondisi = '" +
                xn.SelectSingleNode("id_kondisi").InnerText + "'";
            return Global.ExecQuery(Global.sql);
        }
        
        public static bool delete(XmlNode xn) 
        {
            Global.sql = "DELETE kondisi_keluar WHERE id_kondisi = '" + xn.SelectSingleNode("id_kondisi").InnerText + "'";
            return Global.ExecQuery(Global.sql);
        }
    }
}