using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Dtos
{
    public class LogoutResponseDto
    {
        public LogoutResponseDto(string message, DateTime logoutTime)
        {
            Message = message;
            LogoutTime = logoutTime;
        }

        public string Message { get; set; }
        public DateTime LogoutTime { get; set; }
    }
}
