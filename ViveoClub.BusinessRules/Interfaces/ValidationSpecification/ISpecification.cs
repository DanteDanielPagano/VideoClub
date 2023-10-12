using VideoClub.BusinessRules.DTOs.ValidationDTO;

namespace VideoClub.BusinessRules.Interfaces.ValidationSpecification
{
    /// <summary>
    /// Iinterfaz que se utiliza para representar especificaciones de validación
    /// en el sistema.
    /// </summary>
    /// <typeparam name="T">
    /// Objeto al que se aplica la especificación de validación.
    /// </typeparam>
    public interface ISpecification<T> where T : class
    {
        /// <summary>
        /// Valida el objeto según la especificación y devuelve una lista de 
        /// errores de validación.
        /// </summary>
        /// <returns>Una lista de errores de validación. Si la validación es exitosa, 
        /// la lista estará vacía.</returns>
        List<ValidationErrorDTO> IsValid();
    }
}
