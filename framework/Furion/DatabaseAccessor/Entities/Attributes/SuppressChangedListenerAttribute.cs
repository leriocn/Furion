﻿// 版权归百小僧及百签科技（广东）有限公司所有。
//
// 此源代码遵循位于源代码树根目录中的 LICENSE 文件的许可证。

namespace Furion.DatabaseAccessor;

/// <summary>
/// 禁止实体监听
/// </summary>
[SuppressSniffer, AttributeUsage(AttributeTargets.Class)]
public sealed class SuppressChangedListenerAttribute : Attribute
{
}