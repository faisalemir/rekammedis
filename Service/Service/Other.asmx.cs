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
    /// Summary description for OtherService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OtherService : System.Web.Services.WebService
    {

        [WebMethod]
        public XmlDocument Obat()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Server.MapPath(@"~\Database\obat.xml"));
            return xdoc;
        }

        [WebMethod]
        public XmlDocument Terapi()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Server.MapPath(@"~\Database\terapi.xml"));
            return xdoc;
        }

        [WebMethod]
        public XmlDocument Pasien()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(Server.MapPath(@"~\Database\pasien.xml"));
            return xdoc;
        }

        [WebMethod]
        public XmlDocument Login(string nama, string pass)
        {
            Global.xdoc.Load(Server.MapPath(@"~\Database\login.xml"));
            foreach (XmlNode xn in Global.xdoc.SelectNodes("//login"))
            {
                if (xn.SelectSingleNode("nama").InnerText == nama && xn.SelectSingleNode("pass").InnerText == pass)
                {
                    Global.xdoc.RemoveAll();
                    Global.xdoc.LoadXml(xn.OuterXml);
                    break;
                }
                else
                {
                    xn.ParentNode.RemoveChild(xn);
                }
            }
            return Global.xdoc;
        }
    }
}
