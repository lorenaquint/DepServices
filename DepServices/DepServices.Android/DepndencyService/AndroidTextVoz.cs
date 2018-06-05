using DepServices.Droid.DepndencyService;
using Xamarin.Forms;
using DepServices.DependencyServices;
using Android.Speech.Tts;
using static Android.Speech.Tts.TextToSpeech;
using Android.Runtime;

[assembly: Dependency(typeof(AndroidTextVoz))]
namespace DepServices.Droid.DepndencyService
{
    public class AndroidTextVoz : Java.Lang.Object, ITextVoz,IOnInitListener
    {
        private TextToSpeech speaker;
        private string toSpeak;

        public void OnInit([GeneratedEnum] OperationResult status)
        {
            speaker.Speak(toSpeak, QueueMode.Flush, null, null);
        }

        public void Spek(string text)
        {
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(Forms.Context, this);

            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
    }
}