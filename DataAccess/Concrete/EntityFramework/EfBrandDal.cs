﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            return null;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return null;
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
