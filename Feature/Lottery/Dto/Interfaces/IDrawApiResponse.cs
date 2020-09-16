namespace Business.Dto.Interfaces
{
    public interface IDrawApiResponse
    {
        string ErrorInfo { get; set; }

        bool Success { get; set; }
    }
}
