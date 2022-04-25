using Domain.Data;
using Domain.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Notes
{
    public partial class NoteForm : Form
    {
        protected readonly INoteInterface _noteService;
        private Note _tempNote;
        private IEnumerable<Note> _notes;

        public NoteForm(INoteInterface noteService)
        {
            InitializeComponent();
            _noteService = noteService;
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            boldBtn.CheckOnClick = true;
            underlineBtn.CheckOnClick = true;
            italicBtn.CheckOnClick = true;

            _notes = _noteService.GetAllNodes();
            TempNote = CreateNewNote();

            noteTextBox.SelectAll();

            for (int i = 1; i < 100; i++)
                fontSizeComboBox.Items.Add(i);

            fontSizeComboBox.SelectedIndex = 13;

            InstalledFontCollection installedFontCollection = new InstalledFontCollection();

            var fontFamilies = installedFontCollection.Families;

            foreach (var font in fontFamilies)
                fontComboBox.Items.Add(font.Name);

            fontComboBox.Text = "Time New Roman";
        }

        public Note TempNote
        {
            get
            {
                _tempNote.NoteText = noteTextBox.Rtf;
                _tempNote.Title = titleTextBox.Text;
                return _tempNote;
            }

            set
            {
                _tempNote = value;
                noteTextBox.Rtf = _tempNote.NoteText;
                titleTextBox.Text = _tempNote.Title;
            }
        }

        private void saveNoteBtn_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "")
            {
                _noteService.AddNote(TempNote);
                _notes.Append(TempNote);
                MessageBox.Show("Заметка сохранена!", "", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Пожалуйста, введите название заметки!");
        }

        private void noteListBtn_Click(object sender, EventArgs e)
        {
            NoteListForm noteListForm = new NoteListForm(this);
            noteListForm.Show();
        }

        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            var result = MessageBox.Show("Сохранить текущую заметку?", "Внимание!", buttons);

            if (result == DialogResult.Yes)
            {
                _noteService.AddNote(TempNote);
                _notes.Append(TempNote);

                MessageBox.Show("Заметка сохранена!", "", MessageBoxButtons.OK);

                TempNote = CreateNewNote();
            }
            else if (result == DialogResult.No)
            {
                TempNote = CreateNewNote();
            }
        }

        private void deleteTempNoteBtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show("Удалить текущую заметку?", "Внимание!", buttons);

            if (result == DialogResult.Yes)
            {
                _noteService.AddNote(TempNote);
                _notes.Append(TempNote);

                MessageBox.Show("Заметка удалена!", "", MessageBoxButtons.OK);

                var deletingNote = TempNote;
                TempNote = CreateNewNote();
                _noteService.DeleteNote(deletingNote);
            }
        }

        private void insertImageBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            openFileDialog.Multiselect = false;
            openFileDialog.FileName = "";

            DialogResult result = openFileDialog.ShowDialog();

            var tempClip = "";
            if (Clipboard.GetText() != "")
                tempClip = Clipboard.GetText();

            if (result == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                Clipboard.SetImage(img);
                noteTextBox.Paste();
                Clipboard.SetText(tempClip);
            }
            else
            {
                Clipboard.SetText(tempClip);
            }
        }

        private void fontComboBox_TextChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void fontSizeComboBox_TextChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            ChangeFontStyle((ToolStripButton)(sender), FontStyle.Bold);
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            ChangeFontStyle((ToolStripButton)(sender), FontStyle.Underline);
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            ChangeFontStyle((ToolStripButton)(sender), FontStyle.Italic);
        }

        public void ChangeFontStyle(ToolStripButton button, FontStyle style)
        {
            var tempFont = noteTextBox.SelectionFont;
            var tempFontStyle = FontStyle.Regular;

            if (tempFont == null)
            {
                var size = float.Parse(fontSizeComboBox.Text);
                noteTextBox.SelectionFont = new Font(fontComboBox.Text, size, style);
            }
            else
            {
                tempFontStyle = noteTextBox.SelectionFont.Style;
            }

            if (button.Checked)
            {
                tempFontStyle |= style;
            }
            else
            {
                tempFontStyle -= style;
            }
            noteTextBox.SelectionFont = new Font(tempFont.FontFamily, tempFont.Size, tempFontStyle);
        }

        void ChangeFont()
        {
            var size = float.Parse(fontSizeComboBox.Text);

            var tempFont = noteTextBox.SelectionFont;
            if (tempFont != null)
            {
                noteTextBox.SelectionFont = new Font(fontComboBox.Text, size, tempFont.Style);
            }
            else
            {
                noteTextBox.SelectionFont = new Font(fontComboBox.Text, size, FontStyle.Regular);
            }
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _noteService.GetAllNodes();
        }

        public void DeleteNote(Note note)
        {
            _noteService.DeleteNote(note);
        }

        public void DeleteAllNotes()
        {
            _noteService.DeleteAllNotes();
        }

        Note CreateNewNote()
        {
            var newNotesCount = _notes.Count(note => note.Title.StartsWith("NewNote")) + 1;

            var newNote = new Note()
            {
                Title = "NewNote" + newNotesCount
            };
            return newNote;
        }
    }
}
