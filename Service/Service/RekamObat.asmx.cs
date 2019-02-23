using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Xml;
using Service.Data;

namespace Service.Service
{
    /// <summary>
    /// Summary description for RekamObat
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RekamObat : System.Web.Services.WebService
    {
        [WebMethod]
        public bool insert(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_obat.xml"));
            bool status = true;

            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_obat"))
            {
                if (xn.SelectSingleNode("id_rm").InnerText == ds.Tables[0].Rows[0]["id_rm"].ToString() && xn.SelectSingleNode("id_obat").InnerText == ds.Tables[0].Rows[0]["id_obat"].ToString())
                {
                    if (xn.Attributes["status"].Value != "delete")
                    {
                        status = false;
                        break;
                    }
                    else
                    {
                        xn.Attributes["status"].Value = "update";
                        xn.SelectSingleNode("jumlah").InnerText = ds.Tables[0].Rows[0]["jumlah"].ToString();
                        Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_obat.xml"));
                        status = false;
                        break;
                    }
                }
            }

            if (status == true)
            {
                XmlElement parentelement = Global.xdoc.CreateElement("rekam_obat");
                XmlElement id_rm = Global.xdoc.CreateElement("id_rm");
                XmlElement id_obat = Global.xdoc.CreateElement("id_obat");
                XmlElement jumlah = Global.xdoc.CreateElement("jumlah");

                id_rm.InnerText = ds.Tables[0].Rows[0]["id_rm"].ToString();
                id_obat.InnerText = ds.Tables[0].Rows[0]["id_obat"].ToString();
                jumlah.InnerText = ds.Tables[0].Rows[0]["jumlah"].ToString();

                parentelement.AppendChild(id_rm);
                parentelement.AppendChild(id_obat);
                parentelement.AppendChild(jumlah);
                parentelement.SetAttribute("status", "insert");

                Global.xdoc.DocumentElement.AppendChild(parentelement);
                Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_obat.xml"));
            }
            return status;
        }

        [WebMethod]
        public void update(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_obat.xml"));

            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_obat"))
            {
                if (xn.SelectSingleNode("id_rm").InnerText == ds.Tables[0].Rows[0]["id_rm"].ToString() && xn.SelectSingleNode("id_obat").InnerText == ds.Tables[0].Rows[0]["id_obat"].ToString())
                {
                    if (xn.Attributes["status"].Value == "insert" || xn.Attributes["status"].Value == "insert_update")
                    {
                        xn.Attributes["status"].Value = "insert_update";
                        xn.SelectSingleNode("jumlah").InnerText = ds.Tables[0].Rows[0]["jumlah"].ToString();
                    }
                    else
                    {
                        xn.Attributes["status"].Value = "update";
                        xn.SelectSingleNode("jumlah").InnerText = ds.Tables[0].Rows[0]["jumlah"].ToString();
                    }
                    break;
                }
            }
            Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_obat.xml"));
        }

        [WebMethod]
        public void delete(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_obat.xml"));

            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_obat"))
            {
                if (xn.SelectSingleNode("id_rm").InnerText == ds.Tables[0].Rows[0]["id_rm"].ToString() && xn.SelectSingleNode("id_obat").InnerText == ds.Tables[0].Rows[0]["id_obat"].ToString())
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
            Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_obat.xml"));
        }

        [WebMethod]
        public XmlDocument selectall()
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_obat.xml"));

            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_obat"))
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
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_obat.xml"));
            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_obat"))
            {
                if (xn.Attributes["status"].Value == "insert" || xn.Attributes["status"].Value == "insert_update")
                {
                    bool cek = DataRekamObat.insert(xn);

                    if (cek == true)
                    {
                        xn.Attributes["status"].Value = "none";
                    }
                }
                else if (xn.Attributes["status"].Value == "update")
                {
                    bool cek = DataRekamObat.update(xn);

                    if (cek == true)
                    {
                        xn.Attributes["status"].Value = "none";
                    }
                }
                else if (xn.Attributes["status"].Value == "delete")
                {
                    bool cek = DataRekamObat.delete(xn);

                    if (cek == true)
                    {
                        xn.ParentNode.RemoveChild(xn);
                    }
                }
            }
            Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_obat.xml"));
        }
    }
}
