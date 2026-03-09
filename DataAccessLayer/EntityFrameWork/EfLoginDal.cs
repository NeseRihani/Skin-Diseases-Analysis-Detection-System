using DataAccessLayer.Abstruct;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
	public class EfLoginDal : GenericRepository<Login>, ILoginDal

	{
        private readonly SkinAnalyseContext context;
        public EfLoginDal(SkinAnalyseContext context) : base(context)
        {
            this.context = context;
        }

        public string GetUserNameById(int id)
        {
            // Kullanıcı Tablosunda id'ye göre kullanıcı adını al
            var userName = context.Users
                .Where(u => u.userId == id)
                .Select(u => u.userName)
                .FirstOrDefault();

            return userName;

        }
	}
}
