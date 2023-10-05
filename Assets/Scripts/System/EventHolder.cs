namespace System
{
    public class EventHolder 
    {
        public Action<bool> OnSwitchAudioEvent;
        public void OnSwitchAudio(bool state)
        {
            var temp = OnSwitchAudioEvent;
            temp?.Invoke(state);
        }
    }
}
