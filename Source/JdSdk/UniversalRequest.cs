#region CopyRight
/**************************************************************
   Copyright (c) 2013 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.34003
   命名空间名称   :    JdSdk
   文件名         :    UniversalRequest
   创建时间       :    2013/12/21 17:21:16
   用户所在的域   :    XPC
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
using System.Text;
using JdSdk.Request;
using Newtonsoft.Json;

namespace JdSdk
{
    public class UniversalRequest : IJdRequest<UniversalResponse>
    {
        private String _apiName;

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
        public String ApiName
        {
            get { return _apiName; }
            set { _apiName = value; }
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

        public virtual String GetParamJson()
        {
            var paramters = new Dictionary<String, Object>();
            foreach (var added in _addedParamters)
            {
                if (!paramters.ContainsKey(added.Key))
                {
                    paramters.Add(added.Key, added.Value);
                }
            }

            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
#if NET40
            if (String.IsNullOrWhiteSpace(_apiName))
#else
            if (String.IsNullOrEmpty(_apiName) || String.IsNullOrEmpty(_apiName.Trim()))
#endif
            {
                throw new JdException("API方法名称不能为空！");

            }
        }
    }
}
