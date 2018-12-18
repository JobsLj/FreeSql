﻿using System;

namespace FreeSql.DataAnnotations {
	public class ColumnAttribute : Attribute {

		/// <summary>
		/// 数据库列名
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 指定数据库旧的列名，修改实体属性命名时，同时设置此参数为修改之前的值，CodeFirst才可以正确修改数据库字段；否则将视为【新增字段】
		/// </summary>
		public string OldName { get; set; }
		/// <summary>
		/// 数据库类型，如： varchar(255)
		/// </summary>
		public string DbType { get; set; }

		/// <summary>
		/// 主键
		/// </summary>
		public bool IsPrimary { get; set; }
		/// <summary>
		/// 自增标识
		/// </summary>
		public bool IsIdentity { get; set; }
		/// <summary>
		/// 是否可DBNull
		/// </summary>
		public bool IsNullable { get; set; }
	}
}