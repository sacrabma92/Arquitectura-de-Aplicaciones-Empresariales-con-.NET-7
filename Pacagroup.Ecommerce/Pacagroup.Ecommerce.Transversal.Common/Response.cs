namespace Pacagroup.Ecommerce.Transversal.Common
{
    // v18 minuto 10:30
    public class Response<T>
    {
        // Contendra la informacion de los metodos. Respuesta de los metodos: Update, Get, GetAll, Delete etcc....
        public T Data { get; set; }
        // Almacenara la informacion del estado de la ejecucion.
        public bool IsSuccess { get; set; }
        // Almacenara informacion del mensaje error o ok.
        public string Message { get; set; }
    }
}
