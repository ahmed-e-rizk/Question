namespace Question.Repository
{
    public interface IRepository
    {
        T Add<T>(T entity);

    }
}
