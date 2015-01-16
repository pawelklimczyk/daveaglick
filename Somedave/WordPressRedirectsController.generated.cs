// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
#pragma warning disable 1591, 3008, 3009
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Somedave.Controllers
{
    public partial class WordPressRedirectsController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public WordPressRedirectsController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected WordPressRedirectsController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }


        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public WordPressRedirectsController Actions { get { return MVC.WordPressRedirects; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "WordPressRedirects";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "WordPressRedirects";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Wp20140530 = "Wp20140530";
            public readonly string Wp20140521 = "Wp20140521";
            public readonly string Wp20140509 = "Wp20140509";
            public readonly string Wp20140306 = "Wp20140306";
            public readonly string Wp20140103 = "Wp20140103";
            public readonly string Wp20140102 = "Wp20140102";
            public readonly string Wp20130517 = "Wp20130517";
            public readonly string Wp20130516 = "Wp20130516";
            public readonly string Wp20130513 = "Wp20130513";
            public readonly string Wp20130417 = "Wp20130417";
            public readonly string Wp20130411 = "Wp20130411";
            public readonly string Wp20121017 = "Wp20121017";
            public readonly string Wp20120326 = "Wp20120326";
            public readonly string Wp20120224 = "Wp20120224";
            public readonly string Wp20120217 = "Wp20120217";
            public readonly string Wp20100617 = "Wp20100617";
            public readonly string Wp20100415 = "Wp20100415";
            public readonly string Wp20100412 = "Wp20100412";
            public readonly string Wp20100409 = "Wp20100409";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Wp20140530 = "Wp20140530";
            public const string Wp20140521 = "Wp20140521";
            public const string Wp20140509 = "Wp20140509";
            public const string Wp20140306 = "Wp20140306";
            public const string Wp20140103 = "Wp20140103";
            public const string Wp20140102 = "Wp20140102";
            public const string Wp20130517 = "Wp20130517";
            public const string Wp20130516 = "Wp20130516";
            public const string Wp20130513 = "Wp20130513";
            public const string Wp20130417 = "Wp20130417";
            public const string Wp20130411 = "Wp20130411";
            public const string Wp20121017 = "Wp20121017";
            public const string Wp20120326 = "Wp20120326";
            public const string Wp20120224 = "Wp20120224";
            public const string Wp20120217 = "Wp20120217";
            public const string Wp20100617 = "Wp20100617";
            public const string Wp20100415 = "Wp20100415";
            public const string Wp20100412 = "Wp20100412";
            public const string Wp20100409 = "Wp20100409";
        }


        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_WordPressRedirectsController : Somedave.Controllers.WordPressRedirectsController
    {
        public T4MVC_WordPressRedirectsController() : base(Dummy.Instance) { }

        [NonAction]
        partial void Wp20140530Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20140530()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20140530);
            Wp20140530Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20140521Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20140521()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20140521);
            Wp20140521Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20140509Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20140509()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20140509);
            Wp20140509Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20140306Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20140306()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20140306);
            Wp20140306Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20140103Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20140103()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20140103);
            Wp20140103Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20140102Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20140102()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20140102);
            Wp20140102Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20130517Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20130517()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20130517);
            Wp20130517Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20130516Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20130516()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20130516);
            Wp20130516Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20130513Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20130513()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20130513);
            Wp20130513Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20130417Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20130417()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20130417);
            Wp20130417Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20130411Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20130411()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20130411);
            Wp20130411Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20121017Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20121017()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20121017);
            Wp20121017Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20120326Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20120326()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20120326);
            Wp20120326Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20120224Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20120224()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20120224);
            Wp20120224Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20120217Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20120217()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20120217);
            Wp20120217Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20100617Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20100617()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20100617);
            Wp20100617Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20100415Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20100415()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20100415);
            Wp20100415Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20100412Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20100412()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20100412);
            Wp20100412Override(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void Wp20100409Override(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult Wp20100409()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Wp20100409);
            Wp20100409Override(callInfo);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
