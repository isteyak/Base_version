using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayGuideManager.Helpers;
using WayGuideManager.ProjectData;
using WayGuideManager.UtilityHelpers;
using WayGuideManager.Views;

namespace WayGuideManager.ViewModels
{
    class PasswordViewModel:ViewModelBase
    {
        public DelegateCommand okBtnClickCommand { get; set; }
        public DelegateCommand CancelBtnCLickCommand { get; set; }

        public DelegateCommand enterPressCommand { get; set; }
        /// <summary>
        /// The region manager
        /// </summary>
        private readonly IRegionManager regionManager;

        /// <summary>
        /// The event aggregator
        /// </summary>
        private readonly IEventAggregator eventAggregator;
        public PasswordViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            this.regionManager = regionManager;
            this.eventAggregator = eventAggregator;
            okBtnClickCommand = new DelegateCommand(OkBtnClick);
            CancelBtnCLickCommand = new DelegateCommand(onCancelClick);
            enterPressCommand = new DelegateCommand(OnEnterClicked);
        }

        private void OnEnterClicked()
        {
            try
            {
                OkBtnClick();
            }
            catch(Exception Ex)
            {

            }
        }

        private string _passWord;

        public string PassWord
        {
            get { return _passWord; }
            set
            {
                this.SetValue(ref _passWord, value);
            }
        }

        private string _invalidPassword;

        public string InvalidPassword
        {
            get { return _invalidPassword; }
            set {
                this.SetValue(ref _invalidPassword, value);
            }
        }

        private void onCancelClick()
        {
            try
            {
                InvalidPassword = "";
                PassWord = string.Empty;
            }
            catch (Exception Ex)
            {

            }
        }

        private void OkBtnClick()
        {
            try
            {
                if(PassWord == Project.loginPassword)
                {
                    this.regionManager.RequestNavigate(RegionNames.MainAppRegion, ViewKeys.WayGuideManagerHome);
                }
                else
                {
                    InvalidPassword = "Invalid Password Please check the password and retry";
                }
            }
            catch (Exception Ex)
            {

            }
        }


    }
}
