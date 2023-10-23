using OnionCrafter.Action.Response.Base;
using OnionCrafter.Dto.Response;

namespace OnionCrafter.Dto.Response
{
    /// <summary>
    /// Represents an interface for a collection of response data transfer objects (DTOs) implementing <see cref="IResponseDto"/>.
    /// </summary>
    /// <typeparam name="T">The type of response data transfer objects in the collection.</typeparam>

    public interface IResponseDtoList<T> : IList<T>, IResponseData
        where T : class, IResponseDto
    {
    }
}