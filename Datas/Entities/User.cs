using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [StringLength(100)]
        public string name { get; set; }
    }
}
