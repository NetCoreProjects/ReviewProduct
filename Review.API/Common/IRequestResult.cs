namespace Review.API.Common
{
    public interface IRequestResult
    {
        RequestError Error { get; }

        bool IsSuccess { get; }
    }
}
