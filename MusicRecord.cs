namespace PairProgramming
{
    public class MusicRecord
    {
        private string _title;
        private string _artist;
        private int _duration;
        private int _year;

        public int Id { get; set; }

        public string Title
        {
            get { return _title; }
            set
            {  
                if (value == null)
                {
                    throw new ArgumentNullException("Title cannot be null.");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title must be more than 3 characters.");
                }
                _title = value;
            }
        }

        public string Artist
        {
            get { return _artist; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Artist cannot be null.");
                }
                if (value.Length < 1)
                {
                    throw new ArgumentException("Artist must be more than 1 characters.");
                }
                _artist = value; 
            }
        }

        public int Duration
        {
            get { return _duration; }
            set
            { 
                if (value <= 0)
                {
                    throw new ArgumentException("Duration must be a positiv number.");
                }
                _duration = value; 
            }
        }

        public int Year
        {
            get { return _year; }
            set
            { 
                if (value < 1700)
                {
                    throw new ArgumentException("Year must be after 1700.");
                }
                _year = value; 
            }
        }

        public MusicRecord(int id, string title, string artist, int duration, int year)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Duration = duration;
            Year = year;
        }

        public MusicRecord() : this(0, "Unknown Title", "Unknown Artist", 1, 2000) { }

        public override string ToString()
        {
            return $"ID: {Id} - Title: {Title} - Artist: {Artist} - Duration: {Duration} - Year: {Year}";
        }
    }
}
