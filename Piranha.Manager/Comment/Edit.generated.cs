﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Manager.Comment
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Comment/Edit.cshtml")]
    public class Edit : Piranha.Manager.Templates.CommentEdit
    {

                // Resolve package relative syntax
                // Also, if it comes from a static embedded resource, change the path accordingly
                public override string Href(string virtualPath, params object[] pathParts) {
                    virtualPath = ApplicationPart.ProcessVirtualPath(GetType().Assembly, VirtualPath, virtualPath);
                    return base.Href(virtualPath, pathParts);
                }
        public Edit()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\n\r\n");



            
            #line 4 "..\..\Comment\Edit.cshtml"
  
    Page.Title = @Piranha.Manager.Resources.Comment.EditTitleExisting ;
    Layout = "~/Manager/Shared/_Layout.cshtml" ;


            
            #line default
            #line hidden

DefineSection("Toolbar", () => {

WriteLiteral("\r\n<div class=\"toolbar\">\r\n    <div class=\"inner\">\r\n        <ul>\r\n            <li><" +
"a class=\"save submit\">");


            
            #line 12 "..\..\Comment\Edit.cshtml"
                                  Write(Piranha.Manager.Resources.Toolbar.Save);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a href=\"");


            
            #line 13 "..\..\Comment\Edit.cshtml"
                    Write(Href("~/manager/comment/edit/delete/" + Model.Comment.Id));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"delete\">");


            
            #line 13 "..\..\Comment\Edit.cshtml"
                                                                                               Write(Piranha.Manager.Resources.Toolbar.Delete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a href=\"");


            
            #line 14 "..\..\Comment\Edit.cshtml"
                    Write(Href("~/manager/comment"));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"back\">");


            
            #line 14 "..\..\Comment\Edit.cshtml"
                                                             Write(Piranha.Manager.Resources.Toolbar.Back);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a href=\"");


            
            #line 15 "..\..\Comment\Edit.cshtml"
                    Write(Href("~/manager/comment/edit/" + Model.Comment.Id));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"refresh\">");


            
            #line 15 "..\..\Comment\Edit.cshtml"
                                                                                         Write(Piranha.Manager.Resources.Toolbar.Reload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <div class=\"clear\"></div>\r\n    </div>\r\n</div>\r\n" +
"");


});

WriteLiteral("\r\n<form method=\"post\">\r\n    ");


            
            #line 22 "..\..\Comment\Edit.cshtml"
Write(Form.Action("Save"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 23 "..\..\Comment\Edit.cshtml"
Write(Form.HiddenFor(m => m.Comment.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 24 "..\..\Comment\Edit.cshtml"
Write(Form.HiddenFor(m => m.Comment.AuthorName));

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 25 "..\..\Comment\Edit.cshtml"
Write(Form.HiddenFor(m => m.Comment.AuthorEmail));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div class=\"grid_9\">\r\n        <div class=\"box\">\r\n            <div class=\"ti" +
"tle\"><h2>");


            
            #line 28 "..\..\Comment\Edit.cshtml"
                              Write(Piranha.Manager.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n            <div class=\"inner\">\r\n                <ul class=\"form\">\r\n" +
"                    <li>");


            
            #line 31 "..\..\Comment\Edit.cshtml"
                   Write(Form.LabelFor(m => m.Comment.Title, Piranha.Manager.Resources.Global.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div class=\"input\">\r\n                            ");


            
            #line 33 "..\..\Comment\Edit.cshtml"
                       Write(Form.TextBoxFor(m => m.Comment.Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                        ");


            
            #line 34 "..\..\Comment\Edit.cshtml"
                   Write(Form.ValidationMessageFor(m => m.Comment.Title));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </li>\r\n                    <li>");


            
            #line 36 "..\..\Comment\Edit.cshtml"
                   Write(Form.LabelFor(m => m.Comment.Status, Piranha.Manager.Resources.Global.Status));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div class=\"input\">\r\n                            ");


            
            #line 38 "..\..\Comment\Edit.cshtml"
                       Write(Form.DropDownListFor(m => m.Comment.Status, Model.Statuses));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </li>\r\n                    <li>");


            
            #line 40 "..\..\Comment\Edit.cshtml"
                   Write(Form.LabelFor(m => m.Comment.Body, Piranha.Manager.Resources.Global.Content));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div class=\"input\">\r\n                            ");


            
            #line 42 "..\..\Comment\Edit.cshtml"
                       Write(Form.TextAreaFor(m => m.Comment.Body, new { @rows = 10 }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n   " +
"     </div>\r\n    </div>\r\n    <div class=\"grid_3\">\r\n        <div class=\"box\">\r\n  " +
"          <div class=\"title\"><h2>");


            
            #line 50 "..\..\Comment\Edit.cshtml"
                              Write(Piranha.Manager.Resources.Comment.Author);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n            <div class=\"inner\">\r\n                <ul class=\"form\">\r\n" +
"                    <li>");


            
            #line 53 "..\..\Comment\Edit.cshtml"
                   Write(Form.LabelFor(m => m.Comment.AuthorName, Piranha.Manager.Resources.Comment.Author));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 54 "..\..\Comment\Edit.cshtml"
                     if (Model.Comment.CreatedById.HasValue) {

            
            #line default
            #line hidden
WriteLiteral("                        <p><a href=\"");


            
            #line 55 "..\..\Comment\Edit.cshtml"
                               Write(Href("~/manager/user/" + Model.Comment.CreatedById.Value));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 55 "..\..\Comment\Edit.cshtml"
                                                                                           Write(Model.Comment.AuthorName);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n");


            
            #line 56 "..\..\Comment\Edit.cshtml"
                    } else {

            
            #line default
            #line hidden
WriteLiteral("                        <p>");


            
            #line 57 "..\..\Comment\Edit.cshtml"
                      Write(Model.Comment.AuthorName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");


            
            #line 58 "..\..\Comment\Edit.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    </li>\r\n                    <li>");


            
            #line 60 "..\..\Comment\Edit.cshtml"
                   Write(Form.LabelFor(m => m.Comment.AuthorEmail, Piranha.Manager.Resources.User.Email));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <p><a href=\"mailto:");


            
            #line 61 "..\..\Comment\Edit.cshtml"
                                      Write(Model.Comment.AuthorEmail);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 61 "..\..\Comment\Edit.cshtml"
                                                                  Write(Model.Comment.AuthorEmail);

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n " +
"       </div>\r\n    </div>\r\n</form>\r\n");


        }
    }
}
#pragma warning restore 1591