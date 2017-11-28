using Angular4AspNetWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Angular4AspNetWebForms.FunctionGroupMenu
{
    public partial class FunctionGroupMenu : System.Web.UI.Page
    {
        ESFAccDAO dao = new ESFAccDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            var result = dao.getPow_Func_FuncGrp(x => 1 == 1).ToList();

        }
    }
}