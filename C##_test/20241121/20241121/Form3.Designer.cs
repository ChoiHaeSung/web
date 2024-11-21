namespace _20241121
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(13, 10);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 445);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("굴림", 9F);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "디지털시계";
            tabPage1.ToolTipText = "(컬렉션)";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(428, 181);
            button2.Name = "button2";
            button2.Size = new Size(76, 23);
            button2.TabIndex = 5;
            button2.Text = "해제";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(428, 82);
            button1.Name = "button1";
            button1.Size = new Size(76, 23);
            button1.TabIndex = 4;
            button1.Text = "설정";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Cursor = Cursors.IBeam;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(190, 180);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 21);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(190, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 21);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 156);
            label2.Name = "label2";
            label2.Size = new Size(57, 12);
            label2.TabIndex = 1;
            label2.Text = "시간 설정";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 56);
            label1.Name = "label1";
            label1.Size = new Size(57, 12);
            label1.TabIndex = 0;
            label1.Text = "날짜 설정";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Font = new Font("굴림", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "알람설정";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(525, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 100);
            label4.Name = "label4";
            label4.Size = new Size(42, 12);
            label4.TabIndex = 1;
            label4.Text = "Alam :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 44);
            label3.Name = "label3";
            label3.Size = new Size(57, 12);
            label3.TabIndex = 0;
            label3.Text = "알람 설정";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(102, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "현재 시각";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 42);
            label5.Name = "label5";
            label5.Size = new Size(30, 12);
            label5.TabIndex = 2;
            label5.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("굴림", 20F);
            label6.Location = new Point(197, 99);
            label6.Name = "label6";
            label6.Size = new Size(73, 27);
            label6.TabIndex = 3;
            label6.Text = "Time";
            label6.Click += label6_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form3";
            Text = "Form3";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}