using Service.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace Service.Service
{
    /// <summary>
    /// Summary description for RekamTerapi
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RekamTerapi : System.Web.Services.WebService
    {
        [WebMethod]
        public bool insert(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_terapi.xml"));
            bool status = true;

            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_terapi"))
            {
                if (xn.SelectSingleNode("id_rm").InnerText == ds.Tables[0].Rows[0]["id_rm"].ToString() && xn.SelectSingleNode("id_terapi").InnerText == ds.Tables[0].Rows[0]["id_terapi"].ToString())
                {
                    if (xn.Attributes["status"].Value != "delete")
                    {
                        status = false;
                        break;
                    }
                    else
                    {
                        xn.Attributes["status"].Value = "none";
                        Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_terapi.xml"));
                        status = false;
                        break;
                    }
                }
            }

            if (status == true)
            {
                XmlElement parentelement = Global.xdoc.CreateElement("rekam_terapi");
                XmlElement id_rm = Global.xdoc.CreateElement("id_rm");
                XmlElement id_terapi = Global.xdoc.CreateElement("id_terapi");

                id_rm.InnerText = ds.Tables[0].Rows[0]["id_rm"].ToString();
                id_terapi.InnerText = ds.Tables[0].Rows[0]["id_terapi"].ToString();

                parentelement.AppendChild(id_rm);
                parentelement.AppendChild(id_terapi);
                parentelement.SetAttribute("status", "insert");

                Global.xdoc.DocumentElement.AppendChild(parentelement);
                Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_terapi.xml"));
            }
            return status;
        }

        [WebMethod]
        public void update(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_terapi.xml"));

            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_terapi"))
            {
                if (xn.SelectSingleNode("id_rm").InnerText == ds.Tables[0].Rows[0]["id_rm"].ToString() && xn.SelectSingleNode("id_terapi").InnerText == ds.Tables[0].Rows[0]["id_terapi"].ToString())
                {
                    if (xn.Attributes["status"].Value == "insert" || xn.Attributes["status"].Value == "insert_update")
                    {
                        xn.Attributes["status"].Value = "insert_update";
                    }
                    else
                    {
                        xn.Attributes["status"].Value = "update";
                    }
                    break;
                }
            }
            Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_terapi.xml"));
        }

        [WebMethod]
        public void delete(DataSet ds)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_terapi.xml"));

            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_terapi"))
            {
                if (xn.SelectSingleNode("id_rm").InnerText == ds.Tables[0].Rows[0]["id_rm"].ToString() && xn.SelectSingleNode("id_terapi").InnerText == ds.Tables[0].Rows[0]["id_terapi"].ToString())
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
            Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_terapi.xml"));
        }

        [WebMethod]
        public XmlDocument selectall()
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_terapi.xml"));

            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_terapi"))
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
            Global.xdoc.Load(Server.MapPath(@"~\Database\rekam_terapi.xml"));

            foreach (XmlNode xn in Global.xdoc.SelectNodes("//rekam_terapi"))
            {
                if (xn.Attributes["status"].Value == "insert" || xn.Attributes["status"].Value == "insert_update")
                {
                    bool cek = DataRekamTerapi.insert(xn);

                    if (cek == true)
                    {
                        xn.Attributes["status"].Value = "none";
                    }
                }
                else if (xn.Attributes["status"].Value == "update")
                {
                    bool cek = DataRekamTerapi.update(xn);

                    if (cek == true)
                    {
                        xn.Attributes["status"].Value = "none";
                    }
                }
                else if (xn.Attributes["status"].Value == "delete")
                {
                    bool cek = DataRekamTerapi.delete(xn);

                    if (cek == true)
                    {
                        xn.ParentNode.RemoveChild(xn);
                    }
                }
            }
            Global.xdoc.Save(Server.MapPath(@"~\Database\rekam_terapi.xml"));
        }
    }
}
