using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSRedux
{
    public partial class formAddRSS: Form
    {
        public formAddRSS()
        {
            InitializeComponent();
        }

        private void rssFeedPopUp1_cancelBtnEvent(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddRss_Click(object sender, EventArgs e)
        {
            if (tbRssName.Text.Trim().Equals(""))
            {
                lbWarning.Text = "name\nrequired";
            }
            if (tbRssAddress.Text.Trim().Equals(""))
            {
                lbWarning.Text = "address\nrequired";
            }
            if (!tbRssName.Text.Trim().Equals("") && !tbRssAddress.Text.Trim().Equals(""))
            {
                String SOMETHING_address = tbRssAddress.Text;
                String SOMETHING_name = tbRssName.Text;
                Close();
            }
        }
    }
}
