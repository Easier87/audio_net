using audio_net.View;
using GalaSoft.MvvmLight.Command;
using System.Windows.Controls;
using System.Windows.Input;

namespace audio_net.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private Page search = new Search();
        private Page add = new Add(null);
        private Page most_main = new MostMain();

        private Page _CurrentPage = new MostMain();

        public Page CurrentPage
        {
            get => _CurrentPage;
            set => Set(ref _CurrentPage, value);
        }

        public ICommand OpenAddPage
        {
            get
            {
                return new RelayCommand(() => CurrentPage = add);
            }
        }

        public ICommand OpenMostMainPage
        {
            get
            {
                return new RelayCommand(() => CurrentPage = most_main);
            }
        }

        public ICommand OpenSearchPage
        {
            get
            {
                return new RelayCommand(() => CurrentPage = search);
            }
        }
    }
}
