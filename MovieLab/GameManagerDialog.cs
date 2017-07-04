using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using BoardGameLibrary.Data;
using BoardGameLibrary.Data.Model;


namespace BoardGameLibrary
{
    public partial class GameManagerDialog : Form
    {
        private GameRepository _gameRepository;
        private readonly BindingSource _bindingSource = new BindingSource();
        private readonly XmlSerializer _xmlSerializer = new XmlSerializer(typeof(GameRepository));
        private readonly string _initialTitle;

        public GameManagerDialog()
        {
            InitializeComponent();
            _initialTitle = Text;
        }

        public GameManagerDialog(GameRepository gameRepository)
            : this()
        {
            BindSources(gameRepository);
        }

        private void BindSources(GameRepository gameRepository)
        {
            if (_gameRepository != null)
                _gameRepository.PropertyChanged -= GameRepositoryPropertyChanged;

            _bindingSource.DataSource = gameRepository;
            _bindingSource.DataMember = "Games";

            _gameListBox.DataSource = _bindingSource;
            _gameListBox.DisplayMember = "Name";

			_nameTextBox.DataBindings.Clear();
			_nameTextBox.DataBindings.Add("Text", _bindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged);

			_noteTextBox.DataBindings.Clear();
			_noteTextBox.DataBindings.Add("Text", _bindingSource, "Note", true, DataSourceUpdateMode.OnPropertyChanged);

			_costTextBox.DataBindings.Clear();
			_costTextBox.DataBindings.Add("Text", _bindingSource, "Cost", true, DataSourceUpdateMode.OnPropertyChanged);

			_purchasedDateTimePicker.DataBindings.Clear();
			_purchasedDateTimePicker.DataBindings.Add("Value", _bindingSource, "Purchased", true, DataSourceUpdateMode.OnPropertyChanged);
			
			_lastPlayedDateTimePicker.DataBindings.Clear();
			_lastPlayedDateTimePicker.DataBindings.Add("Value", _bindingSource, "LastPlayed", true, DataSourceUpdateMode.OnPropertyChanged);

			_playsTextBox.DataBindings.Clear();
			_playsTextBox.DataBindings.Add("Text", _bindingSource, "Plays", true, DataSourceUpdateMode.OnPropertyChanged);

            gameRepository.PropertyChanged += GameRepositoryPropertyChanged;

            _gameRepository = gameRepository;

            UpdateButtons();
        }

        public Game CurrentGame
        {
            get { return _bindingSource.Current as Game; }
        }

        private string _lastFileName;
        public string LastFileName
        {
            get { return _lastFileName; }
            set
            {
                _lastFileName = value;
                saveToolStripMenuItem.Enabled = string.IsNullOrWhiteSpace(_lastFileName) == false;
                UpdateTitleBar();
            }
        }

        private bool _isModified;
        public bool IsModified
        {
            get { return _isModified; }
            set
            {
                _isModified = value;
                UpdateTitleBar();
            }
        }

        private void OpenFromFile()
        {
            GameRepository gameRepository = null;
         /*
           * TODO: The LastFileName property contains the name of the file for opening
           * Using the _xmlSerializer, Deserialize a new movie repository
           */
			using (var sr = new StreamReader(LastFileName)) {
				gameRepository = (GameRepository)_xmlSerializer.Deserialize(sr);
			}
            IsModified = false;
            BindSources(gameRepository);
        }

        private void SaveToFile()
        {
			using (var sw = new StreamWriter(LastFileName)) {
				_xmlSerializer.Serialize(sw, _gameRepository);
			}
            _gameRepository.IsModified = IsModified = false;
        }


        private void UpdateTitleBar()
        {
            StringBuilder sb = new StringBuilder(_initialTitle);
            if (string.IsNullOrWhiteSpace(LastFileName) == false)
                sb.AppendFormat(" - {0}", LastFileName);
            if (IsModified)
                sb.Append("*");

            Text = sb.ToString();
        }

        private void GameRepositoryPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            IsModified = true;
        }

        private void UpdateButtons()
        {
            _deleteButton.Enabled = CurrentGame != null;
			_addPlayButton.Enabled = CurrentGame != null;
			
        }

        private void GameManagerDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsModified == false || e.CloseReason != CloseReason.UserClosing) return;

            const string msg = "You haven't saved your changes\nDo you still want to quit?";
            DialogResult res = MessageBox.Show(this, msg, _initialTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            e.Cancel = res == DialogResult.No;
        }

        #region Click events

        private void _newButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            using (GameEditorDialog dlg = new GameEditorDialog(game))
            {
                dlg.StartPosition = FormStartPosition.CenterParent;
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                _gameRepository.Add(game);
                _bindingSource.Position = _bindingSource.IndexOf(game);
                UpdateButtons();
            }
        }

        private void _deleteButton_Click(object sender, EventArgs e)
        {
            if (CurrentGame == null) return;
            _gameRepository.Remove(CurrentGame);
            UpdateButtons();
        }

		private void _deleteGameButton_Click(object sender, EventArgs e) {
			if (CurrentGame == null) return;
			_gameRepository.Remove(CurrentGame);
			UpdateButtons();
		}
		private void _newGameButton_Click(object sender, EventArgs e) {
			Game game = new Game();
			using (GameEditorDialog dlg = new GameEditorDialog(game)) {
				dlg.StartPosition = FormStartPosition.CenterParent;
				if (dlg.ShowDialog(this) != DialogResult.OK) return;

				_gameRepository.Add(game);
				_bindingSource.Position = _bindingSource.IndexOf(game);
				UpdateButtons();
			}
		}


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
			string myMessage = " Double click items to edit them.\nSaveas often as you don't mind redoing it.\n-Curtis LayCraft 2015";
            MessageBox.Show(this, myMessage, _initialTitle, MessageBoxButtons.OK);
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsModified = false;
            BindSources(new GameRepository());
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LastFileName) == false)
            {
                _saveFileDialog.InitialDirectory = Path.GetDirectoryName(LastFileName);
                _saveFileDialog.FileName = Path.GetFileName(LastFileName);
            }

            if (_openFileDialog.ShowDialog(this) != DialogResult.OK) return;
            LastFileName = _openFileDialog.FileName;
            OpenFromFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_saveFileDialog.ShowDialog(this) != DialogResult.OK) return;

            LastFileName = _saveFileDialog.FileName;
            SaveToFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

		private void _gameListBox_MouseDoubleClick(object sender, MouseEventArgs e) {
			Game game = (Game)_gameListBox.SelectedItem;
			Game gameClone = new Game(game);
			GameEditorDialog edit = new GameEditorDialog(gameClone);
			if (edit.ShowDialog() == DialogResult.OK) {
				_gameListBox.SelectedItem = gameClone;
			}

		}

		private void _addPlayButton_Click(object sender, EventArgs e) {
			Game game = (Game)_gameListBox.SelectedItem;

			// update date played to today
			game.LastPlayed = DateTime.Now;
			// increment Plays 
			game.Plays = game.Plays+1;
		}





    }
}
