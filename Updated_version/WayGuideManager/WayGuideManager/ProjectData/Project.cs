using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayGuideManager.Helpers;

namespace WayGuideManager.ProjectData
{
    sealed class Project:ModelBase
    {
        static readonly Project CurrentProj = GetInstanceofProj();

        private static Project GetInstanceofProj()
        {
                return CurrentProj;
        }

        static Project()
        {
            CurrentProj = new Project();
        }

        public const string loginPassword = "Accord";

    }
}
