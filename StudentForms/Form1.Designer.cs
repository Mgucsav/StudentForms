namespace StudentForms
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcStudents = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbtnE = new System.Windows.Forms.RadioButton();
            this.rbtnK = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxNumbersDelete = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.txtNumberUpdate = new System.Windows.Forms.TextBox();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnAddLessonToStudent = new System.Windows.Forms.Button();
            this.cbxLessonsAddOperaton = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNumberLessonsOperation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.cbxLessonDelete = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxNumberLessonDelete = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvLessons = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxNumbersForLesson = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpUpdateBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbcStudents.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcStudents
            // 
            this.tbcStudents.Controls.Add(this.tabPage1);
            this.tbcStudents.Controls.Add(this.tabPage2);
            this.tbcStudents.Controls.Add(this.tabPage3);
            this.tbcStudents.Controls.Add(this.tabPage4);
            this.tbcStudents.Controls.Add(this.tabPage5);
            this.tbcStudents.Controls.Add(this.tabPage6);
            this.tbcStudents.Location = new System.Drawing.Point(12, 12);
            this.tbcStudents.Name = "tbcStudents";
            this.tbcStudents.SelectedIndex = 0;
            this.tbcStudents.Size = new System.Drawing.Size(667, 248);
            this.tbcStudents.TabIndex = 0;
            this.tbcStudents.SelectedIndexChanged += new System.EventHandler(this.tbcStudents_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rbtnE);
            this.tabPage1.Controls.Add(this.rbtnK);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dtpBirthDate);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtNumber);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(659, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Students ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbtnE
            // 
            this.rbtnE.AutoSize = true;
            this.rbtnE.Checked = true;
            this.rbtnE.Location = new System.Drawing.Point(295, 103);
            this.rbtnE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnE.Name = "rbtnE";
            this.rbtnE.Size = new System.Drawing.Size(32, 17);
            this.rbtnE.TabIndex = 8;
            this.rbtnE.TabStop = true;
            this.rbtnE.Text = "E";
            this.rbtnE.UseVisualStyleBackColor = true;
            // 
            // rbtnK
            // 
            this.rbtnK.AutoSize = true;
            this.rbtnK.Location = new System.Drawing.Point(295, 84);
            this.rbtnK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnK.Name = "rbtnK";
            this.rbtnK.Size = new System.Drawing.Size(32, 17);
            this.rbtnK.TabIndex = 7;
            this.rbtnK.Text = "K";
            this.rbtnK.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Birth Date: ";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(355, 44);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(210, 20);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(111, 81);
            this.txtNumber.MaxLength = 10;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 45);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbxNumbersDelete);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(659, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbxNumbersDelete
            // 
            this.cbxNumbersDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumbersDelete.FormattingEnabled = true;
            this.cbxNumbersDelete.Location = new System.Drawing.Point(94, 28);
            this.cbxNumbersDelete.Name = "cbxNumbersDelete";
            this.cbxNumbersDelete.Size = new System.Drawing.Size(121, 21);
            this.cbxNumbersDelete.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(140, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.dtpUpdateBirthDate);
            this.tabPage3.Controls.Add(this.btnUpdateStudent);
            this.tabPage3.Controls.Add(this.txtNumberUpdate);
            this.tabPage3.Controls.Add(this.txtNameUpdate);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.dgvStudents);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(659, 222);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "List Strudents";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(530, 55);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStudent.TabIndex = 9;
            this.btnUpdateStudent.Text = "Update";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // txtNumberUpdate
            // 
            this.txtNumberUpdate.Location = new System.Drawing.Point(234, 51);
            this.txtNumberUpdate.MaxLength = 10;
            this.txtNumberUpdate.Name = "txtNumberUpdate";
            this.txtNumberUpdate.ReadOnly = true;
            this.txtNumberUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtNumberUpdate.TabIndex = 8;
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(234, 15);
            this.txtNameUpdate.MaxLength = 100;
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtNameUpdate.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Name: ";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(22, 98);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 62;
            this.dgvStudents.Size = new System.Drawing.Size(599, 99);
            this.dgvStudents.TabIndex = 1;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnAddLessonToStudent);
            this.tabPage4.Controls.Add(this.cbxLessonsAddOperaton);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.cbxNumberLessonsOperation);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(659, 222);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Lessons to Students";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnAddLessonToStudent
            // 
            this.btnAddLessonToStudent.Location = new System.Drawing.Point(307, 94);
            this.btnAddLessonToStudent.Name = "btnAddLessonToStudent";
            this.btnAddLessonToStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddLessonToStudent.TabIndex = 12;
            this.btnAddLessonToStudent.Text = "Add";
            this.btnAddLessonToStudent.UseVisualStyleBackColor = true;
            this.btnAddLessonToStudent.Click += new System.EventHandler(this.btnAddLessonToStudent_Click);
            // 
            // cbxLessonsAddOperaton
            // 
            this.cbxLessonsAddOperaton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLessonsAddOperaton.FormattingEnabled = true;
            this.cbxLessonsAddOperaton.Location = new System.Drawing.Point(261, 54);
            this.cbxLessonsAddOperaton.Name = "cbxLessonsAddOperaton";
            this.cbxLessonsAddOperaton.Size = new System.Drawing.Size(121, 21);
            this.cbxLessonsAddOperaton.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lessons: ";
            // 
            // cbxNumberLessonsOperation
            // 
            this.cbxNumberLessonsOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumberLessonsOperation.FormattingEnabled = true;
            this.cbxNumberLessonsOperation.Location = new System.Drawing.Point(261, 16);
            this.cbxNumberLessonsOperation.Name = "cbxNumberLessonsOperation";
            this.cbxNumberLessonsOperation.Size = new System.Drawing.Size(121, 21);
            this.cbxNumberLessonsOperation.TabIndex = 9;
            this.cbxNumberLessonsOperation.SelectedIndexChanged += new System.EventHandler(this.cbxNumberLessonsOperation_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnDeleteLesson);
            this.tabPage5.Controls.Add(this.cbxLessonDelete);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.cbxNumberLessonDelete);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage5.Size = new System.Drawing.Size(659, 222);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Delete Lessons from Students";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.Location = new System.Drawing.Point(277, 95);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLesson.TabIndex = 17;
            this.btnDeleteLesson.Text = "Delete";
            this.btnDeleteLesson.UseVisualStyleBackColor = true;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
            // 
            // cbxLessonDelete
            // 
            this.cbxLessonDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLessonDelete.FormattingEnabled = true;
            this.cbxLessonDelete.Location = new System.Drawing.Point(231, 55);
            this.cbxLessonDelete.Name = "cbxLessonDelete";
            this.cbxLessonDelete.Size = new System.Drawing.Size(121, 21);
            this.cbxLessonDelete.TabIndex = 16;
            this.cbxLessonDelete.SelectedIndexChanged += new System.EventHandler(this.cbxLessonDelete_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lessons: ";
            // 
            // cbxNumberLessonDelete
            // 
            this.cbxNumberLessonDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumberLessonDelete.FormattingEnabled = true;
            this.cbxNumberLessonDelete.Location = new System.Drawing.Point(231, 17);
            this.cbxNumberLessonDelete.Name = "cbxNumberLessonDelete";
            this.cbxNumberLessonDelete.Size = new System.Drawing.Size(121, 21);
            this.cbxNumberLessonDelete.TabIndex = 14;
            this.cbxNumberLessonDelete.SelectedIndexChanged += new System.EventHandler(this.cbxNumberLessonDelete_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Number:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dgvLessons);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.cbxNumbersForLesson);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage6.Size = new System.Drawing.Size(659, 222);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "List Lessons of Students";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvLessons
            // 
            this.dgvLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLessons.Location = new System.Drawing.Point(83, 52);
            this.dgvLessons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLessons.Name = "dgvLessons";
            this.dgvLessons.RowHeadersWidth = 62;
            this.dgvLessons.RowTemplate.Height = 28;
            this.dgvLessons.Size = new System.Drawing.Size(489, 154);
            this.dgvLessons.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Number:";
            // 
            // cbxNumbersForLesson
            // 
            this.cbxNumbersForLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumbersForLesson.FormattingEnabled = true;
            this.cbxNumbersForLesson.Location = new System.Drawing.Point(244, 16);
            this.cbxNumbersForLesson.Name = "cbxNumbersForLesson";
            this.cbxNumbersForLesson.Size = new System.Drawing.Size(121, 21);
            this.cbxNumbersForLesson.TabIndex = 0;
            this.cbxNumbersForLesson.SelectedIndexChanged += new System.EventHandler(this.cbxNumbersForLesson_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(368, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Birth Date: ";
            // 
            // dtpUpdateBirthDate
            // 
            this.dtpUpdateBirthDate.Location = new System.Drawing.Point(432, 19);
            this.dtpUpdateBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpUpdateBirthDate.Name = "dtpUpdateBirthDate";
            this.dtpUpdateBirthDate.Size = new System.Drawing.Size(210, 20);
            this.dtpUpdateBirthDate.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 273);
            this.Controls.Add(this.tbcStudents);
            this.Name = "Form1";
            this.Text = "University App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tbcStudents.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcStudents;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNumbersDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddLessonToStudent;
        private System.Windows.Forms.ComboBox cbxLessonsAddOperaton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNumberLessonsOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteLesson;
        private System.Windows.Forms.ComboBox cbxLessonDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxNumberLessonDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxNumbersForLesson;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvLessons;
        private System.Windows.Forms.RadioButton rbtnE;
        private System.Windows.Forms.RadioButton rbtnK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.TextBox txtNumberUpdate;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpUpdateBirthDate;
    }
}

