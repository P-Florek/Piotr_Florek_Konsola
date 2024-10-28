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
                    
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
