using System;
using System.Drawing;

namespace Ai_01_WindowsFormsApp
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.listBoxReservations = new System.Windows.Forms.ListBox();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtReservationDescription = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(194, 20);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 21);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "질문하기";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(6, 44);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(38, 12);
            this.lblResponse.TabIndex = 1;
            this.lblResponse.Text = "label1";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 20);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(182, 21);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(17, 24);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(442, 21);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2024, 12, 9, 10, 20, 31, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(373, 51);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(86, 21);
            this.btnAddReservation.TabIndex = 5;
            this.btnAddReservation.Text = "추가";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // listBoxReservations
            // 
            this.listBoxReservations.FormattingEnabled = true;
            this.listBoxReservations.ItemHeight = 12;
            this.listBoxReservations.Location = new System.Drawing.Point(17, 78);
            this.listBoxReservations.Name = "listBoxReservations";
            this.listBoxReservations.Size = new System.Drawing.Size(442, 136);
            this.listBoxReservations.TabIndex = 6;
            this.listBoxReservations.SelectedIndexChanged += new System.EventHandler(this.listBoxReservations_SelectedIndexChanged);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Location = new System.Drawing.Point(365, 220);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(94, 31);
            this.btnDeleteReservation.TabIndex = 7;
            this.btnDeleteReservation.Text = "삭제";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtReservationDescription);
            this.groupBox1.Controls.Add(this.listBoxReservations);
            this.groupBox1.Controls.Add(this.btnDeleteReservation);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.btnAddReservation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 260);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "예약";
            // 
            // TxtReservationDescription
            // 
            this.TxtReservationDescription.Location = new System.Drawing.Point(17, 52);
            this.TxtReservationDescription.Name = "TxtReservationDescription";
            this.TxtReservationDescription.Size = new System.Drawing.Size(350, 21);
            this.TxtReservationDescription.TabIndex = 8;
            this.TxtReservationDescription.TextChanged += new System.EventHandler(this.TxtReservationDescription_TextChanged_2);
            this.TxtReservationDescription.Enter += new System.EventHandler(this.TxtReservationDescription_Enter_1);
            this.TxtReservationDescription.Leave += new System.EventHandler(this.TxtReservationDescription_Leave_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.lblResponse);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "챗봇";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "예약 및 챗봇";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void txtReservationDescription_TextChanged(object sender, EventArgs e)
        {
            // 초기 텍스트 설정
            txtInput.Text = "이름을 입력하세요";
            txtInput.ForeColor = Color.Gray; // 플레이스홀더 색상 설정
        }

        private void txtInput_Leave(object sender, EventArgs e)
        {
            // 텍스트박스가 포커스를 잃을 때
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                txtInput.Text = "이름을 입력하세요"; // 플레이스홀더 텍스트 설정
                txtInput.ForeColor = Color.Gray; // 플레이스홀더 색상 설정
            }
        }
        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.ListBox listBoxReservations;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtReservationDescription;
    }
}

