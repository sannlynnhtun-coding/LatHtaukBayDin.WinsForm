using LatHtaukBayDin.WinsForm.Models;
using LatHtaukBayDin.WinsForm.Services;
using System.Security.Cryptography;

namespace LatHtaukBayDin.WinsForm
{
    public partial class FrmQuestion : Form
    {
        public FrmQuestion()
        {
            InitializeComponent();
        }

        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var result = await new BayDinApiService().QuestionListAysnc();
            int count = result.pageProps.questions.Count + 1;
            foreach (var item in result.pageProps.questions.OrderByDescending(x=> x.qId))
            {
                string quest = (--count).ToString().PadLeft(2, '0') + ".  " + item.quest + Environment.NewLine;
                Button btn = new Button();

                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(156)))), ((int)(((byte)(169)))));
                btn.Dock = System.Windows.Forms.DockStyle.Top;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                //btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
                btn.ForeColor = System.Drawing.Color.WhiteSmoke;
                btn.Location = new System.Drawing.Point(0, 0);
                btn.Name = "button" + count;
                btn.Size = new System.Drawing.Size(1174, 59);
                btn.TabIndex = 0;
                btn.Text = quest;
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.UseVisualStyleBackColor = false;
                btn.Tag = item;
                btn.Click += new System.EventHandler(btn_AskClick);
                panel1.Controls.Add(btn);
            }
        }

        private async void btn_AskClick(object sender, EventArgs e)
        {
            try
            {
                Question item = (Question)((Button)sender).Tag;
                FrmAlertBox alert = new FrmAlertBox(item.qId, item.quest);
                alert.ShowDialog();
            }
            catch (Exception ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}