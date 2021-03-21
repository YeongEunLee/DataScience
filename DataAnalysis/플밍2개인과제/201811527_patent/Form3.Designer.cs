namespace _201811527_patent
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.title_box = new System.Windows.Forms.TextBox();
            this.inv_box = new System.Windows.Forms.TextBox();
            this.abs_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title_box
            // 
            this.title_box.Location = new System.Drawing.Point(24, 206);
            this.title_box.Multiline = true;
            this.title_box.Name = "title_box";
            this.title_box.ReadOnly = true;
            this.title_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.title_box.Size = new System.Drawing.Size(313, 38);
            this.title_box.TabIndex = 51;
            // 
            // inv_box
            // 
            this.inv_box.Location = new System.Drawing.Point(21, 276);
            this.inv_box.Multiline = true;
            this.inv_box.Name = "inv_box";
            this.inv_box.ReadOnly = true;
            this.inv_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inv_box.Size = new System.Drawing.Size(316, 50);
            this.inv_box.TabIndex = 50;
            // 
            // abs_box
            // 
            this.abs_box.Location = new System.Drawing.Point(22, 359);
            this.abs_box.Multiline = true;
            this.abs_box.Name = "abs_box";
            this.abs_box.ReadOnly = true;
            this.abs_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.abs_box.Size = new System.Drawing.Size(315, 120);
            this.abs_box.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(18, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "abstract";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(18, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "inventors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(19, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "title";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_date.Location = new System.Drawing.Point(19, 147);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(77, 17);
            this.lbl_date.TabIndex = 45;
            this.lbl_date.Text = "app_date:";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_num.Location = new System.Drawing.Point(19, 117);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(79, 17);
            this.lbl_num.TabIndex = 44;
            this.lbl_num.Text = "app_num:";
            // 
            // panel26
            // 
            this.panel26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel26.BackgroundImage")));
            this.panel26.Location = new System.Drawing.Point(38, 12);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(283, 88);
            this.panel26.TabIndex = 43;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 502);
            this.Controls.Add(this.title_box);
            this.Controls.Add(this.inv_box);
            this.Controls.Add(this.abs_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.panel26);
            this.Name = "Form3";
            this.Text = "특허 조회 결과";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox title_box;
        public System.Windows.Forms.TextBox inv_box;
        public System.Windows.Forms.TextBox abs_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_date;
        public System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Panel panel26;
    }
}