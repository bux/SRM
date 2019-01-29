namespace SRM.Classes
{
    public class RepoProfile
    {
        public string Name { get; set; }
        public Repository Repository { get; set; } = new Repository();
    }
}
