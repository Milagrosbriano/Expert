using System;
using System.Collections.Generic;
using System.Text;


namespace Library
{// crear clase para doctor 
//crear clase para persona
//crear clase consulta 
    public class Doctor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Especialidad { get; set; }
        public string Consultorio {get; set;}

        public Doctor(string nombre, string apellido, int id, string telefono, string mail, string especialidad, string consultorio) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Id = id;
            this.Telefono = telefono;
            this.Mail = mail;
            this.Especialidad = especialidad;
            this.Consultorio= consultorio;
        }

    }

    public class Paciente 
    {
        public string Ci { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }

        public Paciente(string ci, string nombre, string apellido, int edad, string telefono, string mail) 
        {
            this.Ci = ci;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Telefono = telefono;
            this.Mail = mail;
        }
    }

    public class Consulta
    {
        public DateTime Fecha { get; set; }
        public Doctor Doctor { get; set; }
        public Paciente Paciente { get; set; }
        public string Observaciones { get; set; }
        public static List<Consulta> ListaConsultas { get; set; } = new List<Consulta>();

        public Consulta(DateTime fecha, Doctor doctor, Paciente paciente, string observaciones)
        {
            this.Fecha = fecha;
            this.Doctor = doctor;
            this.Paciente = paciente;
            this.Observaciones = observaciones;
        }

        public void agregarConsulta(DateTime fecha, Doctor doctor, Paciente paciente, string observaciones)
        {
            Consulta nuevaConsulta = new Consulta(fecha, doctor, paciente, observaciones);
            ListaConsultas.Add(nuevaConsulta);
            Console.WriteLine("Consulta agregada exitosamente");
        }
        public static Consulta buscarConsulta(string ciPaciente, DateTime fechaHoraConsulta)
        {
            foreach (var consulta in ListaConsultas)
            {
                if (consulta.Paciente.Ci == ciPaciente && consulta.Fecha == fechaHoraConsulta)
                {
                    return consulta;
                }
            
            }
        return null;

        }
        public static void eliminarConsulta(Consulta consultaEliminar)
        {
            if (ListaConsultas.Contains(consultaEliminar))
            {
                ListaConsultas.Remove(consultaEliminar);
                Console.WriteLine("Consulta eliminada");
            }
            else
            {
            Console.WriteLine("No se encontró la consulta");
            }
        }
    }
}
























