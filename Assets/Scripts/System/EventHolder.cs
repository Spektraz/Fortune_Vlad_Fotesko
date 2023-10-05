namespace System
{
    public class EventHolder 
    {
        public Action<TimeSpan, Action> OnStartTimeEvent;
        public void OnStartTime(TimeSpan span, Action action)
        {
            var temp = OnStartTimeEvent;
            temp?.Invoke(span, action);
        }
        public Action<TimeSpan> OnTimeTickEvent;
        public void OnTimeTick(TimeSpan span)
        {
            var temp = OnTimeTickEvent;
            temp?.Invoke(span);
        }
        public Action<bool> OnSwitchAudioEvent;
        public void OnSwitchAudio(bool state)
        {
            var temp = OnSwitchAudioEvent;
            temp?.Invoke(state);
        }
        public Action<int> OnLooseAnswerEvent;
        public void OnLooseAnswer(int count)
        {
            var temp = OnLooseAnswerEvent;
            temp?.Invoke(count);
        }
        public Action<bool> OnFinishGameEvent;
        public void OnFinishGame(bool state)
        {
            var temp = OnFinishGameEvent;
            temp?.Invoke(state);
        }
        public Action<bool> OnCloseQuestionWindowEvent;
        public void OnCloseQuestionWindow(bool state)
        {
            var temp = OnCloseQuestionWindowEvent;
            temp?.Invoke(state);
        }
    }
}
