using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.interfaces.LogoutInterfaces
{
public      interface ILogoutRepository

    {
        void InvalidateToken(string token); 
    bool IsTokenValid(string token);   
}
}
