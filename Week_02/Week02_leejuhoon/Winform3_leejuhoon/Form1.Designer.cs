namespace Winform3_leejuhoon
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxKor = new System.Windows.Forms.TextBox();
            this.tbxEng = new System.Windows.Forms.TextBox();
            this.tbxMat = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "영어";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "수학";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "평균";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "합계";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxKor
            // 
            this.tbxKor.Location = new System.Drawing.Point(133, 35);
            this.tbxKor.Name = "tbxKor";
            this.tbxKor.Size = new System.Drawing.Size(100, 27);
            this.tbxKor.TabIndex = 1;
            this.tbxKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxEng
            // 
            this.tbxEng.Location = new System.Drawing.Point(133, 84);
            this.tbxEng.Name = "tbxEng";
            this.tbxEng.Size = new System.Drawing.Size(100, 27);
            this.tbxEng.TabIndex = 1;
            this.tbxEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxMat
            // 
            this.tbxMat.Location = new System.Drawing.Point(133, 134);
            this.tbxMat.Name = "tbxMat";
            this.tbxMat.Size = new System.Drawing.Size(100, 27);
            this.tbxMat.TabIndex = 1;
            this.tbxMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(133, 180);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(89, 30);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "계산";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblSum
            // 
            this.lblSum.Location = new System.Drawing.Point(133, 228);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(100, 32);
            this.lblSum.TabIndex = 3;
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvg
            // 
            this.lblAvg.Location = new System.Drawing.Point(133, 272);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(100, 32);
            this.lblAvg.TabIndex = 3;
            this.lblAvg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(133, 315);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 32);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 385);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.tbxMat);
            this.Controls.Add(this.tbxEng);
            this.Controls.Add(this.tbxKor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "성적처리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxKor;
        private System.Windows.Forms.TextBox tbxEng;
        private System.Windows.Forms.TextBox tbxMat;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblResult;
    }
}

