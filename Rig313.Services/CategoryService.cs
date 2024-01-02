using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rig313.Data;
using Rig313.Core.Categories;
using Rig313.Data.IRepository;
using Rig313.Services.IServices;

namespace Rig313.Services
{
	public class CategoryService : IService
	{
		private readonly IRepository<Category> _repository;

        public CategoryService(IRepository<Category> repository)
        {
			_repository = repository;
        }

        public IEnumerable<Category?> GetAllCategories()
		{
			return _repository.GetAll(true);
		}
		public Category? GetById(int id)
		{
			return _repository.GetById(id);
		}
	}
}
