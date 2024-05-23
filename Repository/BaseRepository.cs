using Question.DbContext;

namespace Question.Repository
{
    public class BaseRepository : IRepository
    {
        public  AppDbContext _dbContext { get; set; }

        public BaseRepository(AppDbContext dbContext)
        {
            _dbContext= dbContext;
        }

        public T Add<T>(T entity)
        {
              _dbContext.Add(entity);
              return entity;
        }public T AddAsync<T>(T entity)
        {
              _dbContext.AddAsync(entity);
              return entity;
        }
        
        public T Delete<T>(T entity)
        {
              _dbContext.Remove(entity);
              return entity;
        }

        public T Update<T>(T entity)
        {
            _dbContext.Update(entity);
            return entity;
        }

        public  List<T> Add<T>(List<T> entities)
        {
            if (entities != null && entities.Count() > 0)

                _dbContext.AddRange(entities);
            return entities;
        }
    }

    
}
