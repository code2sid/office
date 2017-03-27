using ManipulatePresentation.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulatePresentation
{
    public partial class ManipulatePresentation : Form
    {
        
        public ManipulatePresentation()
        {
            InitializeComponent();
        }

        private void ManipulatePresentation_Load(object sender, EventArgs e)
        {
           
        }

        private void presenationTimer_Tick(object sender, EventArgs e)
        {
            LoadPresentations();
        }

        public void LoadPresentations()
        {
            presenationTimer.Enabled = false;
            var presentations = new PresentationController().CheckScheduler();
            foreach (var item in presentations)
            {
                item.GetData();
                item.OpenPresentation();
                
            }
            presenationTimer.Enabled = true;
        }

        
    }
}
