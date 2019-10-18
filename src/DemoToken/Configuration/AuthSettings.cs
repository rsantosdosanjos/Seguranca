namespace DemoToken.Configuration
{
    public class AuthSettings
    {
        public string Secret { get; set; }
        public int Expire { get; set; }
        public string Issue { get; set; }
        public string ValidOn { get; set; }
    }
}
