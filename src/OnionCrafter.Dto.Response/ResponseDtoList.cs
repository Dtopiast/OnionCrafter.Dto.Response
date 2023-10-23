namespace OnionCrafter.Dto.Response
{
    /// <summary>
    /// Represents a concrete implementation of the <see cref="IResponseDtoList{T}"/> interface, which is a collection of response data transfer objects (DTOs).
    /// </summary>
    /// <typeparam name="T">The type of response data transfer objects in the collection.</typeparam>
    public class ResponseDtoList<T> :
        List<T>,
        IResponseDtoList<T>
        where T : class, IResponseDto
    {
    }
}