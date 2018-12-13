using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
