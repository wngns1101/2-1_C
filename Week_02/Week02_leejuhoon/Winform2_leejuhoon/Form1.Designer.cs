namespace Winform2_leejuhoon
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
            this.tbxOpr1 = new System.Windows.Forms.TextBox();
            this.tbxOpr2 = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.chkFloatType = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbxOpr1
            // 
            this.tbxOpr1.Location = new System.Drawing.Point(10, 19);
            this.tbxOpr1.Name = "tbxOpr1";
            this.tbxOpr1.Size = new System.Drawing.Size(81, 25);
            this.tbxOpr1.TabIndex = 0;
            this.tbxOpr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxOpr2
            // 
            this.tbxOpr2.Location = new System.Drawing.Point(118, 19);
            this.tbxOpr2.Name = "tbxOpr2";
            this.tbxOpr2.Size = new System.Drawing.Size(81, 25);
            this.tbxOpr2.TabIndex = 0;
            this.tbxOpr2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(218, 20);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(38, 23);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "=";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "+";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(273, 20);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(30, 23);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chkFloatType
            // 
            this.chkFloatType.AutoSize = true;
            this.chkFloatType.Location = new System.Drawing.Point(319, 24);
            this.chkFloatType.Name = "chkFloatType";
            this.chkFloatType.Size = new System.Drawing.Size(61, 19);
            this.chkFloatType.TabIndex = 3;
            this.chkFloatType.Text = "Float";
            this.chkFloatType.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(382, 68);
            this.Controls.Add(this.chkFloatType);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.tbxOpr2);
            this.Controls.Add(this.tbxOpr1);
            this.Name = "frmMain";
            this.Text = "Winform2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOpr1;
        private System.Windows.Forms.TextBox tbxOpr2;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox chkFloatType;
    }
}

