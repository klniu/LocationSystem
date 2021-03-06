﻿using DbModel.Tools;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Location.TModel.Tools;
using Location.IModel;

namespace DbModel.LocationHistory.Data
{
    /// <summary>
    /// 设备历史数据
    /// </summary>
    public class DevInstantDataHistory:IEntity
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [DataMember]
        [Display(Name = "主键Id")]
        public int Id { get; set; }

        /// <summary>
        /// KKS码
        /// </summary>
        [DataMember]
        [Display(Name = "KKS码")]
        [MaxLength(256)]
        public string KKS { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [DataMember]
        [Display(Name = "名称")]
        [MaxLength(128)]
        public string Name { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [DataMember]
        [Display(Name = "值")]
        [MaxLength(32)]
        public string Value { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [DataMember]
        [Display(Name = "单位")]
        [MaxLength(8)]
        public string Unit { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [DataMember]
        [Display(Name = "时间")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [DataMember]
        [Display(Name = "时间戳")]
        public long DateTimeStamp { get; set; }

        public DevInstantDataHistory Clone()
        {
            DevInstantDataHistory copy = new DevInstantDataHistory();
            copy = this.CloneObjectByBinary();

            return copy;
        }
    }
}
