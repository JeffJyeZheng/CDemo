using AutoMapper;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Mappings
{
    public class BModelProfile : Profile
    {
        public BModelProfile()
        {
            this.CreateMap<AModel, BModel>();
        }
    }
}
