﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="DeleteAssociationResponseModel.cs" company="Zepto Systems">
// //   Zepto Systems
// // </copyright>
// // <summary>
// //   DeleteAssociationResponseModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
namespace RightCRM.DataAccess.Model.BusinessModels
{

    public class AssociationDelete
    {
        public string msg { get; set; }

        public string sqlerr { get; set; }

        public int? status { get; set; }
    }

    public class DeleteAssociationResponseModel
    {
        public AssociationDelete business;
    }
}