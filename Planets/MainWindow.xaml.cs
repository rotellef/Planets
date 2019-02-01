using System.Windows;

namespace Planets
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

		public MainWindow()
		{

			foreach (var item in ShipUtils.ShipStats)
			{
				logger.Debug("{0}", item.Value);
			}
			InitializeComponent();
		}
	}
}
