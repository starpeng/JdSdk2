#region CopyRight
/**************************************************************
   Copyright (c) 2013 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.18052
   命名空间名称   :    JdSdk
   文件名         :    JdRequestBase
   创建时间       :    2013/10/22 11:22:20
   用户所在的域   :    SWT410
   登录用户名     :    Star
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    public abstract class JdRequestBase<T> : IJdRequest<T> where T : JdResponse
    {
        IDictionary<String, Object> _addedParamters = new Dictionary<String, Object>();

        /// <summary>
        /// 附加参数
        /// </summary>
        public IDictionary<String, Object> AddedParam
        {
            get
            {
                return _addedParamters;
            }
        }

        /// <summary>
        /// API方法名称
        /// </summary>
        public abstract string ApiName
        {
            get;
        }

        /// <summary>
        /// 增加附加参数
        /// </summary>
        /// <param name="key">参数名</param>
        /// <param name="value">参数值</param>
        public void AddParam(String key, Object value)
        {
            _addedParamters.Add(key, value);
        }

        /// <summary>
        /// 移除附加参数
        /// </summary>
        /// <param name="key">参数名</param>
        /// <returns></returns>
        public Boolean RemoveParam(String key)
        {
            return _addedParamters.Remove(key);
        }

        protected abstract void PrepareParam(IDictionary<String, Object> paramters);

        public virtual String GetParamJson()
        {
            var paramters = new Dictionary<String, Object>();
            PrepareParam(paramters);
            foreach (var added in _addedParamters)
            {
                if (!paramters.ContainsKey(added.Key))
                {
                    paramters.Add(added.Key, added.Value);
                }
            }

            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public virtual void Validate()
        {
        }
    }
}
