namespace Retry
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
            this.tbxView = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDeparture = new System.Windows.Forms.Button();
            this.btnArrive = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxView
            // 
            this.tbxView.Location = new System.Drawing.Point(46, 80);
            this.tbxView.Multiline = true;
            this.tbxView.Name = "tbxView";
            this.tbxView.ReadOnly = true;
            this.tbxView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxView.Size = new System.Drawing.Size(709, 353);
            this.tbxView.TabIndex = 10;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(680, 18);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 36);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "조회";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDeparture
            // 
            this.btnDeparture.Location = new System.Drawing.Point(486, 18);
            this.btnDeparture.Name = "btnDeparture";
            this.btnDeparture.Size = new System.Drawing.Size(75, 36);
            this.btnDeparture.TabIndex = 8;
            this.btnDeparture.Text = "출차";
            this.btnDeparture.UseVisualStyleBackColor = true;
            this.btnDeparture.Click += new System.EventHandler(this.btnDeparture_Click);
            // 
            // btnArrive
            // 
            this.btnArrive.Location = new System.Drawing.Point(393, 18);
            this.btnArrive.Name = "btnArrive";
            this.btnArrive.Size = new System.Drawing.Size(75, 36);
            this.btnArrive.TabIndex = 9;
            this.btnArrive.Text = "입차";
            this.btnArrive.UseVisualStyleBackColor = true;
            this.btnArrive.Click += new System.EventHandler(this.btnArrive_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "차량번호";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(141, 23);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(222, 25);
            this.tbxNumber.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxView);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDeparture);
            this.Controls.Add(this.btnArrive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxView;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDeparture;
        private System.Windows.Forms.Button btnArrive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNumber;
    }
}

