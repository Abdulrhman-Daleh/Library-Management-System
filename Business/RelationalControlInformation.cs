using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RelationalControlInformation
    {
        public string PageTitle { get; set; }
        public string Title { get; set; }
        public List<string> Lines { get; set; } = new List<string>();
        public List<string> LinesLabels { get; set; } = new List<string>();
        public List<Image> LinesImages { get; set; } = new List<Image>();
        public Action OnClick { get; set; }

        public RelationalControlInformation(string pageTitle, string title, List<string> lines, List<string> linesLables,
            List<Image>linesImages, Action onClick)
        {
            PageTitle = pageTitle;
            Title = title;
            Lines = lines;
            LinesLabels = linesLables;
            LinesImages = linesImages;
            OnClick = onClick;
        }


        public RelationalControlInformation()
        {
            PageTitle = "Unkown";
            Title = "[????]";
            Lines.AddRange(new List<string>() { "[????}", "[????}", "[????}", "[????]" });
            LinesLabels = null;
            LinesImages = null;
            OnClick = null;
        }

    }
}
