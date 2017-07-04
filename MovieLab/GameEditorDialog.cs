using System.Windows.Forms;
using BoardGameLibrary.Data.Model;

namespace BoardGameLibrary
{
  public partial class GameEditorDialog : BaseDialogs.OkApplyCancelDialog
  {
      public GameEditorDialog()
      {
          InitializeComponent();
     }

      public GameEditorDialog(Game game)
          : this()
      {
          _nameTextBox.DataBindings.Add(
			  "Text", game, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
          _playsUpDown.DataBindings.Add(
			  "Value", game, "Plays", true, DataSourceUpdateMode.OnPropertyChanged);
          _noteTextBox.DataBindings.Add(
			  "Text", game, "Note", true, DataSourceUpdateMode.OnPropertyChanged);
		  _costTextBox.DataBindings.Add(
			  "Text", game, "Cost", true, DataSourceUpdateMode.OnPropertyChanged);
		  _lastPlayedDateTimePicker.DataBindings.Add(
			  "Value", game, "LastPlayed",true, DataSourceUpdateMode.OnPropertyChanged);
		  _purchasedDateTimePicker.DataBindings.Add(
			  "Value", game, "Purchased", true, DataSourceUpdateMode.OnPropertyChanged);
          _nameTextBox.Select();
      }

  }
}
