using Serenity;
using Serenity.Extensibility;

namespace Miapp2
{
    [NestedLocalTexts]
    public static partial class Texts
    {
        public static class Db
        {
            public static class Administration
            {
                public static class Translation
                {
                    public static LocalText EntityPlural = "Translations";
                    public static LocalText Key = "Local Text Key";
                    public static LocalText SourceLanguage = "Source Language";
                    public static LocalText SourceText = "Effective Translation in Source Language";
                    public static LocalText TargetLanguage = "Target Language";
                    public static LocalText TargetText = "Effective Translation in Target Language";
                    public static LocalText CustomText = "User Translation in Target Language";
                    public static LocalText OverrideConfirmation = "Overwrite user translation with clicked text?";
                    public static LocalText SaveChangesButton = "Save Changes";
                }
            }
        }

        public static class Forms
        {
            public static class Membership
            {
                public static class ChangePassword
                {
                    public static LocalText FormTitle = "Cambiar contraseña";
                    public static LocalText SubmitButton = "Cambiar contraseña";
                    public static LocalText Success = "Tu contraseña a sido actualizada.";
                }

                public static class ForgotPassword
                {
                    public static LocalText FormInfo = "Por favor ingresa tu contraseña.";
                    public static LocalText FormTitle = "Recuperar contraseña";
                    public static LocalText SubmitButton = "Recuperar contraseña";
                    public static LocalText Success = "Un correo con instrucciones para restablecer su contraseña ha sido enviado.";
                    public static LocalText BackToLogin = "I remember my password";
                }

                public static class ResetPassword
                {
                    public static LocalText EmailSubject = "Reset Your Serene1 Password";
                    public static LocalText FormTitle = "Reset Password";
                    public static LocalText SubmitButton = "Reset Password";
                    public static LocalText Success = "Your password is changed. Please login with your new password.";
                    public static LocalText BackToLogin = "I remember my password. Don't reset it!";
                }

                public static class Login
                {
                    public static LocalText FormTitle = "BIENVENIDO A CONSTRUCTURAS";
                    public static LocalText SignInButton = "Inicia sesion";
                    public static LocalText ForgotPassword = "Olvidaste tu contraseña";
                    public static LocalText SignUpButton = "Registar";
                    public static LocalText RememberMe = "Recordar";
                    public static LocalText OR = "OR";
                    public static LocalText FacebookButton = "Inicia sesion Facebook";
                    public static LocalText GoogleButton = "Inicia sesion Google+";
                }

                public static class SignUp
                {
                    public static LocalText ActivateEmailSubject = "Registrar ";
                    public static LocalText ActivationCompleteMessage = "Cuenta activada. " +
                        "Use the e-mail and password you used while signing up to login.";
                    public static LocalText FormInfo = "Enter your details to create a free account.";
                    public static LocalText FormTitle = "Sign up for Serene1";
                    public static LocalText SubmitButton = "Sign Up";
                    public static LocalText Success = "An e-mail with instructions to active your account is " +
                        "sent to your e-mail address. Please check your e-mails.";

                    public static LocalText DisplayName = "Nombre completo";
                    public static LocalText Email = "Correo electrónico";
                    public static LocalText ConfirmEmail = "Confirmar correo electrónico";
                    public static LocalText Password = "Contraseña";
                    public static LocalText ConfirmPassword = "confirmar contraseña";

                    public static LocalText AcceptTerms = "I agree to the terms";
                    public static LocalText BackToLogin = "I already have a membership";
                }
            }
        }

        public static class Navigation
        {
            public static LocalText LogoutLink = "Logout";
            public static LocalText SiteTitle = "ROCORANZ";
        }

        public static class Site
        {
            public static class AccessDenied
            {
                public static LocalText PageTitle = "Acceso no Autorizado";
                public static LocalText LackPermissions = "No tienes los permisos necesarios para acceder a esta pagina!";
                public static LocalText NotLoggedIn = "Debes iniciar sesión para acceder a esta página!";
                public static LocalText ClickToChangeUser = "haga clic aquí para iniciar sesión con otro usuario ...";
                public static LocalText ClickToLogin = "Haga clic aquí para regresar a la página de inicio de sesión...";
            }

