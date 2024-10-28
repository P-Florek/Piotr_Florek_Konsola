namespace konsola
{
    public class Program
    {
        public string patch = "\\Users\\5tptj\\Desktop\\Data.txt";

        public List<Albumclass> GetPatchTxt()
        {
            List<Albumclass> listAlbum = new List<Albumclass>();
            if(File.Exists(patch))
            {
                string[] line = File.ReadAllLines(patch);
                List<string> updateLines = new List<string>();
                foreach(string nline in line)
                {
                    if(!String.IsNullOrWhiteSpace(nline))
                    {
                        updateLines.Add(nline);
                    }
                }

                for(int i = 0; i < updateLines.Count; i+=5) {
                    try
                    {
                        Albumclass newAlbum = new Albumclass
                        {
                            Artist = updateLines[i],
                            Album = updateLines[i + 1],
                            songsNumber = int.Parse(updateLines[i + 2]),
                            year = int.Parse(updateLines[i + 3]),
                            downloadNumber = int.Parse(updateLines[i + 4])
                        };
                        listAlbum.Add(newAlbum);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine($"Błąd : {e.Message}");
                    }
                }
            }
            return listAlbum;
        }

        public void Display(List<Albumclass> listAlbum)
        {
            foreach(var album in listAlbum)
            {
                Console.WriteLine($"Autor : {album.Artist}, \nAlbum : {album.Album}, \nSongs Number : {album.songsNumber}, \nYear : {album.year}, \nDownload number : {album.downloadNumber}");
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
