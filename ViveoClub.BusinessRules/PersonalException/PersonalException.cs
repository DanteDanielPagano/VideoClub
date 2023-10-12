namespace VideoClub.BusinessRules.PersonalException
{
    public class DBMySqlException : Exception
    {

        public int Number { get; set; }
        public string MessageError { get; set; }
        public DBMySqlException(int number, string message)
        {
            switch (number)
            {
                case 1045:
                    Number = 401;
                    MessageError = "Usuario o contraseña inválido.";
                    break;
                case 1042:
                    Number = 503;
                    MessageError = "El servidor no es accesible.";
                    break;
                case 1049:
                    Number = 404;
                    MessageError = "La base de datos no existe.";
                    break;
                default:
                    Number = number;
                    MessageError = message;
                    break;
            }
        }
    }
}
