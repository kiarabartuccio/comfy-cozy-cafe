using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comfy_Cozy_Cafe
{
    public partial class StartUp : Form
    {
        private float originalButtonX;
        private float originalButtonY;
        private float originalButtonWidth;
        private float originalButtonHeight;
        private float originalFormWidth;
        private float originalFormHeight;
        private float originalButtonFontSize;

        public StartUp()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.StartUp_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#3C1E02");
            StartButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#EBBA80");
            FirstMenu menu = new FirstMenu();
            menu.Show();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            originalFormWidth = this.Width;
            originalFormHeight = this.Height;
            originalButtonX = StartButton.Left;
            originalButtonY = StartButton.Top;
            originalButtonWidth = StartButton.Width;
            originalButtonHeight = StartButton.Height;
            originalButtonFontSize = StartButton.Font.Size;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (originalFormWidth == 0 || originalFormHeight == 0)
                return;

            float xRatio = (float)this.Width / originalFormWidth;
            float yRatio = (float)this.Height / originalFormHeight;

            StartButton.Left = (int)(originalButtonX * xRatio);
            StartButton.Top = (int)(originalButtonY * yRatio);
            StartButton.Width = (int)(originalButtonWidth * xRatio);
            StartButton.Height = (int)(originalButtonHeight * yRatio);

            float fontScale = (xRatio + yRatio) / 2f;
            float newFontSize = originalButtonFontSize * fontScale;

            if (newFontSize < 6) newFontSize = 6;
            StartButton.Font = new Font(StartButton.Font.FontFamily, newFontSize, StartButton.Font.Style);
        }

    }
}
