using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Jeez.AccessOpenByNet.Models;
using Newtonsoft.Json;
using Jeez.AccessOpenByNet.BLL;
using Jeez.AccessOpenByNet.Helper;

namespace Jeez.AccessOpenByNet.Controllers
{
    public class BussController: ApiController
    {
        /// <summary>
        /// 开门请求接口
        /// ADD BY DZH
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public Models.BussResult OpenDoor([FromBody]Buss request)
        {
            Models.BussResult rs = new Models.BussResult();
            try
            {
                BussBLL.BussOpenDoor(request);
                rs.IsResult = true;
            }
            catch (Exception ex)
            {
                rs.IsResult = false;
                rs.ResultMessage = $"异常信息：{ex.Message}";
                LogHelper.WriteLog($"异常信息：{ex.Message}");
            }
            return rs;
        }
    }
}