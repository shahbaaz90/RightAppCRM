﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="BusDetailTab1ViewModel.cs" company="Zepto Systems">
// //   Zepto Systems
// // </copyright>
// // <summary>
// //   BusDetailTab1ViewModel
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------
using System;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using RightCRM.Common;
using RightCRM.Common.Models;
using System.Threading.Tasks;

namespace RightCRM.Core.ViewModels.Home
{
    public class BusDetailTab1ViewModel : BaseViewModel, IMvxViewModel<Business>
    {
        private Business businessItem;

        private BusinessDetails listBusinessDetails;

        public BusDetailTab1ViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public BusinessDetails ListBusinessDetails{ get { return listBusinessDetails; } set{ SetProperty(ref listBusinessDetails, value);}}

        public override void Prepare()
        {
            base.Prepare();

            Title = Constants.TitleBusinessDetailsPage;
        }

        public void Prepare(Business parameter)
        {
            businessItem = parameter;
        }

        public override async Task Initialize()
        {
            await base.Initialize();


            ListBusinessDetails = new BusinessDetails() { 
                BusinessID = 101, 
                AccountName = "hey", 
                AccountType = "test", 
                AnnualRevenue = 133, 
                BusinessNTN = "93829391", 
                BusinessWebsite = "www.helloworld.com", 
                CampaignMedia="bolwala", 
                CampaignName="hellomoto", 
                CampaignSrc="source", 
                CompanySize="1000", 
                Industry="Pharma"};

        }
    }
}
