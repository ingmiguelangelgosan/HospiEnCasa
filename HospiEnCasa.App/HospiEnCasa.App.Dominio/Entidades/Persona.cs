namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary> 
    public class Persona
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string NumeroTelefono { get; set; }

        public Genero Genero { set; get;}
    }
}
