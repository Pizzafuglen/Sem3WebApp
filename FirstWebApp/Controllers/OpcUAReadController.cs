using System.Web.Mvc;
using Opc.UaFx.Client;

namespace FirstWebApp.Controllers
{
    public class OpcUaReadController : Controller
    {
        private const string OpcUrl = "opc.tcp://127.0.0.1:4840";

        public static string ReadNodeValue()
        {
            var client = new OpcClient(OpcUrl);
            client.Connect();

            var returnValue = client.ReadNode("ns=6;s=::Program:Cube.Status.StateCurrent");
            return returnValue.ToString();
        }

        public ActionResult ReadView()
        {
            return View();
        }
    }
}