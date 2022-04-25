
namespace Notes
{
    partial class NoteListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.notesList = new System.Windows.Forms.Panel();
            this.noNotesLable = new System.Windows.Forms.Label();
            this.deleteAllBtn = new System.Windows.Forms.Button();
            this.notesList.SuspendLayout();
            this.SuspendLayout();
            // 
            // notesList
            // 
            this.notesList.AutoScroll = true;
            this.notesList.Controls.Add(this.deleteAllBtn);
            this.notesList.Controls.Add(this.noNotesLable);
            this.notesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesList.Location = new System.Drawing.Point(0, 0);
            this.notesList.Name = "notesList";
            this.notesList.Size = new System.Drawing.Size(437, 450);
            this.notesList.TabIndex = 0;
            // 
            // noNotesLable
            // 
            this.noNotesLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noNotesLable.AutoSize = true;
            this.noNotesLable.Location = new System.Drawing.Point(118, 46);
            this.noNotesLable.Name = "noNotesLable";
            this.noNotesLable.Size = new System.Drawing.Size(206, 20);
            this.noNotesLable.TabIndex = 0;
            this.noNotesLable.Text = "У вас нет ни одной заметки!";
            this.noNotesLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noNotesLable.Visible = false;
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteAllBtn.Location = new System.Drawing.Point(0, 421);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(437, 29);
            this.deleteAllBtn.TabIndex = 1;
            this.deleteAllBtn.Text = "Удалить все заметки";
            this.deleteAllBtn.UseVisualStyleBackColor = true;
            this.deleteAllBtn.Click += new System.EventHandler(this.deleteAllBtn_Click);
            // 
            // NoteListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.notesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NoteListForm";
            this.Text = "Список заметок";
            this.Load += new System.EventHandler(this.NoteListForm_Load);
            this.notesList.ResumeLayout(false);
            this.notesList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel notesList;
        private System.Windows.Forms.Label noNotesLable;
        private System.Windows.Forms.Button deleteAllBtn;
    }
}