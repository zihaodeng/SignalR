using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using Newtonsoft.Json;
using Jeez.AccessOpenByNet.SignalR;

namespace Jeez.AccessOpenByNet.BLL
{
    public class BussBLL
    {
        /// <summary>
        /// 网络开门
        /// ADD BY DZH
        /// </summary>
        /// <param name="request">传递给门禁的参数对象</param>
        public static void BussOpenDoor(Models.Buss request)
        {
            Notifier.ServerSendClientMethod(request.ChannelID, JsonConvert.SerializeObject(request));
        }
        
    }
}