using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
    public interface IServiciosAplicacion : IDisposable
    {
        //IControlDePatentes ControlDePatentes { get; }
        ITraductorUsuario TraductorUsuario { get; }
        //IBitacora Bitacora { get; }
        //IUsuario Usuario { get; }
        //IEmpleado Empleado { get; }
        //IBackupRestore BackupRestore { get; }
        //IGestorDePermisos GestorDePermisos { get; }
        //ICentroDeSalud CentroDeSalud { get; }
        //IEspecialidad Especialidad { get; }
        //IAgenda Agenda { get; }
        //ITurno Turno { get; }
        //IPaciente Paciente { get; }
        //IHistoriaClinica HistoriaClinica { get; }
    }
}
