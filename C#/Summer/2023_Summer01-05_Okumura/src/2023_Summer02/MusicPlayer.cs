using System;

namespace _2023_Summer
{
    public class MusicPlayer
    {
        /// <summary>
        /// List of songs
        /// </summary>
        public List<string> songs;

        public MusicPlayer()
        {
            songs = new List<string>();
        }

        /// <summary>
        /// Ask to add song(s)
        /// </summary>
        public void AskMethod()
        {
            // Ask
            AskWhatSongAdd();

            // Ask looping
            while(AskContinueAddSongs())
            {
                AskWhatSongAdd();
            }
        }
        /// <summary>
        /// Show created song list
        /// </summary>
        public void Play()
        {
            // Show songs
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {songs[i]}");
            }
        }
        /// <summary>
        /// Ask what song want to add
        /// </summary>
        private void AskWhatSongAdd()
        {
            // Request song name
            Console.Write("Please enter a song name: ");
            string song = Console.ReadLine();

            // If song is empty, ask again
            while (song == "")
            {
                Console.Write("[ERROR] Can't include empty bracket first position.\nPlease reenter a song name: ");
                song = Console.ReadLine();
            }

            // Add
            AddSongs(song: song);
        }
        /// <summary>
        /// Adding a song
        /// </summary>
        /// <param name="song"></param>
        private void AddSongs(string song)
        {
            // Add a song to list
            songs.Add(song);
        }
        /// <summary>
        /// Ask to continue adding song
        /// </summary>
        /// <returns></returns>
        private bool AskContinueAddSongs()
        {
            // Ask continue add song to list
            Console.Write("Continue to add songs to list? (yes / no): ");
            string ans = Console.ReadLine();

            // If ans is not yes/y/no/n, ask again
            while(YesOrNo(ans))
            {
                Console.Write("Continue to add songs to list? (yes / no): ");
                ans = Console.ReadLine();
            }

            // Judge continue
            if (ans.ToLower() == "yes" || ans.ToLower() == "y")
            {
                return true;
            }
            else if (ans.ToLower() == "no" || ans.ToLower() == "n")
            {
                return false;
            }
            else if (ans == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool YesOrNo(string ans)
        {
            // Change uppercase to lowercase
            ans.ToLower();

            // Bing AI helps this return
            return !(ans.Equals("yes", StringComparison.OrdinalIgnoreCase) ||
             ans.Equals("y", StringComparison.OrdinalIgnoreCase) ||
             ans.Equals("no", StringComparison.OrdinalIgnoreCase) ||
             ans.Equals("n", StringComparison.OrdinalIgnoreCase));
        }
    }
}
