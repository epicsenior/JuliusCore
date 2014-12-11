using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace Scratch
{

    public class Index : NancyModule
    {

        public Index()
        {
            Get["/"] = x => {

                return View["Index.html"];
            };
        }
    }
}