namespace Core.DataManager.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Citizenship { get; set; } = string.Empty;
        public string Ethnicity { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MobilePhone { get; set; } = string.Empty;
        public string IDCardNumber { get; set; } = string.Empty;
        public string NPI { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string BirthCity { get; set; } = string.Empty;
        public string BirthCountry { get; set; } = string.Empty;
        public string HomeAddress { get; set; } = string.Empty;
        public string HomeCity { get; set; } = string.Empty;
        public string HomeCountry { get; set; } = string.Empty;
        public string HomeZip { get; set; } = string.Empty;
        public string HomePhone { get; set; } = string.Empty;

        public Position Position { get; set; } = new Position();
    }
}
