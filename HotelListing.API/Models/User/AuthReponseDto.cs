namespace HotelListing.API.Models.User
{
    public class AuthReponseDto
    {
        public string UserId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
