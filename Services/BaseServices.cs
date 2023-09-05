using AutoMapper;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Services.Abstraction;
namespace Services
{
    public class BaseService:IBaseService { }
    public class BaseService<TReq, TEntity, TRes> :BaseService, IBaseService<TReq, TEntity, TRes>
    where TEntity : class
    {
        protected readonly DbSet<TEntity> _dbSet;
        protected readonly IMapper _mapper;
        protected readonly AppDbContext _db;
        public BaseService(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
            _mapper = mapper;
        }
        public async Task<TRes> CreateAsync(TReq user)
        {
            var ent = _mapper.Map<TReq, TEntity>(user);
           // ent.CreateDate = DateTime.Now;

            _dbSet.Add(ent);
            await _db.SaveChangesAsync(); // Use asynchronous SaveChangesAsync

            var res = _mapper.Map<TEntity, TRes>(ent);
            return res;
        }

        public  async Task  DeleteAsync(int id)
        {
            var ent = await _dbSet.FindAsync(id);

            if (ent != null)
            {
                _dbSet.Remove(ent);
                await _db.SaveChangesAsync(); // Use asynchronous SaveChangesAsync
            }
        }

        public async virtual Task<TRes> GetAsync(int id)
        {
            var ent = await _dbSet.FindAsync(id);
            var res = _mapper.Map<TEntity, TRes>(ent);
            return res;
        }
        public async Task<IEnumerable<TRes>> GetAllAsync()
        {
            var ents = await _dbSet.ToListAsync();

            var res = _mapper.Map<IEnumerable<TEntity>, IEnumerable<TRes>>(ents);
            return res;
        }
        public async virtual Task<TRes> UpdateAsync(TReq model)
        {
            var ent = _mapper.Map<TReq, TEntity>(model);
          //  ent.UpdateDate = DateTime.Now;

            _dbSet.Update(ent);
           await _db.SaveChangesAsync();
            var res = _mapper.Map<TEntity, TRes>(ent);
            return res;
        }
    }
}
