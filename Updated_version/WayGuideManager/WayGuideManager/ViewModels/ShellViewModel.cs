using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayGuideManager.Helpers;
using WayGuideManager.Views;

namespace WayGuideManager.ViewModels
{
     class ShellViewModel : ViewModelBase
    {

        /// <summary>
        /// The region manager
        /// </summary>
        private readonly IRegionManager regionManager;

        /// <summary>
        /// The event aggregator
        /// </summary>
        private readonly IEventAggregator eventAggregator;

        /// <summary>
        /// Gets or sets the ShellLoadedCommand
        /// </summary>
        public DelegateCommand ShellLoadedCommand { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellViewModel"/> class.
        /// </summary>
        /// <param name="regionManagerr">The region manager.</param>
        /// <param name="eventAggregator">The event aggregator.</param>
        /// <param name="globalProperties">The global properties.</param>
        public ShellViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            this.regionManager = regionManager;
            this.eventAggregator = eventAggregator;
            this.ShellLoadedCommand = new DelegateCommand(() =>
            {
                this.regionManager.RequestNavigate(RegionNames.MainAppRegion, ViewKeys.PasswordView);

            });

        }
    }
}
