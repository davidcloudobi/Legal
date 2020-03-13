using System.Collections.Generic;
using LegalData.Model;

namespace LegalData.DIL
{
    public interface ILawyersAct
    {
       IAsyncEnumerable< Lawyer> GetAll();
       bool Register(Lawyer lawyer);
    }
}