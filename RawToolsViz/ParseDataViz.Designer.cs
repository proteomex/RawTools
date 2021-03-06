﻿namespace RawToolsViz
{
    partial class ParseDataViz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParseDataViz));
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yAxisLabel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xAxisLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.axisTypeComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exportAsComboBox = new System.Windows.Forms.ComboBox();
            this.exportHeightValue = new System.Windows.Forms.TextBox();
            this.exportWidthValue = new System.Windows.Forms.TextBox();
            this.exportHeight = new System.Windows.Forms.Label();
            this.exportWidth = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.yMaxFixedValue = new System.Windows.Forms.TextBox();
            this.yMaxFixed = new System.Windows.Forms.RadioButton();
            this.yMaxAuto = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.yMinFixedValue = new System.Windows.Forms.TextBox();
            this.yMinFixed = new System.Windows.Forms.RadioButton();
            this.yMinAuto = new System.Windows.Forms.RadioButton();
            this.yAxisMax = new System.Windows.Forms.Label();
            this.yAxisMin = new System.Windows.Forms.Label();
            this.logYScaleBase = new System.Windows.Forms.TextBox();
            this.logYScale = new System.Windows.Forms.RadioButton();
            this.linearYScale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotView1.Location = new System.Drawing.Point(3, 123);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(976, 403);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.toolTip1.SetToolTip(this.plotView1, resources.GetString("plotView1.ToolTip"));
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.plotView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 619);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.yAxisLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.xAxisLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.axisTypeComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 6, 6, 3);
            this.panel1.Size = new System.Drawing.Size(976, 114);
            this.panel1.TabIndex = 1;
            // 
            // yAxisLabel
            // 
            this.yAxisLabel.Location = new System.Drawing.Point(74, 41);
            this.yAxisLabel.Name = "yAxisLabel";
            this.yAxisLabel.Size = new System.Drawing.Size(369, 22);
            this.yAxisLabel.TabIndex = 19;
            this.yAxisLabel.TextChanged += new System.EventHandler(this.yAxisLabel_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "y-label:";
            // 
            // xAxisLabel
            // 
            this.xAxisLabel.Location = new System.Drawing.Point(74, 69);
            this.xAxisLabel.Name = "xAxisLabel";
            this.xAxisLabel.Size = new System.Drawing.Size(369, 22);
            this.xAxisLabel.TabIndex = 17;
            this.xAxisLabel.TextChanged += new System.EventHandler(this.xAxisLabel_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "x-label:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "y-axis:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "x-axis:";
            // 
            // axisTypeComboBox
            // 
            this.axisTypeComboBox.DropDownHeight = 1000;
            this.axisTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.axisTypeComboBox.FormattingEnabled = true;
            this.axisTypeComboBox.IntegralHeight = false;
            this.axisTypeComboBox.Location = new System.Drawing.Point(74, 11);
            this.axisTypeComboBox.Name = "axisTypeComboBox";
            this.axisTypeComboBox.Size = new System.Drawing.Size(369, 24);
            this.axisTypeComboBox.TabIndex = 14;
            this.axisTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.axisTypeComboBox_SelectedIndexChanged_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exportAsComboBox);
            this.panel2.Controls.Add(this.exportHeightValue);
            this.panel2.Controls.Add(this.exportWidthValue);
            this.panel2.Controls.Add(this.exportHeight);
            this.panel2.Controls.Add(this.exportWidth);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.yAxisMax);
            this.panel2.Controls.Add(this.yAxisMin);
            this.panel2.Controls.Add(this.logYScaleBase);
            this.panel2.Controls.Add(this.logYScale);
            this.panel2.Controls.Add(this.linearYScale);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 532);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 84);
            this.panel2.TabIndex = 2;
            // 
            // exportAsComboBox
            // 
            this.exportAsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exportAsComboBox.FormattingEnabled = true;
            this.exportAsComboBox.Items.AddRange(new object[] {
            "PNG",
            "SVG",
            "PDF"});
            this.exportAsComboBox.Location = new System.Drawing.Point(617, 11);
            this.exportAsComboBox.Name = "exportAsComboBox";
            this.exportAsComboBox.Size = new System.Drawing.Size(171, 24);
            this.exportAsComboBox.TabIndex = 21;
            // 
            // exportHeightValue
            // 
            this.exportHeightValue.Location = new System.Drawing.Point(736, 50);
            this.exportHeightValue.Name = "exportHeightValue";
            this.exportHeightValue.Size = new System.Drawing.Size(53, 22);
            this.exportHeightValue.TabIndex = 20;
            this.exportHeightValue.Text = "540";
            this.exportHeightValue.TextChanged += new System.EventHandler(this.exportHeightValue_TextChanged);
            // 
            // exportWidthValue
            // 
            this.exportWidthValue.Location = new System.Drawing.Point(617, 50);
            this.exportWidthValue.Name = "exportWidthValue";
            this.exportWidthValue.Size = new System.Drawing.Size(54, 22);
            this.exportWidthValue.TabIndex = 19;
            this.exportWidthValue.Text = "800";
            this.exportWidthValue.TextChanged += new System.EventHandler(this.exportWidthValue_TextChanged);
            // 
            // exportHeight
            // 
            this.exportHeight.AutoSize = true;
            this.exportHeight.Location = new System.Drawing.Point(677, 50);
            this.exportHeight.Name = "exportHeight";
            this.exportHeight.Size = new System.Drawing.Size(53, 17);
            this.exportHeight.TabIndex = 18;
            this.exportHeight.Text = "Height:";
            // 
            // exportWidth
            // 
            this.exportWidth.AutoSize = true;
            this.exportWidth.Location = new System.Drawing.Point(564, 52);
            this.exportWidth.Name = "exportWidth";
            this.exportWidth.Size = new System.Drawing.Size(48, 17);
            this.exportWidth.TabIndex = 17;
            this.exportWidth.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Export as:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.yMaxFixedValue);
            this.panel4.Controls.Add(this.yMaxFixed);
            this.panel4.Controls.Add(this.yMaxAuto);
            this.panel4.Location = new System.Drawing.Point(264, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 30);
            this.panel4.TabIndex = 11;
            // 
            // yMaxFixedValue
            // 
            this.yMaxFixedValue.Enabled = false;
            this.yMaxFixedValue.Location = new System.Drawing.Point(139, 3);
            this.yMaxFixedValue.Name = "yMaxFixedValue";
            this.yMaxFixedValue.Size = new System.Drawing.Size(100, 22);
            this.yMaxFixedValue.TabIndex = 3;
            this.yMaxFixedValue.Text = "NaN";
            this.yMaxFixedValue.TextChanged += new System.EventHandler(this.yMaxFixedValue_TextChanged);
            this.yMaxFixedValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yMaxFixedValue_KeyPress);
            this.yMaxFixedValue.Leave += new System.EventHandler(this.yMaxFixedValue_Leave);
            // 
            // yMaxFixed
            // 
            this.yMaxFixed.AutoSize = true;
            this.yMaxFixed.Location = new System.Drawing.Point(67, 3);
            this.yMaxFixed.Name = "yMaxFixed";
            this.yMaxFixed.Size = new System.Drawing.Size(66, 21);
            this.yMaxFixed.TabIndex = 1;
            this.yMaxFixed.Text = "Fixed:";
            this.yMaxFixed.UseVisualStyleBackColor = true;
            // 
            // yMaxAuto
            // 
            this.yMaxAuto.AutoSize = true;
            this.yMaxAuto.Checked = true;
            this.yMaxAuto.Location = new System.Drawing.Point(3, 3);
            this.yMaxAuto.Name = "yMaxAuto";
            this.yMaxAuto.Size = new System.Drawing.Size(58, 21);
            this.yMaxAuto.TabIndex = 0;
            this.yMaxAuto.TabStop = true;
            this.yMaxAuto.Text = "Auto";
            this.yMaxAuto.UseVisualStyleBackColor = true;
            this.yMaxAuto.CheckedChanged += new System.EventHandler(this.yMaxAuto_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.yMinFixedValue);
            this.panel3.Controls.Add(this.yMinFixed);
            this.panel3.Controls.Add(this.yMinAuto);
            this.panel3.Location = new System.Drawing.Point(264, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 30);
            this.panel3.TabIndex = 10;
            // 
            // yMinFixedValue
            // 
            this.yMinFixedValue.Enabled = false;
            this.yMinFixedValue.Location = new System.Drawing.Point(139, 3);
            this.yMinFixedValue.Name = "yMinFixedValue";
            this.yMinFixedValue.Size = new System.Drawing.Size(100, 22);
            this.yMinFixedValue.TabIndex = 2;
            this.yMinFixedValue.Text = "NaN";
            this.yMinFixedValue.TextChanged += new System.EventHandler(this.yMinFixedValue_TextChanged);
            this.yMinFixedValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yMinFixedValue_KeyPress);
            this.yMinFixedValue.Leave += new System.EventHandler(this.yMinFixedValue_Leave);
            // 
            // yMinFixed
            // 
            this.yMinFixed.AutoSize = true;
            this.yMinFixed.Location = new System.Drawing.Point(67, 3);
            this.yMinFixed.Name = "yMinFixed";
            this.yMinFixed.Size = new System.Drawing.Size(66, 21);
            this.yMinFixed.TabIndex = 1;
            this.yMinFixed.Text = "Fixed:";
            this.yMinFixed.UseVisualStyleBackColor = true;
            // 
            // yMinAuto
            // 
            this.yMinAuto.AutoSize = true;
            this.yMinAuto.Checked = true;
            this.yMinAuto.Location = new System.Drawing.Point(3, 3);
            this.yMinAuto.Name = "yMinAuto";
            this.yMinAuto.Size = new System.Drawing.Size(58, 21);
            this.yMinAuto.TabIndex = 0;
            this.yMinAuto.TabStop = true;
            this.yMinAuto.Text = "Auto";
            this.yMinAuto.UseVisualStyleBackColor = true;
            this.yMinAuto.CheckedChanged += new System.EventHandler(this.yMinAuto_CheckedChanged);
            // 
            // yAxisMax
            // 
            this.yAxisMax.AutoSize = true;
            this.yAxisMax.Location = new System.Drawing.Point(209, 13);
            this.yAxisMax.Name = "yAxisMax";
            this.yAxisMax.Size = new System.Drawing.Size(49, 17);
            this.yAxisMax.TabIndex = 9;
            this.yAxisMax.Text = "y-max:";
            // 
            // yAxisMin
            // 
            this.yAxisMin.AutoSize = true;
            this.yAxisMin.Location = new System.Drawing.Point(212, 48);
            this.yAxisMin.Name = "yAxisMin";
            this.yAxisMin.Size = new System.Drawing.Size(46, 17);
            this.yAxisMin.TabIndex = 8;
            this.yAxisMin.Text = "y-min:";
            // 
            // logYScaleBase
            // 
            this.logYScaleBase.Enabled = false;
            this.logYScaleBase.Location = new System.Drawing.Point(155, 46);
            this.logYScaleBase.Name = "logYScaleBase";
            this.logYScaleBase.Size = new System.Drawing.Size(33, 22);
            this.logYScaleBase.TabIndex = 7;
            this.logYScaleBase.Text = "10";
            this.logYScaleBase.TextChanged += new System.EventHandler(this.logYScaleBase_TextChanged);
            // 
            // logYScale
            // 
            this.logYScale.AutoSize = true;
            this.logYScale.Location = new System.Drawing.Point(63, 46);
            this.logYScale.Name = "logYScale";
            this.logYScale.Size = new System.Drawing.Size(92, 21);
            this.logYScale.TabIndex = 6;
            this.logYScale.Text = "Log base:";
            this.logYScale.UseVisualStyleBackColor = true;
            // 
            // linearYScale
            // 
            this.linearYScale.AutoSize = true;
            this.linearYScale.Checked = true;
            this.linearYScale.Location = new System.Drawing.Point(63, 11);
            this.linearYScale.Name = "linearYScale";
            this.linearYScale.Size = new System.Drawing.Size(69, 21);
            this.linearYScale.TabIndex = 5;
            this.linearYScale.TabStop = true;
            this.linearYScale.Text = "Linear";
            this.linearYScale.UseVisualStyleBackColor = true;
            this.linearYScale.CheckedChanged += new System.EventHandler(this.linearYScale_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "y-axis:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(518, 9);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(449, 106);
            this.checkedListBox1.TabIndex = 20;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // ParseDataViz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 647);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 694);
            this.Name = "ParseDataViz";
            this.Text = "ParseDataViz";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox logYScaleBase;
        private System.Windows.Forms.RadioButton logYScale;
        private System.Windows.Forms.RadioButton linearYScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox yMaxFixedValue;
        private System.Windows.Forms.RadioButton yMaxFixed;
        private System.Windows.Forms.RadioButton yMaxAuto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox yMinFixedValue;
        private System.Windows.Forms.RadioButton yMinFixed;
        private System.Windows.Forms.RadioButton yMinAuto;
        private System.Windows.Forms.Label yAxisMax;
        private System.Windows.Forms.Label yAxisMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label exportWidth;
        private System.Windows.Forms.TextBox exportHeightValue;
        private System.Windows.Forms.TextBox exportWidthValue;
        private System.Windows.Forms.Label exportHeight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox exportAsComboBox;
        private System.Windows.Forms.TextBox yAxisLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox xAxisLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox axisTypeComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

