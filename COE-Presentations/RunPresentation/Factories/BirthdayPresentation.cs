using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatePresentation.Factories
{
    class BirthdayPresentation : IPresentations
    {
        public void OpenPresentation()
        {
            System.Diagnostics.Process.Start(MPConfigurations.Default.birthday);
        }

        public void GetData()
        {
        }
    }
}
