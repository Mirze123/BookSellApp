using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.Operations.Abstract;
using WebApp.Operations.Concrete;

namespace WebApp
{
    public partial class Countries : System.Web.UI.Page
    {
        ICountryOperation _countryOperation = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddOrEditCountry.aspx");
        }

        protected void rptData_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "EDIT":
                    RedirectEditPage(int.Parse(e.CommandArgument.ToString()));
                    break;
                case "REMOVE":
                    RemoveData(int.Parse(e.CommandArgument.ToString()));
                    break;
                default:
                    break;
            }
        }

        private void RemoveData(int id)
        {
            var deletingModel = _countryOperation.GetById(id).Data;
            _countryOperation.Remove(deletingModel);

            LoadData();
        }

        private void RedirectEditPage(int id)
        {
            Response.Redirect("AddOrEditCountry.aspx?ID=" + id);
        }

        private void LoadData()
        {
            var data = _countryOperation.GetAll().Data;
            rptData.DataSource = data;
            rptData.DataBind();
        }
    }
}