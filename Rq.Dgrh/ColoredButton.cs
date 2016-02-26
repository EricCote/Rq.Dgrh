using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rq.Dgrh
{
    public class ColoredButton : Button
    {
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Random rnd = new Random();
            this.BackColor = System.Drawing.Color.FromArgb(rnd.Next(256), 
                                                           rnd.Next(256), 
                                                           rnd.Next(256));
        }

    }
}
