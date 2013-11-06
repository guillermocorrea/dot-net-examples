using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageAtRuntime
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public Default()
        {
            this.PreInit += new EventHandler(Default_PreInit);
        }

        void Default_PreInit(object sender, EventArgs e)
        {
            if (Request["ext"] != null && Request["ext"] == "1")
            {
                this.MasterPageFile = "~/MasterPages/Site2.Master";
                return;
            }

            this.MasterPageFile = "~/MasterPages/Site1.Master";
        }
    }
}