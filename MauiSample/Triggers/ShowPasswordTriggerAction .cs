using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MauiSample.Triggers
{
	
		/// <summary>
		/// The Trigger Action that will handle
		/// the Show/Hide Passeword text
		/// </summary>
		public class ShowPasswordTriggerAction : TriggerAction<Button>
		{
			public string IconImageName { get; set; }

			public string EntryPasswordName { get; set; }

			public string EntryTextName { get; set; }

			protected override void Invoke(Button sender)
			{
				// get the runtime references for our Elements from our custom control
				var imageIconView = ((Grid)sender.Parent)
										.FindByName<Image>(IconImageName);
				var entryPasswordView = ((Grid)sender.Parent)
										.FindByName<Entry>(EntryPasswordName);
				var entryTextView = ((Grid)sender.Parent)
										.FindByName<Entry>(EntryTextName);

				// Switch visibility of Password Entry field and Text Entry fields
				entryPasswordView.IsVisible = !entryPasswordView.IsVisible;
				entryTextView.IsVisible = !entryTextView.IsVisible;

				// update the Show/Hide button Icon states 
				if (entryPasswordView.IsVisible)
				{
					// Password is not Visible state
					imageIconView.Source = ImageSource.FromResource(
						"MauiSample.showpasswordicon.png",
						Assembly.GetExecutingAssembly());

					// Setting up Entry curser focus
					entryPasswordView.Focus();
					entryPasswordView.Text = entryTextView.Text;
				}
				else
				{
					// Password is Visible state
					imageIconView.Source = ImageSource.FromResource(
						"MauiSample.hidepasswordicon.png",
						Assembly.GetExecutingAssembly());

					// Setting up Entry curser focus
					entryTextView.Focus();
					entryTextView.Text = entryPasswordView.Text;
				}
			}
		}
	}

