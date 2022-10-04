using System;
using AppCore8137.DataAccess.Services;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Servicess
{
    public class Service:ServiceBase<Ayakkabi>
    {
        public Service(DbContext Db):base(Db)
        {

        }
    }
}

