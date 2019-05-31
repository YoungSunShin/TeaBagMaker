namespace TeaBagMaker
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
            this.teaComboBox = new System.Windows.Forms.ComboBox();
            this.Soaking = new System.Windows.Forms.Button();
            this.countTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teaComboBox
            // 
            this.teaComboBox.FormattingEnabled = true;
            this.teaComboBox.Location = new System.Drawing.Point(13, 13);
            this.teaComboBox.Name = "teaComboBox";
            this.teaComboBox.Size = new System.Drawing.Size(246, 20);
            this.teaComboBox.TabIndex = 0;
            // 
            // Soaking
            // 
            this.Soaking.Location = new System.Drawing.Point(13, 40);
            this.Soaking.Name = "Soaking";
            this.Soaking.Size = new System.Drawing.Size(246, 106);
            this.Soaking.TabIndex = 1;
            this.Soaking.Text = "담그기!";
            this.Soaking.UseVisualStyleBackColor = true;
            // 
            // countTime
            // 
            this.countTime.AutoSize = true;
            this.countTime.Location = new System.Drawing.Point(12, 164);
            this.countTime.Name = "countTime";
            this.countTime.Size = new System.Drawing.Size(65, 12);
            this.countTime.TabIndex = 2;
            this.countTime.Text = "남은 시간: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "3110_신영선";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countTime);
            this.Controls.Add(this.Soaking);
            this.Controls.Add(this.teaComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teaComboBox;
        private System.Windows.Forms.Button Soaking;
        private System.Windows.Forms.Label countTime;
        private System.Windows.Forms.Label label2;
    }
}

