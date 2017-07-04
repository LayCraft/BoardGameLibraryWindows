using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BoardGameLibrary.BaseDialogs
{
    public partial class OkApplyCancelDialog : System.Windows.Forms.Form
    {
        private readonly Button _okButton;
        private readonly Button _cancelButton;
        private readonly Button _applyButton;

        public OkApplyCancelDialog()
        {
            InitializeComponent();

            _okButton = CreateButton("OK", OnOk);
            _cancelButton = CreateButton("Cancel", OnCancel);
            _applyButton = CreateButton("Apply", OnApply);

            AcceptButton = _okButton;

            MakeButtons();
        }

        public void SelectOk()
        {
            _okButton.Select();
        }

        public enum DialogButtons { Ok, OkCancel, OkApplyCancel }

        private DialogButtons _bottomButtons;

        [DefaultValue(DialogButtons.Ok)]
        [Category("Misc")]
        [Description("Dialog Buttons.")]
        public DialogButtons BottomButtons
        {
            get { return _bottomButtons; }
            set
            {
                _bottomButtons = value;
                //MakeButtons();
				_bottomPanel.Controls.Clear();

				switch (value) {
					case DialogButtons.Ok:
						_bottomPanel.Controls.Add(_okButton);
						break;
					case DialogButtons.OkCancel:
						_bottomPanel.Controls.AddRange(new Control[] { _cancelButton, _okButton });

						break;
					case DialogButtons.OkApplyCancel:
						_bottomPanel.Controls.AddRange(new Control[] { _cancelButton, _applyButton, _okButton });
						break;
					default:
						throw new ArgumentOutOfRangeException("value");
				}
            }
        }

        private void MakeButtons()
        {
            _bottomPanel.Controls.Clear();

            switch (_bottomButtons)
            {
                case DialogButtons.Ok:
                    _bottomPanel.Controls.Add(_okButton);
                    break;
                case DialogButtons.OkCancel:
                    _bottomPanel.Controls.AddRange(new Control[] { _cancelButton, _okButton });

                    break;
                case DialogButtons.OkApplyCancel:
                    _bottomPanel.Controls.AddRange(new Control[] { _cancelButton, _applyButton, _okButton });
                    break;
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }

        private Button CreateButton(string text, EventHandler handler)
        {
            Button button = new Button
            {
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Location = new System.Drawing.Point(35, 3),
                Name = string.Format("_{0}Button", text),
                Size = new System.Drawing.Size(75, 23),
                Text = text,
                UseVisualStyleBackColor = true
            };

            button.Click += handler;
            return button;
        }

        public virtual void OnOk() { }

        private void OnOk(object sender, EventArgs e)
        {
            OnOk();

            DialogResult = DialogResult.OK;
            Close();
        }

        public virtual void OnCancel() { }

        private void OnCancel(object sender, EventArgs e)
        {
            OnCancel();

            DialogResult = DialogResult.Cancel;
            Close();
        }

        public virtual void OnApply() { }

        private void OnApply(object sender, EventArgs e)
        {
            OnApply();
        }

    }
}
