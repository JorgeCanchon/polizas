namespace Polizas.Core.Entities
{
    public class User
    {
        public int Id { get; init; }
        public string Usuario { get; init; }
        public string Password { get; init; }
        public DateTime FechaCreacion { get; init; }

        public User(int Id, string Usuario, string Password, DateTime FechaCreacion)
        {
            this.Id = Id;
            this.Usuario = Usuario;
            this.Password = Password; //No esta encriptada
            this.FechaCreacion = FechaCreacion;
        }
    }
}
