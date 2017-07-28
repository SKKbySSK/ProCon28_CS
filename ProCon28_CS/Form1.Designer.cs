namespace ProCon28_CS
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.deviceN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.beginB = new System.Windows.Forms.Button();
            this.finishB = new System.Windows.Forms.Button();
            this.pauseB = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contoursMode = new System.Windows.Forms.ComboBox();
            this.contoursMaxVal = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cornerBlockSize = new System.Windows.Forms.TrackBar();
            this.cornerQuality = new System.Windows.Forms.TrackBar();
            this.cornerUseHarris = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cornerThresh = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deviceN)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contoursMaxVal)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cornerBlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cornerQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cornerThresh)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceN
            // 
            this.deviceN.Location = new System.Drawing.Point(22, 42);
            this.deviceN.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.deviceN.Name = "deviceN";
            this.deviceN.Size = new System.Drawing.Size(220, 28);
            this.deviceN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "デバイス番号";
            // 
            // beginB
            // 
            this.beginB.Location = new System.Drawing.Point(22, 86);
            this.beginB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.beginB.Name = "beginB";
            this.beginB.Size = new System.Drawing.Size(138, 40);
            this.beginB.TabIndex = 2;
            this.beginB.Text = "開始";
            this.beginB.UseVisualStyleBackColor = true;
            this.beginB.Click += new System.EventHandler(this.beginB_Click);
            // 
            // finishB
            // 
            this.finishB.Location = new System.Drawing.Point(171, 86);
            this.finishB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.finishB.Name = "finishB";
            this.finishB.Size = new System.Drawing.Size(138, 40);
            this.finishB.TabIndex = 3;
            this.finishB.Text = "終了";
            this.finishB.UseVisualStyleBackColor = true;
            this.finishB.Click += new System.EventHandler(this.finishB_Click);
            // 
            // pauseB
            // 
            this.pauseB.Location = new System.Drawing.Point(22, 136);
            this.pauseB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pauseB.Name = "pauseB";
            this.pauseB.Size = new System.Drawing.Size(138, 40);
            this.pauseB.TabIndex = 4;
            this.pauseB.Text = "一時停止";
            this.pauseB.UseVisualStyleBackColor = true;
            this.pauseB.Click += new System.EventHandler(this.pauseB_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 187);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 422);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.contoursMode);
            this.tabPage1.Controls.Add(this.contoursMaxVal);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Size = new System.Drawing.Size(870, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contours";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // contoursMode
            // 
            this.contoursMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contoursMode.FormattingEnabled = true;
            this.contoursMode.Items.AddRange(new object[] {
            "Gray",
            "Binary",
            "Contours"});
            this.contoursMode.Location = new System.Drawing.Point(11, 231);
            this.contoursMode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.contoursMode.Name = "contoursMode";
            this.contoursMode.Size = new System.Drawing.Size(219, 29);
            this.contoursMode.TabIndex = 4;
            this.contoursMode.SelectedIndexChanged += new System.EventHandler(this.contoursMode_SelectedIndexChanged);
            // 
            // contoursMaxVal
            // 
            this.contoursMaxVal.Location = new System.Drawing.Point(11, 142);
            this.contoursMaxVal.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.contoursMaxVal.Maximum = 255;
            this.contoursMaxVal.Name = "contoursMaxVal";
            this.contoursMaxVal.Size = new System.Drawing.Size(842, 80);
            this.contoursMaxVal.TabIndex = 3;
            this.contoursMaxVal.Value = 255;
            this.contoursMaxVal.Scroll += new System.EventHandler(this.contoursMaxVal_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "maxVal";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cornerThresh);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cornerBlockSize);
            this.tabPage2.Controls.Add(this.cornerQuality);
            this.tabPage2.Controls.Add(this.cornerUseHarris);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Corner";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "BlockSize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quality";
            // 
            // cornerBlockSize
            // 
            this.cornerBlockSize.Location = new System.Drawing.Point(10, 165);
            this.cornerBlockSize.Maximum = 100;
            this.cornerBlockSize.Minimum = 1;
            this.cornerBlockSize.Name = "cornerBlockSize";
            this.cornerBlockSize.Size = new System.Drawing.Size(854, 80);
            this.cornerBlockSize.TabIndex = 2;
            this.cornerBlockSize.Value = 1;
            this.cornerBlockSize.Scroll += new System.EventHandler(this.cornerBlockSize_Scroll);
            // 
            // cornerQuality
            // 
            this.cornerQuality.Location = new System.Drawing.Point(6, 58);
            this.cornerQuality.Maximum = 1000;
            this.cornerQuality.Minimum = 1;
            this.cornerQuality.Name = "cornerQuality";
            this.cornerQuality.Size = new System.Drawing.Size(858, 80);
            this.cornerQuality.TabIndex = 1;
            this.cornerQuality.Value = 1;
            this.cornerQuality.Scroll += new System.EventHandler(this.cornerQuality_Scroll);
            // 
            // cornerUseHarris
            // 
            this.cornerUseHarris.AutoSize = true;
            this.cornerUseHarris.Checked = true;
            this.cornerUseHarris.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cornerUseHarris.Location = new System.Drawing.Point(6, 6);
            this.cornerUseHarris.Name = "cornerUseHarris";
            this.cornerUseHarris.Size = new System.Drawing.Size(121, 25);
            this.cornerUseHarris.TabIndex = 0;
            this.cornerUseHarris.Text = "UseHarris";
            this.cornerUseHarris.UseVisualStyleBackColor = true;
            this.cornerUseHarris.CheckedChanged += new System.EventHandler(this.cornerUseHarris_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cornerThresh
            // 
            this.cornerThresh.Location = new System.Drawing.Point(9, 275);
            this.cornerThresh.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cornerThresh.Maximum = 255;
            this.cornerThresh.Name = "cornerThresh";
            this.cornerThresh.Size = new System.Drawing.Size(842, 80);
            this.cornerThresh.TabIndex = 6;
            this.cornerThresh.Scroll += new System.EventHandler(this.cornerThresh_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "thresh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pauseB);
            this.Controls.Add(this.finishB);
            this.Controls.Add(this.beginB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deviceN);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.deviceN)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contoursMaxVal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cornerBlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cornerQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cornerThresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown deviceN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button beginB;
        private System.Windows.Forms.Button finishB;
        private System.Windows.Forms.Button pauseB;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TrackBar contoursMaxVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox contoursMode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar cornerBlockSize;
        private System.Windows.Forms.TrackBar cornerQuality;
        private System.Windows.Forms.CheckBox cornerUseHarris;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar cornerThresh;
        private System.Windows.Forms.Label label2;
    }
}

