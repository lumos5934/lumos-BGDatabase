using System;
using System.Collections.Generic;
using System.Linq;
using BansheeGz.BGDatabase;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Lumos
{
    public class BGManager : MonoBehaviour, IPreInitializable, IBGManager
    {
        #region >--------------------------------------------------- FIELD
        
       
        private Dictionary<Type, Dictionary<int, BaseBGData>> _entryDict = new();
        
        
        #endregion
        #region >--------------------------------------------------- INIT

        
        public UniTask<bool> InitAsync()
        {
            GlobalService.Register<IBGManager>(this);
            return UniTask.FromResult(true);
        }
         
        
        #endregion
        #region >--------------------------------------------------- REGISTER


        private void Register<T>() where T : BaseBGData
        {
            var type = typeof(T);
            var meta = BGRepo.I[type.Name];
            
            _entryDict[type] = new Dictionary<int, BaseBGData>();
            
            foreach (var entity in  meta.EntitiesToList())
            {
                var instance = (BaseBGData)Activator.CreateInstance(typeof(T), entity);
                
                _entryDict[type][instance.TableID] = instance;
            }
        }
        
        
        #endregion
        #region >--------------------------------------------------- GET


        public List<T> GetAll<T>() where T : BaseBGData
        {
            var type = typeof(T);
            
            if (!_entryDict.ContainsKey(type))
            {
                Register<T>();
            }
            
            return _entryDict[type].Values.Cast<T>().ToList();
        }
        
        public T Get<T>(int tableID) where T : BaseBGData
        {
            var type = typeof(T);
            
            if (!_entryDict.ContainsKey(type))
            {
                Register<T>();
            }
            
            return _entryDict[type][tableID] as T;
        }
        
        
        #endregion
    }
}