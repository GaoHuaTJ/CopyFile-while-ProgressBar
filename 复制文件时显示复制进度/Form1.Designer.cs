namespace 复制文件时显示复制进度
{
    partial class Form1
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
            this.textBoxOrigin = new System.Windows.Forms.TextBox();
            this.textBoxGoalFile = new System.Windows.Forms.TextBox();
            this.btn_OriginFile = new System.Windows.Forms.Button();
            this.btnGoalFile = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // textBoxOrigin
            // 
            this.textBoxOrigin.Location = new System.Drawing.Point(33, 57);
            this.textBoxOrigin.Multiline = true;
            this.textBoxOrigin.Name = "textBoxOrigin";
            this.textBoxOrigin.Size = new System.Drawing.Size(416, 25);
            this.textBoxOrigin.TabIndex = 0;
            // 
            // textBoxGoalFile
            // 
            this.textBoxGoalFile.Location = new System.Drawing.Point(33, 125);
            this.textBoxGoalFile.Multiline = true;
            this.textBoxGoalFile.Name = "textBoxGoalFile";
            this.textBoxGoalFile.Size = new System.Drawing.Size(416, 25);
            this.textBoxGoalFile.TabIndex = 1;
            // 
            // btn_OriginFile
            // 
            this.btn_OriginFile.Location = new System.Drawing.Point(483, 59);
            this.btn_OriginFile.Name = "btn_OriginFile";
            this.btn_OriginFile.Size = new System.Drawing.Size(75, 26);
            this.btn_OriginFile.TabIndex = 2;
            this.btn_OriginFile.Text = "源文件";
            this.btn_OriginFile.UseVisualStyleBackColor = true;
            this.btn_OriginFile.Click += new System.EventHandler(this.btn_OriginFile_Click);
            // 
            // btnGoalFile
            // 
            this.btnGoalFile.Location = new System.Drawing.Point(483, 125);
            this.btnGoalFile.Name = "btnGoalFile";
            this.btnGoalFile.Size = new System.Drawing.Size(75, 26);
            this.btnGoalFile.TabIndex = 3;
            this.btnGoalFile.Text = "目的地址";
            this.btnGoalFile.UseVisualStyleBackColor = true;
            this.btnGoalFile.Click += new System.EventHandler(this.btnGoalFile_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(483, 205);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 47);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(33, 220);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(416, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 383);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGoalFile);
            this.Controls.Add(this.btn_OriginFile);
            this.Controls.Add(this.textBoxGoalFile);
            this.Controls.Add(this.textBoxOrigin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOrigin;
        private System.Windows.Forms.TextBox textBoxGoalFile;
        private System.Windows.Forms.Button btn_OriginFile;
        private System.Windows.Forms.Button btnGoalFile;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

