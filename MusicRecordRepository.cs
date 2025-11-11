namespace PairProgramming
{
    public class MusicRecordRepository
    {
        private readonly List<MusicRecord> _musicRecords = new();
        private int _nextId = 1;

        public MusicRecordRepository()
        {
            _musicRecords = new List<MusicRecord>()
            {
                new MusicRecord {Id = _nextId++, Title = "NextGen", Artist = "GenG", Duration = 500, Year = 2027},
                new MusicRecord {Id = _nextId++, Title = "PastGen", Artist = "GG", Duration = 350, Year = 2028},
                new MusicRecord {Id = _nextId++, Title = "FutureGen", Artist = "YesSir", Duration = 280, Year = 2029}
            };
        }

        public IEnumerable<MusicRecord> GetAllMusicRecords()
        {
            IEnumerable<MusicRecord> result = new List<MusicRecord>(_musicRecords);

            return result;
        }
    }
}
