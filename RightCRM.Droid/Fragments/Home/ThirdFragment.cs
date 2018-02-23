﻿using Android.OS;
using Android.Runtime;
using Android.Views;
using RightCRM.Core.ViewModels;
using RightCRM.Droid.Activities;
using MvvmCross.Droid.Views.Attributes;

namespace RightCRM.Droid.Fragments
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("rightcrm.droid.fragments.ThirdFragment")]
    public class ThirdFragment : BaseFragment<ThirdViewModel>
    {
        string oldTitle;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            oldTitle = ((MainActivity)Activity).Title;
            ((MainActivity)Activity).Title = "Third Fragment";            
            return base.OnCreateView(inflater, container, savedInstanceState);        
        }

        public override void OnDestroyView()
        {
            ((MainActivity)Activity).Title = oldTitle;
            base.OnDestroyView();
        }

        protected override int FragmentId 
        {
            get 
            {
                return Resource.Layout.fragment_third;
            }
        }
    }
}