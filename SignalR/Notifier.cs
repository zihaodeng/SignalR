using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Jeez.AccessOpenByNet.SignalR
{
    /// <summary>
    /// 通知
    /// ADD BY DZH
    /// </summary>
    public static class Notifier
    {
        private static readonly IHubContext Context = GlobalHost.ConnectionManager.GetHubContext<SystemHub>();

        /// <summary>
        /// 服务端发送数据至客户端
        /// ADD BY DZH
        /// </summary>
        /// <param name="connectionId">客户端ID</param>
        /// <param name="message">发送内容</param>
        public static void ServerSendClientMethod(String connectionId, string message)
        {
            Context.Clients.Client(connectionId).serverSendClient(message);
        }
    }
}