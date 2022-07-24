using System;
using System.Collections.Generic;
namespace Project13InsuranceManagement.Views
{
    public interface IForm
    {
        List<String> ValidateForm();
        void Set(Object t);
        void Reset();
        bool ValidateAndCreateObject();
        bool ValidateAndUpdateObject(Object o);
    }
}