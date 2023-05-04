namespace ListBox_sport
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox_input = new ComboBox();
            label7 = new Label();
            richTextBox_output = new RichTextBox();
            list_Play1 = new ListBox();
            list_chose = new ListBox();
            BTN_Add_All = new Button();
            BTN_Add = new Button();
            BTN_Sub_All = new Button();
            BTN_Sub = new Button();
            BTN_Run = new Button();
            BTN_Reset = new Button();
            BTN_Exit = new Button();
            text_date = new TextBox();
            text_time = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(87, 36);
            label1.Name = "label1";
            label1.Size = new Size(205, 22);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Thể Thao";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 92);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Chọn họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 142);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 142);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 168);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 4;
            label5.Text = "Danh sách các môn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 168);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 5;
            label6.Text = "Danh sách đã chọn";
            // 
            // comboBox_input
            // 
            comboBox_input.FormattingEnabled = true;
            comboBox_input.Location = new Point(133, 84);
            comboBox_input.Name = "comboBox_input";
            comboBox_input.Size = new Size(121, 23);
            comboBox_input.TabIndex = 6;
            comboBox_input.SelectedIndexChanged += comboBox_input_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 314);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 7;
            label7.Text = "Kết quả";
            // 
            // richTextBox_output
            // 
            richTextBox_output.Location = new Point(26, 341);
            richTextBox_output.Name = "richTextBox_output";
            richTextBox_output.Size = new Size(211, 96);
            richTextBox_output.TabIndex = 8;
            richTextBox_output.Text = "";
            // 
            // list_Play1
            // 
            list_Play1.FormattingEnabled = true;
            list_Play1.ItemHeight = 15;
            list_Play1.Items.AddRange(new object[] { "Bóng đá", "Bóng bàn", "Nhảy dù", "Bập bênh", "" });
            list_Play1.Location = new Point(26, 186);
            list_Play1.Name = "list_Play1";
            list_Play1.Size = new Size(120, 124);
            list_Play1.TabIndex = 9;
            // 
            // list_chose
            // 
            list_chose.FormattingEnabled = true;
            list_chose.ItemHeight = 15;
            list_chose.Location = new Point(252, 186);
            list_chose.Name = "list_chose";
            list_chose.Size = new Size(120, 124);
            list_chose.TabIndex = 10;
            // 
            // BTN_Add_All
            // 
            BTN_Add_All.Location = new Point(162, 186);
            BTN_Add_All.Name = "BTN_Add_All";
            BTN_Add_All.Size = new Size(75, 23);
            BTN_Add_All.TabIndex = 11;
            BTN_Add_All.Text = ">>";
            BTN_Add_All.UseVisualStyleBackColor = true;
            BTN_Add_All.Click += BTN_Add_All_Click;
            // 
            // BTN_Add
            // 
            BTN_Add.Location = new Point(162, 221);
            BTN_Add.Name = "BTN_Add";
            BTN_Add.Size = new Size(75, 23);
            BTN_Add.TabIndex = 12;
            BTN_Add.Text = ">";
            BTN_Add.UseVisualStyleBackColor = true;
            BTN_Add.Click += BTN_Add_Click;
            // 
            // BTN_Sub_All
            // 
            BTN_Sub_All.Location = new Point(162, 250);
            BTN_Sub_All.Name = "BTN_Sub_All";
            BTN_Sub_All.Size = new Size(75, 23);
            BTN_Sub_All.TabIndex = 13;
            BTN_Sub_All.Text = "<<";
            BTN_Sub_All.UseVisualStyleBackColor = true;
            BTN_Sub_All.Click += BTN_Sub_All_Click;
            // 
            // BTN_Sub
            // 
            BTN_Sub.Location = new Point(162, 287);
            BTN_Sub.Name = "BTN_Sub";
            BTN_Sub.Size = new Size(75, 23);
            BTN_Sub.TabIndex = 14;
            BTN_Sub.Text = "<";
            BTN_Sub.UseVisualStyleBackColor = true;
            BTN_Sub.Click += BTN_Sub_Click;
            // 
            // BTN_Run
            // 
            BTN_Run.Location = new Point(266, 341);
            BTN_Run.Name = "BTN_Run";
            BTN_Run.Size = new Size(75, 23);
            BTN_Run.TabIndex = 15;
            BTN_Run.Text = "Nhập";
            BTN_Run.UseVisualStyleBackColor = true;
            BTN_Run.Click += BTN_Run_Click;
            // 
            // BTN_Reset
            // 
            BTN_Reset.Location = new Point(266, 380);
            BTN_Reset.Name = "BTN_Reset";
            BTN_Reset.Size = new Size(75, 23);
            BTN_Reset.TabIndex = 16;
            BTN_Reset.Text = "Reset";
            BTN_Reset.UseVisualStyleBackColor = true;
            BTN_Reset.Click += BTN_Reset_Click;
            // 
            // BTN_Exit
            // 
            BTN_Exit.Location = new Point(266, 414);
            BTN_Exit.Name = "BTN_Exit";
            BTN_Exit.Size = new Size(75, 23);
            BTN_Exit.TabIndex = 17;
            BTN_Exit.Text = "Thoát";
            BTN_Exit.UseVisualStyleBackColor = true;
            BTN_Exit.Click += BTN_Exit_Click;
            // 
            // text_date
            // 
            text_date.Location = new Point(63, 134);
            text_date.Name = "text_date";
            text_date.ReadOnly = true;
            text_date.Size = new Size(132, 23);
            text_date.TabIndex = 18;
            // 
            // text_time
            // 
            text_time.Location = new Point(291, 134);
            text_time.Name = "text_time";
            text_time.ReadOnly = true;
            text_time.Size = new Size(81, 23);
            text_time.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 465);
            Controls.Add(text_time);
            Controls.Add(text_date);
            Controls.Add(BTN_Exit);
            Controls.Add(BTN_Reset);
            Controls.Add(BTN_Run);
            Controls.Add(BTN_Sub);
            Controls.Add(BTN_Sub_All);
            Controls.Add(BTN_Add);
            Controls.Add(BTN_Add_All);
            Controls.Add(list_chose);
            Controls.Add(list_Play1);
            Controls.Add(richTextBox_output);
            Controls.Add(label7);
            Controls.Add(comboBox_input);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListBox Thể thao";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox_input;
        private Label label7;
        private RichTextBox richTextBox_output;
        private ListBox list_Play1;
        private ListBox list_chose;
        private Button BTN_Add_All;
        private Button BTN_Add;
        private Button BTN_Sub_All;
        private Button BTN_Sub;
        private Button BTN_Run;
        private Button BTN_Reset;
        private Button BTN_Exit;
        private TextBox text_date;
        private TextBox text_time;
    }
}