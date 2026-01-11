using System.Collections.Generic;

namespace LumosLib.BGDatabase
{
    public interface IBGManager
    {
        public List<T> GetAll<T>() where T : BaseBGData;
        public T Get<T>(int tableID) where T : BaseBGData;
    }
}