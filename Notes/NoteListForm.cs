using Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Notes
{
    public partial class NoteListForm : Form
    {
        NoteForm _noteForm;

        public NoteListForm(NoteForm noteForm)
        {
            InitializeComponent();
            _noteForm = noteForm;
        }

        private void NoteListForm_Load(object sender, EventArgs e)
        {
            GetListOfNotes();
        }

        void GetListOfNotes()
        {
            int y = 13;
            int offset_y = 60;
            var _notes = _noteForm.GetAllNotes();

            if (_notes.Count() == 0)
                noNotesLable.Visible = true;
            else
            {
                noNotesLable.Visible = false;
                foreach (var note in _notes)
                {
                    var noteTitle = CreateTitleLable(note);
                    var openBtn = CreateOpenBtn(note);
                    var deleteBtn = CreateDeleteBtn(note);
                    var noteGroupBox = CreateNoteGroupBox(note, openBtn, deleteBtn, noteTitle, y);

                    y += offset_y;
                    notesList.Controls.Add(noteGroupBox);
                }
            }
        }
                

        Label CreateTitleLable(Note note)
        {
            Label noteTitle = new Label();
            noteTitle.AutoSize = true;
            noteTitle.Location = new System.Drawing.Point(6, 23);
            noteTitle.Name = note.Id.ToString();
            noteTitle.Size = new System.Drawing.Size(50, 20);
            noteTitle.TabIndex = 0;

            if (note.Title.Length > 20)
                noteTitle.Text = note.Title.Substring(0, 20);
            else
                noteTitle.Text = note.Title;

            return noteTitle;
        }

        Button CreateOpenBtn(Note note)
        {
            Button openBtn = new Button();
            openBtn.Image = global::Notes.Properties.Resources.open;
            openBtn.Location = new System.Drawing.Point(327, 19);
            openBtn.Name = "button" + note.Id.ToString();
            openBtn.Size = new System.Drawing.Size(29, 29);
            openBtn.TabIndex = 1;
            openBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            openBtn.UseVisualStyleBackColor = true;

            openBtn.Click += (sender, args) =>
            {
                _noteForm.TempNote = note;
                this.Close();
            };

            return openBtn;
        }

        Button CreateDeleteBtn(Note note)
        {
            Button deleteBtn = new Button();
            deleteBtn.Image = global::Notes.Properties.Resources.cross;
            deleteBtn.Location = new System.Drawing.Point(362, 19);
            deleteBtn.Name = "button" + note.Id.ToString();
            deleteBtn.Size = new System.Drawing.Size(32, 29);
            deleteBtn.TabIndex = 2;
            deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            deleteBtn.UseVisualStyleBackColor = true;

            deleteBtn.Click += (sender, args) =>
            {
                _noteForm.DeleteNote(note);
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Записка удалена", "", buttons);
                this.Close();
            };

            return deleteBtn;
        }

        GroupBox CreateNoteGroupBox(Note note, Button openBtn, Button deleteBtn, Label noteTitle, int y)
        {
            GroupBox noteGroupBox = new GroupBox();
            noteGroupBox.Controls.Add(deleteBtn);
            noteGroupBox.Controls.Add(openBtn);
            noteGroupBox.Controls.Add(noteTitle);
            noteGroupBox.Location = new System.Drawing.Point(13, y);
            noteGroupBox.Name = "groupBox" + note.Id.ToString();
            noteGroupBox.Size = new System.Drawing.Size(400, 56);
            noteGroupBox.TabIndex = 0;
            noteGroupBox.TabStop = false;

            return noteGroupBox;
        }

        private void deleteAllBtn_Click(object sender, EventArgs e)
        {

            _noteForm.DeleteAllNotes();
            var tempDeleteAllBtn = deleteAllBtn;
            var tempNoNotesLable = noNotesLable;

            notesList.Controls.Clear();
            notesList.Controls.Add(tempDeleteAllBtn);
            notesList.Controls.Add(tempNoNotesLable);

            GetListOfNotes();
        }
    }
}
