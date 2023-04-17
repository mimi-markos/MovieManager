using System;
using Microsoft.AspNetCore.Mvc;

namespace MMS.Web.Controllers
{
    public enum AlertType { success, danger, warning, info } 

    public class BaseController : Controller
    {

        // Store message and alert type in TempData storage where alert will only be accessible in next Request
        public void Alert(string message, AlertType type = AlertType.info) // if alert type not specified, default to info
        {
            TempData["Alert.Message"] = message;
            TempData["Alert.Type"] = type.ToString();
        }

    }
}
