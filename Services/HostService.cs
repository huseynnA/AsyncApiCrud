using AutoMapper;
using DataAccess;
using DataAccess.Entity;
using DTO;
using Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HostService : BaseService<Host, HostDTO, Host>,IHostService
    {
        public HostService(AppDbContext db, IMapper mapper) : base(db, mapper)
        {

        }
    }
}
