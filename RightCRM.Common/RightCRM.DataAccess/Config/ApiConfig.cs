﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="ApiConfig.cs" company="Zepto Systems">
// //   Zepto Systems
// // </copyright>
// // <summary>
// //   ApiConfig
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using RightCRM.Common;

namespace RightCRM.DataAccess.Config
{
    public static class ApiConfig
    {
        /// <summary>
        /// The shared API key.
        /// </summary>
        public static string SharedApiKey = "95925a94-bd18-4e7e-ae52-731832f63c57";


        public static string GetAllBusinesses()
        {
            return $"{SharedConfig.RightCrmApiRoot}GetAllBusinesses";
        }

        public static string GetUserProfile(string username)
        {
            return $"{SharedConfig.RightCrmApiRoot}GetUserProfile/{username}";
        }

    }
}