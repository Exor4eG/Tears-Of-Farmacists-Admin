using System;
using System.Linq;
using System.Windows.Forms;
using Presenter.Common;
using Presenter.Views;

namespace View.Forms
{
    public partial class MainForm : Form, IMainForm
    {
        bool saveFlag = false;
        int? IdT = null;
        int? IdQ = null;
        RequestResult _requestResult;
        public event Func<int?, int?, RequestResult> RefreshData;
        public event Func<int, int, RequestResult> UpdateQCount;
        public event Func<int, RequestResult> UpdateTime;
        public event Func<int, int, string, RequestResult> UpdateQuestion;
        public event Func<int, int, RequestResult> AddQuestion;
        public event Func<int, int, RequestResult> DeleteQuestion;
        public event Func<int, int, int, string, RequestResult> UpdateAnswer;
        public event Func<int, int, int, RequestResult> UpdateIsTrue;
        public event Func<string, RequestResult> UpdateInfo;
        public event Func<bool> OpenLocalFile;
        public event Func<bool> DownloadOpenFile;
        public event Func<bool> SaveFile;
        public event Func<bool> SaveSendFile;

        public MainForm()
        {
            InitializeComponent();
        }

        public void RefreshView()
        {
            L_TotalQuestionsCount_A.Text = _requestResult.totalQCount.ToString();
            LB_Themes.Items.Clear();
            LB_Themes.Items.AddRange(_requestResult.themes.ToArray());
            TB_Time.Text = _requestResult.time.ToString();
            B_SetTime.Enabled = false;
            if (IdT != null)
            {
                LB_Themes.SelectedIndex = (int)IdT;
                L_TotalQCountInTheme_A.Text = _requestResult.totalQCount4t.ToString();
                TB_QuestionInThemeInTest.Text = _requestResult.QCount4t.ToString();
                TB_QuestionInThemeInTest.Enabled = true;
                B_SetQCount.Enabled = false;
                LB_Questions.Items.Clear();
                if (_requestResult.questions != null)
                    LB_Questions.Items.AddRange(_requestResult.questions.ToArray());
                LB_Questions.Enabled = true;
                B_AddQuestion.Enabled = true;
                B_ChangeAnswer1.Enabled = B_ChangeAnswer2.Enabled = B_ChangeAnswer3.Enabled = B_ChangeAnswer4.Enabled = false;
            }
            else
            {
                DisableAll();
            }
            if (IdQ != null)
            {
                LB_Questions.SelectedIndex = (int)IdQ;
                TB_Question.Text = _requestResult.question;
                TB_Question.Enabled = true;
                B_DeleteQuestion.Enabled = true;
                TB_A1.Enabled = TB_A2.Enabled = TB_A3.Enabled = TB_A4.Enabled = true;
                TB_A1.Text = _requestResult.answers.ElementAt(0);
                TB_A2.Text = _requestResult.answers.ElementAt(1);
                TB_A3.Text = _requestResult.answers.ElementAt(2);
                TB_A4.Text = _requestResult.answers.ElementAt(3);
                RB_A1.Enabled = RB_A2.Enabled = RB_A3.Enabled = RB_A4.Enabled = true;
                if (_requestResult.isTrue.ElementAt(0))
                    RB_A1.Checked = true;
                if (_requestResult.isTrue.ElementAt(1))
                    RB_A2.Checked = true;
                if (_requestResult.isTrue.ElementAt(2))
                    RB_A3.Checked = true;
                if (_requestResult.isTrue.ElementAt(3))
                    RB_A4.Checked = true;
                B_ChangeAnswer1.Enabled = B_ChangeAnswer2.Enabled = B_ChangeAnswer3.Enabled = B_ChangeAnswer4.Enabled = false;
            }
            else
            {
                DisableQuestionItems();
            }
        }

