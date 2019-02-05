namespace SRM.Logic.Classes
{
    public class ServerInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Port { get; set; } = 2302;
        public string Password { get; set; } = string.Empty;
        public bool BattleEye { get; set; } = false;
    }
}
