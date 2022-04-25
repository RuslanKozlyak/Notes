using Domain.Data;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class NoteService : INoteInterface
    {
        private readonly IRepository<Note> _noteRepository;

        public NoteService(IRepository<Note> noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public void AddNote(Note note)
        {
            var existingNote = _noteRepository.Get(note.Id);
            if (existingNote != null)
                _noteRepository.Update(note);
            else
                _noteRepository.Insert(note);
        }

        public Note GetNode(int id)
        {
            return _noteRepository.Get(id);
        }

        public IEnumerable<Note> GetAllNodes()
        {
            return _noteRepository.GetAll();
        }

        public void DeleteNote(Note note)
        {
            _noteRepository.Remove(note);
        }

        public void DeleteAllNotes()
        {
            var notes = _noteRepository.GetAll().ToList();
            int count = notes.Count();

            for (int i = 0; i < count; i++)
            {
                _noteRepository.Remove(notes[i]);
            }
        }

        public void UpdateNote(Note note)
        {
            _noteRepository.Update(note);
        }
    }
}
