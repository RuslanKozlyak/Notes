
namespace Notes
{
    partial class NoteForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.noteTextBox = new System.Windows.Forms.RichTextBox();
            this.noteToolStrip = new System.Windows.Forms.ToolStrip();
            this.noteBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.saveNoteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.noteListBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTempNoteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.insertImageBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.fontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.boldBtn = new System.Windows.Forms.ToolStripButton();
            this.underlineBtn = new System.Windows.Forms.ToolStripButton();
            this.italicBtn = new System.Windows.Forms.ToolStripButton();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.noteToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteTextBox
            // 
            this.noteTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.noteTextBox.Location = new System.Drawing.Point(0, 64);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(800, 386);
            this.noteTextBox.TabIndex = 0;
            this.noteTextBox.Text = "";
            // 
            // noteToolStrip
            // 
            this.noteToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.noteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteBtn,
            this.fontComboBox,
            this.fontSizeComboBox,
            this.boldBtn,
            this.underlineBtn,
            this.italicBtn});
            this.noteToolStrip.Location = new System.Drawing.Point(0, 0);
            this.noteToolStrip.Name = "noteToolStrip";
            this.noteToolStrip.Size = new System.Drawing.Size(800, 28);
            this.noteToolStrip.TabIndex = 1;
            this.noteToolStrip.Text = "toolStrip1";
            // 
            // noteBtn
            // 
            this.noteBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.noteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.noteBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveNoteBtn,
            this.noteListBtn,
            this.deleteTempNoteBtn,
            this.newNoteBtn,
            this.insertImageBtn});
            this.noteBtn.Image = ((System.Drawing.Image)(resources.GetObject("noteBtn.Image")));
            this.noteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.noteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.noteBtn.Name = "noteBtn";
            this.noteBtn.Size = new System.Drawing.Size(85, 25);
            this.noteBtn.Text = "Заметки";
            this.noteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.noteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // saveNoteBtn
            // 
            this.saveNoteBtn.Name = "saveNoteBtn";
            this.saveNoteBtn.Size = new System.Drawing.Size(219, 26);
            this.saveNoteBtn.Text = "Сохранить";
            this.saveNoteBtn.Click += new System.EventHandler(this.saveNoteBtn_Click);
            // 
            // noteListBtn
            // 
            this.noteListBtn.Name = "noteListBtn";
            this.noteListBtn.Size = new System.Drawing.Size(219, 26);
            this.noteListBtn.Text = "Список заметок";
            this.noteListBtn.Click += new System.EventHandler(this.noteListBtn_Click);
            // 
            // deleteTempNoteBtn
            // 
            this.deleteTempNoteBtn.Name = "deleteTempNoteBtn";
            this.deleteTempNoteBtn.Size = new System.Drawing.Size(219, 26);
            this.deleteTempNoteBtn.Text = "Удалить текущую";
            this.deleteTempNoteBtn.Click += new System.EventHandler(this.deleteTempNoteBtn_Click);
            // 
            // newNoteBtn
            // 
            this.newNoteBtn.Name = "newNoteBtn";
            this.newNoteBtn.Size = new System.Drawing.Size(219, 26);
            this.newNoteBtn.Text = "Новая заметка";
            this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
            // 
            // insertImageBtn
            // 
            this.insertImageBtn.Name = "insertImageBtn";
            this.insertImageBtn.Size = new System.Drawing.Size(219, 26);
            this.insertImageBtn.Text = "Вставить картинку";
            this.insertImageBtn.Click += new System.EventHandler(this.insertImageBtn_Click);
            // 
            // fontComboBox
            // 
            this.fontComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Time New Roman"});
            this.fontComboBox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(155, 28);
            this.fontComboBox.Text = "Выберите шрифт";
            this.fontComboBox.TextChanged += new System.EventHandler(this.fontComboBox_TextChanged);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(75, 28);
            this.fontSizeComboBox.TextChanged += new System.EventHandler(this.fontSizeComboBox_TextChanged);
            // 
            // boldBtn
            // 
            this.boldBtn.BackColor = System.Drawing.SystemColors.Control;
            this.boldBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boldBtn.Image = ((System.Drawing.Image)(resources.GetObject("boldBtn.Image")));
            this.boldBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(29, 25);
            this.boldBtn.Text = "B";
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // underlineBtn
            // 
            this.underlineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underlineBtn.Image = ((System.Drawing.Image)(resources.GetObject("underlineBtn.Image")));
            this.underlineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineBtn.Name = "underlineBtn";
            this.underlineBtn.Size = new System.Drawing.Size(29, 25);
            this.underlineBtn.Text = "U";
            this.underlineBtn.Click += new System.EventHandler(this.underlineBtn_Click);
            // 
            // italicBtn
            // 
            this.italicBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italicBtn.Image = ((System.Drawing.Image)(resources.GetObject("italicBtn.Image")));
            this.italicBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(29, 25);
            this.italicBtn.Text = "I";
            this.italicBtn.Click += new System.EventHandler(this.italicBtn_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(0, 31);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.PlaceholderText = "Введите название заметки";
            this.titleTextBox.Size = new System.Drawing.Size(800, 27);
            this.titleTextBox.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.noteToolStrip);
            this.Controls.Add(this.noteTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteForm";
            this.ShowIcon = false;
            this.Text = "Заметки";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.noteToolStrip.ResumeLayout(false);
            this.noteToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox noteTextBox;
        private System.Windows.Forms.ToolStrip noteToolStrip;
        private System.Windows.Forms.ToolStripSplitButton noteBtn;
        private System.Windows.Forms.ToolStripMenuItem saveNoteBtn;
        private System.Windows.Forms.ToolStripComboBox fontComboBox;
        private System.Windows.Forms.ToolStripComboBox fontSizeComboBox;
        private System.Windows.Forms.ToolStripButton boldBtn;
        private System.Windows.Forms.ToolStripButton underlineBtn;
        private System.Windows.Forms.ToolStripButton italicBtn;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ToolStripMenuItem noteListBtn;
        private System.Windows.Forms.ToolStripMenuItem deleteTempNoteBtn;
        private System.Windows.Forms.ToolStripMenuItem newNoteBtn;
        private System.Windows.Forms.ToolStripMenuItem insertImageBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

