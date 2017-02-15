using System;

namespace WindowsFormsApplication3
{
    public interface IMount
    {
        DateTime GetDateTime();        
    }
    public class Mount : IMount
    {
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
    }
}
