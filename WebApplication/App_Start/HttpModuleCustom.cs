using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApplication2.App_Start
{
    public class HttpModuleCustom : IHttpModule
    {
        private HttpApplication _application = null;

        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            _application = context;
            string reqTime = string.Empty;
            string resTime = string.Empty;

            _application.BeginRequest += (obj,e)=>
            {
                reqTime = string.Format("请求时间:{0}", DateTime.Now.ToString());
            };

            _application.EndRequest += (obj, e) =>
            {
                resTime = string.Format("请求时间:{0}", DateTime.Now.ToString());

                _application.Context.Response.Write(reqTime + "<br/>" + resTime);
            };
        }

        private void _application_BeginRequest(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}