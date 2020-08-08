namespace WindowsFormsApp1
{
    partial class Formmain
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
            this.lbl_goods = new System.Windows.Forms.Label();
            this.lbl_sale = new System.Windows.Forms.Label();
            this.lbl_salemoney = new System.Windows.Forms.Label();
            this.lbl_monthsale = new System.Windows.Forms.Label();
            this.lbl_monthsalemoney = new System.Windows.Forms.Label();
            this.lbl_date1 = new System.Windows.Forms.Label();
            this.dtp_sale = new System.Windows.Forms.DateTimePicker();
            this.dtp_salemoney = new System.Windows.Forms.DateTimePicker();
            this.btn_sale = new System.Windows.Forms.Button();
            this.btn_salemoney = new System.Windows.Forms.Button();
            this.lbl_date2 = new System.Windows.Forms.Label();
            this.dtp_monthsale = new System.Windows.Forms.DateTimePicker();
            this.dtp_monthsalemoney = new System.Windows.Forms.DateTimePicker();
            this.btn_monthsale = new System.Windows.Forms.Button();
            this.btn_monthsalemoney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_goods
            // 
            this.lbl_goods.AutoSize = true;
            this.lbl_goods.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_goods.Location = new System.Drawing.Point(51, 36);
            this.lbl_goods.Name = "lbl_goods";
            this.lbl_goods.Size = new System.Drawing.Size(261, 30);
            this.lbl_goods.TabIndex = 0;
            this.lbl_goods.Text = "查询商品统计信息";
            // 
            // lbl_sale
            // 
            this.lbl_sale.AutoSize = true;
            this.lbl_sale.Location = new System.Drawing.Point(53, 191);
            this.lbl_sale.Name = "lbl_sale";
            this.lbl_sale.Size = new System.Drawing.Size(179, 18);
            this.lbl_sale.TabIndex = 1;
            this.lbl_sale.Text = "各种类商品销量查询:";
            // 
            // lbl_salemoney
            // 
            this.lbl_salemoney.AutoSize = true;
            this.lbl_salemoney.Location = new System.Drawing.Point(53, 253);
            this.lbl_salemoney.Name = "lbl_salemoney";
            this.lbl_salemoney.Size = new System.Drawing.Size(197, 18);
            this.lbl_salemoney.TabIndex = 2;
            this.lbl_salemoney.Text = "各种类商品销售额查询:";
            // 
            // lbl_monthsale
            // 
            this.lbl_monthsale.AutoSize = true;
            this.lbl_monthsale.Location = new System.Drawing.Point(53, 377);
            this.lbl_monthsale.Name = "lbl_monthsale";
            this.lbl_monthsale.Size = new System.Drawing.Size(215, 18);
            this.lbl_monthsale.TabIndex = 3;
            this.lbl_monthsale.Text = "各种类商品月度销量查询:";
            // 
            // lbl_monthsalemoney
            // 
            this.lbl_monthsalemoney.AutoSize = true;
            this.lbl_monthsalemoney.Location = new System.Drawing.Point(53, 444);
            this.lbl_monthsalemoney.Name = "lbl_monthsalemoney";
            this.lbl_monthsalemoney.Size = new System.Drawing.Size(233, 18);
            this.lbl_monthsalemoney.TabIndex = 4;
            this.lbl_monthsalemoney.Text = "各种类商品月度销售额查询:";
            // 
            // lbl_date1
            // 
            this.lbl_date1.AutoSize = true;
            this.lbl_date1.Location = new System.Drawing.Point(305, 145);
            this.lbl_date1.Name = "lbl_date1";
            this.lbl_date1.Size = new System.Drawing.Size(134, 18);
            this.lbl_date1.TabIndex = 7;
            this.lbl_date1.Text = "日期(年/月/日)";
            // 
            // dtp_sale
            // 
            this.dtp_sale.CustomFormat = "";
            this.dtp_sale.Location = new System.Drawing.Point(308, 185);
            this.dtp_sale.Name = "dtp_sale";
            this.dtp_sale.ShowUpDown = true;
            this.dtp_sale.Size = new System.Drawing.Size(200, 28);
            this.dtp_sale.TabIndex = 8;
            this.dtp_sale.Value = new System.DateTime(2020, 8, 23, 0, 0, 0, 0);
            // 
            // dtp_salemoney
            // 
            this.dtp_salemoney.Location = new System.Drawing.Point(308, 247);
            this.dtp_salemoney.Name = "dtp_salemoney";
            this.dtp_salemoney.ShowUpDown = true;
            this.dtp_salemoney.Size = new System.Drawing.Size(200, 28);
            this.dtp_salemoney.TabIndex = 9;
            this.dtp_salemoney.Value = new System.DateTime(2020, 8, 23, 0, 0, 0, 0);
            // 
            // btn_sale
            // 
            this.btn_sale.Location = new System.Drawing.Point(578, 184);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(75, 32);
            this.btn_sale.TabIndex = 10;
            this.btn_sale.Text = "查询";
            this.btn_sale.UseVisualStyleBackColor = true;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // btn_salemoney
            // 
            this.btn_salemoney.Location = new System.Drawing.Point(578, 247);
            this.btn_salemoney.Name = "btn_salemoney";
            this.btn_salemoney.Size = new System.Drawing.Size(75, 32);
            this.btn_salemoney.TabIndex = 11;
            this.btn_salemoney.Text = "查询";
            this.btn_salemoney.UseVisualStyleBackColor = true;
            this.btn_salemoney.Click += new System.EventHandler(this.btn_salemoney_Click);
            // 
            // lbl_date2
            // 
            this.lbl_date2.AutoSize = true;
            this.lbl_date2.Location = new System.Drawing.Point(305, 328);
            this.lbl_date2.Name = "lbl_date2";
            this.lbl_date2.Size = new System.Drawing.Size(44, 18);
            this.lbl_date2.TabIndex = 12;
            this.lbl_date2.Text = "年份";
            // 
            // dtp_monthsale
            // 
            this.dtp_monthsale.CustomFormat = "yyyy";
            this.dtp_monthsale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_monthsale.Location = new System.Drawing.Point(308, 371);
            this.dtp_monthsale.Name = "dtp_monthsale";
            this.dtp_monthsale.ShowUpDown = true;
            this.dtp_monthsale.Size = new System.Drawing.Size(200, 28);
            this.dtp_monthsale.TabIndex = 13;
            this.dtp_monthsale.Value = new System.DateTime(2020, 8, 23, 0, 0, 0, 0);
            // 
            // dtp_monthsalemoney
            // 
            this.dtp_monthsalemoney.CustomFormat = "yyyy";
            this.dtp_monthsalemoney.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_monthsalemoney.Location = new System.Drawing.Point(308, 441);
            this.dtp_monthsalemoney.Name = "dtp_monthsalemoney";
            this.dtp_monthsalemoney.ShowUpDown = true;
            this.dtp_monthsalemoney.Size = new System.Drawing.Size(200, 28);
            this.dtp_monthsalemoney.TabIndex = 14;
            this.dtp_monthsalemoney.Value = new System.DateTime(2020, 8, 23, 0, 0, 0, 0);
            // 
            // btn_monthsale
            // 
            this.btn_monthsale.Location = new System.Drawing.Point(578, 371);
            this.btn_monthsale.Name = "btn_monthsale";
            this.btn_monthsale.Size = new System.Drawing.Size(75, 32);
            this.btn_monthsale.TabIndex = 15;
            this.btn_monthsale.Text = "查询";
            this.btn_monthsale.UseVisualStyleBackColor = true;
            this.btn_monthsale.Click += new System.EventHandler(this.btn_monthsale_Click);
            // 
            // btn_monthsalemoney
            // 
            this.btn_monthsalemoney.Location = new System.Drawing.Point(578, 441);
            this.btn_monthsalemoney.Name = "btn_monthsalemoney";
            this.btn_monthsalemoney.Size = new System.Drawing.Size(75, 32);
            this.btn_monthsalemoney.TabIndex = 16;
            this.btn_monthsalemoney.Text = "查询";
            this.btn_monthsalemoney.UseVisualStyleBackColor = true;
            this.btn_monthsalemoney.Click += new System.EventHandler(this.btn_monthsalemoney_Click);
            // 
            // Formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 610);
            this.Controls.Add(this.btn_monthsalemoney);
            this.Controls.Add(this.btn_monthsale);
            this.Controls.Add(this.dtp_monthsalemoney);
            this.Controls.Add(this.dtp_monthsale);
            this.Controls.Add(this.lbl_date2);
            this.Controls.Add(this.btn_salemoney);
            this.Controls.Add(this.btn_sale);
            this.Controls.Add(this.dtp_salemoney);
            this.Controls.Add(this.dtp_sale);
            this.Controls.Add(this.lbl_date1);
            this.Controls.Add(this.lbl_monthsalemoney);
            this.Controls.Add(this.lbl_monthsale);
            this.Controls.Add(this.lbl_salemoney);
            this.Controls.Add(this.lbl_sale);
            this.Controls.Add(this.lbl_goods);
            this.Name = "Formmain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_goods;
        private System.Windows.Forms.Label lbl_sale;
        private System.Windows.Forms.Label lbl_salemoney;
        private System.Windows.Forms.Label lbl_monthsale;
        private System.Windows.Forms.Label lbl_monthsalemoney;
        private System.Windows.Forms.Label lbl_date1;
        private System.Windows.Forms.DateTimePicker dtp_sale;
        private System.Windows.Forms.DateTimePicker dtp_salemoney;
        private System.Windows.Forms.Button btn_sale;
        private System.Windows.Forms.Button btn_salemoney;
        private System.Windows.Forms.Label lbl_date2;
        private System.Windows.Forms.DateTimePicker dtp_monthsale;
        private System.Windows.Forms.DateTimePicker dtp_monthsalemoney;
        private System.Windows.Forms.Button btn_monthsale;
        private System.Windows.Forms.Button btn_monthsalemoney;
    }
}

