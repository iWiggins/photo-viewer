using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photo_viewer
{
    public partial class FormMain : Form
    {
        public FormMain(string[] args)
        {
            InitializeComponent();
            if (args.Length >= 1)
            {
                string imagePath = args[0];
                if (imagePath != null)
                {
                    if (!LoadImageFromPath(imagePath))
                    {
                        this.Close();
                    }
                }
            }
            //TODO: Load button.
        }

        private bool LoadImageFromPath(string path)
        {
            try
            {
                this.pictureBoxMain.Image = Image.FromFile(path);
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(this, e.Message, "Error loading image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
