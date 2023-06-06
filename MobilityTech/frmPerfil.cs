using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilityTech
{
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
            formatoPerfil();
            
            

        }

        public void formatoPerfil()
        {
            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0, 0, pcbPerfil.Width, pcbPerfil.Height);
            Region rg = new Region(obj);
            pcbPerfil.Region = rg;
        }
    }
}
