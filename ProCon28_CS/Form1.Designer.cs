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
            this.contoursThresh = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deviceN)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contoursMaxVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contoursThresh)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceN
            // 
            this.deviceN.Location = new System.Drawing.Point(12, 24);
            this.deviceN.Name = "deviceN";
            this.deviceN.Size = new System.Drawing.Size(120, 19);
            this.deviceN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "デバイス番号";
            // 
            // beginB
            // 
            this.beginB.Location = new System.Drawing.Point(12, 49);
            this.beginB.Name = "beginB";
            this.beginB.Size = new System.Drawing.Size(75, 23);
            this.beginB.TabIndex = 2;
            this.beginB.Text = "開始";
            this.beginB.UseVisualStyleBackColor = true;
            this.beginB.Click += new System.EventHandler(this.beginB_Click);
            // 
            // finishB
            // 
            this.finishB.Location = new System.Drawing.Point(93, 49);
            this.finishB.Name = "finishB";
            this.finishB.Size = new System.Drawing.Size(75, 23);
            this.finishB.TabIndex = 3;
            this.finishB.Text = "終了";
            this.finishB.UseVisualStyleBackColor = true;
            this.finishB.Click += new System.EventHandler(this.finishB_Click);
            // 
            // pauseB
            // 
            this.pauseB.Location = new System.Drawing.Point(12, 78);
            this.pauseB.Name = "pauseB";
            this.pauseB.Size = new System.Drawing.Size(75, 23);
            this.pauseB.TabIndex = 4;
            this.pauseB.Text = "一時停止";
            this.pauseB.UseVisualStyleBackColor = true;
            this.pauseB.Click += new System.EventHandler(this.pauseB_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(14, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 201);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.contoursMode);
            this.tabPage1.Controls.Add(this.contoursMaxVal);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.contoursThresh);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 175);
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
            this.contoursMode.Location = new System.Drawing.Point(6, 132);
            this.contoursMode.Name = "contoursMode";
            this.contoursMode.Size = new System.Drawing.Size(121, 20);
            this.contoursMode.TabIndex = 4;
            this.contoursMode.SelectedIndexChanged += new System.EventHandler(this.contoursMode_SelectedIndexChanged);
            // 
            // contoursMaxVal
            // 
            this.contoursMaxVal.Location = new System.Drawing.Point(6, 81);
            this.contoursMaxVal.Maximum = 255;
            this.contoursMaxVal.Name = "contoursMaxVal";
            this.contoursMaxVal.Size = new System.Drawing.Size(459, 45);
            this.contoursMaxVal.TabIndex = 3;
            this.contoursMaxVal.Value = 255;
            this.contoursMaxVal.Scroll += new System.EventHandler(this.contoursMaxVal_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "maxVal";
            // 
            // contoursThresh
            // 
            this.contoursThresh.Location = new System.Drawing.Point(6, 18);
            this.contoursThresh.Maximum = 255;
            this.contoursThresh.Name = "contoursThresh";
            this.contoursThresh.Size = new System.Drawing.Size(459, 45);
            this.contoursThresh.TabIndex = 1;
            this.contoursThresh.Scroll += new System.EventHandler(this.contoursThresh_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "thresh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 320);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pauseB);
            this.Controls.Add(this.finishB);
            this.Controls.Add(this.beginB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deviceN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.deviceN)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contoursMaxVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contoursThresh)).EndInit();
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
        private System.Windows.Forms.TrackBar contoursThresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar contoursMaxVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox contoursMode;
    }
}

