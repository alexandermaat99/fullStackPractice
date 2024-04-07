namespace WebApplication1.Data
{
    public interface IFoodRepository
    {
        IEnumerable<MarriottFood> Foods { get; }

    }
}
