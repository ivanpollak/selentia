using System.IO;
using Microsoft.Win32;

namespace selentia
{
    public class MyMusicPlayer
    {
        private string musicLocation;
        private System.Media.SoundPlayer player;
        private OpenFileDialog openFileDialog1;

        public string Open_File()
        {
            openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Music Files (*.wav)|*.wav";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == true)
            {
                string musicLocation = openFileDialog1.FileName;
                player = new System.Media.SoundPlayer(musicLocation);
                // Weitere Aktionen mit dem SoundPlayer durchführen
                string vollständigerPfad = openFileDialog1.FileName;
                string dateiname = Path.GetFileName(vollständigerPfad);
                return ("Now Selected: " + dateiname);
            }
            else
            {
                return ("No File Selected.");
            }
        }
        
        public string Play()
        {
            player.Play();
            // Hier könntest du den Code einfügen, um die Musik abzuspielen
            string vollständigerPfad = openFileDialog1.FileName;
            string dateiname = Path.GetFileName(vollständigerPfad);
            return "Now Playing: " + dateiname;
        }

        public string Pause()
        {
            player.Stop();
            // Hier könntest du den Code einfügen, um die Musik zu pausieren
            return "Stopped Music.";
        }
    }
}