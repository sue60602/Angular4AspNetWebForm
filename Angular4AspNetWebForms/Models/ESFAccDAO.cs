using Angular4AspNetWebForms.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Angular4AspNetWebForms.Models
{
    public class ESFAccDAO
    {
        ESFAccEntities db = new ESFAccEntities();
        public IQueryable<Pow_Func_FuncGrp> getPow_Func_FuncGrp(Expression<Func<Pow_Func_FuncGrp,bool>> condition) {
            var result = from s1 in db.Pow_Func_FuncGrp select s1;

            return result.Where(condition);
        }
    }
}