using Entities.Infraestructure;

namespace Domain.Contracts
{
    public interface IUsuario
    {
        Usuario IniciarSesion(string nombreUsuario, string contraseña);
        Usuario FinalizarSesion();
    }
}
