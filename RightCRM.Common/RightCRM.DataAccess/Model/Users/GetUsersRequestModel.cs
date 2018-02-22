﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="GetUsersRequestModel.cs" company="Zepto Systems">
// //   Zepto Systems
// // </copyright>
// // <summary>
// //   GetUsersRequestModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
namespace RightCRM.DataAccess.Model.Users
{
    public class GetUsersRequestModel
    {
        public string sessionid { get; set; }
        public string srch_user_svsid { get; set; }
        public string srch_user_email { get; set; }
        public string srch_user_usrname { get; set; }
        public string srch_user_status { get; set; }
        public string srch_user_isadmin { get; set; }
        public int? page_no { get; set; }

    }
}