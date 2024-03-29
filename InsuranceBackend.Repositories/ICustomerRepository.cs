﻿using System.Collections.Generic;
using InsuranceBackend.Models;

namespace InsuranceBackend.Repositories
{
    public interface ICustomerRepository: IRepository<Customer>
    {
        IEnumerable<CustomerList> CustomerPagedList(int page, int rows);
    }
}
