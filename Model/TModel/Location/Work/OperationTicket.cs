﻿using DbModel.Tools;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Location.TModel.Tools;

namespace TModel.Location.Work
{
    /// <summary>
    /// 操作票
    /// </summary>
    [DataContract]
    public class OperationTicket
    {
        /// <summary>
        /// 操作票Id
        /// </summary>
        [DataMember]
        //[Display(Name = "操作票Id")]
        public int Id { get; set; }

        /// <summary>
        /// 对接Id
        /// </summary>
        [DataMember]
        //[Display(Name = "对接Id")]
        public int? Abutment_Id { get; set; }

        /// <summary>
        /// 操作票编号
        /// </summary>
        [DataMember]
        //[Display(Name = "操作票编号")]
        public string No { get; set; }

        /// <summary>
        /// 操作任务
        /// </summary>
        [DataMember]
        //[Display(Name = "操作任务")]
        public string OperationTask { get; set; }

        /// <summary>
        /// 操作开始时间
        /// </summary>
        [DataMember]
        //[Display(Name = "操作开始时间")]
        public DateTime OperationStartTime { get; set; }

        /// <summary>
        /// 操作结束时间
        /// </summary>
        [DataMember]
        //[Display(Name = "操作结束时间")]
        public DateTime OperationEndTime { get; set; }

        /// <summary>
        /// 操作项
        /// </summary>
        [DataMember]
        public List<OperationItem> OperationItems { get; set; }

        /// <summary>
        /// 监护人
        /// </summary>
        [DataMember]
        //[Display(Name = "监护人")]
        public string Guardian { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [DataMember]
        //[Display(Name = "操作人")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作人PersonelId
        /// </summary>
        [DataMember]
        public int OperatorPersonelId;

        /// <summary>
        /// 值班负责人
        /// </summary>
        [DataMember]
        //[Display(Name = "值班负责人")]
        public string DutyOfficer { get; set; }

        /// <summary>
        /// 调度人
        /// </summary>
        [DataMember]
        //[Display(Name = "调度")]
        public string Dispatch { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [DataMember]
        //[Display(Name = "备注")]
        public string Remark { get; set; }

        public OperationTicket Clone()
        {
            OperationTicket copy = new OperationTicket();
            copy = this.CloneObjectByBinary();

            return copy;
        }
    }
}
