using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Xml;
using Service.Data;
using System.Data.SqlClient;

namespace Service.Service
{
    /// <summary>
    /// Summary description for Kondisi
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Kondisi : System.Web.Services.WebService
    {

        [WebMethod]
        public bool insert(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\kondisi_keluar.xml"));
            bool status = true;
            foreach (XmlNode xn in Global.xdoc.SelectNodes("//kondisi_keluar"))
            {
                if (xn.SelectSingleNode("id_kondisi").InnerText == ds.Tables[0].Rows[0]["id_kondisi"].ToString())
                {
                    if (xn.Attributes["status"].Value != "delete")
                    {
                        status = false;
                        break;
                    }
                    else
                    {
                        xn.Attributes["status"].Value = "update";
                        xn.SelectSingleNode("kondisi").InnerText = ds.Tables[0].Rows[0]["kondisi"].ToString();
                        Global.xdoc.Save(Server.MapPath(@"~\Database\kondisi_keluar.xml"));
                        status = false;
                        break;
                    }
                }
            }

            if (status == true)
            {
                XmlElement parentelement = Global.xdoc.CreateElement("kondisi_keluar");
                XmlElement id_kondisi = Global.xdoc.CreateElement("id_kondisi");
                XmlElement kondisi = Global.xdoc.CreateElement("kondisi");

                id_kondisi.InnerText = ds.Tables[0].Rows[0]["id_kondisi"].ToString();
                kondisi.InnerText = ds.Tables[0].Rows[0]["kondisi"].ToString();

                parentelement.AppendChild(id_kondisi);
                parentelement.AppendChild(kondisi);
                parentelement.SetAttribute("status", "insert");

                Global.xdoc.DocumentElement.AppendChild(parentelement);
                Global.xdoc.Save(Server.MapPath(@"~\Database\kondisi_keluar.xml"));
            }
            return status;
        }

        [WebMethod]
        public void update(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\kondisi_keluar.xml"));
            foreach (XmlNode xn in Global.xdoc.SelectNodes("//kondisi_keluar"))
            {
                if (xn.SelectSingleNode("id_kondisi").InnerText == ds.Tables[0].Rows[0]["id_kondisi"].ToString())
                {
                    if (xn.Attributes["status"].Value == "insert" || xn.Attributes["status"].Value == "insert_update")
                    {
                        xn.Attributes["status"].Value = "insert_update";
                        xn.SelectSingleNode("kondisi").InnerText = ds.Tables[0].Rows[0]["kondisi"].ToString();
                    }
                    else
                    {
                        xn.Attributes["status"].Value = "update";
                        xn.SelectSingleNode("kondisi").InnerText = ds.Tables[0].Rows[0]["kondisi"].ToString();
                    }
                    break;
                }
            }
            Global.xdoc.Save(Server.MapPath(@"~\Database\kondisi_keluar.xml"));
        }

        [WebMethod]
        public void delete(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\kondisi_keluar.xml"));
            foreach (XmlNode xn in Global.xdoc.SelectNodes("//kondisi_keluar"))
            {
                if (xn.SelectSingleNode("id_kondisi").InnerText == ds.Tables[0].Rows[0]["id_kondisi"].ToString())
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
            Global.xdoc.Save(Server.MapPath(@"~\Database\kondisi_keluar.xml"));
        }

        [WebMethod]
        public XmlDocument selectall()
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\kondisi_keluar.xml"));
            foreach (XmlNode xn in Global.xdoc.SelectNodes("//kondisi_keluar"))
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
            Global.xdoc.Load(Server.MapPath(@"~\Database\kondisi_keluar.xml"));
            foreach (XmlNode xn in Global.xdoc.SelectNodes("//kondisi_keluar"))
            {
                if (xn.Attributes["status"].Value == "insert" || xn.Attributes["status"].Value == "insert_update")
                {
                    bool cek = DataKondisi.insert(xn);

                    if(cek == true)
                    {
                        xn.Attributes["status"].Value = "none";
                    }
                }
                else if (xn.Attributes["status"].Value == "update")
                {
                    bool cek = DataKondisi.update(xn);

                    if (cek == true)
                    {
                        xn.Attributes["status"].Value = "none";
                    }
                }
                else if (xn.Attributes["status"].Value == "delete")
                {
                    bool cek = DataKondisi.delete(xn);

                    if (cek == true)
                    {
                        xn.ParentNode.RemoveChild(xn);
                    }
                }
            }
            Global.xdoc.Save(Server.MapPath(@"~\Database\kondisi_keluar.xml"));
        }

    }
}
