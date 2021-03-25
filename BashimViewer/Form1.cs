using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BashimViewer
{
    public partial class Form1 : Form
    {
        private ParserLibrary parserLibrary;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            parserLibrary = new ParserLibrary();

            buttonMoveNext.Enabled = false;
            buttonMovePrev.Enabled = false;
            labelInfo.Text = "0/0";
        }

        private async void buttonLoadQuotes_Click(object sender, EventArgs e)
        {
            buttonLoadQuotes.Enabled = false;

            await parserLibrary.LoadQuotesAsync();

            buttonMoveNext.Enabled = true;
            buttonMovePrev.Enabled = true;

            richTextBoxCurrentQuote.Text = parserLibrary.GetCurrentQuote();

            labelInfo.Text = parserLibrary.NumberCurrentQuote + "/" + parserLibrary.CoountQuotes;

            buttonLoadQuotes.Enabled = true;
        }

        private void buttonMovePrev_Click(object sender, EventArgs e)
        {
            if (parserLibrary.MovePrev())
            {
                richTextBoxCurrentQuote.Text = parserLibrary.GetCurrentQuote();

                labelInfo.Text = parserLibrary.NumberCurrentQuote + "/" + parserLibrary.CoountQuotes;
            }
            else
            {
                MessageBox.Show("Soryan, citat net");
            }
        }

        private void buttonMoveNext_Click(object sender, EventArgs e)
        {
            if (parserLibrary.MoveNext())
            {
                richTextBoxCurrentQuote.Text = parserLibrary.GetCurrentQuote();

                labelInfo.Text = parserLibrary.NumberCurrentQuote + "/" + parserLibrary.CoountQuotes;
            }
            else
            {
                MessageBox.Show("Soryan, citat net");
            }
        }
    }
}
