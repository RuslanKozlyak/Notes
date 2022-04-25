using System.Collections.Generic;

namespace Domain.Data
{
    public class Note : BaseEntity
    {
        public string Title { get; set; }
        public string NoteText { get; set; }
    }
}
