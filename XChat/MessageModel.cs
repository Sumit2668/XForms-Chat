using System;
using Xamarin.Forms;

namespace XChat
{
	public class MessageModel
	{
		public string Name { get; set; }
		public string Message { get; set; }
		public DateTime PostedOn { get; set; }
		public string Color { get; set; }
		public Thickness Pad { get; set; }
	}
}

