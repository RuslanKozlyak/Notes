
using Domain.Data;
using System.Collections.Generic;

namespace Domain.ServiceInterfaces
{
    public interface INoteInterface
    {

        public IEnumerable<Note> GetAllNodes();
        public Note GetNode(int id);
        public void AddNote(Note note);
        public void DeleteNote(Note note);
        public void DeleteAllNotes();
        public void UpdateNote(Note note);
    }
}
