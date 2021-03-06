﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Data;

using Entitys.ComonEnti;
using Common;
using FrameCommon;

namespace Xxx.ServiceInterfaces
{
    [ServiceContract(ConfigurationName = "Xxx.ServiceInterfaces.SomebizService")]
    public interface ISomebiz
    {
        #region 字典相关        

        /// <summary>
        /// 获取全部系统字典
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [OperationContract]
        string GetFrameDictAll(string req);

        /// <summary>
        /// 获取系统字典(某个字典的全部字典项)
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [OperationContract]
        string GetFrameDictPager(string req);

        /// <summary>
        /// 操作业务表，动作有增、改、删
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [OperationContract]
        string OpBizObjectSingle_SSY_FRAME_DICT(string req);


        /// <summary>
        /// 获取全部业务字典
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [OperationContract]
        string GetBizDictAll(string req);

        /// <summary>
        /// 获取系统字典(某个字典的全部字典项)
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [OperationContract]
        string GetBizDictPager(string req);

        /// <summary>
        /// 操作业务表，动作有增、改、删
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [OperationContract]
        string OpBizObjectSingle_SSY_BIZ_DICT(string req);

        /// <summary>
        /// 获取某个字典
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [OperationContract]
        string GetDicts(string req);

        #endregion
    }
}
