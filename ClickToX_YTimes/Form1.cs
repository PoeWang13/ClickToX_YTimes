using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ClickToX_YTimes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            clickButton.hookedKeys.Add(Keys.C);
            clickButton.hookedKeys.Add(Keys.F1);
            clickButton.hookedKeys.Add(Keys.F2);
            clickButton.KeyDown += new KeyEventHandler(KullanilanTuslar);

            TimerClick.Interval = 5000;
            ComboStartStop.Text = "F1";
            ComboPlayPause.Text = "F2";

            CoordinateList.Columns.Add("Coordinate No");
            CoordinateList.Columns.Add("X");
            CoordinateList.Columns.Add("Y");

            CoordinateList.Columns[0].TextAlign = HorizontalAlignment.Center;
            CoordinateList.Columns[0].Width = 140;
            CoordinateList.Columns[1].TextAlign = HorizontalAlignment.Center;
            CoordinateList.Columns[2].TextAlign = HorizontalAlignment.Center;
        }
        #region Panel Degislikleri
        private int koordinat_X = 0;
        private int koordinat_Y = 0;
        private int clickAmount = 1;
        private int clickAmountNext = 0;
        private int clickRepeat = 0;
        private int clickStartStopKey = 0;
        private int clickPlayPauseKey = 1;
        private bool started = false;
        private bool played = false;
        ClickButton clickButton = new ClickButton();
        Point clickPoint = new Point();
        private void TextCoordinateX_TextChanged(object sender, EventArgs e)
        {
            if (TextCoordinateX.Text != "")
            {
                if (int.TryParse(TextCoordinateX.Text, out int deger))
                {
                    koordinat_X = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void TextCoordinateY_TextChanged(object sender, EventArgs e)
        {
            if (TextCoordinateY.Text != "")
            {
                if (int.TryParse(TextCoordinateY.Text, out int deger))
                {
                    koordinat_Y = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void TextWaitingTime_TextChanged(object sender, EventArgs e)
        {
            if (TextWaitingTime.Text != "")
            {
                if (int.TryParse(TextWaitingTime.Text, out int deger))
                {
                    TimerClick.Interval = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void TextClickAmount_TextChanged(object sender, EventArgs e)
        {
            if (TextClickAmount.Text != "")
            {
                if (int.TryParse(TextClickAmount.Text, out int deger))
                {
                    clickAmount = deger;
                }
                else
                {
                    MessageBox.Show("Lütfen rakam giriniz.");
                }
            }
        }
        private void ComboStartStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboStartStop.SelectedIndex != clickPlayPauseKey)
            {
                clickButton.hookedKeys.Remove((Keys)(clickStartStopKey + 112));
                clickStartStopKey = ComboStartStop.SelectedIndex;
                clickButton.hookedKeys.Add((Keys)(clickStartStopKey + 112));
            }
            else
            {
                ComboStartStop.Text = ((Keys)(clickStartStopKey + 112)).ToString();
                MessageBox.Show("You can't choose same F with Play-Pause.");
            }
        }
        private void ComboPlayPause_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboPlayPause.SelectedIndex != clickStartStopKey)
            {
                clickButton.hookedKeys.Remove((Keys)(clickPlayPauseKey + 112));
                clickPlayPauseKey = ComboPlayPause.SelectedIndex;
                clickButton.hookedKeys.Add((Keys)(clickPlayPauseKey + 112));

            }
            else
            {
                ComboPlayPause.Text = ((Keys)(clickPlayPauseKey + 112)).ToString();
                MessageBox.Show("You can't choose same F with Start-Stop.");
            }
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ClickStartStop();
        }
        private void TimerClick_Tick(object sender, EventArgs e)
        {
            clickPoint.X = int.Parse(CoordinateList.Items[clickRepeat].SubItems[1].Text);
            clickPoint.Y = int.Parse(CoordinateList.Items[clickRepeat].SubItems[2].Text);

            clickRepeat++;
            if (clickRepeat == CoordinateList.Items.Count)
            {
                clickRepeat = 0;
                clickAmountNext++;
            }
            clickButton.LeftDownClick(clickPoint);
            Thread.Sleep(100);
            clickButton.LeftUpClick();

            if (clickAmountNext == clickAmount)
            {
                ClickStartStop();
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string[] coordinat = { CoordinateList.Items.Count.ToString(), koordinat_X.ToString(), koordinat_Y.ToString() };
            ListViewItem viewItem = new ListViewItem(coordinat);
            CoordinateList.Items.Add(viewItem);
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            for (int c = CoordinateList.Items.Count - 1; c >= 0; c--)
            {
                if (CoordinateList.Items[c].Checked)
                {
                    CoordinateList.Items.RemoveAt(c);
                }
            }
            for (int c = 0; c < CoordinateList.Items.Count; c++)
            {
                CoordinateList.Items[c].SubItems[0].Text = c.ToString();
            }
        }
        private void ClickStartStop()
        {
            TextCoordinateX.Enabled = started;
            TextCoordinateY.Enabled = started;
            TextWaitingTime.Enabled = started;
            TextClickAmount.Enabled = started;
            ComboStartStop.Enabled = started;
            ComboPlayPause.Enabled = started;

            started = !started;
            TimerClick.Enabled = started;
            if (started)
            {
                played = true;
                clickAmountNext = 0;
                clickRepeat = 0;
                TimerClick.Start();
                LabelDurum.Text = "Play";
            }
            else
            {
                played = false;
                TimerClick.Stop();
                LabelDurum.Text = "Start";
            }
        }
        private void ClickPlayPause()
        {
            played = !played;
            TimerClick.Enabled = played;
            if (!played)
            {
                TimerClick.Stop();
                LabelDurum.Text = "Pause";
            }
            else
            {
                TimerClick.Start();
                LabelDurum.Text = "Play";
            }
        }
        #endregion

        #region Dinlenecek Tuslar
        private void KullanilanTuslar(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode == Keys.C && !started && !played)
            {
                koordinat_X = Cursor.Position.X;
                koordinat_Y = Cursor.Position.Y;

                TextCoordinateX.Text = koordinat_X.ToString();
                TextCoordinateY.Text = koordinat_Y.ToString();
            }
            else if (keyEventArgs.KeyCode == (Keys)(clickStartStopKey + 112))
            {
                ClickStartStop();
            }
            else if (keyEventArgs.KeyCode == (Keys)(clickPlayPauseKey + 112) && started)
            {
                ClickPlayPause();
            }
        }
        #endregion
    }
}
