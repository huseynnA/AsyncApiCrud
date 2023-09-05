namespace Services.Abstraction
{
    public interface IBaseService { }
    public interface IBaseService<TReq, TEntity, TRes>:IBaseService where TEntity : class
    {
        Task<TRes>GetAsync(int id);
        Task<IEnumerable<TRes>> GetAllAsync();
        Task< TRes> CreateAsync(TReq user);
        Task< TRes> UpdateAsync(TReq user);
        Task DeleteAsync(int id);
    }
}

