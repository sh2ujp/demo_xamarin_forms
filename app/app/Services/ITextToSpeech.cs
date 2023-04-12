using System;
using System.Collections.Generic;
using System.Text;

namespace app.Services
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
