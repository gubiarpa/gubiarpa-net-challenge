namespace gubiarpa.kidso_challenge.webapi.Entities
{
    public class JwtSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public int ExpiryInMinutes { get; set; }
    }
}
