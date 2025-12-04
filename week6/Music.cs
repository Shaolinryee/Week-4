using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4.week6
{
    public class Music
    {
        public string SongTitle { get; set; }
        public string Artist { get; set; }
        public int DurationInSeconds { get; set; }

        public Music(string songTitle, string artist, int durationInSeconds)
        {
            SongTitle = songTitle;
            Artist = artist;
            DurationInSeconds = durationInSeconds;
        }

        // Helper method to get duration in minutes:seconds format
        public string GetFormattedDuration()
        {
            int minutes = DurationInSeconds / 60;
            int seconds = DurationInSeconds % 60;
            return $"{minutes}:{seconds:D2}";
        }

        public override string ToString()
        {
            return $"'{SongTitle}' by {Artist} - {GetFormattedDuration()} ({DurationInSeconds}s)";
        }
    }
}