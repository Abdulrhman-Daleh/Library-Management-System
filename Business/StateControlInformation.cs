using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Business
{
    public class StateControlInformation
    {
        public List<Image> Images { get; set; }
        public List<string> LinesLables { get; set; }
        public List<string> LinesValues { get; set; }

        public StateControlInformation()
        {
            Images = new List<Image>();
            LinesLables = new List<string>();   
            LinesValues = new List<string>();
        }

        public StateControlInformation(List<Image>images, List<string> linesLables, List<string> linesValues)
        {
            Images = images;
            LinesLables = linesLables;
            LinesValues = linesValues;
        }
    }
}
