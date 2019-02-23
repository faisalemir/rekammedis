using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace Service.Data
{
    public class DataRekamMedis
    {
        public static bool insert(XmlNode xn)
        {
            Global.sql = "INSERT INTO rekam_medis VALUES('" +
                xn.SelectSingleNode("id_rm").InnerText + "','" +
                xn.SelectSingleNode("id_pasien").InnerText + "','" +
                xn.SelectSingleNode("id_reg").InnerText + "','" +
                xn.SelectSingleNode("id_kondisi").InnerText + "'," +
                xn.SelectSingleNode("stole_diastole").InnerText + "," +
                xn.SelectSingleNode("respiratory_rate").InnerText + "," +
                xn.SelectSingleNode("suhu").InnerText + "," +
                xn.SelectSingleNode("nadi").InnerText + "," +
                xn.SelectSingleNode("berat_badan").InnerText + "," +
                xn.SelectSingleNode("tinggi_badan").InnerText + ",'" +
                xn.SelectSingleNode("anamnesia").InnerText + "','" +
                xn.SelectSingleNode("tanggal").InnerText + "')";
            return Global.ExecQuery(Global.sql);
        }

        public static bool update(XmlNode xn)
        {
            Global.sql = "UPDATE rekam_medis SET " +
                "id_pasien = '" + xn.SelectSingleNode("id_pasien").InnerText +
                "', id_reg = '" + xn.SelectSingleNode("id_reg").InnerText +
                "', id_kondisi = '" + xn.SelectSingleNode("id_kondisi").InnerText +
                "', stole_diastole = " + xn.SelectSingleNode("stole_diastole").InnerText +
                ", respiratory_rate = " + xn.SelectSingleNode("respiratory_rate").InnerText +
                ", suhu = " + xn.SelectSingleNode("suhu").InnerText +
                ", nadi = " + xn.SelectSingleNode("nadi").InnerText +
                ", berat_badan = " + xn.SelectSingleNode("berat_badan").InnerText +
                ", tinggi_badan = " + xn.SelectSingleNode("tinggi_badan").InnerText +
                ", anamnesia = '" + xn.SelectSingleNode("anamnesia").InnerText +
                "' WHERE id_rm = '" + xn.SelectSingleNode("id_rm").InnerText + "'";
            return Global.ExecQuery(Global.sql);
        }

        public static bool delete(XmlNode xn)
        {
            Global.sql = "DELETE rekam_medis WHERE id_rm = '" + xn.SelectSingleNode("id_rm").InnerText + "'";
            return Global.ExecQuery(Global.sql);
        }
    }
}