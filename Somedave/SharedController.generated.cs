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
namespace T4MVC
{
    public class SharedController
    {

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
                public readonly string _Master = "_Master";
                public readonly string Error = "Error";
                public readonly string PostList = "PostList";
                public readonly string SocialLinks = "SocialLinks";
                public readonly string Title = "Title";
            }
            public readonly string _Master = "~/Views/Shared/_Master.cshtml";
            public readonly string Error = "~/Views/Shared/Error.cshtml";
            public readonly string PostList = "~/Views/Shared/PostList.cshtml";
            public readonly string SocialLinks = "~/Views/Shared/SocialLinks.cshtml";
            public readonly string Title = "~/Views/Shared/Title.cshtml";
        }
    }

}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009
