using System.Collections.Generic;

namespace Presenter.Common
{
    public class RequestResult
    {
        public List<string> themes;
        public List<string> questions;
        public List<string> answers;
        public List<bool> isTrue;
        public int time;
        public int totalQCount;
        public int totalQCount4t;
        public int QCount4t;
        public string info;
        public string question;

        public RequestResult()
        {

        }
    }
}
