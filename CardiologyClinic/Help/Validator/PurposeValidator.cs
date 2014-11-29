using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardiologyClinic.Dao;
using CardiologyClinic.Bean;

namespace CardiologyClinic.Help.Validator
{
    class PurposeValidator
    {
        PurposeDao purposeDao = (PurposeDao)
            BeanFactory.GetFactory().GetBean("purposeDao");

        public bool DatePurposeValidate(Purpose purpose)
        {
            DateTime dt = purpose.DateOfProcedure;
            DateTime from = dt.AddMinutes(-30);
            DateTime to = dt.AddMinutes(30);

            IList<Purpose> list = purposeDao.GetPurposesBetween(from, to);

            if (list == null || list.Count == 0)
                return true;

            return false;
        }
    }
}
