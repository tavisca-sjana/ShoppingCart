using System;
using System.Runtime.Serialization;

namespace CartApp
{
    [Serializable]
    internal class CategoryNotImplementedException : Exception
    {
        public CategoryNotImplementedException()
        {
        }

      
    }
}