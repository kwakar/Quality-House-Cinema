using Newtonsoft.Json;

namespace QualityCinemaAuto
{
    public class LoginUser
    {
        public LoginUser()
        {
        }

        [JsonProperty("email")]
        public string Email { set; get; }

        [JsonProperty("password")]
        public string Password { set; get; }

        [JsonProperty("display_name")]
        public string DisplayName { set; get; }


        //This method allow us to override following properties
        //with the data from Json file
        public LoginUser(LoginUser other)
        {
            this.Email = other.Email;
            this.Password = other.Password;
            this.DisplayName = other.DisplayName;
        }

    }
}