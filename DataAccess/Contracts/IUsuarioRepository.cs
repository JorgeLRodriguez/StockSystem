using Entities.Infraestructure;

namespace DataAccess.Contracts
{
    public interface IUsuarioRepository
    {
        Usuario GetByName(string nombreUsuario);
        //Usuario ObtenerPorEmpleado(BE.Empleados.Empleado empleado);
        //Usuario CrearCredencialDeUsuario(BE.Empleados.Empleado empleado, BE.Infraestructura.IPermiso permiso, string nombreUsuario);
        //void EliminarCredencialDeUsuario(BE.Infraestructura.Usuario credencialUsuario);
    }
}
