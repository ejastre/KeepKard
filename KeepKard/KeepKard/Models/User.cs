namespace KeepKard.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool PhoneChecked { get; set; }
        public string Email { get; set; }
        public bool EmailChecked { get; set; }
    }
}
