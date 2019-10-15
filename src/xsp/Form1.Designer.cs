namespace xsp
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonthCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDEBX = new System.Windows.Forms.Label();
            this.lblDEBJ = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDEBXLXZE = new System.Windows.Forms.Label();
            this.lblDEBJLXZE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "贷款总额(元)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "月利率(%)：";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 116);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(693, 249);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(107, 6);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(160, 21);
            this.txtTotalAmount.TabIndex = 8;
            this.txtTotalAmount.Text = "1000000";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(350, 6);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 21);
            this.txtRate.TabIndex = 9;
            this.txtRate.Text = "0.44";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "等额本息：每月还款额=[贷款本金×月利率×（1+月利率）^还款月数]÷[（1+月利率）^还款月数－1]\r\n\r\n等额本金：每月还本付息金额=（本金/还款月数）+（本" +
    "金-累计已还本金）×月利率";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "贷款月数：";
            // 
            // txtMonthCount
            // 
            this.txtMonthCount.Location = new System.Drawing.Point(107, 33);
            this.txtMonthCount.Name = "txtMonthCount";
            this.txtMonthCount.Size = new System.Drawing.Size(160, 21);
            this.txtMonthCount.TabIndex = 14;
            this.txtMonthCount.Text = "360";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "等额本息还款总额：";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "等额本金还款总额：";
            // 
            // lblDEBX
            // 
            this.lblDEBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDEBX.AutoSize = true;
            this.lblDEBX.Location = new System.Drawing.Point(131, 379);
            this.lblDEBX.Name = "lblDEBX";
            this.lblDEBX.Size = new System.Drawing.Size(11, 12);
            this.lblDEBX.TabIndex = 17;
            this.lblDEBX.Text = "0";
            // 
            // lblDEBJ
            // 
            this.lblDEBJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDEBJ.AutoSize = true;
            this.lblDEBJ.Location = new System.Drawing.Point(131, 417);
            this.lblDEBJ.Name = "lblDEBJ";
            this.lblDEBJ.Size = new System.Drawing.Size(11, 12);
            this.lblDEBJ.TabIndex = 18;
            this.lblDEBJ.Text = "0";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(275, 31);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 19;
            this.btnCalc.Text = "计算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "等额本金还款利息总额：";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "等额本息还款利息总额：";
            // 
            // lblDEBXLXZE
            // 
            this.lblDEBXLXZE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDEBXLXZE.AutoSize = true;
            this.lblDEBXLXZE.Location = new System.Drawing.Point(416, 379);
            this.lblDEBXLXZE.Name = "lblDEBXLXZE";
            this.lblDEBXLXZE.Size = new System.Drawing.Size(11, 12);
            this.lblDEBXLXZE.TabIndex = 22;
            this.lblDEBXLXZE.Text = "0";
            // 
            // lblDEBJLXZE
            // 
            this.lblDEBJLXZE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDEBJLXZE.AutoSize = true;
            this.lblDEBJLXZE.Location = new System.Drawing.Point(416, 417);
            this.lblDEBJLXZE.Name = "lblDEBJLXZE";
            this.lblDEBJLXZE.Size = new System.Drawing.Size(11, 12);
            this.lblDEBJLXZE.TabIndex = 23;
            this.lblDEBJLXZE.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.lblDEBJLXZE);
            this.Controls.Add(this.lblDEBXLXZE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblDEBJ);
            this.Controls.Add(this.lblDEBX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMonthCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormMain";
            this.Text = "小算盘";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonthCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDEBX;
        private System.Windows.Forms.Label lblDEBJ;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDEBXLXZE;
        private System.Windows.Forms.Label lblDEBJLXZE;
    }
}

