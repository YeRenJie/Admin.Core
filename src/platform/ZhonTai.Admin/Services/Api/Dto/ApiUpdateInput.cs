﻿namespace ZhonTai.Admin.Services.Api.Dto;

/// <summary>
/// 修改
/// </summary>
public partial class ApiUpdateInput : ApiAddInput
{
    /// <summary>
    /// 接口Id
    /// </summary>
    public long Id { get; set; }
}