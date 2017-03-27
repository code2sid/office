using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatePresentation.Factories
{
    public class PresentationController
    {
        IPresentation presentation;
        DataSet ds = new DataSet();

        public PresentationController()
        {
            ds.ReadXml(ConfigurationSettings.AppSettings["configurationfilePath"].ToString());
        }

        internal List<IPresentation> CheckScheduler()
        {
            var dayNo = new Dictionary<string, int>();
            dayNo.Add("monday", 1); dayNo.Add("tuesday", 1); dayNo.Add("wednesday", 1); dayNo.Add("thursday", 1); dayNo.Add("friday", 1); dayNo.Add("saturday", 1); dayNo.Add("sunday", 1);
            var day = dayNo.Where(d => d.Key == DateTime.Today.DayOfWeek.ToString().ToLower()).FirstOrDefault();
            
            var presentations = new List<IPresentation>();
            /*DataRow[] drs = ds.Tables[0].Select(string.Format("starttime<=#{0}# and endtime>=#{0}# and days in ({1}) and start<=#{2}# and expire>=#{2}#"
                                               , DateTime.Now.ToString("HH:mm:ss tt")
                                               , day.Value
                                               , DateTime.Today.Date));*/
            //DataRow[] drs = ds.Tables[0].Select("starttime<=#05:19:38 PM# and endtime>=#05:19:38 PM# and days in ('1') and start<=#03/27/2017# and expire>=#03/27/2017#");
            DataRow[] drs = ds.Tables[0].Select("days in (1)");

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
