using Foundation;
using System;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using RightCRM.Core.ViewModels.ItemViewModels;
using RightCRM.Core.ViewModels.Home.BusinessTabs;

namespace RightCRM.iOS.Views.BusinessTabs
{
    public partial class AssociatedEntCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString(nameof(AssociatedEntCell));

        private const string BindingText = "AssociatedEnt Username; AssociatedUserID UserID";

        public AssociatedEntCell(IntPtr handle) : base(BindingText, handle)
        {
            InitialiseBindings();
        }

        private void InitialiseBindings()
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<AssociatedEntCell, AssociationItemViewModel>();

                set.Bind(btnDeleteAssociation).To(vm => vm.DeleteAssociationCommand).CommandParameter(this.Index);

                set.Apply();
            });
        }

        public string AssociatedEnt { get { return lblAssociatedName.Text; } set { lblAssociatedName.Text = value; } }

        public int AssociatedUserID { get; set; }

        public int Index { get; set; }

    }
}