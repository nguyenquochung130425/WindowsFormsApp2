using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFont();
            LoadSize();
        }

        private void LoadFont()
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cbFont.Items.Add(font.Name);
            }
            cbFont.SelectedItem = "Tahoma"; 
        }

        private void LoadSize()
        {
            for (int i = 8; i <= 72; i += 2)
            {
                cbSize.Items.Add(i);
            }
            cbSize.SelectedItem = 14; 
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void ChangeFontStyle()
        {
            if (cbFont.SelectedItem == null || cbSize.SelectedItem == null) return;

            string fontName = cbFont.SelectedItem.ToString();
            float fontSize = float.Parse(cbSize.SelectedItem.ToString());

            FontStyle style = FontStyle.Regular;

            if (btnBold.Font.Bold) style |= FontStyle.Bold;
            if (btnItalic.Font.Italic) style |= FontStyle.Italic;
            if (btnUnderline.Font.Underline) style |= FontStyle.Underline;

            rtbEditor.SelectionFont = new Font(fontName, fontSize, style);
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            btnBold.Font = new Font(btnBold.Font, btnBold.Font.Bold ? FontStyle.Regular : FontStyle.Bold);
            ChangeFontStyle();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            btnItalic.Font = new Font(btnItalic.Font, btnItalic.Font.Italic ? FontStyle.Regular : FontStyle.Italic);
            ChangeFontStyle();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            btnUnderline.Font = new Font(btnUnderline.Font, btnUnderline.Font.Underline ? FontStyle.Regular : FontStyle.Underline);
            ChangeFontStyle();
        }

        
        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
