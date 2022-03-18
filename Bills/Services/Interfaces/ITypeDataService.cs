using Bills.Models.Entities;
using Bills.Models.ModelView;
using System.Collections.Generic;

namespace Bills.Services.Interfaces
{
    public interface ITypeDataService
    {

        public List<TypeData> getAll();
        public int create(TypeView typeView);

        public bool Unique(string Name , int CompanyId);
    }
}
