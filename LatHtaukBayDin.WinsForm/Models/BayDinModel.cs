using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatHtaukBayDin.WinsForm.Models
{
    public class PageProps
    {
        public List<Question> questions { get; set; }
    }

    public class Question
    {
        public int qId { get; set; }
        public string quest { get; set; }
        public int catId { get; set; }
        public int count { get; set; }
        public string ans { get; set; }
    }

    public class BayDinModel
    {
        public PageProps pageProps { get; set; }
        public bool __N_SSG { get; set; }
    }
}