        private void ShowComponent()
        {
            LB_Themes.Enabled = true;
            TB_Time.Enabled = true;
            TB_QuestionInThemeInTest.Enabled = true;
            ToolStripMenuItem.Enabled = true;
            infoToolStripMenuItem.Enabled = true;
            saveDBToolStripMenuItem.Enabled = true;
            saveAndSendDBToolStripMenuItem.Enabled = true;
        }

        private void DisableAll()
        {
            TB_QuestionInThemeInTest.Enabled = false;
            TB_QuestionInThemeInTest.Text = string.Empty;
            B_SetQCount.Enabled = false;
            LB_Questions.Enabled = false;
            LB_Questions.Items.Clear();
            DisableQuestionItems();
            B_AddQuestion.Enabled = false;
        }

        private void DisableQuestionItems()
        {
            B_DeleteQuestion.Enabled = false;
            TB_Question.Enabled = false;
            TB_Question.Text = string.Empty;
            B_ChangeQuestionName.Enabled = false;
            TB_A1.Enabled = TB_A2.Enabled = TB_A3.Enabled = TB_A4.Enabled = false;
            TB_A1.Text = TB_A2.Text = TB_A3.Text = TB_A4.Text = string.Empty;
            RB_A1.Enabled = RB_A2.Enabled = RB_A3.Enabled = RB_A4.Enabled = false;
            B_ChangeAnswer1.Enabled = B_ChangeAnswer2.Enabled = B_ChangeAnswer3.Enabled = B_ChangeAnswer4.Enabled = false;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void LB_Themes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdT != LB_Themes.SelectedIndex && LB_Themes.SelectedIndex != -1)
            {
                IdT = LB_Themes.SelectedIndex;
                IdQ = null;
                _requestResult = RefreshData(IdT, IdQ);
                RefreshView();
            }
        }

