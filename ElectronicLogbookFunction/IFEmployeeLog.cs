﻿using ElectronicLogbookModel;
using ElectronicLogbookModel.Filter;
using System.Collections.Generic;

namespace ElectronicLogbookFunction
{
    public interface IFEmployeeLog
    {
        #region CREATE
        EmployeeLog Create(int userId, EmployeeLog employeelog);
        #endregion

        #region RETRIEVE
        EmployeeLog Read(int EmployeeLogId);
        List<EmployeeLog> Read();
        List<EmployeeLog> Read(EmployeeLogFilter employeeLogFilter);
        #endregion

        #region UPDATE
        EmployeeLog Update(int userId, EmployeeLog employeelog);
        #endregion

        #region DELETE
        void Delete(int EmployeeLogId);
        #endregion
    }
}
