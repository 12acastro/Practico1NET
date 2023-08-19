using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class Persona
    {
        public string nombre { get; set; } = "--Sin Nombre--";
        private string documento = "";
        public string apellido { get; set; } = "--Sin Apellido--";
        private DateTime fechaNacimiento = DateTime.Now;

        public string FechaNacimiento
        {
            get
            {
                return fechaNacimiento.ToString("yyyy/MM/dd");
            }

            set
            {
                if (DateTime.TryParseExact(value, "yyyy/MM/dd", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                { 
                    this.fechaNacimiento = fecha;
                }
                else
                {
                    Console.WriteLine("Fecha de nacimiento inválida");
                }

            }
        }
        public string Documento
        {
            get
            {
                return documento;
            }
            set
            {
                if (value.Length < 7)
                {
                    throw new Exception("Formato Incorrecto.");
                }
                else
                {
                    documento = value.ToUpper();

                }
            }
        }
        public void Print ()
        {
            Console.WriteLine("Nombre: "+ this.nombre + " DOC: "+ this.documento);
        }

    }
}