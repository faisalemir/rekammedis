using Service.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace Service.Service
{
    /// <summary>
    /// Summary description for RekamMedis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RekamMedis : System.Web.Services.WebService
    {

        [WebMethod]
        public bool insert(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_medis.xml"));
            bool status = true;
            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_medis"))
            {
                if (xn.SelectSingleNode("id_rm").InnerText == ds.Tables[0].Rows[0]["id_rm"].ToString())
                {
                    if (xn.Attributes["status"].Value != "delete")
                    {
                        status = false;
                        break;
                    }
                    else
                    {
                        xn.Attributes["status"].Value = "update";
                        xn.SelectSingleNode("id_pasien").InnerText = ds.Tables[0].Rows[0]["id_pasien"].ToString();
                        xn.SelectSingleNode("id_reg").InnerText = ds.Tables[0].Rows[0]["id_reg"].ToString();
                        xn.SelectSingleNode("id_kondisi").InnerText = ds.Tables[0].Rows[0]["id_kondisi"].ToString();
                        xn.SelectSingleNode("stole_diastole").InnerText = ds.Tables[0].Rows[0]["stole_diastole"].ToString();
                        xn.SelectSingleNode("respiratory_rate").InnerText = ds.Tables[0].Rows[0]["respiratory_rate"].ToString();
                        xn.SelectSingleNode("suhu").InnerText = ds.Tables[0].Rows[0]["suhu"].ToString();
                        xn.SelectSingleNode("nadi").InnerText = ds.Tables[0].Rows[0]["nadi"].ToString();
                        xn.SelectSingleNode("berat_badan").InnerText = ds.Tables[0].Rows[0]["berat_badan"].ToString();
                        xn.SelectSingleNode("tinggi_badan").InnerText = ds.Tables[0].Rows[0]["tinggi_badan"].ToString();
                        xn.SelectSingleNode("anamnesia").InnerText = ds.Tables[0].Rows[0]["anamnesia"].ToString();
                        Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_medis.xml"));
                        status = false;
                        break;
                    }
                }
            }

            if (status == true)
            {
                XmlElement parentelement = Global.xdoc.CreateElement("rekam_medis");
                XmlElement id_rm = Global.xdoc.CreateElement("id_rm");
                XmlElement id_pasien = Global.xdoc.CreateElement("id_pasien");
                XmlElement id_reg = Global.xdoc.CreateElement("id_reg");
                XmlElement id_kondisi = Global.xdoc.CreateElement("id_kondisi");
                XmlElement stole_diastole = Global.xdoc.CreateElement("stole_diastole");
                XmlElement respiratory_rate = Global.xdoc.CreateElement("respiratory_rate");
                XmlElement suhu = Global.xdoc.CreateElement("suhu");
                XmlElement nadi = Global.xdoc.CreateElement("nadi");
                XmlElement berat_badan = Global.xdoc.CreateElement("berat_badan");
                XmlElement tinggi_badan = Global.xdoc.CreateElement("tinggi_badan");
                XmlElement anamnesia = Global.xdoc.CreateElement("anamnesia");
                XmlElement tanggal = Global.xdoc.CreateElement("tanggal");

                id_rm.InnerText = ds.Tables[0].Rows[0]["id_rm"].ToString();
                id_pasien.InnerText = ds.Tables[0].Rows[0]["id_pasien"].ToString();
                id_reg.InnerText = ds.Tables[0].Rows[0]["id_reg"].ToString();
                id_kondisi.InnerText = ds.Tables[0].Rows[0]["id_kondisi"].ToString();
                stole_diastole.InnerText = ds.Tables[0].Rows[0]["stole_diastole"].ToString();
                respiratory_rate.InnerText = ds.Tables[0].Rows[0]["respiratory_rate"].ToString();
                suhu.InnerText = ds.Tables[0].Rows[0]["suhu"].ToString();
                nadi.InnerText = ds.Tables[0].Rows[0]["nadi"].ToString();
                berat_badan.InnerText = ds.Tables[0].Rows[0]["berat_badan"].ToString();
                tinggi_badan.InnerText = ds.Tables[0].Rows[0]["tinggi_badan"].ToString();
                anamnesia.InnerText = ds.Tables[0].Rows[0]["anamnesia"].ToString();
                tanggal.InnerText = ds.Tables[0].Rows[0]["tanggal"].ToString();

                parentelement.AppendChild(id_rm);
                parentelement.AppendChild(id_pasien);
                parentelement.AppendChild(id_reg);
                parentelement.AppendChild(id_kondisi);
                parentelement.AppendChild(stole_diastole);
                parentelement.AppendChild(respiratory_rate);
                parentelement.AppendChild(suhu);
                parentelement.AppendChild(nadi);
                parentelement.AppendChild(berat_badan);
                parentelement.AppendChild(tinggi_badan);
                parentelement.AppendChild(anamnesia);
                parentelement.AppendChild(tanggal);
                parentelement.SetAttribute("status", "insert");

                Global.xdoc.DocumentElement.AppendChild(parentelement);
                Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_medis.xml"));
            }
            return status;
        }

        [WebMethod]
        public void update(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_medis.xml"));
            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_medis"))
            {
                if (xn.SelectSingleNode("id_rm").InnerText == ds.Tables[0].Rows[0]["id_rm"].ToString())
                {
                    if (xn.Attributes["status"].Value == "insert" || xn.Attributes["status"].Value == "insert_update")
                    {
                        xn.Attributes["status"].Value = "insert_update";
                        xn.SelectSingleNode("id_pasien").InnerText = ds.Tables[0].Rows[0]["id_pasien"].ToString();
                        xn.SelectSingleNode("id_reg").InnerText = ds.Tables[0].Rows[0]["id_reg"].ToString();
                        xn.SelectSingleNode("id_kondisi").InnerText = ds.Tables[0].Rows[0]["id_kondisi"].ToString();
                        xn.SelectSingleNode("stole_diastole").InnerText = ds.Tables[0].Rows[0]["stole_diastole"].ToString();
                        xn.SelectSingleNode("respiratory_rate").InnerText = ds.Tables[0].Rows[0]["respiratory_rate"].ToString();
                        xn.SelectSingleNode("suhu").InnerText = ds.Tables[0].Rows[0]["suhu"].ToString();
                        xn.SelectSingleNode("nadi").InnerText = ds.Tables[0].Rows[0]["nadi"].ToString();
                        xn.SelectSingleNode("berat_badan").InnerText = ds.Tables[0].Rows[0]["berat_badan"].ToString();
                        xn.SelectSingleNode("tinggi_badan").InnerText = ds.Tables[0].Rows[0]["tinggi_badan"].ToString();
                        xn.SelectSingleNode("anamnesia").InnerText = ds.Tables[0].Rows[0]["anamnesia"].ToString();
                    }
                    else
                    {
                        xn.Attributes["status"].Value = "update";
                        xn.SelectSingleNode("id_pasien").InnerText = ds.Tables[0].Rows[0]["id_pasien"].ToString();
                        xn.SelectSingleNode("id_reg").InnerText = ds.Tables[0].Rows[0]["id_reg"].ToString();
                        xn.SelectSingleNode("id_kondisi").InnerText = ds.Tables[0].Rows[0]["id_kondisi"].ToString();
                        xn.SelectSingleNode("stole_diastole").InnerText = ds.Tables[0].Rows[0]["stole_diastole"].ToString();
                        xn.SelectSingleNode("respiratory_rate").InnerText = ds.Tables[0].Rows[0]["respiratory_rate"].ToString();
                        xn.SelectSingleNode("suhu").InnerText = ds.Tables[0].Rows[0]["suhu"].ToString();
                        xn.SelectSingleNode("nadi").InnerText = ds.Tables[0].Rows[0]["nadi"].ToString();
                        xn.SelectSingleNode("berat_badan").InnerText = ds.Tables[0].Rows[0]["berat_badan"].ToString();
                        xn.SelectSingleNode("tinggi_badan").InnerText = ds.Tables[0].Rows[0]["tinggi_badan"].ToString();
                        xn.SelectSingleNode("anamnesia").InnerText = ds.Tables[0].Rows[0]["anamnesia"].ToString();
                    }
                    break;
                }
            }
            Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_medis.xml"));
        }

        [WebMethod]
        public void delete(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_medis.xml"));
            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_medis"))
            {
                if (xn.SelectSingleNode("id_rm").InnerText == ds.Tables[0].Rows[0]["id_rm"].ToString())
                {
                    if (xn.Attributes["status"].Value == "insert")
                    {
                        xn.ParentNode.RemoveChild(xn);
                    }
                    else
                    {
                        xn.Attributes["status"].Value = "delete";
                    }
                    break;
                }
            }
            Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_medis.xml"));
        }

        [WebMethod]
        public XmlDocument selectall()
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_medis.xml"));
            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_medis"))
            {
                if (xn.Attributes["status"].Value == "delete")
                {
                    xn.ParentNode.RemoveChild(xn);
                    break;
                }
            }
            return Global.xdoc;
        }

        [WebMethod]
        public void database()
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_medis.xml"));

            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_medis"))
            {
                if (xn.Attributes["status"].Value == "insert" || xn.Attributes["status"].Value == "insert_update")
                {
                    bool cek = DataRekamMedis.insert(xn);

                    if (cek == true)
                    {
                        xn.Attributes["status"].Value = "none";
                    }
                }
                else if (xn.Attributes["status"].Value == "update")
                {
                    bool cek = DataRekamMedis.update(xn);

                    if (cek == true)
                    {
                        xn.Attributes["status"].Value = "none";
                    }
                }
                else if (xn.Attributes["status"].Value == "delete")
                {
                    bool cek = DataRekamMedis.delete(xn);

                    if (cek == true)
                    {
                        xn.ParentNode.RemoveChild(xn);
                    }
                }
            }
            Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_medis.xml"));
        }
    }
}
