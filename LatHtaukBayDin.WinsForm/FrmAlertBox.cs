using LatHtaukBayDin.WinsForm.Models;
using LatHtaukBayDin.WinsForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatHtaukBayDin.WinsForm
{
    public partial class FrmAlertBox : Form
    {
        private readonly int _questionId;
        public FrmAlertBox(int questionId, string questionName)
        {
            InitializeComponent();
            _questionId = questionId;
            lblTitle.Text = questionName;
        }

        private async void btnAsk_Click(object sender, EventArgs e)
        {
            try
            {
                Question item = await new BayDinApiService().AnswerAsync(_questionId);
                lblAnswer.Text = item.ans;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
