using System;

namespace Utils
{
    public static class StringUtils
    {

        public static string TimeSpanToFormattedString(TimeSpan timeSpan)
        {
            if (timeSpan.Hours > 0)
            {
                return timeSpan.ToString(@"h\:mm\:ss");
            }

            return timeSpan.ToString(@"m\:ss");
        }
        
    }
}