using CarBook.Application.interfaces.LogoutInterfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.LogoutRepositories
{
    public class LogoutRepository : ILogoutRepository
    {
        private readonly ConcurrentDictionary<string, bool> _tokenStorage = new();

        // Token geçersiz kılma işlemi
        public void InvalidateToken(string token)
        {
            // Token'i geçersiz olarak işaretle
            _tokenStorage[token] = false;
        }

        // Token geçerli mi kontrol et
        public bool IsTokenValid(string token)
        {
            // Eğer token mevcut değilse, varsayılan olarak geçersiz kabul et
            return _tokenStorage.TryGetValue(token, out bool isValid) && isValid;
        }
    }
}
