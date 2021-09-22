namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Enfermeria</c>
    /// Modela una Persona del personal de enfermería del equipo medico de apoyo 
    /// </summary>   
    public class Enfermeria : Persona
    {
        /// Numero único de la tarjeta profesional   
        public string TarjetaProfesional { get; set; }
        /// Cantidad de horas laborales a la semana 
        public int HorasLaborales { get; set; }
    }
}