using System.Windows.Controls;
using Core;
using Prism.Regions;

namespace RegionIssueDemo.Views
{
    public partial class MainWindow
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();

            //RegionManager.SetRegionName(_stackPanel, RegionNames.ContentRegion);
            //RegionManager.SetRegionManager(_stackPanel, regionManager);
        }
    }
}
