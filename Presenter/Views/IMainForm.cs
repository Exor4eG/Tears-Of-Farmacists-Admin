using Presenter.Common;
using System;

namespace Presenter.Views
{
    public interface IMainForm : IView
    {
        event Func<int?, int?, RequestResult> RefreshData;
        event Func<int, int, RequestResult> UpdateQCount;
        event Func<int, RequestResult> UpdateTime;
        event Func<int, int, string, RequestResult> UpdateQuestion;
        event Func<int, int, RequestResult> AddQuestion;
        event Func<int, int, RequestResult> DeleteQuestion;
        event Func<int, int, int, string, RequestResult> UpdateAnswer;
        event Func<int, int, int, RequestResult> UpdateIsTrue;
        event Func<string, RequestResult> UpdateInfo;
        event Func<bool> OpenLocalFile;
        event Func<bool> DownloadOpenFile;
        event Func<bool> SaveFile;
        event Func<bool> SaveSendFile;

    }
}
