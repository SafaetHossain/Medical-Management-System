﻿using VmsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VmsData
{
    public interface IDoctorDataAccess
    {
        IEnumerable<Doctor> GetAll(bool includeUser = false);
        Doctor GetByContact(string contact, bool includeUser = false);
        Doctor GetByName(string name, bool includeUser = false);
        Doctor GetByExpartArea(string expartArea, bool includeUser = false);
        int Insert(Doctor doctor);
        int Update(Doctor doctor);
        int UpdatePassword(Doctor doctor);
        int Delete(string contact);
    }
}
