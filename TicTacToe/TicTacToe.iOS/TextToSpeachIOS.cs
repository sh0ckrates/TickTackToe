using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using AVFoundation;
using TicTacToe.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeachIOS))]
namespace TicTacToe.iOS
{
    class TextToSpeachIOS : ItextToSpeach
    {
        public TextToSpeachIOS() { }

        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();
            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}