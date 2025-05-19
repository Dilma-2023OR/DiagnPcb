using System;
using System.Collections.Generic;
using System.Text;
using DataAccessPCB;

namespace PCBDomain
{
    public class FailureModels
    {
        FailureDao FailureDao = new FailureDao();

        public bool Insertar(string failure, string config, string FailureEnglish)
        {
            return FailureDao.InsertFalla(failure, config, FailureEnglish);
        }
    }
}
