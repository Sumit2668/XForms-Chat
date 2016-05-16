using System;
using Xamarin.Forms;

namespace XChat
{
	public partial class ChatPage : ContentPage
	{
		private ChatViewModel _model;
		public ChatPage(string name, int color)
		{
			_model = new ChatViewModel(name, color);
			BindingContext = _model;
			InitializeComponent();

			messageEntry.Completed += (sender, e) =>
			{
				sendButton.Command.Execute(null);
			};
		}

		public void HandleFocused(object sender, EventArgs e)
		{
			mainGrid.RowDefinitions[2].Height = new GridLength(5, GridUnitType.Star);
			sendButton.IsVisible = false;
		}
		public void HandleUnfocused(object sender, EventArgs e)
		{
			mainGrid.RowDefinitions[2].Height = 0;
			sendButton.IsVisible = true;
		}
	}
}

