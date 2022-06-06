namespace Week_03_leejuhoon
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOutput = new System.Windows.Forms.Label();
            this.tbxKor = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbxEng = new System.Windows.Forms.TextBox();
            this.tbxMat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Gainsboro;
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblOutput.Location = new System.Drawing.Point(0, 97);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(521, 316);
            this.lblOutput.TabIndex = 6;
            // 
            // tbxKor
            // 
            this.tbxKor.Location = new System.Drawing.Point(12, 12);
            this.tbxKor.Name = "tbxKor";
            this.tbxKor.Size = new System.Drawing.Size(100, 30);
            this.tbxKor.TabIndex = 5;
            this.tbxKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(434, 12);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 42);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "조회";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(339, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(89, 42);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "입력";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbxEng
            // 
            this.tbxEng.Location = new System.Drawing.Point(118, 12);
            this.tbxEng.Name = "tbxEng";
            this.tbxEng.Size = new System.Drawing.Size(100, 30);
            this.tbxEng.TabIndex = 5;
            this.tbxEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxMat
            // 
            this.tbxMat.Location = new System.Drawing.Point(224, 12);
            this.tbxMat.Name = "tbxMat";
            this.tbxMat.Size = new System.Drawing.Size(100, 30);
            this.tbxMat.TabIndex = 5;
            this.tbxMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(521, 413);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.tbxMat);
            this.Controls.Add(this.tbxEng);
            this.Controls.Add(this.tbxKor);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnInsert);
            this.Font = new System.Drawing.Font("굴림", 12F);
            this.Name = "Form1";
            this.Text = "예제3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox tbxKor;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbxEng;
        private System.Windows.Forms.TextBox tbxMat;
    }
}

