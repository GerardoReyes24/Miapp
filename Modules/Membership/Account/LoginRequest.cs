
namespace Miapp2.Membership
{
    using Serenity.ComponentModel;
    using Serenity.Services;

    [FormScript("Membership.Login")]
    [BasedOnRow(typeof(Administration.Entities.UserRow), CheckNames = true)]
    public class LoginRequest : ServiceRequest
    {
        [Placeholder("Nombre de usuario")]
        public string Username { get; set; }
        [PasswordEditor, Placeholder("ingresa la contraseña"), Required(true)]
        public string Password { get; set; }
    }
}