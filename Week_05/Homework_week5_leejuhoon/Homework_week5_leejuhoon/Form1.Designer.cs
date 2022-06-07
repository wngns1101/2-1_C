namespace Homework_week5_leejuhoon
{
    partial class FrmMain
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
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.btnArrive = new System.Windows.Forms.Button();
            this.btnDeparture = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.tbxView = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "차량번호";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(107, 28);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(222, 25);
            this.tbxNumber.TabIndex = 1;
            // 
            // btnArrive
            // 
            this.btnArrive.Location = new System.Drawing.Point(359, 23);
            this.btnArrive.Name = "btnArrive";
            this.btnArrive.Size = new System.Drawing.Size(75, 36);
            this.btnArrive.TabIndex = 2;
            this.btnArrive.Text = "입차";
            this.btnArrive.UseVisualStyleBackColor = true;
            this.btnArrive.Click += new System.EventHandler(this.btnArrive_Click);
            // 
            // btnDeparture
            // 
            this.btnDeparture.Location = new System.Drawing.Point(452, 23);
            this.btnDeparture.Name = "btnDeparture";
            this.btnDeparture.Size = new System.Drawing.Size(75, 36);
            this.btnDeparture.TabIndex = 2;
            this.btnDeparture.Text = "출차";
            this.btnDeparture.UseVisualStyleBackColor = true;
            this.btnDeparture.Click += new System.EventHandler(this.btnDeparture_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(646, 23);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 36);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "조회";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // tbxView
            // 
            this.tbxView.Location = new System.Drawing.Point(12, 85);
            this.tbxView.Multiline = true;
            this.tbxView.Name = "tbxView";
            this.tbxView.Size = new System.Drawing.Size(709, 353);
            this.tbxView.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.tbxView);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDeparture);
            this.Controls.Add(this.btnArrive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNumber);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Button btnArrive;
        private System.Windows.Forms.Button btnDeparture;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox tbxView;
    }
}

