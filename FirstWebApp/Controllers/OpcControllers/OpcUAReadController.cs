﻿using System.Web.Mvc;
using Opc.UaFx.Client;

namespace FirstWebApp.Controllers.OpcControllers
{
    public class OpcUaReadController : Controller
    {
        private const string OpcUrl = "opc.tcp://127.0.0.1:4840";

        public static string ReadNodeValue(string nodeId)
        {
            var client = new OpcClient(OpcUrl);
            client.Connect();

            var returnValue = client.ReadNode(nodeId);
            return returnValue.ToString();
        }

        public ActionResult ReadView()
        {
            return View();
        }
    }
}