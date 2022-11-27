using AnalyzeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzeTextsSystem
{
    public class FacadeLayer
    {
        //public Scaner scaner;
        public Converting convert;
        public Emotion emotion;
        public PhoneNumber phoneNumber;
        public Dictionary<int, string[]> DicWords { get; set; }

        public FacadeLayer()
        {
            //scaner = new Scaner();
            convert = new Converting();
            emotion = new Emotion();
            phoneNumber = new PhoneNumber();
            DicWords = convert.ToWords();
        }

        public void EmotionInText()
        {
            emotion.IsEmotion(DicWords);
        }
        public void PhoneNumsInText()
        {
            phoneNumber.SearchPhoneNumber(DicWords);
        }
    }
}
