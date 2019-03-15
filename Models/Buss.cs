using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jeez.AccessOpenByNet.Models
{
    /// <summary>
    /// 接收参数
    /// ADD BY DZH
    /// </summary>
    public class Buss
    {
        public string ChannelID { get; set; }
        public string DoorNumber { get; set; }
        public string People { get; set; }
        public DateTime NowTime { get; set; }
    }

    /// <summary>
    /// 返回结果
    /// ADD BY DZH
    /// </summary>
    public class BussResult
    {
        public bool IsResult { get; set; }
        public string ResultMessage { get; set; }
        public string Token { get; set; }
    }
}