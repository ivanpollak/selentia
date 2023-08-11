using System;
using System.Windows;

namespace selentia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private bool isPlaying = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private MyMusicPlayer _myMusicPlayer = new MyMusicPlayer();
        private void FileSelection_OnClick(object sender, RoutedEventArgs e)
        {
            Action_Bar.Content = _myMusicPlayer.Open_File();
        }

        private void Play_Button_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isPlaying)
                {
                    // Führe die Pause-Aktion aus
                    // Zum Beispiel: mediaPlayer.Pause();
                    Action_Bar.Content = _myMusicPlayer.Play();
                    Play_Button.Content = "Playing";
                }
                else
                {
                    // Führe die Play-Aktion aus
                    // Zum Beispiel: mediaPlayer.Play();
                    Action_Bar.Content = _myMusicPlayer.Pause();
                    Play_Button.Content = "Resume";
                }
                isPlaying = !isPlaying;
            }
            catch (System.NullReferenceException exception)
            {
                Action_Bar.Content = "No File Selected.";
            }
        }
    }
}