namespace View.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LB_Themes = new System.Windows.Forms.ListBox();
            this.L_Theme = new System.Windows.Forms.Label();
            this.L_TotalQCountInTheme = new System.Windows.Forms.Label();
            this.L_TotalQCountInTheme_A = new System.Windows.Forms.Label();
            this.L_QuestionsInTheme = new System.Windows.Forms.Label();
            this.L_Time = new System.Windows.Forms.Label();
            this.TB_Time = new System.Windows.Forms.TextBox();
            this.L_TotalQuestCount = new System.Windows.Forms.Label();
            this.L_TotalQuestionsCount_A = new System.Windows.Forms.Label();
            this.TB_QuestionInThemeInTest = new System.Windows.Forms.TextBox();
            this.B_SetTime = new System.Windows.Forms.Button();
            this.B_SetQCount = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.L_Question = new System.Windows.Forms.Label();
            this.LB_Questions = new System.Windows.Forms.ListBox();
            this.B_AddQuestion = new System.Windows.Forms.Button();
            this.B_ChangeQuestionName = new System.Windows.Forms.Button();
            this.B_DeleteQuestion = new System.Windows.Forms.Button();
            this.TB_Question = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.L_Answer = new System.Windows.Forms.Label();
            this.B_ChangeAnswer1 = new System.Windows.Forms.Button();
            this.B_ChangeAnswer2 = new System.Windows.Forms.Button();
            this.B_ChangeAnswer3 = new System.Windows.Forms.Button();
            this.B_ChangeAnswer4 = new System.Windows.Forms.Button();
            this.RB_A1 = new System.Windows.Forms.RadioButton();
            this.RB_A2 = new System.Windows.Forms.RadioButton();
            this.RB_A3 = new System.Windows.Forms.RadioButton();
            this.RB_A4 = new System.Windows.Forms.RadioButton();
            this.TB_A1 = new System.Windows.Forms.TextBox();
            this.TB_A2 = new System.Windows.Forms.TextBox();
            this.TB_A3 = new System.Windows.Forms.TextBox();
            this.TB_A4 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLocalDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadAndOpenDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndSendDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEFRESHITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1288, 617);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.LB_Themes, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.L_Theme, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.L_TotalQCountInTheme, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.L_TotalQCountInTheme_A, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.L_QuestionsInTheme, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.L_Time, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.TB_Time, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.L_TotalQuestCount, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.L_TotalQuestionsCount_A, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.TB_QuestionInThemeInTest, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.B_SetTime, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.B_SetQCount, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(316, 611);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // LB_Themes
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.LB_Themes, 2);
            this.LB_Themes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Themes.Enabled = false;
            this.LB_Themes.FormattingEnabled = true;
            this.LB_Themes.ItemHeight = 16;
            this.LB_Themes.Location = new System.Drawing.Point(3, 33);
            this.LB_Themes.Name = "LB_Themes";
            this.LB_Themes.Size = new System.Drawing.Size(310, 185);
            this.LB_Themes.TabIndex = 11;
            this.LB_Themes.SelectedIndexChanged += new System.EventHandler(this.LB_Themes_SelectedIndexChanged);
            // 
            // L_Theme
            // 
            this.L_Theme.AutoSize = true;
            this.L_Theme.Location = new System.Drawing.Point(3, 5);
            this.L_Theme.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.L_Theme.Name = "L_Theme";
            this.L_Theme.Size = new System.Drawing.Size(44, 17);
            this.L_Theme.TabIndex = 16;
            this.L_Theme.Text = "Темы";
            // 
            // L_TotalQCountInTheme
            // 
            this.L_TotalQCountInTheme.AutoSize = true;
            this.L_TotalQCountInTheme.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_TotalQCountInTheme.Location = new System.Drawing.Point(3, 226);
            this.L_TotalQCountInTheme.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.L_TotalQCountInTheme.Name = "L_TotalQCountInTheme";
            this.L_TotalQCountInTheme.Size = new System.Drawing.Size(161, 55);
            this.L_TotalQCountInTheme.TabIndex = 21;
            this.L_TotalQCountInTheme.Text = "Всего вопросов в теме:";
            this.L_TotalQCountInTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_TotalQCountInTheme_A
            // 
            this.L_TotalQCountInTheme_A.AutoSize = true;
            this.L_TotalQCountInTheme_A.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_TotalQCountInTheme_A.Location = new System.Drawing.Point(224, 226);
            this.L_TotalQCountInTheme_A.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.L_TotalQCountInTheme_A.Name = "L_TotalQCountInTheme_A";
            this.L_TotalQCountInTheme_A.Size = new System.Drawing.Size(16, 55);
            this.L_TotalQCountInTheme_A.TabIndex = 22;
            this.L_TotalQCountInTheme_A.Text = "0";
            this.L_TotalQCountInTheme_A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_QuestionsInTheme
            // 
            this.L_QuestionsInTheme.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.L_QuestionsInTheme, 2);
            this.L_QuestionsInTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_QuestionsInTheme.Location = new System.Drawing.Point(3, 286);
            this.L_QuestionsInTheme.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.L_QuestionsInTheme.Name = "L_QuestionsInTheme";
            this.L_QuestionsInTheme.Size = new System.Drawing.Size(310, 50);
            this.L_QuestionsInTheme.TabIndex = 23;
            this.L_QuestionsInTheme.Text = "Будет задано вопросов из темы:";
            this.L_QuestionsInTheme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // L_Time
            // 
            this.L_Time.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.L_Time, 2);
            this.L_Time.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.L_Time.Location = new System.Drawing.Point(3, 499);
            this.L_Time.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.L_Time.Name = "L_Time";
            this.L_Time.Size = new System.Drawing.Size(310, 17);
            this.L_Time.TabIndex = 20;
            this.L_Time.Text = "Времени на тест (сек):";
            this.L_Time.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TB_Time
            // 
            this.TB_Time.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_Time.Enabled = false;
            this.TB_Time.Location = new System.Drawing.Point(3, 526);
            this.TB_Time.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.TB_Time.Name = "TB_Time";
            this.TB_Time.Size = new System.Drawing.Size(215, 22);
            this.TB_Time.TabIndex = 8;
            this.TB_Time.TextChanged += new System.EventHandler(this.TB_Time_TextChanged);
            // 
            // L_TotalQuestCount
            // 
            this.L_TotalQuestCount.AutoSize = true;
            this.L_TotalQuestCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_TotalQuestCount.Location = new System.Drawing.Point(3, 406);
            this.L_TotalQuestCount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.L_TotalQuestCount.Name = "L_TotalQuestCount";
            this.L_TotalQuestCount.Size = new System.Drawing.Size(166, 55);
            this.L_TotalQuestCount.TabIndex = 18;
            this.L_TotalQuestCount.Text = "Всего вопросов в тесте:";
            this.L_TotalQuestCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // L_TotalQuestionsCount_A
            // 
            this.L_TotalQuestionsCount_A.AutoSize = true;
            this.L_TotalQuestionsCount_A.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_TotalQuestionsCount_A.Location = new System.Drawing.Point(224, 406);
            this.L_TotalQuestionsCount_A.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.L_TotalQuestionsCount_A.Name = "L_TotalQuestionsCount_A";
            this.L_TotalQuestionsCount_A.Size = new System.Drawing.Size(16, 55);
            this.L_TotalQuestionsCount_A.TabIndex = 19;
            this.L_TotalQuestionsCount_A.Text = "0";
            this.L_TotalQuestionsCount_A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TB_QuestionInThemeInTest
            // 
            this.TB_QuestionInThemeInTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.TB_QuestionInThemeInTest.Enabled = false;
            this.TB_QuestionInThemeInTest.Location = new System.Drawing.Point(3, 346);
            this.TB_QuestionInThemeInTest.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.TB_QuestionInThemeInTest.Name = "TB_QuestionInThemeInTest";
            this.TB_QuestionInThemeInTest.Size = new System.Drawing.Size(215, 22);
            this.TB_QuestionInThemeInTest.TabIndex = 24;
            this.TB_QuestionInThemeInTest.TextChanged += new System.EventHandler(this.TB_QuestionInThemeInTest_TextChanged);
            // 
            // B_SetTime
            // 
            this.B_SetTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_SetTime.Enabled = false;
            this.B_SetTime.Location = new System.Drawing.Point(224, 526);
            this.B_SetTime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.B_SetTime.Name = "B_SetTime";
            this.B_SetTime.Size = new System.Drawing.Size(89, 30);
            this.B_SetTime.TabIndex = 25;
            this.B_SetTime.Text = "Изменить";
            this.B_SetTime.UseVisualStyleBackColor = true;
            this.B_SetTime.Click += new System.EventHandler(this.B_SetTime_Click);
            // 
            // B_SetQCount
            // 
            this.B_SetQCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_SetQCount.Enabled = false;
            this.B_SetQCount.Location = new System.Drawing.Point(224, 346);
            this.B_SetQCount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.B_SetQCount.Name = "B_SetQCount";
            this.B_SetQCount.Size = new System.Drawing.Size(89, 30);
            this.B_SetQCount.TabIndex = 26;
            this.B_SetQCount.Text = "Изменить";
            this.B_SetQCount.UseVisualStyleBackColor = true;
            this.B_SetQCount.Click += new System.EventHandler(this.B_SetQCount_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.L_Question, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LB_Questions, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.B_AddQuestion, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.B_ChangeQuestionName, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.B_DeleteQuestion, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.TB_Question, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(325, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(380, 611);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // L_Question
            // 
            this.L_Question.AutoSize = true;
            this.L_Question.Location = new System.Drawing.Point(3, 5);
            this.L_Question.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.L_Question.Name = "L_Question";
            this.L_Question.Size = new System.Drawing.Size(66, 17);
            this.L_Question.TabIndex = 17;
            this.L_Question.Text = "Вопросы";
            // 
            // LB_Questions
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.LB_Questions, 3);
            this.LB_Questions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Questions.Enabled = false;
            this.LB_Questions.FormattingEnabled = true;
            this.LB_Questions.ItemHeight = 16;
            this.LB_Questions.Location = new System.Drawing.Point(3, 33);
            this.LB_Questions.Name = "LB_Questions";
            this.LB_Questions.Size = new System.Drawing.Size(374, 295);
            this.LB_Questions.TabIndex = 15;
            this.LB_Questions.SelectedIndexChanged += new System.EventHandler(this.LB_Questions_SelectedIndexChanged);
            // 
            // B_AddQuestion
            // 
            this.B_AddQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_AddQuestion.Enabled = false;
            this.B_AddQuestion.Location = new System.Drawing.Point(5, 465);
            this.B_AddQuestion.Margin = new System.Windows.Forms.Padding(5);
            this.B_AddQuestion.Name = "B_AddQuestion";
            this.B_AddQuestion.Size = new System.Drawing.Size(116, 50);
            this.B_AddQuestion.TabIndex = 12;
            this.B_AddQuestion.Text = "Добавить";
            this.B_AddQuestion.UseVisualStyleBackColor = true;
            this.B_AddQuestion.Click += new System.EventHandler(this.B_AddQuestion_Click);
            // 
            // B_ChangeQuestionName
            // 
            this.B_ChangeQuestionName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_ChangeQuestionName.Enabled = false;
            this.B_ChangeQuestionName.Location = new System.Drawing.Point(131, 465);
            this.B_ChangeQuestionName.Margin = new System.Windows.Forms.Padding(5);
            this.B_ChangeQuestionName.Name = "B_ChangeQuestionName";
            this.B_ChangeQuestionName.Size = new System.Drawing.Size(116, 50);
            this.B_ChangeQuestionName.TabIndex = 13;
            this.B_ChangeQuestionName.Text = "Изменить";
            this.B_ChangeQuestionName.UseVisualStyleBackColor = true;
            this.B_ChangeQuestionName.Click += new System.EventHandler(this.B_ChangeQuestionName_Click);
            // 
            // B_DeleteQuestion
            // 
            this.B_DeleteQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_DeleteQuestion.Enabled = false;
            this.B_DeleteQuestion.Location = new System.Drawing.Point(257, 465);
            this.B_DeleteQuestion.Margin = new System.Windows.Forms.Padding(5);
            this.B_DeleteQuestion.Name = "B_DeleteQuestion";
            this.B_DeleteQuestion.Size = new System.Drawing.Size(118, 50);
            this.B_DeleteQuestion.TabIndex = 14;
            this.B_DeleteQuestion.Text = "Удалить";
            this.B_DeleteQuestion.UseVisualStyleBackColor = true;
            this.B_DeleteQuestion.Click += new System.EventHandler(this.B_DeleteQuestion_Click);
            // 
            // TB_Question
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.TB_Question, 3);
            this.TB_Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Question.Enabled = false;
            this.TB_Question.Location = new System.Drawing.Point(3, 336);
            this.TB_Question.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_Question.Multiline = true;
            this.TB_Question.Name = "TB_Question";
            this.TB_Question.Size = new System.Drawing.Size(374, 119);
            this.TB_Question.TabIndex = 18;
            this.TB_Question.TextChanged += new System.EventHandler(this.TB_Question_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel4.Controls.Add(this.L_Answer, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.B_ChangeAnswer1, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.B_ChangeAnswer2, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.B_ChangeAnswer3, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.B_ChangeAnswer4, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.RB_A1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.RB_A2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.RB_A3, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.RB_A4, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.TB_A1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.TB_A2, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.TB_A3, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.TB_A4, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(711, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(574, 611);
            this.tableLayoutPanel4.TabIndex = 27;
            // 
            // L_Answer
            // 
            this.L_Answer.AutoSize = true;
            this.L_Answer.Location = new System.Drawing.Point(3, 5);
            this.L_Answer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.L_Answer.Name = "L_Answer";
            this.L_Answer.Size = new System.Drawing.Size(58, 17);
            this.L_Answer.TabIndex = 0;
            this.L_Answer.Text = "Ответы";
            // 
            // B_ChangeAnswer1
            // 
            this.B_ChangeAnswer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_ChangeAnswer1.Enabled = false;
            this.B_ChangeAnswer1.Location = new System.Drawing.Point(447, 35);
            this.B_ChangeAnswer1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.B_ChangeAnswer1.Name = "B_ChangeAnswer1";
            this.B_ChangeAnswer1.Size = new System.Drawing.Size(124, 45);
            this.B_ChangeAnswer1.TabIndex = 1;
            this.B_ChangeAnswer1.Text = "Сохранить изменения";
            this.B_ChangeAnswer1.UseVisualStyleBackColor = true;
            this.B_ChangeAnswer1.Click += new System.EventHandler(this.B_ChangeAnswer1_Click);
            // 
            // B_ChangeAnswer2
            // 
            this.B_ChangeAnswer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_ChangeAnswer2.Enabled = false;
            this.B_ChangeAnswer2.Location = new System.Drawing.Point(447, 172);
            this.B_ChangeAnswer2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.B_ChangeAnswer2.Name = "B_ChangeAnswer2";
            this.B_ChangeAnswer2.Size = new System.Drawing.Size(124, 45);
            this.B_ChangeAnswer2.TabIndex = 2;
            this.B_ChangeAnswer2.Text = "Сохранить изменения";
            this.B_ChangeAnswer2.UseVisualStyleBackColor = true;
            this.B_ChangeAnswer2.Click += new System.EventHandler(this.B_ChangeAnswer2_Click);
            // 
            // B_ChangeAnswer3
            // 
            this.B_ChangeAnswer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_ChangeAnswer3.Enabled = false;
            this.B_ChangeAnswer3.Location = new System.Drawing.Point(447, 309);
            this.B_ChangeAnswer3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.B_ChangeAnswer3.Name = "B_ChangeAnswer3";
            this.B_ChangeAnswer3.Size = new System.Drawing.Size(124, 45);
            this.B_ChangeAnswer3.TabIndex = 3;
            this.B_ChangeAnswer3.Text = "Сохранить изменения";
            this.B_ChangeAnswer3.UseVisualStyleBackColor = true;
            this.B_ChangeAnswer3.Click += new System.EventHandler(this.B_ChangeAnswer3_Click);
            // 
            // B_ChangeAnswer4
            // 
            this.B_ChangeAnswer4.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_ChangeAnswer4.Enabled = false;
            this.B_ChangeAnswer4.Location = new System.Drawing.Point(447, 446);
            this.B_ChangeAnswer4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.B_ChangeAnswer4.Name = "B_ChangeAnswer4";
            this.B_ChangeAnswer4.Size = new System.Drawing.Size(124, 45);
            this.B_ChangeAnswer4.TabIndex = 4;
            this.B_ChangeAnswer4.Text = "Сохранить изменения";
            this.B_ChangeAnswer4.UseVisualStyleBackColor = true;
            this.B_ChangeAnswer4.Click += new System.EventHandler(this.B_ChangeAnswer4_Click);
            // 
            // RB_A1
            // 
            this.RB_A1.AutoSize = true;
            this.RB_A1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_A1.Enabled = false;
            this.RB_A1.Location = new System.Drawing.Point(3, 35);
            this.RB_A1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.RB_A1.Name = "RB_A1";
            this.RB_A1.Size = new System.Drawing.Size(74, 129);
            this.RB_A1.TabIndex = 5;
            this.RB_A1.TabStop = true;
            this.RB_A1.Text = "Верно";
            this.RB_A1.UseVisualStyleBackColor = true;
            this.RB_A1.Click += new System.EventHandler(this.RB_A1_Click);
            // 
            // RB_A2
            // 
            this.RB_A2.AutoSize = true;
            this.RB_A2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_A2.Enabled = false;
            this.RB_A2.Location = new System.Drawing.Point(3, 172);
            this.RB_A2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.RB_A2.Name = "RB_A2";
            this.RB_A2.Size = new System.Drawing.Size(74, 129);
            this.RB_A2.TabIndex = 6;
            this.RB_A2.TabStop = true;
            this.RB_A2.Text = "Верно";
            this.RB_A2.UseVisualStyleBackColor = true;
            this.RB_A2.Click += new System.EventHandler(this.RB_A2_Click);
            // 
            // RB_A3
            // 
            this.RB_A3.AutoSize = true;
            this.RB_A3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_A3.Enabled = false;
            this.RB_A3.Location = new System.Drawing.Point(3, 309);
            this.RB_A3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.RB_A3.Name = "RB_A3";
            this.RB_A3.Size = new System.Drawing.Size(74, 129);
            this.RB_A3.TabIndex = 7;
            this.RB_A3.TabStop = true;
            this.RB_A3.Text = "Верно";
            this.RB_A3.UseVisualStyleBackColor = true;
            this.RB_A3.Click += new System.EventHandler(this.RB_A3_Click);
            // 
            // RB_A4
            // 
            this.RB_A4.AutoSize = true;
            this.RB_A4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_A4.Enabled = false;
            this.RB_A4.Location = new System.Drawing.Point(3, 446);
            this.RB_A4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.RB_A4.Name = "RB_A4";
            this.RB_A4.Size = new System.Drawing.Size(74, 129);
            this.RB_A4.TabIndex = 8;
            this.RB_A4.TabStop = true;
            this.RB_A4.Text = "Верно";
            this.RB_A4.UseVisualStyleBackColor = true;
            this.RB_A4.Click += new System.EventHandler(this.RB_A4_Click);
            // 
            // TB_A1
            // 
            this.TB_A1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_A1.Enabled = false;
            this.TB_A1.Location = new System.Drawing.Point(83, 35);
            this.TB_A1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_A1.Multiline = true;
            this.TB_A1.Name = "TB_A1";
            this.TB_A1.Size = new System.Drawing.Size(358, 127);
            this.TB_A1.TabIndex = 9;
            this.TB_A1.TextChanged += new System.EventHandler(this.TB_A1_TextChanged);
            // 
            // TB_A2
            // 
            this.TB_A2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_A2.Enabled = false;
            this.TB_A2.Location = new System.Drawing.Point(83, 172);
            this.TB_A2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_A2.Multiline = true;
            this.TB_A2.Name = "TB_A2";
            this.TB_A2.Size = new System.Drawing.Size(358, 127);
            this.TB_A2.TabIndex = 10;
            this.TB_A2.TextChanged += new System.EventHandler(this.TB_A2_TextChanged);
            // 
            // TB_A3
            // 
            this.TB_A3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_A3.Enabled = false;
            this.TB_A3.Location = new System.Drawing.Point(83, 309);
            this.TB_A3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_A3.Multiline = true;
            this.TB_A3.Name = "TB_A3";
            this.TB_A3.Size = new System.Drawing.Size(358, 127);
            this.TB_A3.TabIndex = 11;
            this.TB_A3.TextChanged += new System.EventHandler(this.TB_A3_TextChanged);
            // 
            // TB_A4
            // 
            this.TB_A4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_A4.Enabled = false;
            this.TB_A4.Location = new System.Drawing.Point(83, 446);
            this.TB_A4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TB_A4.Multiline = true;
            this.TB_A4.Name = "TB_A4";
            this.TB_A4.Size = new System.Drawing.Size(358, 127);
            this.TB_A4.TabIndex = 12;
            this.TB_A4.TextChanged += new System.EventHandler(this.TB_A4_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1288, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLocalDBToolStripMenuItem,
            this.downloadAndOpenDBToolStripMenuItem,
            this.saveDBToolStripMenuItem,
            this.saveAndSendDBToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // openLocalDBToolStripMenuItem
            // 
            this.openLocalDBToolStripMenuItem.Name = "openLocalDBToolStripMenuItem";
            this.openLocalDBToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.openLocalDBToolStripMenuItem.Text = "Открыть локальный файл";
            this.openLocalDBToolStripMenuItem.Click += new System.EventHandler(this.openLocalDBToolStripMenuItem_Click);
            // 
            // downloadAndOpenDBToolStripMenuItem
            // 
            this.downloadAndOpenDBToolStripMenuItem.Name = "downloadAndOpenDBToolStripMenuItem";
            this.downloadAndOpenDBToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.downloadAndOpenDBToolStripMenuItem.Text = "Загрузить и открыть файл";
            this.downloadAndOpenDBToolStripMenuItem.Click += new System.EventHandler(this.downloadAndOpenDBToolStripMenuItem_Click);
            // 
            // saveDBToolStripMenuItem
            // 
            this.saveDBToolStripMenuItem.Enabled = false;
            this.saveDBToolStripMenuItem.Name = "saveDBToolStripMenuItem";
            this.saveDBToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.saveDBToolStripMenuItem.Text = "Сохранить файл";
            this.saveDBToolStripMenuItem.Click += new System.EventHandler(this.saveDBToolStripMenuItem_Click);
            // 
            // saveAndSendDBToolStripMenuItem
            // 
            this.saveAndSendDBToolStripMenuItem.Enabled = false;
            this.saveAndSendDBToolStripMenuItem.Name = "saveAndSendDBToolStripMenuItem";
            this.saveAndSendDBToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.saveAndSendDBToolStripMenuItem.Text = "Сохранить и отправить файл";
            this.saveAndSendDBToolStripMenuItem.Click += new System.EventHandler(this.saveAndSendDBToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Enabled = false;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.ToolStripMenuItem.Text = "Обновить";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Enabled = false;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.infoToolStripMenuItem.Text = "Изменить Инфо";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // rEFRESHITToolStripMenuItem
            // 
            this.rEFRESHITToolStripMenuItem.Name = "rEFRESHITToolStripMenuItem";
            this.rEFRESHITToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 645);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "MainForm";
            this.Text = "TOF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TB_Time;
        private System.Windows.Forms.ListBox LB_Themes;
        private System.Windows.Forms.Button B_AddQuestion;
        private System.Windows.Forms.Button B_ChangeQuestionName;
        private System.Windows.Forms.Button B_DeleteQuestion;
        private System.Windows.Forms.ListBox LB_Questions;
        private System.Windows.Forms.Label L_Theme;
        private System.Windows.Forms.Label L_Question;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.Label L_TotalQuestCount;
        private System.Windows.Forms.Label L_TotalQuestionsCount_A;
        private System.Windows.Forms.Label L_Time;
        private System.Windows.Forms.Label L_TotalQCountInTheme;
        private System.Windows.Forms.Label L_TotalQCountInTheme_A;
        private System.Windows.Forms.Label L_QuestionsInTheme;
        private System.Windows.Forms.TextBox TB_QuestionInThemeInTest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label L_Answer;
        private System.Windows.Forms.Button B_ChangeAnswer1;
        private System.Windows.Forms.Button B_ChangeAnswer2;
        private System.Windows.Forms.Button B_ChangeAnswer3;
        private System.Windows.Forms.Button B_ChangeAnswer4;
        private System.Windows.Forms.RadioButton RB_A1;
        private System.Windows.Forms.RadioButton RB_A2;
        private System.Windows.Forms.RadioButton RB_A3;
        private System.Windows.Forms.RadioButton RB_A4;
        private System.Windows.Forms.TextBox TB_A1;
        private System.Windows.Forms.TextBox TB_A2;
        private System.Windows.Forms.TextBox TB_A3;
        private System.Windows.Forms.TextBox TB_A4;
        private System.Windows.Forms.TextBox TB_Question;
        private System.Windows.Forms.Button B_SetTime;
        private System.Windows.Forms.Button B_SetQCount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEFRESHITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openLocalDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadAndOpenDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAndSendDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}