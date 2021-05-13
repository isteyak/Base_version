using Prism;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayGuideManager.Helpers
{
    class ViewModelBase : ModelBase, IRegionMemberLifetime, INavigationAware, IActiveAware
    {
        public virtual bool KeepAlive
        {
            get { return false; }
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                SetValue(ref _isActive, value);
                RaiseIsActiveChanged();
            }
        }

        protected virtual void RaiseIsActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler IsActiveChanged;

        private bool _isBusy;

        public bool IsBusy
        {
            get { return this._isBusy; }
            set { this.SetValue(ref _isBusy, value); }
        }



        /// <summary>
        /// If this returns true, then existing view will be opened if exists in the region.
        /// Otherwise a new view will be added everytime.
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <returns></returns>
        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        /// <summary>
        /// The OnNavigatedFrom
        /// </summary>
        /// <param name="navigationContext">The navigationContext<see cref="NavigationContext"/></param>
        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        /// <summary>
        /// The OnNavigatedTo
        /// </summary>
        /// <param name="navigationContext">The navigationContext<see cref="NavigationContext"/></param>
        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
        }
    }

}
