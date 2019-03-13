using Model;
using Presenter.Common;
using Presenter.Views;
using System.Collections.Generic;
using System.Linq;

namespace Presenter.Presenters
{
    class MainPresenter : BasePresenter<IMainForm>
    {
        private Data data;
        public MainPresenter(IMainForm view, Data d) : base(view)
        {
            data = d;
            //Create();
            View.UpdateQCount += View_UpdateQCount;
            View.RefreshData += View_RefreshData;
            View.UpdateTime += View_UpdateTime;
            View.AddQuestion += View_AddQuestion;
            View.UpdateQuestion += View_UpdateQuestion;
            View.DeleteQuestion += View_DeleteQuestion;
            View.UpdateAnswer += View_UpdateAnswer;
            View.UpdateIsTrue += View_UpdateIsTrue;
            View.UpdateInfo += View_UpdateInfo;
            View.OpenLocalFile += View_OpenLocalFile;
            View.DownloadOpenFile += View_DownloadOpenFile;
            View.SaveFile += View_SaveFile;
            View.SaveSendFile += View_SaveSendFile;
        }

        /// <summary>
        /// Сохранение и отправка файла
        /// </summary>
        /// <returns></returns>
        private bool View_SaveSendFile()
        {
            try
            {
                data.Serialize();
                if (!data.UploadDat())
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <returns></returns>
        private bool View_SaveFile()
        {
            try
            {
                data.Serialize();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Загрузка и открытие файла
        /// </summary>
        /// <returns></returns>
        private bool View_DownloadOpenFile()
        {
            try
            {
                if (!data.DownloadDat())
                    return false;
                data.Deserialize();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Открытие файла
        /// </summary>
        /// <returns></returns>
        private bool View_OpenLocalFile()
        {
            try
            {
                data.Deserialize();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //удалить
        private void Create()
        {
            data.testData = new TestData(new Setting(300), new List<Subject>(), "Инфо");
            data.testData.Subjects.Add(new Subject("Бухгалтерская", 0, new List<Question>()));
            data.testData.Subjects.Add(new Subject("Менеджерская", 0, new List<Question>()));
            data.testData.Subjects.Add(new Subject("Маркетинговая", 0, new List<Question>()));
            data.testData.Subjects.Add(new Subject("ИТ", 0, new List<Question>()));
            data.Serialize();
        }

        /// <summary>
        /// Сохранение вопроса после изменения
        /// </summary>
        /// <param Индекс темы="IdT"></param>
        /// <param Индекс вопроса="IdQ"></param>
        /// <param Текст вопроса="question"></param>
        /// <returns></returns>
        private RequestResult View_UpdateQuestion(int IdT, int IdQ, string question)
        {
            data.testData.Subjects.ElementAt(IdT).Questions.ElementAt(IdQ).Name = question;
            return View_RefreshData(IdT, IdQ);
        }

        /// <summary>
        /// Удаление вопроса из темы
        /// </summary>
        /// <param Индекс темы="IdT"></param>
        /// <param Индекс вопроса="IdQ"></param>
        /// <returns></returns>
        private RequestResult View_DeleteQuestion(int IdT, int IdQ)
        {
            data.testData.Subjects.ElementAt(IdT).Questions.RemoveAt(IdQ);
            return View_RefreshData(IdT, null);
        }

        /// <summary>
        /// Сохранение ответа после изменения
        /// </summary>
        /// <param Индекс темы="IdT"></param>
        /// <param Индекс вопроса="IdQ"></param>
        /// <param Индекс ответа="IdA"></param>
        /// <param Текст ответа="answer"></param>
        /// <returns></returns>
        private RequestResult View_UpdateAnswer(int IdT, int IdQ, int IdA, string answer)
        {
            if (answer != string.Empty)
                data.testData.Subjects.ElementAt(IdT).Questions.ElementAt(IdQ).Answers.ElementAt(IdA).Name = answer;
            return View_RefreshData(IdT, IdQ);
        }

        /// <summary>
        /// Сохранение правильности ответа
        /// </summary>
        /// <param Индекс темы="IdT"></param>
        /// <param Индекс вопроса="IdQ"></param>
        /// <param Индекс ответа="IdA"></param>
        /// <returns></returns>
        private RequestResult View_UpdateIsTrue(int IdT, int IdQ, int IdA)
        {
            foreach (var ans in data.testData.Subjects.ElementAt(IdT).Questions.ElementAt(IdQ).Answers)
            {
                ans.IsTrue = false;
            }
            data.testData.Subjects.ElementAt(IdT).Questions.ElementAt(IdQ).Answers.ElementAt(IdA).IsTrue = true;
            return View_RefreshData(IdT, IdQ);
        }

        /// <summary>
        /// Добавление нового вопроса в тему
        /// </summary>
        /// <param Индекс темы="IdT"></param>
        /// <param Текст вопроса="question"></param>
        /// <returns></returns>
        private RequestResult View_AddQuestion(int IdT, int IdQ)
        {
            data.testData.Subjects.ElementAt(IdT).Questions.Add(new Question());
            return View_RefreshData(IdT, IdQ);
        }

        /// <summary>
        /// Сохранение нового количества вопросов, которые будут заданы из темы
        /// </summary>
        /// <param Индекс темы="IdT"></param>
        /// <param Количество вопросов="count"></param>
        /// <returns></returns>
        private RequestResult View_UpdateQCount(int IdT, int count)
        {
            data.testData.Subjects.ElementAt(IdT).QCount = count;
            return View_RefreshData(IdT, null);
        }

        /// <summary>
        /// Сохранение времени на прохождение теста
        /// </summary>
        /// <param Время на прохождение теста="time"></param>
        /// <returns>Фиктивное значение</returns>
        private RequestResult View_UpdateTime(int time)
        {
            data.testData.Setting.Time = time;
            return View_RefreshData(null, null);
        }

        /// <summary>
        /// Сохранение информации для фармацевтов
        /// </summary>
        /// <param Текст для фармацевтов="arg"></param>
        /// <returns></returns>
        private RequestResult View_UpdateInfo(string arg)
        {
            data.testData.Info = arg;
            return View_RefreshData(null, null);
        }

        /// <summary>
        /// Обновление данных
        /// </summary>
        /// <param Индекс темы="sIdT"></param>
        /// <param Индекс вопроса="sIdQ"></param>
        /// <returns></returns>
        private RequestResult View_RefreshData(int? sIdT, int? sIdQ)
        {
            var res = new RequestResult();
            res.themes = data.testData.Subjects.Select(x => x.Name).ToList();
            res.time = data.testData.Setting.Time;
            if (sIdT != null)
            {
                res.questions = data.testData.Subjects.ElementAt((int)sIdT).Questions.Select(x => x.Name).ToList();
                res.totalQCount4t = data.testData.Subjects.ElementAt((int)sIdT).Questions.Count;
                res.QCount4t = data.testData.Subjects.ElementAt((int)sIdT).QCount;
                if (sIdQ != null)
                {
                    res.question = data.testData.Subjects.ElementAt((int)sIdT).Questions.ElementAt((int)sIdQ).Name;
                    res.answers = data.testData.Subjects.ElementAt((int)sIdT).Questions.ElementAt((int)sIdQ).Answers.Select(x => x.Name).ToList();
                    res.isTrue = data.testData.Subjects.ElementAt((int)sIdT).Questions.ElementAt((int)sIdQ).Answers.Select(x => x.IsTrue).ToList();
                }
            }
            res.info = data.testData.Info;
            res.totalQCount = data.testData.Subjects.Sum(x => x.Questions.Count);
            return res;
        }
    }
}
