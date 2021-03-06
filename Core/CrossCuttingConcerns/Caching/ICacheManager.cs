using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {//duration:verinin cachete durma süresi
     //istenen şey cachete varsa ordan getirilir yoksa veritabanından getirilir.
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key);//cachete var mı metodu
        void Remove(string key); //cacheten uçurma metodu
        void RemoveByPattern(string pattern);//ör: isimde category olanları uçur
    }
}
