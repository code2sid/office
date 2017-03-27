using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatePresentation.Factories
{
    public class PresentationController
    {
       IPresentation presentation;
       DataSet ds = null;

        public PresentationController()
        {
            ds.ReadXml(System.IO.Path.GetFullPath("SchedulerSettings.xml"));
        }

       internal List<IPresentation> CheckScheduler()
        {
            var presentations = new List<IPresentation>();
            DataRow[] drs = ds.Tables[0].Select(string.Format("{0} between starttime and endtime and {1} in (days) and {2} between start and end"
                                               , DateTime.Now.ToString("HH:mm:ss tt")
                                               , DateTime.Today.DayOfWeek.ToString()
                                               , DateTime.Today.Date.ToString()));
            if (drs.Count() > 0)
            {
                foreach (var item in drs)
                {
                    switch (item["Name"].ToString())
                    {
                        case "Birthday": { presentation = new BirthdayPresentation { Name = drs[0]["Name"].ToString() }; break; }
                        case "Induction": { break; }
                        case "TechTed": { break; }
                        default:
                            break;
                    }
                    presentations.Add(presentation);
                }
            }


            return presentations;
        }
    }
}
