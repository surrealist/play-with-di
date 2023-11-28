using PlayWithDI.IServices;
using System;

namespace PlayWithDI.Services
{
    public class AqiService : IAqiService
  {
    public int GetAQI(string place, DateTime dateTime)
    {
      return 78;
    }
  }
}
