using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace COE_Presentations
{
    public partial class SchedulerDesigner : Form
    {
        readonly public DataSet ds = new DataSet();
        readonly string timeFormat = "hh:mm:ss tt";

        public SchedulerDesigner()
        {
            InitializeComponent();
        }

        private void SchedulerDesigner_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            ddlCategory.Items.Clear();
            ds.Clear();
            ds.ReadXml(ConfigurationSettings.AppSettings["configurationfilePath"].ToString());
            ddlCategory.Items.Add("--Select Category--");
            foreach (DataRow dr in ds.Tables[0].Rows)
                ddlCategory.Items.Add(dr["Name"].ToString());
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text.Equals("Submit Schedule"))
            {
                XmlDocument xmlSchedule = new XmlDocument();
                xmlSchedule.Load(ConfigurationSettings.AppSettings["configurationfilePath"].ToString());
                XmlElement ParentElement = xmlSchedule.CreateElement("Schedule");
                XmlElement Name = xmlSchedule.CreateElement("Name"); Name.InnerText = txtCategory.Text;
                XmlElement Start = xmlSchedule.CreateElement("Start"); Start.InnerText = dtStart.Text;
                XmlElement Expire = xmlSchedule.CreateElement("Expire"); Expire.InnerText = dtExpire.Text;
                XmlElement Days = xmlSchedule.CreateElement("Days"); Days.InnerText = GetWeeks();
                XmlElement StartTime = xmlSchedule.CreateElement("StartTime"); StartTime.InnerText = timeStart.Value.ToString(timeFormat);
                XmlElement EndTime = xmlSchedule.CreateElement("EndTime"); EndTime.InnerText = timeEnd.Value.ToString(timeFormat);
                XmlElement TemplateFile = xmlSchedule.CreateElement("TemplateFile"); TemplateFile.InnerText = txtTemplateFile.Text;
                ParentElement.AppendChild(Name);
                ParentElement.AppendChild(Start);
                ParentElement.AppendChild(Expire);
                ParentElement.AppendChild(Days);
                ParentElement.AppendChild(StartTime);
                ParentElement.AppendChild(EndTime);
                ParentElement.AppendChild(TemplateFile);
                xmlSchedule.DocumentElement.AppendChild(ParentElement);
                xmlSchedule.Save(ConfigurationSettings.AppSettings["configurationfilePath"].ToString());
            }
            else
            {
                DataSet ds = new DataSet();
                ds.ReadXml(ConfigurationSettings.AppSettings["configurationfilePath"].ToString());
                int xmlRow = ddlCategory.SelectedIndex - 1;
                ds.Tables[0].Rows[xmlRow]["Name"] = txtCategory.Text;
                ds.Tables[0].Rows[xmlRow]["Start"] = dtStart.Text;
                ds.Tables[0].Rows[xmlRow]["Expire"] = dtExpire.Text;
                ds.Tables[0].Rows[xmlRow]["Days"] = GetWeeks();
                ds.Tables[0].Rows[xmlRow]["StartTime"] = timeStart.Value.ToString(timeFormat);
                ds.Tables[0].Rows[xmlRow]["EndTime"] = timeEnd.Value.ToString(timeFormat);
                ds.Tables[0].Rows[xmlRow]["TemplateFile"] = txtTemplateFile.Text;
                ds.WriteXml(ConfigurationSettings.AppSettings["configurationfilePath"].ToString());
            }
            LoadCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void SelectAllCheckBoxes(bool CheckThem)
        {
            for (int i = 0; i <= (chkdays.Items.Count - 1); i++)
            {
                if (CheckThem)
                {
                    chkdays.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    chkdays.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        public void FillWeeks(string value)
        {
            var days = value.Split(',');
            foreach (var item in days)
                chkdays.SetItemCheckState(int.Parse(item) - 1, CheckState.Checked);
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
            return value.Substring(1);
        }

        private void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow dr = null;
            if (!string.IsNullOrWhiteSpace(ddlCategory.SelectedItem.ToString()))
            {
                dr = ds.Tables[0].Select(string.Format("Name='{0}'", ddlCategory.SelectedItem.ToString())).FirstOrDefault();
                if (dr != null)
                {
                    FillWeeks(dr["Days"].ToString());
                    dtStart.Text = dr["Start"].ToString();
                    dtExpire.Text = dr["Expire"].ToString();
                    txtCategory.Text = dr["Name"].ToString();
                    timeStart.Text = dr["StartTime"].ToString();
                    timeEnd.Text = dr["EndTime"].ToString();
                    txtTemplateFile.Text = dr["TemplateFile"].ToString();

                    btnSubmit.Text = "Edit Schedule";

                }

                else if (ddlCategory.SelectedItem.ToString().Contains("Select Category"))
                {
                    btnSubmit.Text = "Submit Schedule";
                    SelectAllCheckBoxes(false);
                    dtStart.Text = DateTime.Today.ToString("M/dd/yyyy");
                    dtExpire.Text = DateTime.Today.ToString("M/dd/yyyy");
                    txtCategory.Text = string.Empty;
                    timeStart.Text = string.Empty;
                    timeEnd.Text = string.Empty;
                    txtTemplateFile.Text = string.Empty;
                }
            }



        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
                txtTemplateFile.Text = openFile.FileName;
        }



    }
}
