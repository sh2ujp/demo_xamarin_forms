using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using app.Droid.Services;
using app.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeechImpl))]
namespace app.Droid.Services
{
    class TextToSpeechImpl : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public void OnInit([GeneratedEnum] OperationResult status)
        {
            if(status.Equals(OperationResult.Success))
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
        }

        public void Speak(string text)
        {
            toSpeak = text;

            if (speaker == null)
                speaker = new TextToSpeech(Android.App.Application.Context as Activity, this);
            else
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
        }
    }
}