﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using RightCRM.Common;
using RightCRM.Common.Services;
using RightCRM.DataAccess.Model.RequestModels;
using RightCRM.Facade.Facades;

namespace RightCRM.Core.ViewModels
{
    /// <summary>
    /// Login view model.
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        /// <summary>
        /// The user facade.
        /// </summary>
        private readonly IUserFacade userFacade;

        /// <summary>
        /// The cache service.
        /// </summary>
        private readonly ICacheService cacheService;

        private readonly IUserDialogs userDialog;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:RightCRM.Core.ViewModels.LoginViewModel"/> class.
        /// </summary>
        /// <param name="navigationService">Navigation service.</param>
        public LoginViewModel(IMvxNavigationService navigationService,
                              IUserFacade userFacade,
                              IUserDialogs userDialog) : base (userDialog)
                             // ICacheService cacheService)
        {
            this.navigationService = navigationService;
            this.userFacade = userFacade;
            this.userDialog = userDialog;
           // this.cacheService = cacheService;
        }
        private string _userName = "khurram123_admin@zeptowork.com";
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        private string _password = "test123";
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private string _loginResult;

        public string LoginResult
        {
            get { return _loginResult; }
            set { SetProperty(ref _loginResult, value); }
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            //var result = await this.userFacade.GetUserSessionId(new RequestUserLogin()
            //{
            //    loginid = UserName,
            //    token = Password,
            //    svsid = "work"
            //});

            LoginCommand = new MvxAsyncCommand(Login);
        }

        public IMvxCommand LoginCommand { get; private set; }
        private async Task Login()
        {
            //if (UserName == "admin" && Password == "123"){
            //    LoginResult = "Login Successfully";
            //}
            //else{
            //LoginResult = "User Name or Password is Invalid";

            //}

            //ShowViewModel<AccountsViewModel>();
           // userDialog.ShowLoading("logging in");


            var result = await this.userFacade.GetUserSessionId(new RequestUserLogin()
            {
                loginid = UserName,
                token = Password,
                svsid = "work"
            });

            if (result != null && !string.IsNullOrWhiteSpace(result.user?.msg))
            {
                if(result.user?.msg == "Login Successful..." && result.user.status == 0)
                    this.GoToRootMenuCommand.Execute();

                else
                    await userDialog.AlertAsync("Credentials invalid. Please try again");
            }

            else
            {
                await userDialog.AlertAsync("Something went wrong.");
                this.GoToRootMenuCommand.Execute();
            }
        }
    }
}
