using System;

namespace ParcialPOO2
{
    public class DatabaseException : Exception
    {
        
        public DatabaseException(string message) : base(message){
        }
    }
}