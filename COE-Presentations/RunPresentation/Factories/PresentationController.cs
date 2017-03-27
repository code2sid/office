using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatePresentation.Factories
{
    class PresentationController
    {
        IPresentations presentationObject;

        public IPresentations CheckScheduler()
        {
            if (1 == 1)
            {
                presentationObject = new BirthdayPresentation();
            }

            return presentationObject;
        }
    }
}
