using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagnPcb.Styles
{
    public class CustomMenuRender : ToolStripProfessionalRenderer
    {
        public CustomMenuRender() : base(new CustomColorTable()) { }
    }

    public class CustomColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.MediumAquamarine;
        public override Color MenuItemBorder => Color.DarkSlateBlue;
        public override Color MenuItemSelectedGradientBegin => Color.MediumAquamarine;
        public override Color MenuItemSelectedGradientEnd => Color.MediumAquamarine;
        public override Color MenuItemPressedGradientBegin => Color.Indigo;
        public override Color MenuItemPressedGradientEnd => Color.Indigo;
    }
}
