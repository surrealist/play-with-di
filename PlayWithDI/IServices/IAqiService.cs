using System;

namespace PlayWithDI.IServices
{
  public interface IAqiService
  {
    int GetAQI(string place, DateTime dateTime);
  }
}