namespace FBSharedLibrary.Models
{
    public class UserFull
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int GenderId { get; set; }
        public DateTime Dob { get; set; }
        public int SecurityQuestionID { get; set; }
        public string SecurityQuestionAnswer { get; set; }
    }
}
