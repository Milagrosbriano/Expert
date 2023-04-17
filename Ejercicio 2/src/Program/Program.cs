using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1=new Doctor("Juan", "Pérez", 123456, "099123456", "juan.perez@hospital.com", "Cardiología", "Consultorio A");
            Paciente paciente1 = new Paciente("1234567", "Milagros", "Briano", 19, "0997654321", "milagrosbriano@gmail.com");
        
            Consulta consulta1= new Consulta(DateTime.Now, doctor1, paciente1, "Rutina"); //datetime.now FECHA ACTUAL
            consulta1.agregarConsulta(consulta1.Fecha, consulta1.Doctor, consulta1.Paciente, consulta1.Observaciones);
            Consulta consultaEncontrada = Consulta.buscarConsulta("1111111", consulta1.Fecha);
            
        }
    }
}
