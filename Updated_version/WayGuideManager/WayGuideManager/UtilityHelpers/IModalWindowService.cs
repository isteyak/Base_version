using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayGuideManager.UtilityHelpers
{
    public interface IModalWindowService
    {
        void Close(string viewName);
        NavigationParameters GetParameters(string viewName);
        void Show(string viewName, string title = "", NavigationParameters navigationParameters = null, double width = 0, double height = 0);
    }
}
