using app.iOS.Services;
using app.Services;
using AVFoundation;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechImpl))]
namespace app.iOS.Services
{
    class TextToSpeechImpl : ITextToSpeech
    {
        public void Speak(string text)
        {
            var speechSynthesizer   = new AVSpeechSynthesizer();
            var speechUtterance     = new AVSpeechUtterance(text);
            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}