﻿namespace ZhonTai.Admin.Services.Tenant.Dto;

/// <summary>
/// 修改
/// </summary>
public partial class TenantUpdateInput : TenantAddInput
{
    /// <summary>
    /// 接口Id
    /// </summary>
    public long Id { get; set; }
}