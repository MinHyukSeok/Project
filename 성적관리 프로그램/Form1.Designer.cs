namespace 성적관리프로그램2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_INPUT = new System.Windows.Forms.Button();
            this.INPUT_GRADE3 = new System.Windows.Forms.TextBox();
            this.INPUT_GRADE2 = new System.Windows.Forms.TextBox();
            this.INPUT_GRADE1 = new System.Windows.Forms.TextBox();
            this.INPUT_NUMBER = new System.Windows.Forms.TextBox();
            this.INPUT_NAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lview_member = new System.Windows.Forms.ListView();
            this.LIST_NUM = new System.Windows.Forms.ColumnHeader();
            this.LIST_NAME = new System.Windows.Forms.ColumnHeader();
            this.LIST_NUMBER = new System.Windows.Forms.ColumnHeader();
            this.LIST_GRADE1 = new System.Windows.Forms.ColumnHeader();
            this.LIST_GRADE2 = new System.Windows.Forms.ColumnHeader();
            this.LIST_GRADE3 = new System.Windows.Forms.ColumnHeader();
            this.LIST_GRADE_SCORE = new System.Windows.Forms.ColumnHeader();
            this.LIST_GRADE_AVERAGE = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SEARCH_NUMBER = new System.Windows.Forms.TextBox();
            this.button_SEARCH = new System.Windows.Forms.Button();
            this.SEARCH_NAME = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_CLEAR = new System.Windows.Forms.Button();
            this.button_SAVE = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.button_LOAD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_INPUT);
            this.groupBox1.Controls.Add(this.INPUT_GRADE3);
            this.groupBox1.Controls.Add(this.INPUT_GRADE2);
            this.groupBox1.Controls.Add(this.INPUT_GRADE1);
            this.groupBox1.Controls.Add(this.INPUT_NUMBER);
            this.groupBox1.Controls.Add(this.INPUT_NAME);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "새로운 입력";
            // 
            // button_INPUT
            // 
            this.button_INPUT.Location = new System.Drawing.Point(254, 57);
            this.button_INPUT.Name = "button_INPUT";
            this.button_INPUT.Size = new System.Drawing.Size(74, 77);
            this.button_INPUT.TabIndex = 10;
            this.button_INPUT.Text = "추가하기";
            this.button_INPUT.UseVisualStyleBackColor = true;
            this.button_INPUT.Click += new System.EventHandler(this.button_INPUT_Click);
            // 
            // INPUT_GRADE3
            // 
            this.INPUT_GRADE3.Location = new System.Drawing.Point(101, 140);
            this.INPUT_GRADE3.Name = "INPUT_GRADE3";
            this.INPUT_GRADE3.Size = new System.Drawing.Size(137, 23);
            this.INPUT_GRADE3.TabIndex = 9;
            // 
            // INPUT_GRADE2
            // 
            this.INPUT_GRADE2.Location = new System.Drawing.Point(101, 111);
            this.INPUT_GRADE2.Name = "INPUT_GRADE2";
            this.INPUT_GRADE2.Size = new System.Drawing.Size(137, 23);
            this.INPUT_GRADE2.TabIndex = 8;
            // 
            // INPUT_GRADE1
            // 
            this.INPUT_GRADE1.Location = new System.Drawing.Point(101, 82);
            this.INPUT_GRADE1.Name = "INPUT_GRADE1";
            this.INPUT_GRADE1.Size = new System.Drawing.Size(137, 23);
            this.INPUT_GRADE1.TabIndex = 7;
            // 
            // INPUT_NUMBER
            // 
            this.INPUT_NUMBER.Location = new System.Drawing.Point(101, 53);
            this.INPUT_NUMBER.Name = "INPUT_NUMBER";
            this.INPUT_NUMBER.Size = new System.Drawing.Size(137, 23);
            this.INPUT_NUMBER.TabIndex = 6;
            // 
            // INPUT_NAME
            // 
            this.INPUT_NAME.Location = new System.Drawing.Point(101, 24);
            this.INPUT_NAME.Name = "INPUT_NAME";
            this.INPUT_NAME.Size = new System.Drawing.Size(137, 23);
            this.INPUT_NAME.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "수학 점수";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "영어 점수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "국어 점수";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "학번";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // lview_member
            // 
            this.lview_member.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LIST_NUM,
            this.LIST_NAME,
            this.LIST_NUMBER,
            this.LIST_GRADE1,
            this.LIST_GRADE2,
            this.LIST_GRADE3,
            this.LIST_GRADE_SCORE,
            this.LIST_GRADE_AVERAGE});
            this.lview_member.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lview_member.Location = new System.Drawing.Point(6, 20);
            this.lview_member.MultiSelect = false;
            this.lview_member.Name = "lview_member";
            this.lview_member.Size = new System.Drawing.Size(502, 373);
            this.lview_member.TabIndex = 1;
            this.lview_member.UseCompatibleStateImageBehavior = false;
            this.lview_member.View = System.Windows.Forms.View.Details;
            // 
            // LIST_NUM
            // 
            this.LIST_NUM.Text = "번호";
            // 
            // LIST_NAME
            // 
            this.LIST_NAME.Text = "이름";
            // 
            // LIST_NUMBER
            // 
            this.LIST_NUMBER.Text = "학번";
            // 
            // LIST_GRADE1
            // 
            this.LIST_GRADE1.Text = "국어 점수";
            // 
            // LIST_GRADE2
            // 
            this.LIST_GRADE2.Text = "영어 점수";
            // 
            // LIST_GRADE3
            // 
            this.LIST_GRADE3.Text = "수학 점수";
            // 
            // LIST_GRADE_SCORE
            // 
            this.LIST_GRADE_SCORE.Text = "총점";
            // 
            // LIST_GRADE_AVERAGE
            // 
            this.LIST_GRADE_AVERAGE.Text = "평균";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SEARCH_NUMBER);
            this.groupBox2.Controls.Add(this.button_SEARCH);
            this.groupBox2.Controls.Add(this.SEARCH_NAME);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(372, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 181);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "검색";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "학번";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SEARCH_NUMBER
            // 
            this.SEARCH_NUMBER.Location = new System.Drawing.Point(56, 67);
            this.SEARCH_NUMBER.Name = "SEARCH_NUMBER";
            this.SEARCH_NUMBER.Size = new System.Drawing.Size(79, 23);
            this.SEARCH_NUMBER.TabIndex = 5;
            // 
            // button_SEARCH
            // 
            this.button_SEARCH.Location = new System.Drawing.Point(35, 96);
            this.button_SEARCH.Name = "button_SEARCH";
            this.button_SEARCH.Size = new System.Drawing.Size(71, 67);
            this.button_SEARCH.TabIndex = 4;
            this.button_SEARCH.Text = "검색";
            this.button_SEARCH.UseVisualStyleBackColor = true;
            this.button_SEARCH.Click += new System.EventHandler(this.button_search_Click2);
            // 
            // SEARCH_NAME
            // 
            this.SEARCH_NAME.Location = new System.Drawing.Point(56, 29);
            this.SEARCH_NAME.Name = "SEARCH_NAME";
            this.SEARCH_NAME.Size = new System.Drawing.Size(79, 23);
            this.SEARCH_NAME.TabIndex = 2;
            this.SEARCH_NAME.TextChanged += new System.EventHandler(this.SEARCH_NAME_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "이름";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button_CLEAR
            // 
            this.button_CLEAR.Location = new System.Drawing.Point(171, 201);
            this.button_CLEAR.Name = "button_CLEAR";
            this.button_CLEAR.Size = new System.Drawing.Size(72, 48);
            this.button_CLEAR.TabIndex = 3;
            this.button_CLEAR.Text = "초기화";
            this.button_CLEAR.UseVisualStyleBackColor = true;
            this.button_CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // button_SAVE
            // 
            this.button_SAVE.Location = new System.Drawing.Point(249, 201);
            this.button_SAVE.Name = "button_SAVE";
            this.button_SAVE.Size = new System.Drawing.Size(72, 48);
            this.button_SAVE.TabIndex = 4;
            this.button_SAVE.Text = "파일 저장";
            this.button_SAVE.UseVisualStyleBackColor = true;
            this.button_SAVE.Click += new System.EventHandler(this.button_FILESAVE_Click);
            // 
            // button_EXIT
            // 
            this.button_EXIT.Location = new System.Drawing.Point(407, 201);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(72, 48);
            this.button_EXIT.TabIndex = 6;
            this.button_EXIT.Text = "종료";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lview_member);
            this.groupBox3.Location = new System.Drawing.Point(5, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 404);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "학생 정보";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(15, 201);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(72, 48);
            this.btn_modify.TabIndex = 8;
            this.btn_modify.Text = "수정";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.Button_modify_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(93, 201);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(72, 48);
            this.btn_remove.TabIndex = 9;
            this.btn_remove.Text = "삭제";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // button_LOAD
            // 
            this.button_LOAD.Location = new System.Drawing.Point(329, 201);
            this.button_LOAD.Name = "button_LOAD";
            this.button_LOAD.Size = new System.Drawing.Size(72, 48);
            this.button_LOAD.TabIndex = 10;
            this.button_LOAD.Text = "파일 로드";
            this.button_LOAD.UseVisualStyleBackColor = true;
            this.button_LOAD.Click += new System.EventHandler(this.getTextFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 666);
            this.Controls.Add(this.button_LOAD);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.button_SAVE);
            this.Controls.Add(this.button_CLEAR);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "성적관리프로그램";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox INPUT_GRADE3;
        private TextBox INPUT_GRADE2;
        private TextBox INPUT_GRADE1;
        private TextBox INPUT_NUMBER;
        private TextBox INPUT_NAME;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button_INPUT;
        private ListView lview_member;
        private GroupBox groupBox2;
        private Button button_SEARCH;
        private TextBox SEARCH_NAME;
        private Label label6;
        private Button button_CLEAR;
        private Button button_SAVE;
        private Button button_EXIT;
        private GroupBox groupBox3;
        private ImageList imageList1;
        private ColumnHeader LIST_NUM;
        private ColumnHeader LIST_NAME;
        private ColumnHeader LIST_NUMBER;
        private ColumnHeader LIST_GRADE1;
        private ColumnHeader LIST_GRADE2;
        private ColumnHeader LIST_GRADE3;
        private ColumnHeader LIST_GRADE_SCORE;
        private ColumnHeader LIST_GRADE_AVERAGE;
        private Button btn_modify;
        private Button btn_remove;
        private Button button_LOAD;
        private Label label7;
        private TextBox SEARCH_NUMBER;
    }
}