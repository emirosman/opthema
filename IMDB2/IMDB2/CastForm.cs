using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB2
{
    public partial class CastForm : Form
    {
        public CastForm()
        {
            InitializeComponent();
        }
        internal Cast cast = new Cast();

        private void CastForm_Load(object sender, EventArgs e)
        {
            CastNameLabel.Text = cast.name;
            castBioLabel.Text = cast.bio+"\n\nBorn:"+cast.born;//born olmayabilir kontrol ekle
        }
    }
}
