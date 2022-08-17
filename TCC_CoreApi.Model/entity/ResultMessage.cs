using System;
using System.Collections.Generic;
using System.Text;

namespace TCC_CoreApi.Model.entity
{
    public class ResultMessage
    {
        /// <summary>
        /// 返回消息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回结果 0 代表成功，1代表未知错误
        /// </summary>
        public int Result { get; set; }

    }
}