        private void LB_Questions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdQ != LB_Questions.SelectedIndex && LB_Questions.SelectedIndex != -1)
            {
                IdQ = LB_Questions.SelectedIndex;
                _requestResult = RefreshData(IdT, IdQ);
                RB_A1.Checked = RB_A2.Checked = RB_A3.Checked = RB_A4.Checked = false;
                RefreshView();
                B_ChangeQuestionName.Enabled = false;
            }
        }

        private void B_SetQCount_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = Convert.ToInt32(TB_QuestionInThemeInTest.Text);
                if (x < 0 || x > _requestResult.questions.Count)
                    throw new Exception();
                _requestResult = UpdateQCount((int)IdT, x);
                saveFlag = true;
            }
            catch
            {
                MessageBox.Show("Неверные данные в поле установки количества вопросов из темы", "Неверные данные");
            }
            IdQ = null;
            RefreshView();
            B_SetQCount.Enabled = false;
        }

        private void B_SetTime_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = Convert.ToInt32(TB_Time.Text);
                if (x < 1)
                    throw new Exception();
                _requestResult.time = x;
                UpdateTime(x);
                saveFlag = true;
            }
            catch
            {
                MessageBox.Show("Неверные данные в поле установки времени на прохождение теста", "Неверные данные");
            }
            RefreshView();
            B_SetTime.Enabled = false;
        }

        private void B_AddQuestion_Click(object sender, EventArgs e)
        {
            IdQ = LB_Questions.Items.Count;
            _requestResult = AddQuestion((int)IdT, (int)IdQ);
            RefreshView();
            B_ChangeQuestionName.Enabled = false;
            RB_A1.Checked = RB_A2.Checked = RB_A3.Checked = RB_A4.Checked = false;
            saveFlag = true;
        }

        private void TB_Question_TextChanged(object sender, EventArgs e)
        {
            B_ChangeQuestionName.Enabled = true;
        }

        private void B_ChangeQuestionName_Click(object sender, EventArgs e)
        {
            _requestResult = UpdateQuestion((int)IdT, (int)IdQ, TB_Question.Text);
            RefreshView();
            B_ChangeQuestionName.Enabled = false;
            saveFlag = true;
        }

        private void B_DeleteQuestion_Click(object sender, EventArgs e)
        {
            _requestResult = DeleteQuestion((int)IdT, (int)IdQ);
            IdQ = null;
            RefreshView();
            saveFlag = true;
        }

        private void SetTrue(int i)
        {
            _requestResult = UpdateIsTrue((int)IdT, (int)IdQ, i);
            saveFlag = true;
        }

        private void TB_A1_TextChanged(object sender, EventArgs e)
        {
            B_ChangeAnswer1.Enabled = true;
        }

        private void TB_A2_TextChanged(object sender, EventArgs e)
        {
            B_ChangeAnswer2.Enabled = true;
        }

        private void TB_A3_TextChanged(object sender, EventArgs e)
        {
            B_ChangeAnswer3.Enabled = true;
        }

        private void TB_A4_TextChanged(object sender, EventArgs e)
        {
            B_ChangeAnswer4.Enabled = true;
        }

        private void B_ChangeAnswer1_Click(object sender, EventArgs e)
        {
            ChangeAnswer(0, TB_A1.Text);
        }

        private void B_ChangeAnswer2_Click(object sender, EventArgs e)
        {
            ChangeAnswer(1, TB_A2.Text);
        }

        private void B_ChangeAnswer3_Click(object sender, EventArgs e)
        {
            ChangeAnswer(2, TB_A3.Text);
        }

        private void B_ChangeAnswer4_Click(object sender, EventArgs e)
        {
            ChangeAnswer(3, TB_A4.Text);
        }

        private void ChangeAnswer(int i, string s)
        {
            _requestResult = UpdateAnswer((int)IdT, (int)IdQ, i, s);
            RefreshView();
            saveFlag = true;
        }

        private void TB_QuestionInThemeInTest_TextChanged(object sender, EventArgs e)
        {
            B_SetQCount.Enabled = true;
        }

        private void TB_Time_TextChanged(object sender, EventArgs e)
        {
            B_SetTime.Enabled = true;
        }

        private void RB_A1_Click(object sender, EventArgs e)
        {
            SetTrue(0);
        }

        private void RB_A2_Click(object sender, EventArgs e)
        {
            SetTrue(1);
        }

        private void RB_A3_Click(object sender, EventArgs e)
        {
            SetTrue(2);
        }

        private void RB_A4_Click(object sender, EventArgs e)
        {
            SetTrue(3);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InfoChangeForm icf = new InfoChangeForm(_requestResult.info))
            {
                if (icf.ShowDialog() == DialogResult.OK)
                {
                    _requestResult.info = icf.InfoText;
                    UpdateInfo(icf.InfoText);
                }
            }
            saveFlag = true;
        }

        private void openLocalDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenLocalFile())
            {
                IdQ = null; IdT = null;
                _requestResult = RefreshData(IdT, IdQ);
                RefreshView();
                saveFlag = false;
                ShowComponent();
            }
            else
            {
                MessageBox.Show("Файл открыть не удалось");
            }
        }

        private void downloadAndOpenDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DownloadOpenFile())
            {
                IdT = null; IdQ = null;
                _requestResult = RefreshData(IdT, IdQ);
                RefreshView();
                saveFlag = false;
                ShowComponent();
            }
            else
            {
                MessageBox.Show("Файл загрузить либо открыть не удалось");
            }
        }

        private void saveDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFile())
            {
                MessageBox.Show("Файл сохранён");
                saveFlag = false;
            }
            else
            {
                MessageBox.Show("Файл cохранить не удалось");
            }
        }

        private void saveAndSendDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveSendFile())
            {
                MessageBox.Show("Файл сохранён и отправлен");
                saveFlag = false;
            }
            else
            {
                MessageBox.Show("Файл cохранён, но отправить не удалось");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saveFlag)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в локальном файле?", "Прогресс не сохранён", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    saveDBToolStripMenuItem_Click(null, null);
                    Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
        }
    }
}
