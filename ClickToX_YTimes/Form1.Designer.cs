
namespace ClickToX_YTimes
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextCoordinateX = new System.Windows.Forms.TextBox();
            this.TextCoordinateY = new System.Windows.Forms.TextBox();
            this.TextWaitingTime = new System.Windows.Forms.TextBox();
            this.TextClickAmount = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.CoordinateList = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboPlayPause = new System.Windows.Forms.ComboBox();
            this.ComboStartStop = new System.Windows.Forms.ComboBox();
            this.TimerClick = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.LabelDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coordinate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(175, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(265, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Waiting Time (ms)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Click Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Save - Delete Coordinate";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextCoordinateX
            // 
            this.TextCoordinateX.Location = new System.Drawing.Point(200, 10);
            this.TextCoordinateX.Margin = new System.Windows.Forms.Padding(0);
            this.TextCoordinateX.Name = "TextCoordinateX";
            this.TextCoordinateX.Size = new System.Drawing.Size(60, 29);
            this.TextCoordinateX.TabIndex = 6;
            this.TextCoordinateX.Text = "0";
            this.TextCoordinateX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextCoordinateX.TextChanged += new System.EventHandler(this.TextCoordinateX_TextChanged);
            // 
            // TextCoordinateY
            // 
            this.TextCoordinateY.Location = new System.Drawing.Point(295, 10);
            this.TextCoordinateY.Margin = new System.Windows.Forms.Padding(0);
            this.TextCoordinateY.Name = "TextCoordinateY";
            this.TextCoordinateY.Size = new System.Drawing.Size(60, 29);
            this.TextCoordinateY.TabIndex = 7;
            this.TextCoordinateY.Text = "0";
            this.TextCoordinateY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextCoordinateY.TextChanged += new System.EventHandler(this.TextCoordinateY_TextChanged);
            // 
            // TextWaitingTime
            // 
            this.TextWaitingTime.Location = new System.Drawing.Point(220, 40);
            this.TextWaitingTime.Margin = new System.Windows.Forms.Padding(0);
            this.TextWaitingTime.Name = "TextWaitingTime";
            this.TextWaitingTime.Size = new System.Drawing.Size(100, 29);
            this.TextWaitingTime.TabIndex = 8;
            this.TextWaitingTime.Text = "5000";
            this.TextWaitingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextWaitingTime.TextChanged += new System.EventHandler(this.TextWaitingTime_TextChanged);
            // 
            // TextClickAmount
            // 
            this.TextClickAmount.Location = new System.Drawing.Point(220, 70);
            this.TextClickAmount.Margin = new System.Windows.Forms.Padding(0);
            this.TextClickAmount.Name = "TextClickAmount";
            this.TextClickAmount.Size = new System.Drawing.Size(100, 29);
            this.TextClickAmount.TabIndex = 9;
            this.TextClickAmount.Text = "1";
            this.TextClickAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextClickAmount.TextChanged += new System.EventHandler(this.TextClickAmount_TextChanged);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(50, 200);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 35);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "SAVE";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(200, 200);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(100, 35);
            this.ButtonDelete.TabIndex = 11;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // CoordinateList
            // 
            this.CoordinateList.CheckBoxes = true;
            this.CoordinateList.FullRowSelect = true;
            this.CoordinateList.GridLines = true;
            this.CoordinateList.HideSelection = false;
            this.CoordinateList.Location = new System.Drawing.Point(10, 240);
            this.CoordinateList.Margin = new System.Windows.Forms.Padding(0);
            this.CoordinateList.Name = "CoordinateList";
            this.CoordinateList.Size = new System.Drawing.Size(345, 195);
            this.CoordinateList.TabIndex = 13;
            this.CoordinateList.UseCompatibleStateImageBehavior = false;
            this.CoordinateList.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Start-Stop Key";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Play-Pause Key";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboPlayPause
            // 
            this.ComboPlayPause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPlayPause.FormattingEnabled = true;
            this.ComboPlayPause.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10"});
            this.ComboPlayPause.Location = new System.Drawing.Point(220, 140);
            this.ComboPlayPause.Margin = new System.Windows.Forms.Padding(0);
            this.ComboPlayPause.Name = "ComboPlayPause";
            this.ComboPlayPause.Size = new System.Drawing.Size(100, 32);
            this.ComboPlayPause.TabIndex = 17;
            this.ComboPlayPause.SelectedIndexChanged += new System.EventHandler(this.ComboPlayPause_SelectedIndexChanged);
            // 
            // ComboStartStop
            // 
            this.ComboStartStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboStartStop.FormattingEnabled = true;
            this.ComboStartStop.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10"});
            this.ComboStartStop.Location = new System.Drawing.Point(220, 105);
            this.ComboStartStop.Margin = new System.Windows.Forms.Padding(0);
            this.ComboStartStop.Name = "ComboStartStop";
            this.ComboStartStop.Size = new System.Drawing.Size(100, 32);
            this.ComboStartStop.TabIndex = 18;
            this.ComboStartStop.SelectedIndexChanged += new System.EventHandler(this.ComboStartStop_SelectedIndexChanged);
            // 
            // TimerClick
            // 
            this.TimerClick.Tick += new System.EventHandler(this.TimerClick_Tick);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 440);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Learn Coordinate with C";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(110, 470);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 35);
            this.ButtonStart.TabIndex = 20;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelDurum
            // 
            this.LabelDurum.ForeColor = System.Drawing.Color.Red;
            this.LabelDurum.Location = new System.Drawing.Point(220, 475);
            this.LabelDurum.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDurum.Name = "LabelDurum";
            this.LabelDurum.Size = new System.Drawing.Size(100, 25);
            this.LabelDurum.TabIndex = 21;
            this.LabelDurum.Text = "Stop";
            this.LabelDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 511);
            this.Controls.Add(this.LabelDurum);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ComboStartStop);
            this.Controls.Add(this.ComboPlayPause);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CoordinateList);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextClickAmount);
            this.Controls.Add(this.TextWaitingTime);
            this.Controls.Add(this.TextCoordinateY);
            this.Controls.Add(this.TextCoordinateX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Click To X";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextCoordinateX;
        private System.Windows.Forms.TextBox TextCoordinateY;
        private System.Windows.Forms.TextBox TextWaitingTime;
        private System.Windows.Forms.TextBox TextClickAmount;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.ListView CoordinateList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboPlayPause;
        private System.Windows.Forms.ComboBox ComboStartStop;
        private System.Windows.Forms.Timer TimerClick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabelDurum;
    }
}

