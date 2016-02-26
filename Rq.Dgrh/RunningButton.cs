using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rq.Dgrh
{
    public class RunningButton : Button
    {
        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            Random rnd = new Random();

            this.Left = rnd.Next(this.Parent.ClientSize.Width- this.Size.Width);
            this.Top = rnd.Next(this.Parent.ClientSize.Height - this.Size.Height);
        }

    }
}
