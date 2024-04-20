using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizAppDATAL;

namespace QuizAppBUSINESSL
{
    public class QBusiness
    {
        public List<string> GetR1Questions()
        {
            return QData.R1Questions;
        }

        public List<string> GetR1Choices()
        {
            return QData.R1Choices;
        }

        public List<string> GetR1Answers()
        {
            return QData.R1Answers;
        }
        public List<string> GetR2Questions()
        {
            return QData.R2Questions;
        }

        public List<string> GetR2Choices()
        {
            return QData.R2Choices;
        }

        public List<string> GetR2Answers()
        {
            return QData.R2Answers;
        }

        public List<string> GetR3Questions()
        {
            return QData.R3Questions;
        }

        public List<string> GetR3Choices()
        {
            return QData.R3Choices;
        }

        public List<string> GetR3Answers()
        {
            return QData.R3Answers;
        }
    }
}
