﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Location.Model.Work
{
    /// <summary>
    /// 操作票中具体的操作项
    /// </summary>
    public class OperationItem
    {
        /// <summary>
        /// 操作项Id
        /// </summary>
        [DataMember]
        [Display(Name = "操作项Id")]
        public int Id { get; set; }

        /// <summary>
        /// 操作票Id
        /// </summary>
        [DataMember]
        [Display(Name = "操作票Id")]
        public int? TicketId { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [DataMember]
        [Display(Name = "操作时间")]
        public DateTime OperationTime { get; set; }

        /// <summary>
        /// 记号
        /// </summary>
        [DataMember]
        [Display(Name = "记号")]
        public bool Mark { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        [DataMember]
        [Display(Name = "顺序")]
        public int OrderNum { get; set; }

        /// <summary>
        /// 操作项目
        /// </summary>
        [DataMember]
        [Display(Name = "操作项目")]
        public string Item { get; set; }

    }
}
