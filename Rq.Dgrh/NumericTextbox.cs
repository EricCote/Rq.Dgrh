using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rq.Dgrh
{
    public class NumericTextbox :TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            { 
                base.OnKeyPress(e);
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                //SoundPlayer p = new SoundPlayer("doh.wav");
                //p.Play();
            }
        }
    }
}
