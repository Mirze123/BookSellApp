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
    public partial class Register : System.Web.UI.Page
    {
        IUserOperation userManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            divErrorMessages.Visible = false;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                InsertData();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region Business Operations

        private void InsertData()
        {
            User user = new User();
            user.ID = userManager.GetNextId().Data;
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            user.Email = txtEmail.Text;
            user.CreatedDate = DateTime.Now;
            user.LastUpdateDate = DateTime.Now;
            user.Role = GetRoleByCode(ddlRoles.SelectedValue);

            var result =  userManager.Add(user);

            if (!result.IsSuccess)
            {
                divErrorMessages.Visible = true;
                lblErrorMessages.Text = result.Message;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
        
        private Enums.Roles GetRoleByCode(string code)
        {
            switch (code)
            {
                case "1":
                    return Enums.Roles.Admin;
                case "2":
                    return Enums.Roles.Moderator;
                case "3":
                    return Enums.Roles.User;
                default:
                    return Enums.Roles.Anonymous;
            }
        }

        #endregion
    }
}