using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class EmployeeTaskManager: IEmployeeTaskService
	{
		IEmployeeTaskDal _employeeTaskDal;

		public EmployeeTaskManager(IEmployeeTaskDal employeeTaskDal)
		{
			_employeeTaskDal = employeeTaskDal;
		}

		public void TAdd(EmployeeTask t)
		{
			_employeeTaskDal.Insert(t);
		}

		public void TDelete(EmployeeTask t)
		{
			_employeeTaskDal.Delete(t);
		}

		public EmployeeTask TGetById(int id)
		{
			return _employeeTaskDal.GetByID(id);
		}

		public List<EmployeeTask> TGetList()
		{
			return _employeeTaskDal.GetList();
		}

		public void TUpdate(EmployeeTask t)
		{
			_employeeTaskDal.Update(t);
		}
	}
}
