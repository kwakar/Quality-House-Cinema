using Newtonsoft.Json;

namespace QualityCinemaAuto
{
    public class RegistrationUser
    {
        public RegistrationUser()
        {
        }
               
        [JsonProperty("email")]
        public string Email { set; get; }

        [JsonProperty("password")]
        public string Password { set; get; }

        [JsonProperty("confirm_password")]
        public string ConfirmPassword { set; get; }

        [JsonProperty("display_name")]
        public string DisplayName { set; get; }

        [JsonProperty("year_of_birth")]
        public string YearofBirth { set; get; }


        //This method allow us to override following properties
        //with the data from Json file
        public RegistrationUser(RegistrationUser other)
        {
            this.Email = other.Email;
            this.Password = other.Password;
            this.ConfirmPassword = other.ConfirmPassword;
            this.DisplayName = other.DisplayName;
            this.YearofBirth = other.YearofBirth;
        }
    }
}