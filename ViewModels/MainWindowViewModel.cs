using Core;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace RegionIssueDemo.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private string _title = "Prism Application";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        private DelegateCommand<string> _navigateCommand;
        public DelegateCommand<string> NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(Navigate));

        void Navigate(string view)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion,view);
        }

    }
}
