using System;


public class MusicPlaylistOrganizer
{
    public static void Main(string[] args)
    {
        Console.Write ("Song to add: ");
        int len = Convert.ToInt32(Console.ReadLine());
        Song[] songs = new Song[len];
        double totalTime = 0;
        
        for(int i = 0; i < len; i++)
        {
            
        Console.WriteLine($"\nSong #{i + 1}");
        Console.Write("Title: ");
        string t = Console.ReadLine();
        
        Console.Write("Artist: ");
        string a = Console.ReadLine();
        
        Console.Write("Duration (minutes): ");
        double d = double.Parse(Console.ReadLine());
        
        songs[i] = new Song(t,a,d);
        
        }
        
        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        Console.WriteLine($"{"Title", -18}{"Artist", -15}Time");
        Console.WriteLine("----------------------------------------------");
        foreach(Song s in songs){
            s.DisplaySong();
            totalTime += s.duration;
        }
        Console.WriteLine($"\nTotal Duration: {totalTime:F2} mins");
        Console.WriteLine($"Average Duration: {totalTime/len:F2} mins");
        
    }
    
    public class Song{
        private string title;
        private string artist;
        public double duration;
        
       
        public Song(string title, string artist, double duration){
            this.title = title;
            this.artist = artist;
            this.duration = duration;
        }
        
         public Song(string title, string artist): this(title, artist, 0){
        }
        public Song(): this("unknown", "unknown", 0){
        }
        
        public void DisplaySong(){
         Console.WriteLine($"{title, -18}{artist, -15}{duration, -10:F2}");   
        }
        
        
    }
    
}
