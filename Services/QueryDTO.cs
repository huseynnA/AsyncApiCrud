using AutoMapper;
using DataAccess;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class QueryDTO : BaseService<Query, QueryDTO, Query>
    {
        public QueryDTO(AppDbContext db, IMapper mapper) : base(db, mapper)
        {
        }
    }
}
