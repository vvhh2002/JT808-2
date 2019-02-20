﻿using JT808.Protocol.Attributes;
using JT808.Protocol.Formatters.MessageBodyFormatters;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 道路运输证 IC 卡认证主服务器 UDP 端口
    /// </summary>
    [JT808Formatter(typeof(JT808_0x8103_0x001C_Formatter))]
    public class JT808_0x8103_0x001C : JT808_0x8103_BodyBase
    {
        public override uint ParamId { get; set; } = 0x001C;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; } = 4;
        /// <summary>
        ///道路运输证 IC 卡认证主服务器 UDP 端口
        /// </summary>
        public uint ParamValue { get; set; }
    }
}
