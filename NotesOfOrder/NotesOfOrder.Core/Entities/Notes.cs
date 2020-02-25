using System;
using System.Collections.Generic;
using System.Text;

namespace NotesOfOrder.Core.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public int MapCoordinatesX { get; set; }
        public int MapCoordinatesY { get; set; }
        public int StartRatId { get; set; }
        public int StartSeasonId { get; set; }
        public int StartSunId { get; set; }
        public int EndRatId { get; set; }
        public int EndSeasonId { get; set; }
        public int EndSunId { get; set; }
        public int CharacterId { get; set; }
        public string StorageLocale { get; set; }
        public int CurrencyGold { get; set; }
        public string NoteText { get; set; }
    }
}
