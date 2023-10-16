using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.Helpers;
using WebApp.Models.Concrete;
using WebApp.Operations.Abstract;
using WebApp.Operations.Concrete;

namespace WebApp
{
    public partial class AddOrEditCountry : System.Web.UI.Page
    {
        ICountryOperation _countryOperation = new CountryManager();

        private Enums.Mode PageMode {
            get
            {
                return (Enums.Mode)ViewState["PageMode"];
            }
            set
            {
                ViewState["PageMode"] = value;
            }
        }
        private int RowId
        {
            get
            {
                return (int)ViewState["id"];
            }
            set
            {
                ViewState["id"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                var idQueryData = Request.QueryString["ID"];

                if (idQueryData != null)
                {
                    PageMode = Enums.Mode.Update;
                    RowId = int.Parse(idQueryData.ToString());
                    BindData();
                }
                else
                {
                    PageMode = Enums.Mode.Insert;
                }
            }

        }

        private void BindData()
        {
            var model = _countryOperation.GetById(RowId).Data;
            txtName.Text = model.Name;
            txtCode.Text = model.Code;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (PageMode == Enums.Mode.Update)
            {
                UpdateData();
            }
            else
            {
                InsertData();
            }
        }

        private void InsertData()
        {
            Country country = new Country();
            country.ID = _countryOperation.GetNextId().Data;
            country.Name = txtName.Text;
            country.Code = txtCode.Text;
            country.CreatedDate = DateTime.Now;
            country.LastUpdateDate = DateTime.Now;

            var result = _countryOperation.Add(country);

            if (result.IsSuccess)
            {
                Response.Redirect("Countries.aspx");
            }
        }

        private void UpdateData()
        {
            var updatedModel = _countryOperation.GetById(RowId).Data;
            updatedModel.Name = txtName.Text;
            updatedModel.Code = txtCode.Text;
            updatedModel.LastUpdateDate= DateTime.Now;

            var result = _countryOperation.Update(updatedModel);

            if (result.IsSuccess)
            {
                Response.Redirect("Countries.aspx");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Countries.aspx");
        }
    }
}