using System.Windows;

namespace selentia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
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
            Action_Bar.Content = _myMusicPlayer.Play();
        }

        private void Pause_Button_OnClick(object sender, RoutedEventArgs e)
        {
            Action_Bar.Content = _myMusicPlayer.Pause();
        }
    }
}