            public static class Dashboard
            {
                public static LocalText ContentDescription =
                    "a sample with random data (from free <em><a href = \"https://almsaeedstudio.com/\" target= \"_blank\">" +
                    "AdminLTE theme</a></em>)";
            }

            public static class BasicProgressDialog
            {
                public static LocalText CancelTitle = "Operation cancelled. Waiting for in progress calls to complete...";
                public static LocalText PleaseWait = "Please wait...";
            }

            public static class BulkServiceAction
            {
                public static LocalText AllHadErrorsFormat = "All {0} record(s) that are processed had errors!";
                public static LocalText AllSuccessFormat = "Finished processing on {0} record(s) with success.";
                public static LocalText ConfirmationFormat = "Perform this operation on {0} selected record(s)?";
                public static LocalText ErrorCount = "{0} error(s)";
                public static LocalText NothingToProcess = "Please select some records to process!";
                public static LocalText SomeHadErrorsFormat = "Finished processing on {0} record(s) with success. {1} record(s) had errors!";
                public static LocalText SuccessCount = "{0} done";
            }

            public static class UserDialog
            {
                public static LocalText EditPermissionsButton = "Editar permisos";
                public static LocalText EditRolesButton = "Editar roles";
            }

            public static class UserRoleDialog
            {
                public static LocalText DialogTitle = "Editar roles";
                public static LocalText SaveSuccess = "Actualizar roles de usuario.";
            }

            public static class UserPermissionDialog
            {
                public static LocalText DialogTitle = "Editar permisos de usuario ({0})";
                public static LocalText SaveSuccess = "Actualizar permisos.";
                public static LocalText Permission = "Permisos";
                public static LocalText Grant = "Conceder";
                public static LocalText Revoke = "Revocar";
            }

            public static class RolePermissionDialog
            {
                public static LocalText EditButton = "Editar permisos";
                public static LocalText DialogTitle = "Editar Roles ({0})";
                public static LocalText SaveSuccess = "Actualizar roles.";
            }

            public static class Layout
            {
                public static LocalText FooterCopyright = "Copyright (c) 2015.";
                public static LocalText FooterInfo = "Serenity Platform";
                public static LocalText FooterRights = "All rights reserved.";
                public static LocalText GeneralSettings = "General Settings";
                public static LocalText Language = "Language";
                public static LocalText Theme = "Theme";
                public static LocalText ThemeBlack = "Black";
                public static LocalText ThemeBlackLight = "Black Light";
                public static LocalText ThemeBlue = "Blue";
                public static LocalText ThemeBlueLight = "Blue Light";
                public static LocalText ThemeGreen = "Green";
                public static LocalText ThemeGreenLight = "Green Light";
                public static LocalText ThemePurple = "Purple";
                public static LocalText ThemePurpleLight = "Purple Light";
                public static LocalText ThemeRed = "Red";
                public static LocalText ThemeRedLight = "Red Light";
                public static LocalText ThemeYellow = "Yellow";
                public static LocalText ThemeYellowLight = "Yellow Light";
            }

            public static class ValidationError
            {
                public static LocalText Title = "ERROR";
            }
        }

        public static partial class Validation
        {
            public static LocalText AuthenticationError = "Usuario o Contraseña incorrecto!";
            public static LocalText CurrentPasswordMismatch = "Su contraseña actual no es valida!";
            public static LocalText MinRequiredPasswordLength = "La contraseña introducida no tiene suficientes caracteres (min {0})!";
            public static LocalText InvalidResetToken = "Su token para restablecer su contraseña no es válido o ha expirado!";
            public static LocalText InvalidActivateToken = "Your token to activate your account is invalid or has expired!";
            public static LocalText CantFindUserWithEmail = "Can't find a user with that e-mail adress!";
            public static LocalText EmailInUse = "Another user with this e-mail exists!";
            public static LocalText EmailConfirm = "Emails entered doesn't match!";
            public static LocalText DeleteForeignKeyError = "Can't delete record. '{0}' table has " +
                "records that depends on this one!";
            public static LocalText SavePrimaryKeyError = "Can't save record. There is another record with the same {1} value!";
        }
    }
}