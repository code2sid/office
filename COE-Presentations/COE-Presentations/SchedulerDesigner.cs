using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace COE_Presentations
{
    public partial class SchedulerDesigner : Form
    {
        public SchedulerDesigner()
        {
            InitializeComponent();
        }

        private void SchedulerDesigner_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(System.IO.Path.GetFullPath("SchedulerSettings.xml"));
            ddlCategory.DataSource = ds.Tables[0];
            ddlCategory.DisplayMember = "Name";
            ddlCategory.ValueMember = "Name";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            XmlDocument xmlSchedule = new XmlDocument();
            xmlSchedule.Load(System.IO.Path.GetFullPath("SchedulerSettings.xml"));
            XmlElement ParentElement = xmlSchedule.CreateElement("Schedule");
            XmlElement Name = xmlSchedule.CreateElement("Name");
            Name.InnerText = txtCategory.Text;
            XmlElement Start = xmlSchedule.CreateElement("Start");
            Start.InnerText = dtStart.Text;
            XmlElement Expire = xmlSchedule.CreateElement("Expire");
            Expire.InnerText = dtExpire.Text;
            XmlElement Days = xmlSchedule.CreateElement("Days");
            Days.InnerText = GetWeeks();
            ParentElement.AppendChild(Name);
            ParentElement.AppendChild(Start);
            ParentElement.AppendChild(Expire);
            ParentElement.AppendChild(Days);
            xmlSchedule.DocumentElement.AppendChild(ParentElement);
            xmlSchedule.Save(System.IO.Path.GetFullPath("SchedulerSettings.xml"));

            LoadData();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

        }

        public void FillWeeks(string value)
        {
            var days = value.Split(',');
            foreach (var item in days)
            {
                switch (int.Parse(item))
                {
                    case 1: { chkdays.SelectedItem = "Monday"; break; }
                    case 2: { chkdays.SelectedItem = "Tuesday"; break; }
                    case 3: { chkdays.SelectedItem = "Wednesday"; break; }
                    case 4: { chkdays.SelectedItem = "Thursday"; break; }
                    case 5: { chkdays.SelectedItem = "Friday"; break; }
                    case 6: { chkdays.SelectedItem = "Saturday"; break; }
                    case 7: { chkdays.SelectedItem = "Sunday"; break; }
                    default:
                        break;
                }
            }
        }

        public string GetWeeks()
        {
            string value = string.Empty;
            foreach (var item in chkdays.CheckedItems)
            {
                switch (item.ToString())
                {
                    case "Monday": { value += ",1"; break; }
                    case "Tuesday": { value += ",2"; break; }
                    case "Wednesday": { value += ",3"; break; }
                    case "Thursday": { value += ",4"; break; }
                    case "Friday": { value += ",5"; break; }
                    case "Saturday": { value += ",6"; break; }
                    case "Sunday": { value += ",7"; break; }
                    default:
                        break;
                }
            }
            return value;
        }

        private void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

    }
}
